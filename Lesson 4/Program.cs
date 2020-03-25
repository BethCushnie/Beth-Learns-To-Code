using System;

namespace Lesson_4
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Print("What Fibonacci number do you want?");
                int numberToPrint = GetNumberFromUser();

                Print($"The {numberToPrint}th fibonacci number is {GetFibonacciNumber(numberToPrint)}");
            }
           
        }

        static void Print(object obj)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(obj);
        }

        static int GetNumberFromUser()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            bool numberIsGood = int.TryParse(Console.ReadLine(), out int enteredNumber);

            if (numberIsGood)
                return enteredNumber;

            Print("That ain't a number brah");
            Print("We're pretending you entered 0");
            return 0;
        }

        static int GetFibonacciNumber(int index)
        {
            int a = 0, b = 1;

            if (index == 0)
                return 0;

            if (index == 1)
                return 1;

            for (int i = 0; i < index - 2; i++)
            {
                b = a + b;
                a = b - a;
            }
            return b;
        }
    }
}
