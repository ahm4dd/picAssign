namespace pictureAhmed
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            studentPictureBox2 = new PictureBox();
            btnSave = new Button();
            btnBrowse = new Button();
            btnStartStop = new Button();
            btnCapture = new Button();
            studentPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)studentPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentPictureBox).BeginInit();
            SuspendLayout();
            // 
            // studentPictureBox2
            // 
            studentPictureBox2.BorderStyle = BorderStyle.FixedSingle;
            studentPictureBox2.Location = new Point(12, 47);
            studentPictureBox2.Name = "studentPictureBox2";
            studentPictureBox2.Size = new Size(400, 290);
            studentPictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            studentPictureBox2.TabIndex = 0;
            studentPictureBox2.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(712, 386);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(106, 47);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(600, 386);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(106, 47);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnStartStop
            // 
            btnStartStop.Location = new Point(12, 343);
            btnStartStop.Name = "btnStartStop";
            btnStartStop.Size = new Size(75, 23);
            btnStartStop.TabIndex = 4;
            btnStartStop.Text = "Start";
            btnStartStop.UseVisualStyleBackColor = true;
            btnStartStop.Click += btnStartStop_Click;
            // 
            // btnCapture
            // 
            btnCapture.Location = new Point(93, 343);
            btnCapture.Name = "btnCapture";
            btnCapture.Size = new Size(75, 23);
            btnCapture.TabIndex = 5;
            btnCapture.Text = "Capture";
            btnCapture.UseVisualStyleBackColor = true;
            btnCapture.Click += btnCapture_Click;
            // 
            // studentPictureBox
            // 
            studentPictureBox.BorderStyle = BorderStyle.FixedSingle;
            studentPictureBox.Location = new Point(418, 47);
            studentPictureBox.Name = "studentPictureBox";
            studentPictureBox.Size = new Size(400, 290);
            studentPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            studentPictureBox.TabIndex = 6;
            studentPictureBox.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 445);
            Controls.Add(studentPictureBox);
            Controls.Add(btnCapture);
            Controls.Add(btnStartStop);
            Controls.Add(btnBrowse);
            Controls.Add(btnSave);
            Controls.Add(studentPictureBox2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)studentPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox studentPictureBox2;
        private Button btnSave;
        private Button btnBrowse;
        private Button btnStartStop;
        private Button btnCapture;
        private PictureBox studentPictureBox;
    }
}
