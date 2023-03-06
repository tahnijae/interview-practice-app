namespace InterviewPracticeProject
{
    partial class CaptureForm
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
            this.gbx_displayInterviewerOrSelf = new System.Windows.Forms.GroupBox();
            this.rbtn_showSelf = new System.Windows.Forms.RadioButton();
            this.rbtn_showInterviewer = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_skip = new System.Windows.Forms.Button();
            this.btn_repeatQuestion = new System.Windows.Forms.Button();
            this.btn_stopRecording = new System.Windows.Forms.Button();
            this.tbx_displayQuestion = new System.Windows.Forms.TextBox();
            this.cbx_showQuestion = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_backToMainMenu = new System.Windows.Forms.Button();
            this.gbx_displayInterviewerOrSelf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbx_displayInterviewerOrSelf
            // 
            this.gbx_displayInterviewerOrSelf.Controls.Add(this.rbtn_showSelf);
            this.gbx_displayInterviewerOrSelf.Controls.Add(this.rbtn_showInterviewer);
            this.gbx_displayInterviewerOrSelf.Location = new System.Drawing.Point(538, 72);
            this.gbx_displayInterviewerOrSelf.Name = "gbx_displayInterviewerOrSelf";
            this.gbx_displayInterviewerOrSelf.Size = new System.Drawing.Size(175, 66);
            this.gbx_displayInterviewerOrSelf.TabIndex = 16;
            this.gbx_displayInterviewerOrSelf.TabStop = false;
            this.gbx_displayInterviewerOrSelf.Text = "Display Option";
            // 
            // rbtn_showSelf
            // 
            this.rbtn_showSelf.AutoSize = true;
            this.rbtn_showSelf.Location = new System.Drawing.Point(6, 42);
            this.rbtn_showSelf.Name = "rbtn_showSelf";
            this.rbtn_showSelf.Size = new System.Drawing.Size(73, 17);
            this.rbtn_showSelf.TabIndex = 12;
            this.rbtn_showSelf.Text = "Show Self";
            this.rbtn_showSelf.UseVisualStyleBackColor = true;
            this.rbtn_showSelf.CheckedChanged += new System.EventHandler(this.rbtn_showSelf_CheckedChanged);
            // 
            // rbtn_showInterviewer
            // 
            this.rbtn_showInterviewer.AutoSize = true;
            this.rbtn_showInterviewer.Checked = true;
            this.rbtn_showInterviewer.Location = new System.Drawing.Point(6, 19);
            this.rbtn_showInterviewer.Name = "rbtn_showInterviewer";
            this.rbtn_showInterviewer.Size = new System.Drawing.Size(107, 17);
            this.rbtn_showInterviewer.TabIndex = 11;
            this.rbtn_showInterviewer.TabStop = true;
            this.rbtn_showInterviewer.Text = "Show Interviewer";
            this.rbtn_showInterviewer.UseVisualStyleBackColor = true;
            this.rbtn_showInterviewer.CheckedChanged += new System.EventHandler(this.rbtn_showInterviewer_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(90, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(415, 340);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_skip
            // 
            this.btn_skip.Location = new System.Drawing.Point(565, 346);
            this.btn_skip.Name = "btn_skip";
            this.btn_skip.Size = new System.Drawing.Size(117, 23);
            this.btn_skip.TabIndex = 18;
            this.btn_skip.Text = "Skip";
            this.btn_skip.UseVisualStyleBackColor = true;
            this.btn_skip.Click += new System.EventHandler(this.btn_skip_Click);
            // 
            // btn_repeatQuestion
            // 
            this.btn_repeatQuestion.Location = new System.Drawing.Point(565, 375);
            this.btn_repeatQuestion.Name = "btn_repeatQuestion";
            this.btn_repeatQuestion.Size = new System.Drawing.Size(117, 23);
            this.btn_repeatQuestion.TabIndex = 19;
            this.btn_repeatQuestion.Text = "Repeat Question";
            this.btn_repeatQuestion.UseVisualStyleBackColor = true;
            this.btn_repeatQuestion.Click += new System.EventHandler(this.btn_repeatQuestion_Click);
            // 
            // btn_stopRecording
            // 
            this.btn_stopRecording.Location = new System.Drawing.Point(565, 404);
            this.btn_stopRecording.Name = "btn_stopRecording";
            this.btn_stopRecording.Size = new System.Drawing.Size(117, 23);
            this.btn_stopRecording.TabIndex = 20;
            this.btn_stopRecording.Text = "Stop Recording";
            this.btn_stopRecording.UseVisualStyleBackColor = true;
            this.btn_stopRecording.Click += new System.EventHandler(this.btn_stopRecording_Click);
            // 
            // tbx_displayQuestion
            // 
            this.tbx_displayQuestion.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbx_displayQuestion.Enabled = false;
            this.tbx_displayQuestion.Location = new System.Drawing.Point(154, 23);
            this.tbx_displayQuestion.Name = "tbx_displayQuestion";
            this.tbx_displayQuestion.Size = new System.Drawing.Size(356, 20);
            this.tbx_displayQuestion.TabIndex = 22;
            this.tbx_displayQuestion.TextChanged += new System.EventHandler(this.tbx_displayQuestion_TextChanged);
            // 
            // cbx_showQuestion
            // 
            this.cbx_showQuestion.AutoSize = true;
            this.cbx_showQuestion.Location = new System.Drawing.Point(43, 23);
            this.cbx_showQuestion.Name = "cbx_showQuestion";
            this.cbx_showQuestion.Size = new System.Drawing.Size(105, 17);
            this.cbx_showQuestion.TabIndex = 21;
            this.cbx_showQuestion.Text = "Display Question";
            this.cbx_showQuestion.UseVisualStyleBackColor = true;
            this.cbx_showQuestion.CheckedChanged += new System.EventHandler(this.cbx_showQuestion_CheckedChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(90, 411);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(415, 23);
            this.progressBar1.TabIndex = 23;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // btn_backToMainMenu
            // 
            this.btn_backToMainMenu.Location = new System.Drawing.Point(565, 23);
            this.btn_backToMainMenu.Name = "btn_backToMainMenu";
            this.btn_backToMainMenu.Size = new System.Drawing.Size(168, 23);
            this.btn_backToMainMenu.TabIndex = 24;
            this.btn_backToMainMenu.Text = "Back to Main Menu";
            this.btn_backToMainMenu.UseVisualStyleBackColor = true;
            this.btn_backToMainMenu.Click += new System.EventHandler(this.btn_backToMainMenu_Click);
            // 
            // CaptureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_backToMainMenu);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.tbx_displayQuestion);
            this.Controls.Add(this.cbx_showQuestion);
            this.Controls.Add(this.btn_stopRecording);
            this.Controls.Add(this.btn_repeatQuestion);
            this.Controls.Add(this.btn_skip);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbx_displayInterviewerOrSelf);
            this.Name = "CaptureForm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CaptureForm_FormClosed);
            this.Load += new System.EventHandler(this.CaptureForm_Load);
            this.gbx_displayInterviewerOrSelf.ResumeLayout(false);
            this.gbx_displayInterviewerOrSelf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_displayInterviewerOrSelf;
        private System.Windows.Forms.RadioButton rbtn_showSelf;
        private System.Windows.Forms.RadioButton rbtn_showInterviewer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_skip;
        private System.Windows.Forms.Button btn_repeatQuestion;
        private System.Windows.Forms.Button btn_stopRecording;
        private System.Windows.Forms.TextBox tbx_displayQuestion;
        private System.Windows.Forms.CheckBox cbx_showQuestion;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn_backToMainMenu;
    }
}