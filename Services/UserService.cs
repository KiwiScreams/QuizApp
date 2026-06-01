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
            VALUES (@Name, @RegistrationDate)
        ";

        SqlCommand command = new SqlCommand(query, connection);

        command.Parameters.AddWithValue("@Name", name);
        command.Parameters.AddWithValue("@RegistrationDate", DateTime.Now);
        connection.Open();
        int id = (int)command.ExecuteScalar();
        connection.Close();
        return id;
    }
    public void UpdateRank(int userId, decimal rank)
    {
        using SqlConnection connection = Database.GetConnection();

        string query = @"
        UPDATE [User]
        SET Rank = @Rank
        WHERE Id = @UserId
    ";

        using SqlCommand command = new SqlCommand(query, connection);

        command.Parameters.AddWithValue("@Rank", rank);
        command.Parameters.AddWithValue("@UserId", userId);

        connection.Open();
        command.ExecuteNonQuery();
    }
}