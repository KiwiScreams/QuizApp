using System;
using System.Collections.Generic;

namespace QuizApp.Models;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime RegistrationDate { get; set; }
    public decimal? Rank { get; set; }
}
