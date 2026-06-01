namespace QuizApp.Forms
{
    partial class AdminForm
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
            Heading = new Label();
            downloadBTN = new Button();
            uploadBTN = new Button();
            SuspendLayout();
            // 
            // Heading
            // 
            Heading.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Heading.AutoSize = true;
            Heading.Font = new Font("Showcard Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Heading.ForeColor = SystemColors.HotTrack;
            Heading.Location = new Point(151, 9);
            Heading.Name = "Heading";
            Heading.Size = new Size(504, 74);
            Heading.TabIndex = 11;
            Heading.Text = "Quiz App ADMIN";
            // 
            // downloadBTN
            // 
            downloadBTN.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            downloadBTN.BackColor = SystemColors.HotTrack;
            downloadBTN.Font = new Font("Showcard Gothic", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            downloadBTN.ForeColor = SystemColors.ButtonFace;
            downloadBTN.Location = new Point(219, 124);
            downloadBTN.Name = "downloadBTN";
            downloadBTN.Size = new Size(350, 80);
            downloadBTN.TabIndex = 9;
            downloadBTN.Text = "DOWNLOAD";
            downloadBTN.UseVisualStyleBackColor = false;
            downloadBTN.Click += playButton_Click;
            // 
            // uploadBTN
            // 
            uploadBTN.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            uploadBTN.BackColor = SystemColors.HotTrack;
            uploadBTN.Font = new Font("Showcard Gothic", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uploadBTN.ForeColor = SystemColors.ButtonFace;
            uploadBTN.Location = new Point(219, 232);
            uploadBTN.Name = "uploadBTN";
            uploadBTN.Size = new Size(350, 80);
            uploadBTN.TabIndex = 12;
            uploadBTN.Text = "UPLOAD";
            uploadBTN.UseVisualStyleBackColor = false;
            uploadBTN.Click += uploadBTN_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(uploadBTN);
            Controls.Add(Heading);
            Controls.Add(downloadBTN);
            Name = "AdminForm";
            Text = "AdminForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Heading;
        private TextBox questionTB;
        private Button downloadBTN;
        private Button uploadBTN;
        private Label label1;
        private TextBox answerATB;
        private Label label3;
        private TextBox answerBTB;
        private Label label4;
        private TextBox answerCTB;
        private Label label2;
        private TextBox answerDTB;
        private Label label5;
        private RadioButton correctB;
        private RadioButton correctA;
        private RadioButton correctC;
        private RadioButton correctD;
        private Label label6;
        private TextBox pointTB;
        private Label label7;
    }
}