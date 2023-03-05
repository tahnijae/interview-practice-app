using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace InterviewPracticeProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        private void Form1_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                cbx_camera.Items.Add(filterInfo.Name);
            }
            cbx_camera.SelectedIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice();
        }

        

        /*
         * ----------------------------RADIO BUTTONS--------------------------------
         */
        private void rbtn_hrQuestions_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtn_starQuestions_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtn_bothQuestions_CheckedChanged(object sender, EventArgs e)
        {

        }



        /*
         * ----------------------------BUTTONS--------------------------------
         */

        private void btn_info_Click(object sender, EventArgs e)
        {

        }

        private void btn_begin_Click(object sender, EventArgs e)
        {

        }

        private void btn_testCamera_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cbx_camera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }

        private void btn_endTest_Click(object sender, EventArgs e)
        {
            videoCaptureDevice.Stop();
        }

        /*
         * ----------------------------CAMERA SELECTION--------------------------------
         */
        private void cbx_camera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /*
         * ----------------------------PHOTO BOX--------------------------------
         */
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }

       

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(videoCaptureDevice.IsRunning == true)
            {
                videoCaptureDevice.Stop();
            }
        }

        
    }
}
