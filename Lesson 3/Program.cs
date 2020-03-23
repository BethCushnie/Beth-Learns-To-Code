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

                i += 1; // Is the same as i = i + 1
                // i -= 1 is the same as i = i - 1
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
