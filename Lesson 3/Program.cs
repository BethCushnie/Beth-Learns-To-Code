using System;

namespace Lesson_3
{
    class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            
            Console.WriteLine("Enter a number");
            string text = Console.ReadLine();

            int number = int.Parse(text);
            const int goalNumber = 69;
            // Adding const means that this variable cannot be changed for the rest of the code
            // Without it, you could assign the variable a different value partway through the code. Adding const prevents this

            int answer = goalNumber - number;
            Console.WriteLine($"Your number is {answer} away from {goalNumber}");
        }
    }
}
