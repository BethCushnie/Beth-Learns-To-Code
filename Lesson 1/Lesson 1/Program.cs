using System;
// System is like the overall tools that I'm using. There are instructions within System, 
// and they're what I'm using to run my code.
// I capitalized the first line so that when I have comments over 2 lines, I can easily find the start.

namespace Lesson_1 // I can write comments on the same line, or make a new one.
    // This namespace is the program thing that I'm making. It includes different code and instructions,
    // that I'm creating. This is what runs (using instructions found in the system)/what code is read/used.
{
    // These squiggly bracket things show what classes/functions/namespaces/code are contained within each other
    class Program
        // Classes are objects that contain code. For example, a player in Logic World, or a NOT gate.
    {
        static void Main()
            // I don't completely understand it right now but void is a function/list of instructions.
            // The parentheses indicate that it's a function. If there were parameters, they would go
            // inside the parentheses
        {
            Console.WriteLine("I'm still kinda lost but optimistic ✌");
            // Console.WriteLine is a function, and it makes the program write whatever is within the brackets 
            // and quotation marks.
            // System.console is a class, just like Program is a class. Console.WriteLine is a function,
            // just like Main() is a function.
            Console.WriteLine("Getting the hang of this more");
            // To make a new line, you can add a new function (note: you have to add a semicolon after each statement)
            Console.WriteLine("Calculus is hard, \nbut this is also hard");
            // To add a new line without calling the function again, you can add \n
            Console.WriteLine(@"The Habs are the best team
Boston sucks");
            // Another way to add a new line is to add an @ before the quotation marks, which denotes a string literal
            // (so it takes everything you do, like press enter to make a new line, or type \n just as \n, literally)
        }
    }
}
