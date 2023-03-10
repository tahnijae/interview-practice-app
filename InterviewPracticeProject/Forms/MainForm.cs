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
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        string questionType = "hr";

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                cbx_camera.Items.Add(filterInfo.Name);
            }
            cbx_camera.SelectedIndex = 0;


            ShowWelcomeImage();
        }

        

        /*
         * ----------------------------RADIO BUTTONS--------------------------------
         */
        private void rbtn_hrQuestions_CheckedChanged(object sender, EventArgs e)
        {
            questionType = "hr"
;        }

        private void rbtn_starQuestions_CheckedChanged(object sender, EventArgs e)
        {
            questionType = "star";
        }

        private void rbtn_bothQuestions_CheckedChanged(object sender, EventArgs e)
        {
            questionType = "both";
        }



        /*
         * ----------------------------BUTTONS--------------------------------
         */

        private void btn_info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select desired camera from the drop down menu and choose question type before clicking \"Begin\" to continue. \n Testing the camera beforehand is optional", "Information", MessageBoxButtons.OK);
        }

        private void btn_begin_Click(object sender, EventArgs e)
        {
            CaptureForm captureForm = new CaptureForm();
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cbx_camera.SelectedIndex].MonikerString);
            captureForm.inputSettings(filterInfoCollection, videoCaptureDevice, questionType);
            captureForm.ShowDialog();

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

            ShowWelcomeImage();
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
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning == true)
                {
                    videoCaptureDevice.Stop();
                }
            }
        }


        private void ShowWelcomeImage()
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Properties.Resources.WelcomeImage;
        }
        
    }
}
