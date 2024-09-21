using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int gradePercent = Convert.ToInt32(grade);

        if (gradePercent >= 90){
            Console.WriteLine("A");
            Console.WriteLine("PASSED");
        }

        else if (gradePercent >= 80){
            Console.WriteLine("B");
            Console.WriteLine("PASSED");
        }
        else if (gradePercent >= 70){
            Console.WriteLine("C");
            Console.WriteLine("PASSED");
        }
        else if (gradePercent >= 60){
            Console.WriteLine("D");
            Console.WriteLine("FAIL");
        }
        else {
            Console.WriteLine("F");
            Console.WriteLine("FAIL");
        }

    }
}