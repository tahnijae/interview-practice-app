using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterviewPracticeProject
{
    public partial class CaptureForm : Form
    {
        FilterInfoCollection Filter;
        VideoCaptureDevice VideoInput;
        string QuestionType;


        public CaptureForm()
        {
            InitializeComponent();
        }


        private void CaptureForm_Load(object sender, EventArgs e)
        {
            VideoInput.NewFrame += VideoInput_NewFrame;
            VideoInput.Start(); 
        }

        private void VideoInput_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        public void inputSettings(FilterInfoCollection filter, VideoCaptureDevice videoCaptureDevice, string questionType)
        {
            Filter = filter;
            VideoInput = videoCaptureDevice;
            QuestionType = questionType;

        }

        private void cbx_showQuestion_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tbx_displayQuestion_TextChanged(object sender, EventArgs e)
        {

        }

        /*
         * ----------------------------RADIO BUTTONS--------------------------------
         */

        private void rbtn_showInterviewer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtn_showSelf_CheckedChanged(object sender, EventArgs e)
        {

        }

        /*
         * ----------------------------BUTTONS--------------------------------
         */

        private void btn_skip_Click(object sender, EventArgs e)
        {

        }

        private void btn_repeatQuestion_Click(object sender, EventArgs e)
        {

        }

        private void btn_stopRecording_Click(object sender, EventArgs e)
        {

        }
        private void btn_backToMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void CaptureForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            VideoInput.Stop();
        }
    }
}
