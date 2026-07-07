using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise3 Project.");
        // Console.WriteLine("What is the magic number? ");
        // string valueOne = Console.ReadLine();
        // int magic = int.Parse(valueOne);
        string play = "";

        while (play != "yes")
        {
            Random randomGenerator = new Random();
            int magic = randomGenerator.Next(1, 100);

            int guess = 0;
            int sum = 0;
            while (guess != magic)
            {
                Console.WriteLine("What is the guess? ");
                string value = Console.ReadLine();
                guess = int.Parse(value);
                if (magic > guess)
                {
                    Console.WriteLine("Low");
                }
                else
                {
                    Console.WriteLine("High");
                }
                sum += 1;
            }
            Console.WriteLine("You guessed it!");
            Console.WriteLine($"You have guessed {sum} times");
            Console.WriteLine();
            Console.WriteLine("Want to Quit Game?");
            play = Console.ReadLine();     
        }
        Console.WriteLine("Game has stopped!");

    }
}