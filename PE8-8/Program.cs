using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8_8
{
    // Class: IGME 201.01
    // Author: Judy Derrick
    // Purpose: PE8 Q8 - More About Variables
    // Restrictions: None
    internal class Program
    {
        // Method: Main
        // Purpose: write a console application that accepts a string
        //          and replaces all occurances of the word "no" with "yes"
        // Restrictions: None
        static void Main(string[] args)
        {
            Console.WriteLine("Write something with 'yes' or 'no': ");
            string userWords = Console.ReadLine();

            string newWords = userWords.Replace("no", "yes");
            Console.WriteLine(newWords);
        }
    }
}
