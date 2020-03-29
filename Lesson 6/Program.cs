using System;

namespace Lesson_6
{
    class Program
    {
        static void Main()
        {
            Print("Up to what power of 2 do you want mersenne primes?");
            ulong maxPower = GetNumberFromUser();

            for (ulong i = 0; i < maxPower; i++)
            {
                ulong mersenneNumber = TwoToThePowerOf(i) - 1;

                if (IsPrime(mersenneNumber))
                    Print(mersenneNumber);
            }
        }

        static bool IsPrime(ulong number)
        {
            for (ulong i = 2; i < number; i++)
            {
                if (IsEvenlyDivisibleBy(number, i))
                    return false;
            }

            return true;
        }

        static bool IsEvenlyDivisibleBy(ulong dividend, ulong divisor)
        {
            ulong remainder = dividend % divisor;
            return remainder == 0;
        }

        static ulong TwoToThePowerOf(ulong exponent)
        {
            ulong power = 1;

            for (ulong i = 0; i < exponent; i++)
                power *= 2;

            return power;
        }

        static ulong GetNumberFromUser()
        {
            Console.ForegroundColor = ConsoleColor.White;
            bool numberIsTrue = ulong.TryParse(Console.ReadLine(), out ulong enteredNumber);
            
            if (numberIsTrue)
                return enteredNumber;

            Print("That's not a number. Returning 0.");
            return 0;
        }

        static void Print(object obj)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(obj);
        }
    }
}
