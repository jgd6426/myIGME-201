using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit1Test_Q12
{
    static internal class Program
    {
        // Class: IGME 201.01
        // Author: Judy Derrick
        // Purpose: Unit 1 Test Q.13 Rewrite Q12 with struct
        // Restrictions: None

        public struct employee
        {
            public string sName;
            public double dSalary;
        }

        static void Main(string[] args)
        {
            // Method: Main
            // Purpose: prompt user for name, check for raise, congratulate if true.
            // Restrictions: None

            // string sName;
            string sName;
            double dSalary = 30000;

            Console.WriteLine("What is your name? ");
            sName = Console.ReadLine();

            // congratulate user if they got a raise and display new salary
            if (GiveRaise(sName, ref dSalary) is true)
            {
                Console.WriteLine("Congrats! You got a raise!");
                Console.WriteLine("Your new salary is " + dSalary);
            }


        }
        static bool GiveRaise(string name, ref double salary)
        {
            // Method: GiveRaise
            // Purpose: if name = my name increase salary by $19,999.99
            // Restrictions: None

            // if name = my name return true and increase salary by $19,999.99
            if (name == "Judy")
            {
                salary += 19999.99;
                return true;
            }
            // else return false
            else
            {
                return false;
            }
        }
    }
}
