using System;


public class ReflectingActivity : Activity {
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description, 
    int duration, string prompt, string question) 
    : base(name, description)
    {
        DisplayStartingMessage();
        int seconds = GetDuration();
        SetDuration(seconds);
        Run(seconds);
        DisplayEndingMessage();
    }
    public void Run(int seconds){
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
        int time = 0;
        while(seconds > time) {
           DisplayQuestion();
            for(int i = 0; i <= 10; i++){
                Thread.Sleep(1000);
                time += 1;
                i+=1;
            }
        }
    }
    public string GetRandomPrompt(){
        _prompts =
        [
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
        ];

        Random random = new Random();
        int randPrompt = random.Next(_prompts.Count);
        return _prompts[randPrompt];

    }
    public string GetRandomQuestion(){
        _questions =
        [
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?",
        ];

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