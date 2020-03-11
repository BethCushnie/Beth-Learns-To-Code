using System;

namespace Lesson_2
{
    class Program
    {
        static void Main()
        {
            start:
            
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Type a number!");
            string line = Console.ReadLine();
            bool lineIsValid = int.TryParse(line, out int number);


            if (!lineIsValid)
            {
                Console.WriteLine("u done f***ed up");

                goto start;
                // now the program restarts if the input is not valid
            }

            Console.WriteLine("Type another number!");
            string line2 = Console.ReadLine();
            int number2 = int.Parse(line2);

            int answer = number + number2;
            Console.WriteLine($"The answer is {answer}");
        }
    }
}
