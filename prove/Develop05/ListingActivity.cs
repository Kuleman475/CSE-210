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
        DisplayEndingMessage();
    }
    public void Run(int seconds){
        _count = 0;
        Console.Clear();
        Console.WriteLine("Welcome to Listing Activity!");
        GetRandomPrompt();
        while(seconds > time) {
            


        
        Console.WriteLine($" P{_count}");

        // return _count;
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
        return _prompts[randPrompt];
    }
    public List<string> GetListFromUser(){
        List<string> userInput = new List<string>();
        
            Console.Write("> ");
            string userList = Console.ReadLine();
            userInput.Add(userList);

        
        return userInput;
    }
}