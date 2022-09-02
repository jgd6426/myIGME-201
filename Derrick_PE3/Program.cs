using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Derrick_PE3
{
    // Class: IGME 201.01
    // Author: Judy Derrick
    // Purpose: PE3 - Variables and Expressions Question #5
    // Restrictions: None
    internal class Program
    {
        // Method: Main
        // Purpose: obtain four int values from the user and display the product
        // Restrictions: None
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a second integer: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a third integer: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a final integer: ");
            int num4 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Your numbers are " + num1 + " , " + num2 + " , " + num3 + " and " + num4);

            Console.WriteLine("The product of all your numbers equals " + num1 * num2 * num3 * num4);
        }
    }
}
