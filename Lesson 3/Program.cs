using System;

namespace Lesson_3
{
    class Program
    {
        static void Main()
        {
            WriteLine("Enter a number");
            string text = Console.ReadLine();

            bool textIsValid = int.TryParse(text, out int number);

            if (textIsValid)
            {
                const int goalNumber = 69;
                int answer = goalNumber - number;
                WriteLine($"Your number is {answer} away from {goalNumber}");   
            }
            else
            {
                WriteLine("That's not a number, fool");
            }
        }

        static void WriteLine(string line)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(line);
            Console.ForegroundColor = ConsoleColor.Cyan;
        }
    }
}
