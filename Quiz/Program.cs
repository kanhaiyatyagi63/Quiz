using Quiz;

internal class Program
{
    public static McqQuiz mcqQuiz;

    public Program()
    {
        mcqQuiz = new();
    }

    public void Init()
    {
        mcqQuiz.SetCriteria(100, 33);
        Console.WriteLine("Welcome to test!");
        Console.WriteLine($"Maximum number of marks in assement is {mcqQuiz.MaximumMarks} " +
            $"\nYou must need to obtained {mcqQuiz.MiniumMarks} marks");
    }

    public void QuestionGenerator()
    {
        var choices = new Dictionary<string, string>();
        // Question 1
        choices.Add("A", "C#");
        choices.Add("B", "Java");
        choices.Add("C", "Python");
        choices.Add("D", "Javascript");
        var quesiton1 = new Question();
        quesiton1.SetQuestion(1, "What is your favourite language?", choices, "A", 25);
        mcqQuiz.Questions.Add(quesiton1);

        //reset choices 
        choices = new();

        // Question 2
        choices.Add("A", "Hibernate");
        choices.Add("B", "Dapper");
        choices.Add("C", "Entity Framework");
        choices.Add("D", "Ado.net");
        var quesiton2 = new Question();
        quesiton2.SetQuestion(2, "What is your favourite Framework?", choices, "C", 25);
        mcqQuiz.Questions.Add(quesiton2);

        //reset choices 
        choices = new();

        // Question 3
        choices.Add("A", "Virat Kohli");
        choices.Add("B", "Rohit sharma");
        choices.Add("C", "Shikhar Dhawan");
        choices.Add("D", "Rishabh Pant");
        var quesiton3 = new Question();
        quesiton3.SetQuestion(3, "What is your favourite Cricker?", choices, "B", 25);
        Console.WriteLine("Please enter your answer");
        mcqQuiz.Questions.Add(quesiton3);

        //reset choices 
        choices = new();

        // Question 4
        choices.Add("A", "Nawaz");
        choices.Add("B", "Hritik Roshan");
        choices.Add("C", "Varun Dhawan");
        choices.Add("D", "Kanhaiya Tyagi");
        var quesiton4 = new Question();
        quesiton4.SetQuestion(4, "What is your favourite Actor?", choices, "D", 25);
        mcqQuiz.Questions.Add(quesiton4);

    }

    public void DisplayQuestion()
    {
        Console.WriteLine("Question are -");
        foreach (var question in mcqQuiz.Questions)
        {
            Console.WriteLine($"{question.Id} - {question.Name}");
            foreach (var choice in question.Choices)
            {
                Console.WriteLine($"{choice.Key} : {choice.Value}");
            }
            Console.WriteLine("Please enter your answer");
            question.SelectedAnswer = Console.ReadLine();
        }

    }

    public void GenerateReport()
    {
        mcqQuiz.MarksObtained = mcqQuiz.Questions.Where(x => x.CorrectAnswer == x.SelectedAnswer).Sum(x => x.Marks);
        Console.WriteLine("Assesment completed");
        Console.WriteLine($"Your result is {mcqQuiz.Result}, you get {mcqQuiz.MarksObtained} marks");
    }


    private static void Main(string[] args)
    {
        var program = new Program();
        program.Init();
        program.QuestionGenerator();
        program.DisplayQuestion();
        program.GenerateReport();
    }

}