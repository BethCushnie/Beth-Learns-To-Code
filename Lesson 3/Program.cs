using System;

namespace Lesson_3
{
    class Program
    {
        static void Main()
        {
            int i = 0;

            while (i < 10) // instead of putting a boolean variable in it, we're putting a boolean value (because it's cleaner)
            {
                WriteLine(i);
                i++;
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
