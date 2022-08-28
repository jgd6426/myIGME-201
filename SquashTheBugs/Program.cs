using System;

namespace SquashTheBugs
{
    // Class Program
    // Author: David Schuh
    // Purpose: Bug squashing exercise
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: Loop through the numbers 1 through 10 
        //          Output N/(N-1) for all 10 numbers
        //          and list all numbers processed
        // Restrictions: None
        static void Main(string[] args)
        {
            // declare int counter
            // int i = 0
            int i = 0;  
                    // compile-time error: missing semicolon

            // declare string to hold all numbers outside and before the for loop
            string allNumbers = null;

            // loop through the numbers 1 through 10
            // for (i = 1; i < 10; ++i)
            for (i = 1; i <= 10; ++i)   // Logical error: want to include 10
            {
                // declare string to hold all numbers
                // string allNumbers = null;

                // output explanation of calculation
                //Console.Write(i + "/" + i - 1 + " = ");

                Console.WriteLine(i + "/" + Convert.ToString(i - 1) + " = ");
                         // compile-time error: can't compute a string minus an int. Need to do the math the convert to a string

                // output the calculation based on the numbers
                // Console.WriteLine(i / (i - 1));
                try
                {
                    Console.WriteLine(i / (i - 1));
                    // syntax error: can't divide by zero when i = 1
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Can't divide by zero.");
                }

                // concatenate each number to allNumbers
                allNumbers += i + " ";

                // increment the counter
                // i = i + 1;
                        // logical error: i is already going up by one
            }

            // output all numbers which have been processed
            // Console.WriteLine("These numbers have been processed: " allNumbers);
            Console.WriteLine("These numbers have been processed: " + allNumbers);
                                           // compile-time error: variable needed to be created before and outside the for loop
                                           // compile-time error: missing plus or comma
        }
    }
}
