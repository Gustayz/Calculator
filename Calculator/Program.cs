using System;

namespace Calculator // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hi there, whats your name?");
            string userName = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"Hello {userName}, choice an option down below.");
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine(" ONLINE CALCULATOR");
            Console.WriteLine("*******************");
            Console.WriteLine("*                 *");
            Console.WriteLine("*                 *");
            Console.WriteLine("*                 *");
            Console.WriteLine("*                 *");
            Console.WriteLine("*                 *");
            Console.WriteLine("*******************");
        }
    }
}