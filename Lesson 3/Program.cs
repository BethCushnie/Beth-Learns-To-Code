using System;

namespace Lesson_3
{
    class Program
    {
        static void Main()
        {
            int i = 0;
            while (i < 5)
            {
                WriteLine(i);
            }
            // Right now, this is an infinite loop. Because i is always < 5, the program just runs a bunch of 0s, forever
        }

        static void WriteLine(object line)
            // Previously, when the variable was a string, this function could only write strings
            // However, everything in C# is an object, so now WriteLine can be used for anything
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(line);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
