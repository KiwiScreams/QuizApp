using Microsoft.Data.SqlClient;
using QuizApp.Data;
using QuizApp.Models;

namespace QuizApp.Services;

public class QuestionService
{
    public List<Question> GetQuestions(int count)
    {
        List<Question> questions = new List<Question>();

        SqlConnection connection = Database.GetConnection();
        string query = @"
            SELECT TOP (@Count) Id, QuestionText, Point
            FROM Questions
            ORDER BY NEWID()
        ";

        SqlCommand command = new SqlCommand(query, connection);
        command.Parameters.AddWithValue("@Count", count);

        connection.Open();

        SqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            Question question = new Question();

            question.Id = reader.GetInt32(0);
            question.Text = reader.GetString(1);
            question.Point = reader.GetInt32(2);

            questions.Add(question);
        }

        reader.Close();
        connection.Close();

        for (int i = 0; i < questions.Count; i++)
        {
            questions[i].answers = GetAnswers(questions[i].Id);
        }

        return questions;
    }

    public List<Answer> GetAnswers(int questionId)
    {
        List<Answer> answers = new List<Answer>();

        SqlConnection connection = Database.GetConnection();
        string query = @"
            SELECT Id, AnswerText, IsCorrect, QuestionId
            FROM Answers
            WHERE QuestionId = @QuestionId
        ";

        SqlCommand command = new SqlCommand(query, connection);
        command.Parameters.AddWithValue("@QuestionId", questionId);

        connection.Open();
        SqlDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
            Answer answer = new Answer();

            answer.Id = reader.GetInt32(0);
            answer.AnswerText = reader.GetString(1);
            answer.IsCorrect = reader.GetBoolean(2);
            answer.QuestionId = reader.GetInt32(3);

            answers.Add(answer);
        }

        reader.Close();
        connection.Close();
        return answers;
    }
}