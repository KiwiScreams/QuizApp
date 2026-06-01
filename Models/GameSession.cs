using System;

namespace QuizApp.Models;

public class GameSession
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int QuestionsCount { get; set; }
    public int Score { get; set; }
    public DateTime SessionStart { get; set; }
    public DateTime? SessionEnd { get; set; }
}
