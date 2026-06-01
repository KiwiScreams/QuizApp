using Microsoft.Data.SqlClient;
using QuizApp.Data;

namespace QuizApp.Services;

public class GameSessionService
{
    public int StartSession(int userId, int questionsCount)
    {
        SqlConnection connection = Database.GetConnection();

        string query = @"
            INSERT INTO GameSession 
            (UserId, QuestionsCount, Score, SessionStart, SessionEnd)
            OUTPUT INSERTED.Id
            VALUES (@UserId, @QuestionsCount, 0, @SessionStart, NULL)
        ";

        SqlCommand command = new SqlCommand(query, connection);

        command.Parameters.AddWithValue("@UserId", userId);
        command.Parameters.AddWithValue("@QuestionsCount", questionsCount);
        command.Parameters.AddWithValue("@SessionStart", DateTime.Now);

        connection.Open();
        int sessionId = (int)command.ExecuteScalar();
        connection.Close();
        return sessionId;
    }

    public void FinishSession(int sessionId, int score)
    {
        SqlConnection connection = Database.GetConnection();

        string query = @"
            UPDATE GameSession
            SET Score = @Score,
                SessionEnd = @SessionEnd
            WHERE Id = @SessionId
        ";

        SqlCommand command = new SqlCommand(query, connection);

        command.Parameters.AddWithValue("@Score", score);
        command.Parameters.AddWithValue("@SessionEnd", DateTime.Now);
        command.Parameters.AddWithValue("@SessionId", sessionId);

        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();
    }
}