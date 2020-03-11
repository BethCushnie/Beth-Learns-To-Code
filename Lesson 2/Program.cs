using System;

namespace Lesson_2
{
    class Program
    {
        static void Main()
        { 
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Type a number!");
            int number1 = ReadNumber();

            Console.WriteLine("Type another number!");
            int number2 = ReadNumber();

            int answer = number1 + number2;
            Console.WriteLine($"The answer is {answer}");


            int ReadNumber()
            {
                string line = Console.ReadLine();
                bool lineIsValid = int.TryParse(line, out int number);

                if (!lineIsValid)
                {
                    Console.WriteLine("u done f***ed up");
                    Main();
                }

                return number;
            }
        }
    }
}
