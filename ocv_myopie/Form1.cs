using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using gei1076_tools;

namespace ocv_myopie
{
    public partial class Form1 : Form
    {
        VideoCapture cap = new VideoCapture(0);
        Mat frame = new Mat();

        OpenCvSharp.Size kSize;
        double sigma = 0.0;

        PortSerie ps;
        byte octet;
        const int tailleTrame = 2;
        private byte[] trame = new byte[tailleTrame];
        private byte[] tableau = new byte[tailleTrame];

        int cm = 0;

        public Form1()
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

            if (cm > 0)
            {
                double metre = cm / 100.0;

            }

            Console.WriteLine("sigma = " + sigma);
 

            e.Value = raw.ToString("0.00");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ps = spc.getPS();
            tmrReception.Enabled = true;

            kSize.Height = 1;
            kSize.Width = 1;
            
            cap.Read(frame);

            Width = frame.Width + 50;
            Height = frame.Height + 60;

            pbCamera.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(frame);

            tmrFrame.Enabled = true;
        }

        private void matToPictureBox(PictureBox pb, Mat img)
        {
            pb.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(img);
        }

        private void tmrFrame_Tick(object sender, EventArgs e)
        {
            cap.Read(frame);

            matToPictureBox(pbCamera, process(frame));
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private Mat process(Mat src)
        {

            if (src == null) return null;

            Mat result = new Mat();

            Cv2.GaussianBlur(src, result, kSize, sigma);

            return result;
        }

        private void vsbDioptrie_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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

            kSize.Width = kSize.Height = (int)(resultat) % 2 == 0 ? (int)resultat + 1 : (int)resultat;

            return resultat;

        }

        private void tmrReception_Tick(object sender, EventArgs e)
        {
            if (!ps.Ouvert) return;

            tmrReception.Enabled = false;


            while (ps.DonneesALire() >= tailleTrame + 2)
            {
                ps.LireOctet(ref octet);
                if (octet == 0x5A)
                {
                    ps.LireOctet(ref octet);
                    if (octet == 0xA5)
                    {
                        
                        ps.LireOctets(tableau, 0, tailleTrame);

                        cm = ((int)tableau[0] << 8) + tableau[1];

                        lblDistance.Text = cm.ToString() + " cm";
                    }
                }
            }

            tmrReception.Enabled = true;
        }
    }
}
