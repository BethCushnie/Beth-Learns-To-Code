using System;

namespace Lesson_3
{
    class Program
    {
        static void Main()
        {
            for (int i = 0; i < 10; i++)
                // This is a While Loop, but better
                // int i = 0 creates the variable, and assigns it a starting value
                // i < 10 is the parameters for the lopp to happen
                // i++ is what happens each time the loop rus again
            {
                WriteLine(i);
            }
        }

        static void WriteLine(object line)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(line);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
