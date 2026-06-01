using System;

namespace QuizApp.Models;

public class Question
{
    public int Id { get; set; }
    public string Text { get; set; }
    public int Point { get; set; }
    public List<Answer> answers { get; set; } = new List<Answer>();

}
