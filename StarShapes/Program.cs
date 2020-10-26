using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarShapes
{
    class Program
    {
        static void Main(string[] args)
        {

            string keepGoing = "Yes";

            while (keepGoing == "Yes" || keepGoing == "yes")
            {
                
                Console.WriteLine("For Right Angle Triangle, enter 1. For a Regular Triangle, enter 2");
                int input = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("How many lines do you want?");
                int number = Convert.ToInt32(Console.ReadLine());

                if (input == 1)
                {
                    rightAngle(number);
                }
                else if (input == 2)
                {
                    regularTriangle(number);
                }
                else
                {
                    Console.WriteLine("You have entered an invalid input.");
                }

                Console.WriteLine("If you want to keep going, enter Yes. If not, press any key to quit");
                keepGoing = Console.ReadLine();
            }
            
        }



        static void rightAngle(int number)
        {
            for (int i = 0; i < (number + 1); i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void regularTriangle(double number)
        {
            for (int i = 0; i <= Math.Ceiling(number/2); i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = (int)(number/2); i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }


    }
}
