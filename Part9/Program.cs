using System;

namespace Part9
{
    class Program
    {
        static void Main(string[] args)
        {
            //while (true)
            //{
            //    Console.WriteLine("10");
            //}
            Console.WriteLine("Enter Name or Press q To Exit");
            string input = Console.ReadLine();
            while (input!="q")
            {
                Console.WriteLine("Hello "+input);
                Console.WriteLine("Enter Name or Press q To Exit");
                input = Console.ReadLine();
            }
        }
    }
}
