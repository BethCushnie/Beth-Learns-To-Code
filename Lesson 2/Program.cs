using System;

namespace Lesson_2
{
    class Program
    {
        static void Main()
            // void means that the function does not return code, it only runs it
        {
            string line = Console.ReadLine();
            Console.WriteLine(line);
            // console.readline was run, so nothing happened until I hit enter
            // When I did, it returned what I had written in the program
            // ReadLine returns code, while WriteLine does not
        }
    }
}
