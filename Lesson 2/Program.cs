using System;

namespace Lesson_2
{
    class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
           
            Console.WriteLine("Type a number!");
            string line = Console.ReadLine();
            int number = int.Parse(line);
          
            Console.WriteLine("Type another number!");
            string line2 = Console.ReadLine();
            int number2 = int.Parse(line2);

            int sum = number + number2;
            Console.WriteLine($"The sum of your two numbers is {sum}");
            // {sum} doesn't have to be a string
        }
    }
}
