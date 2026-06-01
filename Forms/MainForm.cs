using QuizApp.Services;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;

            if (name == "")
            {
                MessageBox.Show("Enter Name");
                return;
            }

            int questionsCount = 5;

            if (radioButton10.Checked)
            {
                questionsCount = 10;
            }

            UserService userService = new UserService();
            int userId = userService.AddUser(name);

            GameSessionService gameSessionService = new GameSessionService();
            int sessionId = gameSessionService.StartSession(userId, questionsCount);

            QuizForm quizForm = new QuizForm(userId, sessionId, questionsCount);
            quizForm.Show();
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
        }
    }
}
