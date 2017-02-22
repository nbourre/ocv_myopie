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


namespace ocv_myopie
{
    public partial class Form1 : Form
    {
        VideoCapture cap = new VideoCapture(0);
        Mat frame = new Mat();

        OpenCvSharp.Size kSize;

        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kSize.Height = 5;
            kSize.Width = 5;

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

            Cv2.GaussianBlur(src, result, kSize, 1);

            
            return result;
        }

        private void vsbDioptrie_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
