using System;

namespace Mandelbrot
{
    /// <summary>
    /// This class generates Mandelbrot sets in the console window!
    /// </summary>


    class Class1
    {
        /// <summary>
        /// This is the Main() method for Class1 -
        /// this is where we call the Mandelbrot generator!
        /// </summary>
        /// <param name="args">
        /// The args parameter is used to read in
        /// arguments passed from the console window
        /// </param>

        [STAThread]
        static void Main(string[] args)
        {
            double realCoord, imagCoord;
            double realTemp, imagTemp, realTemp2, arg;
            int iterations;

            // promt user for imagCoord values
            Console.WriteLine("Enter a starting value: (ex. 1.2)");
            double userImgCoord = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter an ending value less than the starting value: (ex. -1.2)");
            double imgCoordEnd = Convert.ToDouble(Console.ReadLine());

            // check for invalid numbers
            if (userImgCoord < imgCoordEnd)
            {
                while (userImgCoord < imgCoordEnd)
                {
                    Console.WriteLine("Invalid numbers. Starting value needs to be greater than ending. Try again.");

                    Console.WriteLine("Enter a starting value: (ex. 1.2)");
                    userImgCoord = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter an ending value less than the starting value: (ex. -1.2)");
                    imgCoordEnd = Convert.ToDouble(Console.ReadLine());
                }
            }

            double dec = (userImgCoord - imgCoordEnd) / 48;

            // promt user for realCoord values
            Console.WriteLine("Enter a second starting value: (ex. -0.6)");
            double userRealCoord = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a second ending value more than the starting value: (ex. 1.77)");
            double realCoordEnd = Convert.ToDouble(Console.ReadLine());

            // check for invalid numbers
            if (userRealCoord > realCoordEnd)
            {
                while (userRealCoord > realCoordEnd)
                {
                    Console.WriteLine("Invalid numbers. Starting value needs to be greater than ending. Try again.");

                    Console.WriteLine("Enter a second starting value: (ex. -0.6)");
                    userRealCoord = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter a second ending value more than the starting value: (ex. 1.77)");
                    realCoordEnd = Convert.ToDouble(Console.ReadLine());
                }
            }

            double inc = (realCoordEnd - userRealCoord) / 80;

            for (imagCoord = userImgCoord; imagCoord >= imgCoordEnd; imagCoord -= dec)
            {
                for (realCoord = userRealCoord; realCoord <= realCoordEnd; realCoord += inc)
                {
                    iterations = 0;
                    realTemp = realCoord;
                    imagTemp = imagCoord;
                    arg = (realCoord * realCoord) + (imagCoord * imagCoord);
                    while ((arg < 4) && (iterations < 40))
                    {
                        realTemp2 = (realTemp * realTemp) - (imagTemp * imagTemp)
                           - realCoord;
                        imagTemp = (2 * realTemp * imagTemp) - imagCoord;
                        realTemp = realTemp2;
                        arg = (realTemp * realTemp) + (imagTemp * imagTemp);
                        iterations += 1;
                    }
                    switch (iterations % 4)
                    {
                        case 0:
                            Console.Write(".");
                            break;
                        case 1:
                            Console.Write("o");
                            break;
                        case 2:
                            Console.Write("O");
                            break;
                        case 3:
                            Console.Write("@");
                            break;
                    }
                }
                Console.Write("\n");
            }

        }
    }
}
