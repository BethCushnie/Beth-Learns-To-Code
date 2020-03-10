using System;
using System.Collections;

namespace Lesson_2
{
    class Program
    {
        static void Main()
        {
            string text = "hi blog peeps";
            // Variable: an instance of an object. "Text" is a variable, but it can be anything
            // Useful if you want to use the same string multiple times (now you can just write "text")
            // Also, if you want to change the string, you only have to do it in one place

            text += " a new string";
            // text = text + " a new string";
            // += is shorthand for saying "old variable plus whatever comes in front of the operator (whatever comes next)
            // It updates the variable

            // text -= " a thrid string";
            // this makes an error but you can also minus a section
            // Also have *= and /=
            Console.WriteLine(text);
        }
    }
}
