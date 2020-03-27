using System;

namespace Lesson_5
{
    class Program
    {
        static void Main()
        {
            Print("Up to what number do you want prime?");
            int maxPrime = GetNumberFromUser();

            for (int i = 1; i <= maxPrime; i++)
            {
                if (IsPrime(i))
                    Print(i);
            }
        }

        static bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (IsEvenlyDivisibleBy(number, i))
                    return false;
            }

            return true;
        }

        static bool IsEvenlyDivisibleBy(int dividend, int divisor)
        {
            int remainder = dividend % divisor;
            
            if (remainder == 0)
                return true;

            return false;
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
