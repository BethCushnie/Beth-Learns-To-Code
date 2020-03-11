using System;
// Contains the instructions that the computer uses to read the code

namespace Lesson_2
    // A thing that includes code
{
    class Program
        // object that runs code
    {
        static void Main()
            // how the program starts
            // Main is what's run when the program starts
        { 
            Console.ForegroundColor = ConsoleColor.Yellow;
            // makes the text yellow

            Console.WriteLine("Type a number!");
            // Console is a class, WriteLine is a function, and Type a number is the parameters
            int number1 = ReadNumber();
            // sets the integer number1 to the result of ReadNumber

            Console.WriteLine("Type another number!");
            int number2 = ReadNumber();

            int answer = number1 + number2;
            // sets the integer answer equal to the sum of number1 and number2
            Console.WriteLine($"The answer is {answer}");
            // program writes "the answer is" and then says the integer Answer
            // Every class in C# must have a method for turning it into a string, so that's why you can put anything inside the 
            // curly brackets and have it read (ex. answer is an integer, but it's read as a string here)

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();


            int ReadNumber()
                // we made our own function called ReadNumber for integers
                // this turns the input (what the user typed in) into an integer the computer can use
                // it also handles errors (makes it so that the program doesn't crash if there's an error)
            {
                string line = Console.ReadLine();
                // sets the variable line (which is a string) to what the Console.ReadLine returns (which is what the user typed in)
                bool lineIsValid = int.TryParse(line, out int number);
                // int.TryParse() turns the numbers in line into the integer number (so that it can be used as an integer)
                // bool lineIsValid makes it so that this only happens if it can be turned into an integer
                // if not, then it ignores the variable (and sets it to 0) and shows the error message:

                if (!lineIsValid)
                    // ! means opposite of
                    // if lineIsValid is not true because the input can't be turned into an integer, everything within the following
                    // curly brackets is run
                {
                    Console.WriteLine("u done f***ed up");
                    Console.WriteLine();
                    // tells you that u done f***ed up
                    Main();
                    // returns you to the beginning of Main (restarts the program)
                    Environment.Exit(0);
                    // exits program when Main() is done (when you don't f*** up)
                }

                return number;
            }
        }
    }
}
