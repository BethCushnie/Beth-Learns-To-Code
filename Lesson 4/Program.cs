using System;

namespace Lesson_4
{
    class Program
    {
        static void Main()
        {
            Print("How many Fibonacci numbers do you want?");
            int numbersToPrint = GetNumberFromUser();

            ulong previousAnswer = 0;
            ulong answer = 1;

            Print("0");
            Print("1");
            Print("1");

            for (int i = 0; i < numbersToPrint - 3; i++)
            {
                previousAnswer = answer - previousAnswer;
                answer = answer + previousAnswer;
                Print(answer);
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
