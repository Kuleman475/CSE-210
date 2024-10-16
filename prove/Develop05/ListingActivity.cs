public class ListingActivity : Activity {
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string description, 
    int duration, int count, string prompt)
    : base(name, description, duration)
    {
        DisplayStartingMessage();
        Run();
        DisplayEndingMessage();
    }
    public void Run(){
        _count = 0;
        Console.Clear();
        Console.WriteLine("Welcome to Listing Activity!");
        GetRandomPrompt();
        // for(int i = 0; i <= 10; i++){
        //   GetListFromUser();  
        // }
        
        Console.WriteLine($" P{_count}");

        // return _count;
    }
    public string GetRandomPrompt(){
        _prompts = new List<string>();

        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

        Random random = new Random();
        int randPrompt = random.Next(_prompts.Count);
        return _prompts[randPrompt];
    }
    public List<string> GetListFromUser(){
        List<string> userInput = new List<string>();
        string userList = Console.ReadLine();
        userInput.Add(userList);
        return userInput;
    }
}