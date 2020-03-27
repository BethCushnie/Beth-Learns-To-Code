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

                Print($"The {GetOrdinalString(numberToPrint)} fibonacci number is {GetFibonacciNumber(numberToPrint)}");
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

            for (int i = 0; i < index - 2; i++)
            {
                b = a + b;
                a = b - a;
            }
            return b;
        }

        static string GetOrdinalString(int number)
        {
            string suffix = "th";

            int absoluteValue = GetAbsoluteValue(number);
            if (absoluteValue < 4 || absoluteValue > 13) // Exclude the early 10s because we use 'th' for 11th, 12th, and 13th
            {
                char lastCharacter = GetLastCharacter(number.ToString());

                if (lastCharacter == '1')
                    suffix = "st";
                else if (lastCharacter == '2')
                    suffix = "nd";
                else if (lastCharacter == '3')
                    suffix = "rd";
            }

            return $"{number}{suffix}";
        }

        static int GetAbsoluteValue(int number)
        {
            if (number < 0)
                return -number;

            return number;
        }

        static char GetLastCharacter(string text)
        {
            return text[text.Length - 1];
        }
    }
}
