using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();     
        int number = PromptUserNumber();   
        int squaredNum = SquareNumber(number);    
        DisplayResult(squaredNum, userName);      
    }

    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the Program!");
    }
    
    static string PromptUserName(){    
        Console.WriteLine("What is your first name: ");
        string firstName = Console.ReadLine();
        Console.WriteLine("What is your last name: ");
        string lastName = Console.ReadLine();
        string name = firstName + " " + lastName;
        return name;
    }

    static int PromptUserNumber(){

        Console.WriteLine("What is your favorite number: ");
        string favoriteNumber = Console.ReadLine();
        int favnum = Convert.ToInt32(favoriteNumber);
        return favnum;
    }

    static int SquareNumber(int number){
        int squaredNumber = number * number;
        return squaredNumber;
    }

    static void DisplayResult(int snumber, string uName){
        Console.WriteLine(uName + ", the square of your number is " + snumber);
    }
}