namespace QuizApp.Forms
{
    partial class QuizForm
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
            lblQuestion = new Label();
            Heading = new Label();
            AnswerB = new RadioButton();
            AnswerA = new RadioButton();
            groupBox = new GroupBox();
            nextButton = new Button();
            AnswerC = new RadioButton();
            AnswerD = new RadioButton();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuestion.Location = new Point(230, 113);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(345, 31);
            lblQuestion.TabIndex = 12;
            lblQuestion.Text = "Choose the number of questions";
            // 
            // Heading
            // 
            Heading.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Heading.AutoSize = true;
            Heading.Font = new Font("Showcard Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Heading.ForeColor = SystemColors.HotTrack;
            Heading.Location = new Point(249, 24);
            Heading.Name = "Heading";
            Heading.Size = new Size(304, 74);
            Heading.TabIndex = 11;
            Heading.Text = "Quiz App";
            // 
            // AnswerB
            // 
            AnswerB.AutoSize = true;
            AnswerB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AnswerB.Location = new Point(417, 15);
            AnswerB.Name = "AnswerB";
            AnswerB.Size = new Size(147, 32);
            AnswerB.TabIndex = 5;
            AnswerB.TabStop = true;
            AnswerB.Text = "10 Questions";
            AnswerB.UseVisualStyleBackColor = true;
            // 
            // AnswerA
            // 
            AnswerA.AutoSize = true;
            AnswerA.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AnswerA.Location = new Point(45, 26);
            AnswerA.Name = "AnswerA";
            AnswerA.Size = new Size(136, 32);
            AnswerA.TabIndex = 4;
            AnswerA.TabStop = true;
            AnswerA.Text = "5 Questions";
            AnswerA.UseVisualStyleBackColor = true;
            // 
            // groupBox
            // 
            groupBox.BackColor = SystemColors.GradientActiveCaption;
            groupBox.Controls.Add(AnswerD);
            groupBox.Controls.Add(AnswerC);
            groupBox.Controls.Add(AnswerB);
            groupBox.Controls.Add(AnswerA);
            groupBox.Location = new Point(73, 147);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(664, 168);
            groupBox.TabIndex = 13;
            groupBox.TabStop = false;
            // 
            // nextButton
            // 
            nextButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nextButton.BackColor = SystemColors.HotTrack;
            nextButton.Font = new Font("Showcard Gothic", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nextButton.ForeColor = SystemColors.ButtonFace;
            nextButton.Location = new Point(219, 346);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(350, 80);
            nextButton.TabIndex = 9;
            nextButton.Text = "NEXT";
            nextButton.UseVisualStyleBackColor = false;
            nextButton.Click += nextButton_Click;
            // 
            // AnswerC
            // 
            AnswerC.AutoSize = true;
            AnswerC.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AnswerC.Location = new Point(45, 110);
            AnswerC.Name = "AnswerC";
            AnswerC.Size = new Size(136, 32);
            AnswerC.TabIndex = 6;
            AnswerC.TabStop = true;
            AnswerC.Text = "5 Questions";
            AnswerC.UseVisualStyleBackColor = true;
            // 
            // AnswerD
            // 
            AnswerD.AutoSize = true;
            AnswerD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AnswerD.Location = new Point(428, 110);
            AnswerD.Name = "AnswerD";
            AnswerD.Size = new Size(136, 32);
            AnswerD.TabIndex = 7;
            AnswerD.TabStop = true;
            AnswerD.Text = "5 Questions";
            AnswerD.UseVisualStyleBackColor = true;
            // 
            // QuizForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblQuestion);
            Controls.Add(Heading);
            Controls.Add(groupBox);
            Controls.Add(nextButton);
            Name = "QuizForm";
            Text = "QuizForm";
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblQuestion;
        private Label Heading;
        private RadioButton AnswerB;
        private RadioButton AnswerA;
        private GroupBox groupBox;
        private RadioButton AnswerD;
        private RadioButton AnswerC;
        private Button nextButton;
    }
}