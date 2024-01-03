using System;
using System.ComponentModel.Design;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;

namespace Calculator 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userNum1, userChoice, userNum2;

            // getting the user name
            Console.WriteLine("Hello there, whats your name?");
            string userName = Console.ReadLine();

            // getting the user's two whole numbers
            Console.WriteLine("Before we continue, please enter first number: ");
            userNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now enter the second number: ");
            userNum2 = Convert.ToInt32(Console.ReadLine());

            // getting the user choice
            Menu();
            Console.WriteLine($"Welcome {userName}, please choose an option above. (Only numbers 1-4)");
            userChoice = Convert.ToInt32(Console.ReadLine());

             int userFinalResult = FinalResult(userChoice, userNum1, userNum2);

            Console.WriteLine($"The result (based on the option and the numbers you have input) is: {userFinalResult}");
        }
        /* method that inputs the menu to the console when called in main*/
        static void Menu()
        {
            Console.WriteLine("ONLINE CALCULATOR");
            Console.WriteLine("****************");
            Console.WriteLine("* 1. Multiply  *");
            Console.WriteLine("* 2. Divide    *");
            Console.WriteLine("* 3. Add       *");
            Console.WriteLine("* 4. Subtract  *");
            Console.WriteLine("****************");
        }

        static int FinalResult(int userChoice, int userNum1, int userNum2)
        {
            int final = 0;

            if (userChoice == 1)
            {
                final = userNum1 * userNum2;
            }

            else if (userChoice == 2)
            {
                final = userNum1 / userNum2;
            }

            else if (userChoice == 3)
            {
                final = userNum1 + userNum2;
            }

            else if (userChoice == 4)
            {
                final = userNum1 - userNum2;
            }

            else
            {
                Console.WriteLine("Sorry, no option found");
            }

            return final;
        }
    }
}