using System;


public class ReflectingActivity : Activity {
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description, 
    int duration, string prompt, string question) 
    : base(name, description, duration)
    {
        DisplayStartingMessage();
        Run();
        DisplayEndingMessage();
    }
    public void Run(){
        DisplayPrompt();
        Console.WriteLine("Press Enter once you have thought of something.");
        Console.ReadLine();
        Console.WriteLine("Now ponder each of the following as they relate to the experience.");
        Console.WriteLine($"We will beging in ... ");
        for (int i = 5; i >= 0; i--)
        {
           Thread.Sleep(1000);
           int currentLineCursor = Console.CursorTop;
           Console.SetCursorPosition(0, Console.CursorTop);
           Console.Write(new string(' ', Console.WindowWidth)); 
           Console.SetCursorPosition(0, currentLineCursor);
           Console.Write(i);
        }
        Console.Clear();
        for (int x = 0; x < 3; x++)
        {
           DisplayQuestion();
           Thread.Sleep(10000);
        }
        Console.WriteLine("Congratulations! YOu have completed the reflecting activity.");


    }
    public string GetRandomPrompt(){
        _prompts = new List<string>();
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        Random random = new Random();
        int randPrompt = random.Next(_prompts.Count);
        return _prompts[randPrompt];

    }
    public string GetRandomQuestion(){
        _questions = new List<string>();

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");

        Random random = new Random();
        int randomQuestion = random.Next(_questions.Count);
        return _questions[randomQuestion];
    }
    public void DisplayPrompt(){
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt + "  DISPLAUPROMT");
    }
    public void DisplayQuestion(){
        string question = GetRandomQuestion();
        Console.WriteLine($"> {question}");
    }
}