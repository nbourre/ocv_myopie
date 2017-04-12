using System;
using System.Windows.Forms;
using OpenCvSharp;
using gei1076_tools;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;

namespace ocv_myopie
{
    public partial class frmMain : Form
    {
        

        VideoCapture cap = new VideoCapture(0);
        Mat frame = new Mat();
        Mat imgEInput = new Mat();
        Mat imgEOutput;

        OpenCvSharp.Size kSize;
        double sigma = 0.0;

        bool diopDirty = true;
        double dioptrie = 0;

        double hauteurE = 97;

        PortSerie ps;
        byte octet;
        const int tailleTrame = 2;
        private byte[] trame = new byte[tailleTrame];
        private byte[] tableau = new byte[tailleTrame];

        int cm = 0;
        double distanceReference = 3.0; // 3 m
        double ratioReference = 2; // 6 / 3;

        public OpenCvSharp.Size screenResolution;
        public Vec2f screenDPI;

        public frmMain()
        {
            InitializeComponent();
            Binding binding = new Binding("Text", vsbDioptrie, "Value");

            binding.Format += bind_Format;
            binding.Parse += bind_Parse;

            txtDioptrie.DataBindings.Add(binding);

            
        }

        private void bind_Parse(object sender, ConvertEventArgs e)
        {

        }

        private void bind_Format(object sender, ConvertEventArgs e)
        {
            double raw = -(int)(e.Value) / 100.0;

            sigma = dyoptrieToSigma(raw);



            kSize.Width = kSize.Height = (int)(sigma) % 2 == 0 ? (int)sigma + 1 : (int)sigma;

            Console.WriteLine("sigma = " + sigma);

            dioptrie = raw;
            e.Value = raw.ToString("0.00");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ps = spc.getPS();
            tmrReception.Enabled = true;

            kSize.Height = 1;
            kSize.Width = 1;
            


            tmrFrame.Enabled = true;

            initSizes();

            initPictureBoxes();
        }

        private void matToPictureBox(PictureBox pb, Mat img)
        {
            try
            {
                pb.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(img);
            } catch (Exception e)
            {
                Console.Write(e.Message);
            }

        }

        int cmPrecedent = 0;

        private void tmrFrame_Tick(object sender, EventArgs e)
        {
            tmrFrame.Enabled = false;
            if (!chkNoCamera.Checked)
            {
                cap.Read(frame);


                Width = frame.Width + 50;
                Height = frame.Height + 60;
                pbCamera.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(frame);

                matToPictureBox(pbCamera, process(frame));
            } else
            {
                if (diopDirty || cmPrecedent != cm)
                {
                    diopDirty = false;
                    
                    imgEOutput = process(resizeImgE());
                }

                cmPrecedent = cm;
                
                matToPictureBox(pbSnellen, imgEOutput);
            }

            lblDistance.Text = cm.ToString() + " cm";

            tmrFrame.Enabled = true;
        }



        private Mat process(Mat src)
        {

            if (src == null) return null;

            Mat result = new Mat();

            if (cm != 0)
            {
                double dioptrieSimulee = calculerDioptrieSimulee(-dioptrie, cm / 100.0, distanceReference);

                double sigma = dyoptrieToSigma(dioptrieSimulee);

                kSize.Width = kSize.Height = (int)(sigma) % 2 == 0 ? (int)sigma + 1 : (int)sigma;

                //lblDioptrie.Text = "Je vois comme : " + (-dioptrieSimulee).ToString("0.00");
            }

            Cv2.GaussianBlur(src, result, kSize, sigma);

            return result;
        }



        double dyoptrieToSigma(double dyoptrie)
        {
            // Source : http://esatjournals.net/ijret/2014v03/i17/IJRET20140317008.pdf
            // Myopie : y = -6.921x + 0.0642
            // Hypermétrie : y = 7.1401x + 0.657

            // Source2 : view-source:http://www.billauer.co.il/simulator.html
            if (dyoptrie == 0) return 0;

            double resultat = 0.0;

            if (dyoptrie < 0)
            {
                resultat = -6.921 * dyoptrie + 0.0642 - 1;
            } else
            {
                resultat = 7.1401 * dyoptrie + 0.657 - 1;
            }

            //kSize.Width = kSize.Height = (int)(resultat) % 2 == 0 ? (int)resultat + 1 : (int)resultat;

            return resultat;

        }

        /// <summary>
        /// Permet de calculer la dioptrie simulée selon une distance donnée
        /// </summary>
        /// <param name="dioptrieInitiale"></param>
        /// <param name="distanceActuelle"></param>
        /// <param name="distanceInfinie"></param>
        /// <returns></returns>
        double calculerDioptrieSimulee (double dioptrieInitiale, double distanceActuelle, double distanceInfinie)
        {
            if (dioptrieInitiale == 0) return 0;
               
            double pr = -1 / dioptrieInitiale;
            double sigmaInitiale = -6.921 * dioptrieInitiale * 0.0642;
            double m = sigmaInitiale / (distanceInfinie - pr);
            double b = -sigmaInitiale / (distanceInfinie - pr) * pr;

            double dioptrieSimulee = dioptrieInitiale / (distanceInfinie - pr) * distanceActuelle + b;

            return dioptrieSimulee;
        }

        private void tmrReception_Tick(object sender, EventArgs e)
        {
            if (!ps.Ouvert) return;

            tmrReception.Enabled = false;

            int cmTempo = 0;

            while (ps.DonneesALire() >= tailleTrame + 2)
            {
                ps.LireOctet(ref octet);
                if (octet == 0x5A)
                {
                    ps.LireOctet(ref octet);
                    if (octet == 0xA5)
                    {
                        
                        ps.LireOctets(tableau, 0, tailleTrame);

                        cmTempo = (tableau[0] << 8) + tableau[1];

                        if (cmTempo < 1000)
                        {
                            cm = cmTempo;
                        }
                        
                    }
                }
            }

            tmrReception.Enabled = true;
        }

        private void initPictureBoxes()
        {
            imgEInput = OpenCvSharp.Extensions.BitmapConverter.ToMat(ressources.Snellen_E);
            
            imgEOutput = imgEInput.Resize(new OpenCvSharp.Size(0, 0), 88.4 / hauteurE / ratioReference, 88.4 / hauteurE / ratioReference);

            pbSnellen.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(imgEOutput);
            pbEOriginal.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(imgEInput);
        }

        private void initSizes()
        {
            screenResolution.Height = Screen.PrimaryScreen.Bounds.Height;
            screenResolution.Width = Screen.PrimaryScreen.Bounds.Width;

            Graphics DesktopGraphics = Graphics.FromHdc(GetDC( IntPtr.Zero));
            
            screenDPI.Item0 = DesktopGraphics.DpiX;
            screenDPI.Item1 = DesktopGraphics.DpiY;

            txtResX.Text = screenResolution.Width.ToString();
            txtResY.Text = screenResolution.Height.ToString();

            txtDpiX.Text = screenDPI.Item0.ToString();
            txtDpiY.Text = screenDPI.Item1.ToString();

            txtLargeur.Text = (screenResolution.Width / screenDPI.Item0).ToString();
            txtHauteurEcran.Text = (screenResolution.Height / screenDPI.Item1).ToString();
        }

        [DllImport("user32.dll", EntryPoint = "GetDC")]
        public static extern IntPtr GetDC(IntPtr ptr);

        private Mat resizeImgE()
        {
            // E : 384px x 386px
            // 109 <-- nb mm du E sur mon écran de bureau
            // 97 <-- nb mm du E sur mon écran de portable
            double ratio3m = 88.4 / hauteurE / ratioReference; // Le E doit mesurer 88.4 mm à 6 m

            
            return imgEInput.Resize(new OpenCvSharp.Size(0, 0), ratio3m, ratio3m);
        }

        private void txtDioptrie_TextChanged(object sender, EventArgs e)
        {
            string rawValue = ((TextBox)sender).Text;

            double raw;

            if (double.TryParse(rawValue, out raw)) { 
                
                
                sigma = dyoptrieToSigma(raw);
                kSize.Width = kSize.Height = (int)(sigma) % 2 == 0 ? (int)sigma + 1 : (int)sigma;

                Console.WriteLine("sigma = " + sigma);

                int tempValue = Math.Max (-(int)(raw * 100), vsbDioptrie.Minimum);
                vsbDioptrie.Value = Math.Min( tempValue , vsbDioptrie.Maximum);
                
                diopDirty = true;
            }

            
        }

        private double punctumRemotumToDyoptrie(double pr)
        {
            if (pr != 0) return 1 / pr;

            return 10000;
        }

        private double dioptrieToPunctumRemotum(double dioptrie)
        {
            if (dioptrie != 0) return -1.0 / dioptrie;

            return 10000;
        }

        private double map(double value, double currentMin, double currentMax, double mapMin, double mapMax)
        {
            double currentRange = currentMax - currentMin;
            double mapRange = mapMax - mapMin;


            return mapMin + mapRange * ((value - currentMin) / currentRange);
        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            
            

            if (!double.TryParse(txtDistanceReference.Text, out distanceReference)) return;
            if (!double.TryParse(txtHauteurE.Text, out hauteurE)) return;

            ratioReference = 6 / distanceReference;
            diopDirty = true;
        }

        /// <summary>
        ///  Calcul de la moyenne mobile
        /// </summary>
        const int DIM_FENETRE_MOY_MOBILE = 5;

        List<int> values = new List<int>();

        int runningAverage(int nouvelleValeur)
        {
            values.Add(nouvelleValeur);

            if (values.Count > DIM_FENETRE_MOY_MOBILE)
            {
                values.RemoveAt(0);
            }
            
            return (int)values.Average();

        }
    }
}
