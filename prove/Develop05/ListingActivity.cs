public class ListingActivity : Activity {
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string description, 
    int duration, int count, string prompt)
    : base(name, description)
    {
        DisplayStartingMessage();
        int seconds = GetDuration();
        SetDuration(seconds);
        Run(seconds);
        Console.WriteLine("");
        DisplayEndingMessage();
    }
    public void Run(int seconds){
        _count = 0;
        Console.Clear();
        Console.WriteLine("Welcome to Listing Activity!");
        Console.WriteLine("");
        Console.WriteLine("List as many responses as you can to the following prompt");
        GetRandomPrompt();
        Console.WriteLine("");
        ShowSpinner();
        _count = GetListFromUser(seconds).Count;     
        Console.WriteLine("Well Done! \n"); 
        Console.WriteLine($"You listed {_count} items!");
        ShowSpinner();
        
        
    }
    public string GetRandomPrompt(){
        _prompts =
        [
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
        ];

        Random random = new Random();
        int randPrompt = random.Next(_prompts.Count);
        Console.WriteLine($"--- {_prompts[randPrompt]} ---");
        return _prompts[randPrompt];
    }
    public List<string> GetListFromUser(int seconds){
        List<string> userInput = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.Write("> ");
            string userList = Console.ReadLine();
            userInput.Add(userList);
            currentTime = DateTime.Now;
        }
        
        return userInput;
    }
}