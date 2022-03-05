using System;
using System.Diagnostics;

namespace Part2
{
    class Program
    {//admin
     //123   
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Username");
            string username = Console.ReadLine();

            Console.WriteLine("Enter Password");
            string passwrod = Console.ReadLine();

            if (username=="admin" & passwrod=="123")
            {
                Console.Clear();
                Console.WriteLine("Welcome To My App");
                Process.Start("mspaint");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Username or Password not valid");
            }

            Console.ReadKey();
        }
    }
}
