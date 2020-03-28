using System;

namespace Lesson_6
{
    class Program
    {
        static void Main()
        {
            Print("Enter a base.");
            int @base = GetNumberFromUser();

            Print("Enter the maximum exponent.");
            int exponent = GetNumberFromUser();

            for (int i = 1; i <= exponent; i++)
            {
                Print($"{@base}^{i} is {Power(@base, i)}");
            }
        }

        static int Power(int @base, int exponent)
        {
            int answer = 1;

            for (int i = 0; i < exponent; i++)
                answer *= @base;

            return answer;
        }

        static int GetNumberFromUser()
        {
            Console.ForegroundColor = ConsoleColor.White;
            bool numberIsTrue = int.TryParse(Console.ReadLine(), out int enteredNumber);
            
            if (numberIsTrue)
                return enteredNumber;

            Print("That's not a number. Returning 0.");
            return 0;
        }

        static void Print(object obj)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(obj);
        }
    }
}
