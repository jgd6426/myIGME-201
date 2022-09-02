using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Derrick_HelloWorld
{
    // Class: IGME 201.01
    // Author: Judy Derrick
    // Purpose: PE1 - Hello World
    // Restrictions: None
    internal class Program
    {
        // Method: Main
        // Purpose: create variables, print messages to console, 
        //          do math, run ifs and for loops
        // Restrictions: None
        static void Main(string[] args)
        {
            // create variables
            string sWords = "words words words";
            int nNum = 2;
            int newNum = sWords.Length;

            // print name and "hello world" to console
            Console.WriteLine("Hello World!");
            Console.WriteLine("Judy Derrick");

            // print variable to console
            Console.WriteLine(sWords);
            Console.WriteLine(nNum);
            Console.WriteLine(newNum);

            // do some math and print answer to console
            Console.WriteLine(newNum - nNum);

            // try and if statement
            if (newNum >= 2)
            {
                Console.WriteLine(sWords);
            }

            // try a for loop
            for (int i = 0; i < newNum; i++)
            {
                Console.WriteLine(sWords[i]);
            }
        }
    }
}
