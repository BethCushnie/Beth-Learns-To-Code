using System;

namespace Lesson_6
{
    class Program
    {
        static void Main()
        {
            Print("How many squares do you want?");
            int numberOfSquares = GetNumberFromUser();

            for (int i = 1; i <= numberOfSquares; i++)
            {
                Print($"The square of {i} is {SquareOf(i)}");
            }
        }

        static int SquareOf(int number)
        {
            return number * number;
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
