using System;
using System.IO;
//

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //while loop in c#
            //string keep_going = "y";

            //while(keep_going == "y")
            {
                //Console.WriteLine("Enter your sales: ");
                //double sales = Double.Parse(Console.ReadLine());

                //Console.WriteLine("Enter your comish rate as a decimal");
                //double comish_rate = Double.Parse(Console.ReadLine());

                //double commish = sales * comish_rate;
                //Console.WriteLine("Your commission is " + commish);

                //Console.WriteLine("Do you wish to keep going ?  Y for yes..N for N");
                //keep_going = Console.ReadLine();

                //for loop

                //average program

                double sum = 0;
                double average;
                double number_entered;


                Console.WriteLine("Please enter 3 numbers to be averaged");

                for (int i = 1; i <= 3; i++)
                {
                    Console.WriteLine("Please enter the " + i + " number");
                    number_entered = Double.Parse(Console.ReadLine());
                    sum = sum + number_entered;
                }

                average = sum / 3;
                Console.WriteLine("Your average is " + average);






            }

        }
    }
}
