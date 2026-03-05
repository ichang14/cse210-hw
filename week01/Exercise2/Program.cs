using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Enter your grade: ");
        string grade = Console.ReadLine();
        
        int number = int.Parse(grade);
        

        string letter = "";
        string sign = "";
        if (number % 10 >= 0 && number % 10 <= 3)
        {
            sign ="-";
        }
        else if (number % 10 <= 9 && number % 10 >= 7)
        {
            sign ="+";
        }                
        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        if (letter == "A" || letter == "F")
        {
            Console.WriteLine($"Your grade is {letter}");
        }
        else
        {
            Console.WriteLine($"Your grade is {letter}{sign}");
        }        
        if (number >= 70)
        {
            Console.WriteLine("Congratulations, you approved!");
        }
        else
        {
            Console.WriteLine("You failed. Keep trying!");
        }

    }
}