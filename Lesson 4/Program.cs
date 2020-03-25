using System;

namespace Lesson_4
{
    class Program
    {
        static void Main()
        {
            Print("How many numbers are you going to enter?");

            int numberOfNumbers = GetNumberFromUser();

            int answer = 0;

            for (int i = 0; i < numberOfNumbers; i++)
            {
                Print("Enter a number");
                int enteredNumber = GetNumberFromUser();

                answer += enteredNumber;
            }


            Print($"The inverse of the sum of these numbers is {InverseNumber(answer)}");

            Print("\nPress any key to exit");
            Console.ReadKey();
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

        static int SquareNumber(int number)
        {
            return number * number;
        }

        static int InverseNumber(int number)
        {
            return -number;
        }

        static int InverseSqure(int number)
        {
            number = SquareNumber(number);
            number = InverseNumber(number);
            return number;
        }
        // Code within functions exists in isolation. So I can't use the variable answer here because it doesn't exist in this function
        // Hence the use of number
    }
}
