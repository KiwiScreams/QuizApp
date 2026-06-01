using QuizApp.Data;
using QuizApp.Models;
using System;
using Microsoft.Data.SqlClient;

using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;

namespace QuizApp.Services
{
    public class QuestionService
    {
        public List<Question> GetQuestions(int count)
        {
            List<Question> questions = new List<Question>();

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();

                string query = $@"
            SELECT TOP (@Count) *
            FROM Questions
            ORDER BY NEWID()";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Count", count);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Question question = new Question();

                    question.Id = Convert.ToInt32(reader["Id"]);
                    question.Text = reader["QuestionText"].ToString();
                    question.Point = Convert.ToInt32(reader["Point"]);
                    question.answers = GetAnswersByQuestionId(question.Id);

                    questions.Add(question);
                }
            }

            return questions;
        }
        private List<Answer> GetAnswersByQuestionId(int questionId)
        {
            List<Answer> answers = new List<Answer>();

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();

                string query = @"
            SELECT *
            FROM Answers
            WHERE QuestionId = @QuestionId";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@QuestionId", questionId);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Answer answer = new Answer();

                    answer.Id = Convert.ToInt32(reader["Id"]);
                    answer.AnswerText = reader["AnswerText"].ToString();
                    answer.IsCorrect = Convert.ToBoolean(reader["IsCorrect"]);
                    answer.QuestionId = Convert.ToInt32(reader["QuestionId"]);

                    answers.Add(answer);
                }
            }

            return answers;
        }
        public static void ExportToTxt(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT q.Id, q.QuestionText, q.Point, a.AnswerText, a.IsCorrect
                    FROM Questions q
                    INNER JOIN Answers a ON q.Id = a.QuestionId
                    ORDER BY q.Id";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                int currentQuestionId = -1;

                while (reader.Read())
                {
                    int questionId = Convert.ToInt32(reader["Id"]);

                    if (questionId != currentQuestionId)
                    {
                        if (currentQuestionId != -1)
                            writer.WriteLine();

                        writer.WriteLine("Question: " + reader["QuestionText"]);
                        writer.WriteLine("Point: " + reader["Point"]);

                        currentQuestionId = questionId;
                    }

                    writer.WriteLine("Answer: " + reader["AnswerText"] + "|" + reader["IsCorrect"]);
                }
            }
        }

        public static void ImportFromTxt(string filePath)
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();

                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    SqlCommand deleteAnswers = new SqlCommand("DELETE FROM Answers", conn, transaction);
                    deleteAnswers.ExecuteNonQuery();

                    SqlCommand deleteQuestions = new SqlCommand("DELETE FROM Questions", conn, transaction);
                    deleteQuestions.ExecuteNonQuery();

                    string[] lines = File.ReadAllLines(filePath);

                    int currentQuestionId = 0;

                    foreach (string rawLine in lines)
                    {
                        string line = rawLine.Trim();

                        if (line == "")
                            continue;

                        if (line.StartsWith("Question:"))
                        {
                            string questionText = line.Replace("Question:", "").Trim();

                            SqlCommand cmd = new SqlCommand(@"
                                INSERT INTO Questions (QuestionText, Point)
                                OUTPUT INSERTED.Id
                                VALUES (@QuestionText, 1)", conn, transaction);

                            cmd.Parameters.AddWithValue("@QuestionText", questionText);

                            currentQuestionId = Convert.ToInt32(cmd.ExecuteScalar());
                        }
                        else if (line.StartsWith("Point:"))
                        {
                            // :)
                        }
                        else if (line.StartsWith("Answer:"))
                        {
                            string answerPart = line.Replace("Answer:", "").Trim();
                            string[] parts = answerPart.Split('|');

                            string answerText = parts[0].Trim();
                            bool isCorrect = Convert.ToBoolean(parts[1].Trim());

                            SqlCommand cmd = new SqlCommand(@"
                                INSERT INTO Answers (AnswerText, IsCorrect, QuestionId)
                                VALUES (@AnswerText, @IsCorrect, @QuestionId)", conn, transaction);

                            cmd.Parameters.AddWithValue("@AnswerText", answerText);
                            cmd.Parameters.AddWithValue("@IsCorrect", isCorrect);
                            cmd.Parameters.AddWithValue("@QuestionId", currentQuestionId);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }
}