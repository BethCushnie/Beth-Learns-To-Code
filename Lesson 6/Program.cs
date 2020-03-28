using System;

namespace Lesson_6
{
    class Program
    {
        static void Main()
        {
            Print("How many powers of two do you want?");
            int numberOfPowers = GetNumberFromUser();

            for (int i = 1; i <= numberOfPowers; i++)
            {
                Print($"2^{i} is {PowerOf2(i)}");
            }
        }

        static int PowerOf2(int exponent)
        {
            int answer = 1;
            
            for (int i = 0; i < exponent; i++)
                answer *= 2;
            
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
