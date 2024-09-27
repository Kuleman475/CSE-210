using System;
using System.Collections;
using System.Data;
using System.Net;

class Program
{
    static void Main(string[] args)
    {

        List<string> prompts = new List<string>
        {"What is the weather like?", "How did you feel today?", "What did you most recently eat?",
        "How did you see God's hand in your life today?", "Who did you talk to today?", "What is something fun you did?", 
        "What time did you wake up?", "What do you wish you did differently today?", "What did you ponder on today?"};


        Journal myJournal = new Journal();
            Console.WriteLine("Hello here is your Journal");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
        
            Console.Write("What would you like to do? ");
            string userNum = Console.ReadLine();
            int userChoice = Convert.ToInt32(userNum);

        Entry entry1 = new Entry();    
        entry1._date = DateTime.Now.ToString("MM/dd/yyyy");
        entry1._promptText = "What temperature is it inside? ";
        entry1._entryText = "it is a cool 78 degrees";
        
        Entry entry2 = new Entry();
        entry2._date = DateTime.Now.ToString("MM/dd/yyyy");
        entry2._promptText = "What temperature is the outside? ";
        entry2._entryText = "it is really hot outside";
                
        myJournal._entries.Add(entry1);
        myJournal._entries.Add(entry2);

            if (userChoice == 1)
                {        
                    string prompt = RandomPrompt(prompts);
                    Console.WriteLine(prompt);
                    string response = Console.ReadLine();
                    string date = DateTime.Now.ToString("MM/dd/yyyy");
                    myJournal.AddEntry(prompt, response, date);
                    displayMessage();
                }
            
             else if (userChoice == 2) {
                myJournal.DisplayAll();
                displayMessage();
            }
            else if (userChoice == 3) {
                Console.WriteLine("SAVE");
                myJournal.SaveFile();
                displayMessage();
            }
            else if (userChoice == 4) {
                Console.WriteLine("LOAD");
                myJournal.LoadFile();
                displayMessage();
            }
            else if (userChoice == 5) {
                Console.WriteLine("GOODBYE!");
            }
            else{
                displayMessage();
            }       
    }
        static string RandomPrompt(List<string> prompts) {
            Random random = new Random();
            int index = random.Next(prompts.Count);
            return prompts[index];
        }
        static void displayMessage(){
            Main([]);
        }
}