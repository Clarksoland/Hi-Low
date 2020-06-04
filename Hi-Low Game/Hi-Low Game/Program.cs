using System;

namespace Hi_Low_Game
{
    class Program
    {
        public static int number;
        public static Random rand = new Random();
        public static int guess;
        public static string lower = string.Empty;

        public static bool win = false;
        public static int guessCount = 0;
        static void Main(string[] args)
        {
            number = rand.Next(101);
            //Console.WriteLine(number);

            Console.WriteLine("The number has been chosen. It's time to guess!");
            Console.ReadKey();

            while (!win)
            {
                Console.Clear();
                Console.WriteLine(lower);
                Console.WriteLine("Enter your guess: ");

                while (true)
                {
                    try
                    {
                        guess = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("Please enter a valid integer.");
                    }
                }

                Console.Clear();
                guessCount++;
                if (guess == number)
                {
                    lower = "You guessed correctly!";
                    win = true;
                }
                else if (guess > number)
                {
                    lower = "Too high!";
                }
                else
                {
                    lower = "Too low!";
                }
            }

            Console.WriteLine(lower);

            Console.WriteLine("Good job! It took you {0} attempts!", guessCount);

            Console.WriteLine("\nPress any key to exit.");

            Console.ReadKey();
        }
    }
}
