using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Derrick_MadLibs
// Class: IGME 201.01
// Author: Judy Derrick
// Purpose: PE7 - Mad Libs
// Restrictions: None
{
    static internal class Program
    {
        // Method: Main
        // Purpose: Practice working with strings, lists, and input/output to create a Mad Libs game.
        //          Using predetermined narratives stored in a text file,
        //          gather information from the user to generate a complete story.    
        // Restrictions: None
        static void Main(string[] args)
        {
            // ask the user if they want to play Mad Libs

            Console.WriteLine("Do you want to play Mad Libs?");
            string answer = Console.ReadLine();

            if (answer == "yes")
            {
                
            }
            else if (answer == "no")
            {
                Console.WriteLine("Goodbye.");
                return;
            }
            else
            {
                while (answer != "no" || answer != "yes")
                {
                    Console.WriteLine("Do you want to play Mad Libs? yes or no");
                    answer = Console.ReadLine();

                    if (answer == "yes")
                    {
                        break;
                    }
                    if (answer == "no")
                    {
                        Console.WriteLine("Goodbye.");
                        return;
                    }
                }
            }

            // Mad Libs game 

            int numLibs = 0;
            int cntr = 0;
            int nChoice = 0;

            string finalResult = "";

            StreamReader input;

            // open the template file to count how many Mad Libs it contains
            input = new StreamReader("c:\\templates\\MadLibsTemplate.txt");
            // input = new StreamReader("Z:\\IGMProfile\\Desktop\\MadLibsTemplate.txt");

            string line = null;
            while ((line = input.ReadLine()) != null)
            {
                ++numLibs;
            }

            // close it
            input.Close();

            // only allocate as many strings as there are Mad Libs
            string[] madLibs = new string[numLibs];

            // read the Mad Libs into the array of strings
            input = new StreamReader("c:\\templates\\MadLibsTemplate.txt");
            // input = new StreamReader("Z:\\IGMProfile\\Desktop\\MadLibsTemplate.txt");

            line = null;
            while ((line = input.ReadLine()) != null)
            {
                // set this array element to the current line of the template file
                madLibs[cntr] = line;

                // replace the "\\n" tag with the newline escape character
                madLibs[cntr] = madLibs[cntr].Replace("\\n", "\n");

                ++cntr;
            }

            input.Close();

            // prompt the user for name and which Mad Lib they want to play (nChoice)
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("Choose a story between 1 and 6: ");
            nChoice = Convert.ToInt32(Console.ReadLine());

            // split the Mad Lib into separate words
            string[] words = madLibs[nChoice - 1].Split(' ');

            foreach (string word in words)
            {
                // if word is a placeholder
                if (word.StartsWith("{"))
                {
                    // prompt the user for the replacement
                    // and append the user response to the result string

                    string prompt = word.Replace("{", "");
                    prompt = prompt.Replace("}", "");

                    if (prompt.StartsWith("A"))
                    {
                        Console.WriteLine("Give an " + prompt + ": ");
                        finalResult += Console.ReadLine() + " ";
                    }
                    else
                    {
                        Console.WriteLine("Give a " + prompt + ": ");
                        finalResult += Console.ReadLine() + " ";
                    }
                }
                // else append word to the result string
                else
                {
                    finalResult += word + " ";
                }
            }

            // print final story
            Console.WriteLine(finalResult);
        }
    }
}
