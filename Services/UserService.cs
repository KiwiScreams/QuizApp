using Microsoft.Data.SqlClient;
using QuizApp.Data;

namespace QuizApp.Services;

public class UserService
{
    public int AddUser(string name)
    {
        SqlConnection connection = Database.GetConnection();

        string query = @"
            INSERT INTO [User] (Name, RegistrationDate)
            OUTPUT INSERTED.Id
            VALUES (@Name, @Date)
        ";

        SqlCommand command = new SqlCommand(query, connection);

        command.Parameters.AddWithValue("@Name", name);
        command.Parameters.AddWithValue("@Date", DateTime.Now);
        connection.Open();
        int id = (int)command.ExecuteScalar();
        connection.Close();
        return id;
    }
}