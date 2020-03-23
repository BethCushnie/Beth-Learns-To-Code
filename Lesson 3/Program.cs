using System;

namespace Lesson_3
{
    class Program
    {
        static void Main()
        {
            WriteLine("Enter the starting number");
            string line1 = Console.ReadLine();
            int number1 = int.Parse(line1);

            WriteLine("Enter the ending number");
            string line2 = Console.ReadLine();
            int number2 = int.Parse(line2);

            WriteLine("The numbers between those two numbers are:");

            for (int i = number1 + 1; i < number2; i++)
                WriteLine(i);
            // fun fact: if you have only 1 statement inside curly brackets, you can get rid of the curly brackets
        }

        static void WriteLine(object line)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(line);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
