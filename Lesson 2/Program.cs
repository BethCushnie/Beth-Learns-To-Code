using System;

namespace Lesson_2
{
    class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Type a number!");
            string line = Console.ReadLine();
            bool lineIsValid = int.TryParse(line, out int number);
            // int.TryParse works like int.Parse (converts line to number) except it doesn't fail if the input isn't valid
            // if line isn't a number, instead of the program crashing, it just leaves Number as 0


            if (lineIsValid)
            {
                Console.WriteLine("input was valid!");
                // remember: "" declare it as a string
            }
            else
            {
                Console.WriteLine("u done f***ed up");
            }


            Console.WriteLine("Type another number!");
            string line2 = Console.ReadLine();
            int number2 = int.Parse(line2);

            int answer = number + number2;
            Console.WriteLine($"The answer is {answer}");
        }
    }
}
