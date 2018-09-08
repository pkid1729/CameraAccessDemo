using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;

namespace CameraAccessDemo
{
    public partial class Form1 : Form
    {
        VideoCapture Capture;
        public Form1()
        {
            InitializeComponent();
            Run();
        }
        private void Run()
        {
            try
            {
                Capture = new VideoCapture();
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);

            }
            Application.Idle += ProcessFrame;
        }

        private void ProcessFrame(object sender, EventArgs e)
        {
            imageBox1.Image = Capture.QuerySmallFrame();
        }

        private void imageBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
