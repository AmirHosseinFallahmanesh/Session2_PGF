using System;
using System.Diagnostics;

namespace Part3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Username");
            string username = Console.ReadLine();
            if (username == "admin" )
            {
                
                Console.WriteLine("Enter Password");
                string passwrod = Console.ReadLine();

                if (passwrod == "123")
                {
                    Console.Clear();
                    Console.WriteLine("Welcome To My App");
                    Process.Start("mspaint");
                }
                else
                {
                    Console.WriteLine("Password not Correct");
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Username  not found");
            }

            Console.ReadKey();
        }
    }
}
