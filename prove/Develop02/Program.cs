using System;

class Program
{
    static void Main(string[] args)
    {
        
            Console.WriteLine("Hello here is your Journal");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
        
            Console.Write("What would you like to do? ");
            string userNum = Console.ReadLine();
            int userChoice = Convert.ToInt32(userNum);
            
            if (userChoice == 1) {
                Entry entry = new Entry();
                entry.DisplayEntry();
            }
            else if (userChoice == 2) {
                Console.WriteLine("DISPLAY");
            }
            else if (userChoice == 3) {
                Console.WriteLine("SAVE");
            }
            else if (userChoice == 4) {
                Console.WriteLine("LOAD");
            }
            else if (userChoice == 5) {
                Console.WriteLine("GOODBYE!");
            }
            else{
                displayMessage();
            }
            
    }
        static void displayMessage(){
            Main([]);
        }
}