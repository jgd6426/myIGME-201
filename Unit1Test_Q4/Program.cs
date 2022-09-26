using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Timers;
using System.Threading;
using System.Xml.Linq;

namespace Unit1Test_Q4
{
    static internal class Program
    {
        static bool bTimeOut = false;

        static Timer timeOutTimer;

        static void Main(string[] args)
        {

            // question #
            string sQuestion = "";

            // # correct counter
            int nCorrect = 0;

            // response
            string sResponse = "";

            string q1Answer = "black";
            string q2Answer = "42";
            string q3Answer = "What do you mean? African or European swallow?";

            bool bValid = false;

            string sAgain = "";

        start:

            nCorrect = 0;
            Console.WriteLine();

            do
            {
                Console.WriteLine("Choose your question (1-3): ");
                sQuestion = Console.ReadLine();

                try
                {
                    int.Parse(sQuestion);
                    bValid = true;
                }
                catch
                {
                    Console.WriteLine("Please enter an integer.");
                    bValid = false;
                }
            } while (!bValid);
            Console.WriteLine();

            timeOutTimer = new Timer(5000);
            timeOutTimer.Elapsed += new ElapsedEventHandler(TimesUp);

            bTimeOut = false;

            timeOutTimer.Start();

            // display the question
            do
            {
                Console.WriteLine("You have 5 seconds to answer the following question: ");

                if (sQuestion == "1")
                {
                    Console.WriteLine("What is your favorite color?");
                    sResponse = Console.ReadLine();

                    timeOutTimer.Stop();

                    if (bTimeOut)
                    {
                        Console.WriteLine("Time's up!");
                        break;
                    }
                    try
                    {
                        sResponse = q1Answer;
                        bValid = true;
                    }
                    catch
                    {
                        bValid = false;
                    }
                } while (!bValid)
                {
                    if (sResponse == q1Answer)
                    {
                        Console.WriteLine("Well done!");
                        ++nCorrect;
                    }
                    else
                    {
                        Console.WriteLine("Wrong!The answer is {0}", q1Answer);
                    }
                    Console.WriteLine();
                }
                do
                {
                    Console.WriteLine("Play again?");
                    sAgain = Console.ReadLine();

                    if (sAgain.ToLower().StartsWith("y"))
                    {
                        goto start;
                    }
                    else if (sAgain.ToLower().StartsWith("n"))
                    {
                        break;
                    }

                } while (true);
            }
        }   
        static void TimesUp(object source, ElapsedEventArgs e)
        {
            Console.WriteLine();
            Console.WriteLine("Time's up!");

            bTimeOut = true;
            timeOutTimer.Stop();
        }
}
