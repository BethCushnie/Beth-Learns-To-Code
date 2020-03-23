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

                i++; // Is the same as i += 1
                // i-- is the same as i -= 1
                // These shortcuts are only for adding or subtracting 1
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
