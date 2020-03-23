using System;

namespace Lesson_3
{
    class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            
            Console.WriteLine("Enter a number");
            Console.ForegroundColor = ConsoleColor.Magenta;
            string text = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;

            int number;
            bool textIsValid;
            textIsValid = int.TryParse(text, out number);

            if (textIsValid)
            {
                const int goalNumber = 69;
                int answer = goalNumber - number;
                Console.WriteLine($"Your number is {answer} away from {goalNumber}");   
            }
            else
            {
                Console.WriteLine("That's not a number, fool");
            }

        }
    }
}
