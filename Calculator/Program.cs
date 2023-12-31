using System;

namespace Calculator // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hi there, whats your name?");
            string userName = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"Hello {userName}, choose an option down below. (type a number 1-4) ");
            Menu();
            int userChoice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter two whole numbers (separate them with space)");
            int userNumber = Convert.ToInt32(Console.ReadLine());

        }

        static void Menu()
        {
            Console.WriteLine(" ---ONLINE CALCULATOR---");
            Console.WriteLine("  *******************");
            Console.WriteLine("  * 1. Multiply     *");
            Console.WriteLine("  * 2. divide       *");
            Console.WriteLine("  * 3. Add          *");
            Console.WriteLine("  * 4. Subtract     *");
            Console.WriteLine("  *******************");
        }

        static int Choice(int number)
        {
           

            return number;
        }
    }
}