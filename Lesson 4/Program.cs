using System;

namespace Lesson_4
{
    class Program
    {
        static void Main()
        {
            Print("How many Fibonacci numbers do you want?");
            int numbersToPrint = GetNumberFromUser();

            int a = 0, b = 1;

            for (int i = 0; i < numbersToPrint; i++)
            {
                Print(a + b);
                b += a;
                a = b - a;
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
    }
}
