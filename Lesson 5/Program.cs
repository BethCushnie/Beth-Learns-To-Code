using System;

namespace Lesson_5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("How many prime numbers do you want?");
            int numberOfPrimes = GetNumberFromUser();
        }

        static void Print(object obj)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(obj);
        }

        static int GetNumberFromUser()
        {
            Console.ForegroundColor = ConsoleColor.White;
            bool numberIsValid = int.TryParse(Console.ReadLine(), out int enteredNumber);

            if (numberIsValid)
                return enteredNumber;

            Print("C'mom man. Number. A NUMBER.");
            Print("I'm just going to pretend you entered zero because you SUCK and that's the score I give you out of 10.");
            return 0;

        }
    }
}
