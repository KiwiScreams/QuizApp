using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp.Forms
{
    public partial class ResultForm : Form
    {
        public ResultForm(int score, int questionsCount)
        {
            InitializeComponent();

            resultLabel.Text = $"Quiz Finished!\nYour result: {score}/{questionsCount}";
        }
    }
}
