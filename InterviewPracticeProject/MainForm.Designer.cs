namespace InterviewPracticeProject
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_info = new System.Windows.Forms.Button();
            this.rbtn_hrQuestions = new System.Windows.Forms.RadioButton();
            this.rbtn_starQuestions = new System.Windows.Forms.RadioButton();
            this.rbtn_bothQuestions = new System.Windows.Forms.RadioButton();
            this.gbx_questionTypeDesired = new System.Windows.Forms.GroupBox();
            this.cbx_camera = new System.Windows.Forms.ComboBox();
            this.lbl_camera = new System.Windows.Forms.Label();
            this.btn_begin = new System.Windows.Forms.Button();
            this.btn_testCamera = new System.Windows.Forms.Button();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.btn_endTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbx_questionTypeDesired.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(66, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(415, 340);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_info
            // 
            this.btn_info.Location = new System.Drawing.Point(687, 9);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(59, 23);
            this.btn_info.TabIndex = 5;
            this.btn_info.Text = "Info";
            this.btn_info.UseVisualStyleBackColor = true;
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // rbtn_hrQuestions
            // 
            this.rbtn_hrQuestions.AutoSize = true;
            this.rbtn_hrQuestions.Checked = true;
            this.rbtn_hrQuestions.Location = new System.Drawing.Point(6, 19);
            this.rbtn_hrQuestions.Name = "rbtn_hrQuestions";
            this.rbtn_hrQuestions.Size = new System.Drawing.Size(134, 17);
            this.rbtn_hrQuestions.TabIndex = 8;
            this.rbtn_hrQuestions.TabStop = true;
            this.rbtn_hrQuestions.Text = "HR / Phone Screening";
            this.rbtn_hrQuestions.UseVisualStyleBackColor = true;
            this.rbtn_hrQuestions.CheckedChanged += new System.EventHandler(this.rbtn_hrQuestions_CheckedChanged);
            // 
            // rbtn_starQuestions
            // 
            this.rbtn_starQuestions.AutoSize = true;
            this.rbtn_starQuestions.Location = new System.Drawing.Point(6, 42);
            this.rbtn_starQuestions.Name = "rbtn_starQuestions";
            this.rbtn_starQuestions.Size = new System.Drawing.Size(115, 17);
            this.rbtn_starQuestions.TabIndex = 9;
            this.rbtn_starQuestions.Text = "Behavioral / STAR";
            this.rbtn_starQuestions.UseVisualStyleBackColor = true;
            this.rbtn_starQuestions.CheckedChanged += new System.EventHandler(this.rbtn_starQuestions_CheckedChanged);
            // 
            // rbtn_bothQuestions
            // 
            this.rbtn_bothQuestions.AutoSize = true;
            this.rbtn_bothQuestions.Location = new System.Drawing.Point(6, 65);
            this.rbtn_bothQuestions.Name = "rbtn_bothQuestions";
            this.rbtn_bothQuestions.Size = new System.Drawing.Size(47, 17);
            this.rbtn_bothQuestions.TabIndex = 10;
            this.rbtn_bothQuestions.Text = "Both";
            this.rbtn_bothQuestions.UseVisualStyleBackColor = true;
            this.rbtn_bothQuestions.CheckedChanged += new System.EventHandler(this.rbtn_bothQuestions_CheckedChanged);
            // 
            // gbx_questionTypeDesired
            // 
            this.gbx_questionTypeDesired.Controls.Add(this.rbtn_hrQuestions);
            this.gbx_questionTypeDesired.Controls.Add(this.rbtn_starQuestions);
            this.gbx_questionTypeDesired.Controls.Add(this.rbtn_bothQuestions);
            this.gbx_questionTypeDesired.Location = new System.Drawing.Point(533, 59);
            this.gbx_questionTypeDesired.Name = "gbx_questionTypeDesired";
            this.gbx_questionTypeDesired.Size = new System.Drawing.Size(200, 100);
            this.gbx_questionTypeDesired.TabIndex = 16;
            this.gbx_questionTypeDesired.TabStop = false;
            this.gbx_questionTypeDesired.Text = "Question Type Desired:";
            // 
            // cbx_camera
            // 
            this.cbx_camera.FormattingEnabled = true;
            this.cbx_camera.Location = new System.Drawing.Point(89, 26);
            this.cbx_camera.Name = "cbx_camera";
            this.cbx_camera.Size = new System.Drawing.Size(392, 21);
            this.cbx_camera.TabIndex = 17;
            this.cbx_camera.SelectedIndexChanged += new System.EventHandler(this.cbx_camera_SelectedIndexChanged);
            // 
            // lbl_camera
            // 
            this.lbl_camera.AutoSize = true;
            this.lbl_camera.Location = new System.Drawing.Point(22, 29);
            this.lbl_camera.Name = "lbl_camera";
            this.lbl_camera.Size = new System.Drawing.Size(46, 13);
            this.lbl_camera.TabIndex = 18;
            this.lbl_camera.Text = "Camera:";
            // 
            // btn_begin
            // 
            this.btn_begin.Location = new System.Drawing.Point(533, 377);
            this.btn_begin.Name = "btn_begin";
            this.btn_begin.Size = new System.Drawing.Size(149, 23);
            this.btn_begin.TabIndex = 20;
            this.btn_begin.Text = "Click to begin";
            this.btn_begin.UseVisualStyleBackColor = true;
            this.btn_begin.Click += new System.EventHandler(this.btn_begin_Click);
            // 
            // btn_testCamera
            // 
            this.btn_testCamera.Location = new System.Drawing.Point(533, 339);
            this.btn_testCamera.Name = "btn_testCamera";
            this.btn_testCamera.Size = new System.Drawing.Size(75, 23);
            this.btn_testCamera.TabIndex = 21;
            this.btn_testCamera.Text = "Test Camera";
            this.btn_testCamera.UseVisualStyleBackColor = true;
            this.btn_testCamera.Click += new System.EventHandler(this.btn_testCamera_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // btn_endTest
            // 
            this.btn_endTest.Location = new System.Drawing.Point(614, 339);
            this.btn_endTest.Name = "btn_endTest";
            this.btn_endTest.Size = new System.Drawing.Size(75, 23);
            this.btn_endTest.TabIndex = 22;
            this.btn_endTest.Text = "End Test";
            this.btn_endTest.UseVisualStyleBackColor = true;
            this.btn_endTest.Click += new System.EventHandler(this.btn_endTest_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_endTest);
            this.Controls.Add(this.btn_testCamera);
            this.Controls.Add(this.btn_begin);
            this.Controls.Add(this.lbl_camera);
            this.Controls.Add(this.cbx_camera);
            this.Controls.Add(this.gbx_questionTypeDesired);
            this.Controls.Add(this.btn_info);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbx_questionTypeDesired.ResumeLayout(false);
            this.gbx_questionTypeDesired.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.RadioButton rbtn_hrQuestions;
        private System.Windows.Forms.RadioButton rbtn_starQuestions;
        private System.Windows.Forms.RadioButton rbtn_bothQuestions;
        private System.Windows.Forms.GroupBox gbx_questionTypeDesired;
        private System.Windows.Forms.ComboBox cbx_camera;
        private System.Windows.Forms.Label lbl_camera;
        private System.Windows.Forms.Button btn_begin;
        private System.Windows.Forms.Button btn_testCamera;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Button btn_endTest;
    }
}

