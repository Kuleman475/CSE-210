using System;

class Program
{
    static void Main(string[] args)
    {
        string UserChoice = "0";
    while(UserChoice != "4"){
    switch(UserChoice){
        case "0":
        Console.WriteLine("Which activity did you do?");
        Console.WriteLine("    1. Running");
        Console.WriteLine("    2. Swimming");
        Console.WriteLine("    3. Cycling");
        Console.WriteLine("    4. Quit");
        Console.Write("Select a choice from the menu: ");
        UserChoice = Console.ReadLine();
        break;
        case "1":
            Console.WriteLine("How many minutes did you run? ");
            int minutes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How far did you run (in Miles): ");
            double miles = Convert.ToDouble(Console.ReadLine());
            Activity a1 = new Activity (minutes, "");
            Running r = new Running (minutes, "", miles);
            r.GetSummary();
            UserChoice = "0";
            break;
        case "2":
            Console.WriteLine("How many minutes did you swim? ");
            int minutes2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many laps did you swim? : ");
            double laps = Convert.ToDouble(Console.ReadLine());
            Activity a2 = new Activity(minutes2, "");
            Swimming s = new Swimming(minutes2, "", laps);
            s.GetSummary();
            UserChoice = "0";
            break;
        case "3":
            Console.WriteLine("How many minutes did you cycle? ");
            int minutes3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How fast did you cycle? (miles per hour): ");
            double speed = Convert.ToDouble(Console.ReadLine());
            Activity a3 = new Activity (minutes3, "");
            Cycling c = new Cycling(minutes3, "", speed);
            c.GetSummary();
            UserChoice = "0";
            break;
        case "4":
            Console.WriteLine("\nGoodbye!");
            break;
    }
    }

    }
}