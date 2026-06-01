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

            //MessageBox.Show("Button clicked");

            string name = nameTextBox.Text;

            UserService userService = new UserService();
            int userId = userService.AddUser(name);

            //MessageBox.Show("Added with Id: " + userId);

            if (name == "")
            {
                MessageBox.Show("Enter Name");
                return;
            }

            int questionCount = 5;

            if (radioButton10.Checked)
            {
                questionCount = 10;
            }
            //MessageBox.Show("User Added. Id: " + userId +
                            //"\nNumber of Questions: " + questionCount);
        }
    }
}
