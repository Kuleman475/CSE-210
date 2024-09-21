using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        Console.WriteLine("Enter a number: ");
        string num = Console.ReadLine();
        int number = Convert.ToInt32(num);
        
        List<int> numberList = new List<int>();
        int countNum = 0;
        int sum = number;
        while (number != 0){

        numberList.Add(number);
        
        Console.WriteLine("Enter a number: ");
        num = Console.ReadLine();
        number = Convert.ToInt32(num);
        sum += number;
        countNum += 1;
        }

        double avg = Queryable.Average(numberList.AsQueryable());
        Console.WriteLine("the sum is: " + sum);
        Console.WriteLine("The average is: " + avg);
        Console.WriteLine("The largest number is: " + numberList.Max());
    }
}