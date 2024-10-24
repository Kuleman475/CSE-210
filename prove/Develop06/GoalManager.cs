using System.ComponentModel;
using System.IO;
using static System.IO.StreamWriter;

class GoalManager {

    private List<Goal> _goals;
    private int _score;

    public GoalManager(){
        _score = 0;
        _goals = new List<Goal>();
    }

    public void Start(){
// Start - This is the "main" function for this class. It is called by Program.cs, and then runs the menu loop.
    Console.WriteLine($"Your have {_score} points\n");
    Console.WriteLine("Menu Options: ");
    Console.WriteLine("    1. Create New Goal");
    Console.WriteLine("    2. List Goals");
    Console.WriteLine("    3. Save Goals");
    Console.WriteLine("    4. Load Goals");
    Console.WriteLine("    5. Record Event"); 
    Console.WriteLine("    6. Quit");
    Console.Write("Select a choice from the menu: ");
    string UserChoice = Console.ReadLine();

    switch(UserChoice){
        case "1":
            CreateGoal();
            break;
        case "2":
            ListGoalDetails();
            break;
        case "3":
            SaveGoals();
            break;
        case "4":
            LoadGoals();
            break;
        case "5":
            RecordEvent();
            break;
        case "6":
            Console.WriteLine("\nGoodbye!");
            break;
    }

    }

    public void DisplayPlayerInfo(){
// DisplayPlayerInfo - Displays the players current score.
    }
    public void ListGoalNames(){
        int goalNum = 1;
        foreach(Goal goal in _goals){
            Console.Write(goalNum + ". ");
            goal.GetStringRepresetation();
            goalNum += 1;
        }
        if(_goals.Count == 0){
            Console.WriteLine("No goals.");
        }
    }
    public void ListGoalDetails(){
// ListGoalDetails - Lists the details of each goal (including the checkbox of whether it is complete).
        int goalNum = 1;
        foreach(Goal goal in _goals){
            Console.Write($"{goalNum}. ");
            goal.GetStringRepresetation();
            goalNum += 1;
        }
        if(_goals.Count == 0){
            Console.WriteLine("No goals.");
        }
        Console.WriteLine("Press Enter key to continue: ");
        Console.ReadLine();
        Start();
    }
    public void CreateGoal(){
// CreateGoal - Asks the user for the information about a new goal. Then, creates the goal and adds it to the list.
        Console.WriteLine("Which Goal would you like to create: ");
        Console.WriteLine("    1. Simple goal");
        Console.WriteLine("    2. Eternal goal");
        Console.WriteLine("    3. Checklist goal");
        string goalInput = Console.ReadLine();

        switch(goalInput){
            case "1":
                Console.WriteLine("What is the name of the goal? ");
                string name = Console.ReadLine();
                Console.WriteLine("What is the short description of the goal? ");
                string description = Console.ReadLine();
                Console.WriteLine("How many points do you want with this goal? ");
                int points = Convert.ToInt32(Console.ReadLine());
                SimpleGoal simp = new SimpleGoal(name, description, points, false);
                _goals.Add(simp);
                break;
            case "2":
                Console.WriteLine("What is the name of the goal? ");
                string Ename = Console.ReadLine();
                Console.WriteLine("What is the short description of the goal? ");
                string Edescription = Console.ReadLine();
                Console.WriteLine("How many points do you want with this goal? ");
                int Epoints = Convert.ToInt32(Console.ReadLine());
                EternalGoal eternal = new EternalGoal(Ename, Edescription, Epoints);
                _goals.Add(eternal);
                break;
            case "3":
                Console.WriteLine("What is the name of the goal? ");
                string Cname = Console.ReadLine();
                Console.WriteLine("What is the short description of the goal? ");
                string Cdescription = Console.ReadLine();
                Console.WriteLine("How many points do you want with this goal? ");
                int Cpoints = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("How many times do you want to achieve this goal? ");
                int target = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("How many points do you want as a bonus? ");
                int bonus = Convert.ToInt32(Console.ReadLine());
                ChecklistGoal check = new ChecklistGoal(Cname, Cdescription, Cpoints, target, bonus);
                _goals.Add(check);
                break;
        }
        Start();
    }
    public void RecordEvent(){
// RecordEvent - Asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal.
        ListGoalNames();
        Console.WriteLine("Which goal would you like to record? ");
        int userRecord = Convert.ToInt32(Console.ReadLine());
        int Rpoints = _goals[userRecord - 1].GetPoints();
        _score += Rpoints;
        _goals[userRecord - 1].IsComplete();
        _goals[userRecord - 1].RecordEvent();

        Start();
    }
    public void SaveGoals(){
// SaveGoals - Saves the list of goals to a file. 
    Console.Write("Enter Filename: ");
    string userFile = Console.ReadLine();
    //PC 
    // string fileName = $"C:\\Users\\chris\\OneDrive\\Desktop\\BYU-Idaho Classes\\CSE 210\\CSE-210\\prove\\Develop06\\{userFile}";
    //Laptop
    // string fileName = @"C:\\Users\\Taylor\\Desktop\\BYU-IDAHO classes\\CSE 210 (Programming with classes)\\CSE-210\\prove\\Develop06";
        using (StreamWriter outputFile = new StreamWriter(userFile))
    {
    // You can add text to the file with the WriteLine method
    foreach (Goal goal in _goals) {
            outputFile.WriteLine(_score);
            outputFile.WriteLine(goal.GetStringRepresetation());
        }     
    }
    }
    public void LoadGoals(){
// LoadGoals - Loads the list of goals from a file.
 Console.Write("Enter Filename: ");
    string userFile = Console.ReadLine();
    if (File.Exists(userFile)){
    using (StreamReader outputFile = new StreamReader(userFile))
    {
    // You can add text to the file with the WriteLine method
    string[] lines = System.IO.File.ReadAllLines(userFile);
    foreach (string line in lines)
    {
    string[] parts = line.Split("::");
    Console.WriteLine(line);
    // List<Entry> entrie = new List<Entry>();
    // string _date = parts[0];
    // string _entryText = parts[1];
    // string _promptText = parts[2];
    // Console.WriteLine($"{_date}, {_entryText}, {_promptText}");
    // entry._date = _date;
    // entry._entryText = _entryText;
    // entry._promptText = _promptText;
    // _entries.Add(entry);
    }
    }
    }
    Start();
    }
}