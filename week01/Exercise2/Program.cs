using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine("What is your grade in Percent? ");
        string valueFromUser = Console.ReadLine();
        int percent = int.Parse(valueFromUser);

        string letter = "";
        string sign = "";
        int remainder = 0;
        int divider = 10;
        if (percent >=90)
        {
            letter = "A";
            remainder = percent % divider;
        }
        else if (percent >=80)
        {
            letter = "B";
            remainder = percent % divider;
        }
        else if (percent >=70)
        {
            letter = "C";
            remainder = percent % divider;
        }
        else if (percent >=60)
        {
            letter = "D";
            remainder = percent % divider;
        }
        else
        {
            letter = "F";
            remainder = percent % divider;
        }

        if (remainder >= 7)
        {
            sign = "+";
        }
        else if (remainder < 3) 
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        if (percent >= 70)
        {
            Console.WriteLine("Congratulation, you have pass the course.");
        }
        else
        {
            Console.WriteLine("No worries. Try again next time.");
        }
        Console.WriteLine($"Your grade is: {letter}{sign}");
    }
}