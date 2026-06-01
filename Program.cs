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

        QuestionService questionService = new QuestionService();
        var questions = questionService.GetQuestions(5);

        Application.Run(new MainForm());
    }
}