using Microsoft.Data.SqlClient;

namespace QuizApp.Data;

public static class Database
{
    public static string ConnectionString =
        @"Server=localhost\SQLEXPRESS;Database=QuizAppDB;Trusted_Connection=True;TrustServerCertificate=True;";

    public static SqlConnection GetConnection()
    {
        return new SqlConnection(ConnectionString);
    }
}