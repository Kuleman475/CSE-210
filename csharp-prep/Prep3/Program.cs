using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("What is your magic number?");
        // string num = Console.ReadLine();
        Random num = new Random();
        int magicNumber = num.Next(1, 101);


        Console.WriteLine("What is your guess? ");
        string g = Console.ReadLine();
        int guess = Convert.ToInt32(g);

        while (guess != magicNumber){
            if (guess > magicNumber){
                Console.WriteLine("LOWER");
                }
            else{
                Console.WriteLine("HIGHER");
            }
        Console.WriteLine("What is your guess? ");
        g = Console.ReadLine();
        guess = Convert.ToInt32(g);
        }
        Console.WriteLine("You guessed it! ");
    }
}