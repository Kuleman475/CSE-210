using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
        Console.Write("Select a choice from the menu: ");
        string UserChoice = Console.ReadLine();
        switch(UserChoice) 
        {
        case "1":
            string description = "This activity will help you relax" +
        "by walking your through breathing in and out slowly."
        + "Clear your mind and focus on your breathing.";
            Activity breathe = new Activity("Breathing Activity", description, 20);
            BreathingActivity bactivity = new BreathingActivity("Breathing Activity", description, 20);
            bactivity.Run();
            break;
        case "2":
        string description = "This activity will help you reflect on times"
        + " in your life when you have shown strength and resilience."
        + " This will help you recognize the power you have and how you can "
        + "use it in other aspects of your life.";
            Activity reflecting = new Activity("Reflecting Activity", description, 20);
            break;
        case "3":
        string description = "This activity will help you reflect on the good things in your life"
        + " by having you list as many things as you can in a certain area.";
            // Activity listing = new Activity("Listing Activity");
            break;
        case "4":
            Console.WriteLine("Quit");
            break;
        }

    }
}