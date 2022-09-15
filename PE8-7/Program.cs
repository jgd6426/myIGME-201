using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8_7
{
    // Class: IGME 201.01
    // Author: Judy Derrick
    // Purpose: PE8 Q7 - More About Variables
    // Restrictions: None
    static internal class Program
    {
        // Method: Main
        // Purpose: write a console application that accepts a string from the user
        //          and outputs a string with the characters in reverse order
        // Restrictions: None
        static void Main(string[] args)
        {
            Console.WriteLine("Type something: ");
            string userWords = Console.ReadLine();
            string backwords = "";

            for (int i = 0; i < userWords.Length; i++)
            {
                backwords += userWords[userWords.Length -i - 1];   
            }

            Console.WriteLine(backwords);
        }
    }
}
