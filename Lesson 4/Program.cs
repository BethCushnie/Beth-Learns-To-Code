using System;

namespace Lesson_4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("How many numbers are you going to enter?");

            int numberOfNumbers = int.Parse(Console.ReadLine());

            int i = 0;
            int answer = 0;

            while (i < numberOfNumbers)
            {
                Console.WriteLine("Enter a number");
                int enteredNumber = int.Parse(Console.ReadLine());

                answer += enteredNumber;

                i++;
            }
            Console.WriteLine($"The sum of these numbers is {answer}");

            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();
        }
    }
}
