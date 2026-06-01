using QuizApp.Data;
using QuizApp.Forms;
using QuizApp.Services;
namespace QuizApp;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        DBTest.TestConnection();

        QuestionService questionService = new QuestionService();
        var questions = questionService.GetQuestions(5);

        MessageBox.Show("question: " + questions.Count);

        Application.Run(new MainForm());
    }
}