using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int gradePercent = Convert.ToInt32(grade);
        string Letter;
        string passFail;

        if (gradePercent >= 90){
            Letter = "A";
        }

        else if (gradePercent >= 80){
            Letter = "B";
        }
        else if (gradePercent >= 70){
            Letter = "C";
        }
        else if (gradePercent >= 60){
            Letter = "D";
        }
        else {
            Letter = "F";
        }
        if (gradePercent < 70){
            passFail = "Sorry you have failed. better luck next time.";
        }
        else {
            passFail = "Congratulations you passed!";
        }
        Console.WriteLine($"{Letter}");
        Console.WriteLine($"{passFail}");
    }
}