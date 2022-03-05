using System;
using System.Diagnostics;

namespace Part13
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1)paint");
                Console.WriteLine("2)notepad");
                Console.WriteLine("3)cmd");
                Console.WriteLine("4)exit");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Process.Start("mspaint");
                        break;

                    case "2":
                        Process.Start("notepad");
                        break;

                    case "3":
                        Process.Start("cmd");
                        break;

                    case "4":
                        return;


                    default:
                        Console.WriteLine("Try Again");
                        Console.ReadKey();
                        break;
                }


            }
        }
    }
}
