using Microsoft.Data.SqlClient;
using System.Windows.Forms;
namespace QuizApp.Data;

public static class DBTest
{
    public static string ConnectionString =
        @"Server=localhost\SQLEXPRESS;Database=QuizAppDB;Trusted_Connection=True;TrustServerCertificate=True;";

    public static void TestConnection()
    {
        using SqlConnection connection =
            new SqlConnection(ConnectionString);

        connection.Open();
        MessageBox.Show("Connected!");
    }
}