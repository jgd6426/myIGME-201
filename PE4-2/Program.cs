using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE4_2
{
    // Class: IGME 201.01
    // Author: Judy Derrick
    // Purpose: PE4 Question 2
    // Restrictions: None
    static internal class Program
    {
        static void Main(string[] args)
        {
            // Method: Main
            // Purpose: obtains two numbers from the user and displays them, 
            //          but rejects any input where both numbers are greater than 10
            //          and asks for new numbers
            // Restrictions: None

            // get first number from user and display
            Console.WriteLine("Please enter a number: ");
            int var1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your first number is " + var1);

            // get second number from user and display
            Console.WriteLine("Please enter a second number: ");
            int var2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your second number is " + var2);

            // check if both are greater than 10
            if (var1 > 10 && var2 > 10)
            {
                // if they are keep asking for new numbers until at least one is less than 10
                while (var1 > 10 && var2 > 10)
                {
                    Console.WriteLine("Oops! Sorry but both numbers can't be greater than ten. Try again.");

                    Console.WriteLine("Please enter a number: ");
                    var1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Your first number is " + var1);

                    Console.WriteLine("Please enter a second number: ");
                    var2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Your second number is " + var2);
                }

                Console.WriteLine("Yay! Those numbers work!");
            }
            else
            {
                Console.WriteLine("Yay! Those numbers work!");
            }
        }
    }
}
