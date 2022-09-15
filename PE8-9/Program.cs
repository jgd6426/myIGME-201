using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8_9
{
    // Class: IGME 201.01
    // Author: Judy Derrick
    // Purpose: PE8 Q9 - More About Variables
    // Restrictions: None
    internal class Program
    {
        // Method: Main
        // Purpose: write a console application that places double quotes
        //          around each word in a string
        // Restrictions: None
        static void Main(string[] args)
        {
            Console.WriteLine("Type some words: ");
            string userWords = Console.ReadLine();

            string newWords = "\"" + userWords;
            newWords = newWords.Replace(" ", "\" \"");
            newWords += "\"";

            Console.WriteLine(newWords);
        }
    }
}
