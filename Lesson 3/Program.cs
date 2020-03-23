using System;

namespace Lesson_3
{
    class Program
    {
        static void Main()
        {
            WriteLineColor("Enter a number");
            string text = Console.ReadLine();

            int number;
            bool textIsValid;
            textIsValid = int.TryParse(text, out number);

            if (textIsValid)
            {
                const int goalNumber = 69;
                int answer = goalNumber - number;
                WriteLineColor($"Your number is {answer} away from {goalNumber}");   
            }
            else
            {
                WriteLineColor("That's not a number, fool");
            }

        }

        static void WriteLineColor(string line)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(line);
            Console.ForegroundColor = ConsoleColor.Cyan;
        }
    }
}
