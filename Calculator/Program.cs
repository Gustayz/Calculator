using System;
using System.ComponentModel.Design;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;

namespace Calculator // Note: actual namespace depends on the project name.
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
        }

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

        static int FinalResult(int userChoice, int userNum)
        {
            int final;

            switch (userChoice)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                default:
                    break;
            }
            return final;
        }
    }
}