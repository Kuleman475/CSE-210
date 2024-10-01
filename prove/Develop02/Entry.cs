using System;
using System.Security.Cryptography.X509Certificates;
// from DateTime in dateTime;
 public class Entry {

    public string _date = DateTime.Now.ToString("MM/dd/yyyy");

            public List<string> prompts = new List<string>
        {"What is the weather like?", "How did you feel today?", "What did you most recently eat?",
        "How did you see God's hand in your life today?", "Who did you talk to today?", "What is something fun you did?", 
        "What time did you wake up?", "What do you wish you did differently today?", "What did you ponder on today?"};


    public string _promptText;
    public string _entryText;

    public void DisplayEntry(){
        Console.WriteLine($"Date:{_date} >>> Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}");

    }


    }
