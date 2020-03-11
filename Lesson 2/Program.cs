using System;

namespace Lesson_2
{
    class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            // This will make the forground (the text) magenta :)
           
            Console.WriteLine("Type a number!");
            string line = Console.ReadLine();
            int x = int.Parse(line);
            // line is a string, but x is an integer
            // int.Parse() is a function that converts a string into an integer
            // However, if the string isn't a number, then an error will appear
            Console.WriteLine("Type another number!");
            string line2 = Console.ReadLine();
            int y = int.Parse(line2);
            Console.WriteLine("The sum of your two numbers is");
            Console.WriteLine(x + y);
        }
    }
}
