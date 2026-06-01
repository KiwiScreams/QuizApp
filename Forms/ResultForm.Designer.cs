namespace QuizApp.Forms
{
    partial class ResultForm
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
            resultLabel = new Label();
            Heading = new Label();
            SuspendLayout();
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resultLabel.Location = new Point(228, 307);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(345, 31);
            resultLabel.TabIndex = 8;
            resultLabel.Text = "Choose the number of questions";
            // 
            // Heading
            // 
            Heading.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Heading.AutoSize = true;
            Heading.Font = new Font("Showcard Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Heading.ForeColor = SystemColors.HotTrack;
            Heading.Location = new Point(250, 112);
            Heading.Name = "Heading";
            Heading.Size = new Size(304, 74);
            Heading.TabIndex = 7;
            Heading.Text = "Quiz App";
            // 
            // ResultForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultLabel);
            Controls.Add(Heading);
            Name = "ResultForm";
            Text = "ResultForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label resultLabel;
        private Label Heading;
    }
}