using System;

namespace Lesson_3
{
    class Program
    {
        static void Main()
        {
            int i = 0;
            bool b = i < 10;

            while (b)
                // Inside the brackets is a boolean that is either true or false
                // The code inside will run as long as it is true
                // Currently, this is an infinite loop because b is outside the loop, so the i value in it never changes,
                // so b is always true
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
