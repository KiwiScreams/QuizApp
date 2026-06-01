using QuizApp.Models;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace QuizApp.Forms
{
    public partial class QuizForm : Form
    {
        private List<Question> questions;
        private int currentQuestionIndex = 0;
        private int score = 0;
        private int sessionId;

        public QuizForm(int sessionId, int questionsCount)
        {
            InitializeComponent();

            this.sessionId = sessionId;

            QuestionService questionService = new QuestionService();
            questions = questionService.GetQuestions(questionsCount);

            ShowQuestion();
        }
        private void ShowQuestion()
        {
            Question question = questions[currentQuestionIndex];

            lblQuestion.Text = question.Text;

            AnswerA.Text = question.answers[0].AnswerText;
            AnswerB.Text = question.answers[1].AnswerText;
            AnswerC.Text = question.answers[2].AnswerText;
            AnswerD.Text = question.answers[3].AnswerText;

            AnswerA.Checked = false;
            AnswerB.Checked = false;
            AnswerC.Checked = false;
            AnswerD.Checked = false;
        }
        private void FinishQuiz()
        {
            GameSessionService gameSessionService = new GameSessionService();

            gameSessionService.FinishSession(sessionId, score);

            MessageBox.Show(
                $"Quiz finished!\nScore: {score}");

            Close();
        }
        private void nextButton_Click(object sender, EventArgs e)
        {
            Answer selectedAnswer = null;

            if (AnswerA.Checked)
                selectedAnswer = questions[currentQuestionIndex].answers[0];

            if (AnswerB.Checked)
                selectedAnswer = questions[currentQuestionIndex].answers[1];

            if (AnswerC.Checked)
                selectedAnswer = questions[currentQuestionIndex].answers[2];

            if (AnswerD.Checked)
                selectedAnswer = questions[currentQuestionIndex].answers[3];

            if (selectedAnswer == null)
            {
                MessageBox.Show("Select an answer!");
                return;
            }
            if (selectedAnswer.IsCorrect)
            {
                score += questions[currentQuestionIndex].Point;
            }

            currentQuestionIndex++;
            if (currentQuestionIndex >= questions.Count)
            {
                FinishQuiz();
                return;
            }
            ShowQuestion();
        }
    }
}
