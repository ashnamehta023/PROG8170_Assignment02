using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog8170_Assignment2
{
    class Program
    {
        public static void Main(string[] args)
        {
            int sideOne = 0;
            int sideTwo = 0;
            int sideThree = 0;
            int userChoice = 0;
            string inputString = "";
            string checkChoice = " ";
            try
            {
                do
                {
                    Console.WriteLine("\n 1.Enter triangle Dimensions");
                    Console.WriteLine("\n 2.Exit");
                    Console.Write("\n Select option:");

                    do
                    {
                        checkChoice = Console.ReadLine();
                        if (!int.TryParse(checkChoice, out userChoice) || userChoice < 1 || userChoice > 2)
                        {
                            Console.WriteLine("Incorrect choice. Try Again");
                        }

                    } while (!int.TryParse(checkChoice, out userChoice) || userChoice < 1 || userChoice > 2);

                    switch (userChoice)
                    {
                        case 1:
                            Console.Write("\nEnter first side of Triangle: ");
                            sideOne = CheckInputSide();
                            Console.Write("Enter second side of Triangle: ");
                            sideTwo = CheckInputSide();
                            Console.Write("Enter thrid side of Triangle: ");
                            sideThree = CheckInputSide();
                            string result = TriangleSolver.Analyze(sideOne, sideTwo, sideThree);
                            Console.Write(result);
                            break;

                        case 2:
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("\n Invalid Input were given by user; please select either 1 or 2");
                            break;
                    }

                } while (userChoice != 2);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // get and check user input value;
            int CheckInputSide()
            {
                int value;
                do
                {
                    inputString = Console.ReadLine();
                    if (!int.TryParse(inputString, out value) || value < 0)
                    {
                        Console.WriteLine("Side can only be positive integer");
                    }

                } while (!int.TryParse(inputString, out value) || value < 0);
                return value;
            }

        }
    }
}
