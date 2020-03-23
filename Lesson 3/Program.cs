using System;

namespace Lesson_3
{
    class Program
    {
        static void Main()
        {
            WriteLineColor("Enter a number", ConsoleColor.Magenta);
            Console.ForegroundColor = ConsoleColor.Cyan;
            string text = Console.ReadLine();

            int number;
            bool textIsValid;
            textIsValid = int.TryParse(text, out number);

            if (textIsValid)
            {
                const int goalNumber = 69;
                int answer = goalNumber - number;
                WriteLineColor($"Your number is {answer} away from {goalNumber}", ConsoleColor.Magenta);   
            }
            else
            {
                WriteLineColor("That's not a number, fool", ConsoleColor.Magenta);
            }

        }

        static void WriteLineColor(string line, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(line);
        }
    }
}
