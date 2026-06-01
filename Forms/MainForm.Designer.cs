namespace QuizApp.Forms
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
            label1 = new Label();
            playButton = new Button();
            nameTextBox = new TextBox();
            Heading = new Label();
            label2 = new Label();
            groupBox = new GroupBox();
            radioButton10 = new RadioButton();
            radioButton5 = new RadioButton();
            adminBtn = new Button();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(251, 117);
            label1.Name = "label1";
            label1.Size = new Size(126, 31);
            label1.TabIndex = 0;
            label1.Text = "Your Name";
            // 
            // playButton
            // 
            playButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            playButton.BackColor = SystemColors.HotTrack;
            playButton.Font = new Font("Showcard Gothic", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            playButton.ForeColor = SystemColors.ButtonFace;
            playButton.Location = new Point(243, 330);
            playButton.Name = "playButton";
            playButton.Size = new Size(350, 80);
            playButton.TabIndex = 1;
            playButton.Text = "PLAY";
            playButton.UseVisualStyleBackColor = false;
            playButton.Click += playButton_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(383, 117);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(210, 27);
            nameTextBox.TabIndex = 4;
            // 
            // Heading
            // 
            Heading.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Heading.AutoSize = true;
            Heading.Font = new Font("Showcard Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Heading.ForeColor = SystemColors.HotTrack;
            Heading.Location = new Point(273, 9);
            Heading.Name = "Heading";
            Heading.Size = new Size(304, 74);
            Heading.TabIndex = 5;
            Heading.Text = "Quiz App";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(251, 204);
            label2.Name = "label2";
            label2.Size = new Size(345, 31);
            label2.TabIndex = 6;
            label2.Text = "Choose the number of questions";
            // 
            // groupBox
            // 
            groupBox.Controls.Add(radioButton10);
            groupBox.Controls.Add(radioButton5);
            groupBox.Location = new Point(243, 238);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(362, 62);
            groupBox.TabIndex = 7;
            groupBox.TabStop = false;
            // 
            // radioButton10
            // 
            radioButton10.AutoSize = true;
            radioButton10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton10.Location = new Point(209, 15);
            radioButton10.Name = "radioButton10";
            radioButton10.Size = new Size(147, 32);
            radioButton10.TabIndex = 5;
            radioButton10.TabStop = true;
            radioButton10.Text = "10 Questions";
            radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton5.Location = new Point(6, 15);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(136, 32);
            radioButton5.TabIndex = 4;
            radioButton5.TabStop = true;
            radioButton5.Text = "5 Questions";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // adminBtn
            // 
            adminBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            adminBtn.BackColor = SystemColors.GradientActiveCaption;
            adminBtn.Font = new Font("Rockwell", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adminBtn.ForeColor = SystemColors.ActiveCaptionText;
            adminBtn.Location = new Point(443, 416);
            adminBtn.Name = "adminBtn";
            adminBtn.Size = new Size(150, 50);
            adminBtn.TabIndex = 8;
            adminBtn.Text = "ADMIN PAGE";
            adminBtn.UseVisualStyleBackColor = false;
            adminBtn.Click += adminBtn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 482);
            Controls.Add(adminBtn);
            Controls.Add(groupBox);
            Controls.Add(label2);
            Controls.Add(Heading);
            Controls.Add(nameTextBox);
            Controls.Add(playButton);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "MainForm";
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button playButton;
        private TextBox nameTextBox;
        private Label Heading;
        private Label label2;
        private GroupBox groupBox;
        private RadioButton radioButton10;
        private RadioButton radioButton5;
        private Button adminBtn;
    }
}