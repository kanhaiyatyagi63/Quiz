using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz;

public class McqQuiz
{
    public void SetCriteria(int maximumMarks, int minimumMarks)
    {
        MaximumMarks = maximumMarks;
        MiniumMarks = minimumMarks;
        MarksObtained = 0;
    }
    public McqQuiz()
    {
        Questions = new List<Question>();
    }
    public int MaximumMarks { get; set; } // maximum marks to clear the exam
    public int MarksObtained { get; set; } // marks obtained by user
    public int MiniumMarks { get; set; } // minimum marks to clear the paper
    public string Result
    {
        get
        {
            if (MarksObtained < MiniumMarks)
                return "Fail";
            return "Pass";
        }
    }
    public List<Question> Questions { get; set; }
}

public class Question
{
    public void SetQuestion(int id, string name, Dictionary<string, string> choices, string correctAnswer, int marks)
    {
        Id = id;
        Name = name;
        Choices = choices;
        CorrectAnswer = correctAnswer;
        Marks = marks;
    }
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public Dictionary<string, string> Choices { get; set; } = null!;
    public string CorrectAnswer { get; set; } = null!;
    public int Marks { get; set; }
    public string SelectedAnswer { get; set; } = null!;

}