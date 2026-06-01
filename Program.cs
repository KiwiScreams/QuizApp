using QuizApp.Data;
using QuizApp.Forms;
namespace QuizApp;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        DBTest.TestConnection();
        Application.Run(new MainForm());
    }
}