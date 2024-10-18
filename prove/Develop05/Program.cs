using System;

class Program
{

    // Exceeding Requirements I made the background color of when you breathe in to a blue and when you breathe out to a yellow.

    static void Main(string[] args)
    {
        string UserChoice = "0";
        while(UserChoice != "4"){
        switch(UserChoice) 
        {
        case "0":
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            UserChoice = Console.ReadLine();
            break;
        case "1":
            string description1 = "This activity will help you relax " +
        "by walking your through breathing in and out slowly."
        + "Clear your mind and focus on your breathing.";
            Activity breathe = new Activity("Breathing Activity", description1);
            BreathingActivity bactivity = new BreathingActivity("Breathing Activity", description1);
            UserChoice = "0";
            break;

        case "2":
        string description2 = "This activity will help you reflect on times"
        + " in your life when you have shown strength and resilience."
        + " This will help you recognize the power you have and how you can "
        + "use it in other aspects of your life.";
            Activity reflecting = new Activity("Reflecting Activity", description2);
            ReflectingActivity r = new ReflectingActivity("Reflecting Activity", description2, 20, "", "");
            UserChoice = "0";
            break;

        case "3":
        string description3 = "This activity will help you reflect on the good things in your life"
        + " by having you list as many things as you can in a certain area.";
            Activity listing = new Activity("Listing Activity", description3);
            ListingActivity l = new ListingActivity("Listing Activity", description3, 20, 0, "");
            UserChoice = "0";
            break;
        
        case "4":
            Console.WriteLine("Quit");
            break;
        
        }
        }
    }
}