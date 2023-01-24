using System;

namespace SquashTheBugs
{
    // Class Program
    // Author: David Schuh
    // Purpose: Bug squashing exercise
    // Restrictions: None
    class Program
    {
        private static string allNumbers;

        // Method: Main
        // Purpose: Loop through the numbers 1 through 10
        // Output N/(N-1) for all 10 numbers
        // and list all numbers processed
        // Restrictions: None
        static void Main(string[] args)
        {
            // declare int counter
            int i = 0; // missing semicolon, compile-time error
                       // loop through the numbers 1 through 10
            for (i = 1; i <= 10; ++i) // changed < to <= to include 10 in the loop, logical error
            {
                // declare string to hold all numbers
                string allNumbers = null;

                // output explanation of calculation
                Console.Write(i + "/" + (i - 1) + " = "); // added parentheses to separate i and i-1, compile-time error

                // added check for division by zero
                if (i - 1 == 0)
                {
                    Console.WriteLine("Cannot divide by zero.");
                }
                else
                {
                    Console.WriteLine(Math.Round((double)i / (i - 1), 3)); //using Math.Round() to get 3 decimal places
                }

                // added check for division by zero before concatenating to allNumbers
                if (i - 1 != 0)
                {
                    allNumbers += i + " ";
                }
                else
                {
                    allNumbers += i + "(division by zero) ";
                }
            }

            // output all numbers which have been processed
            Console.WriteLine("These numbers have been processed: " + allNumbers); // added missing + operator, compile-time error
        }
    }
}