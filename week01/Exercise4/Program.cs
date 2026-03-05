using System;

class Program
{
    static void Main(string[] args)
    {   
       
        List <int> numbers_list = new List<int>();
        Console.Write("Enter a list of numbers, type 0 when finished. ");
        string number_read = Console.ReadLine();
        int number = int.Parse(number_read);
        int sum = 0;
        int count = 0;
        
        
        while (number != 0)
        {
            numbers_list.Add(number);
            sum += number;
            count++;

            Console.Write("Enter a list of numbers, type 0 when finished: ");
            number = int.Parse(Console.ReadLine());
            
            
        }
        double  avarage = (double)sum / count;
        int max = numbers_list[0];
        foreach (int num in numbers_list)
    {
        if (num > max)
        {
            max = num;
        }
}

    Console.WriteLine($"the sum is: {sum}");
    Console.WriteLine($"The average is: {avarage}");
    Console.WriteLine($"The largest number is: {max}");

    }
}