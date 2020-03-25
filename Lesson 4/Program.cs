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

            Print($"The sum of these numbers is {answer}");

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
    }
}
