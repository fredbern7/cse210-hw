using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 to when finished");
        List<int> numbers = new List<int>();
        int num = -1;
        while (num != 0)
        {
            Console.WriteLine("Enter number. ");
            string inputString = Console.ReadLine();
            num = int.Parse(inputString);
            
            if (num != 0)
            {
                numbers.Add(num);                
            }

        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        float average = ((float)sum) / numbers.Count;

        int max = numbers[0];

        foreach(int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        int min = numbers[0];
        foreach(int number in numbers)
        {
            if (number > 0)
            {   
                if (number < min)
                {
                    // Console.WriteLine(number);
                    min = number;
                }
            }
        }



        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number: {max}");
        Console.WriteLine($"The Smallest positive number is: {min}");

        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach ( float number in numbers)
        {
            Console.WriteLine(number);
        }

        
    }
}