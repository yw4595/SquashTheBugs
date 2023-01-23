using System;

namespace SquashTheBugs2._0
{
    /*
    * Class Program
    * Author: David Schuh
    * Purpose: Bug squashing exercise
    * Restrictions: None
    */
    static class Program
    {
        /*
        * Method: Main
        * Purpose: Loop through the numbers 1 through 10 
        *          Output N/(N-1) for all 10 numbers with 5 decimal places
        *          and list all numbers processed
        * Restrictions: None
        */
        static void Main(string[] args)
        {
            // declare int counter
            int i = 0;
            // declare string to hold all numbers
            string allNumbers = null;
            // loop through the numbers 1 through 10
            for (i = 1; i <= 10; ++i)
            {
                // output explanation of calculation
                Console.Write(i + "/" + (i - 1) + " = ");

                // output the calculation based on the numbers with 5 decimal places
                Console.WriteLine(Math.Round(i / (double)(i - 1), 5)); //making sure that one of the argument is double

                // concatenate each number to allNumbers
                allNumbers += i + " ";

                // increment the counter 
                //no need to increment the counter as its already done in the loop
            }

            // output all numbers which have been processed
            Console.WriteLine("These numbers have been processed: " + allNumbers);
        }
    }
}
