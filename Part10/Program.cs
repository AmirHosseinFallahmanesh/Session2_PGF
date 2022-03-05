using System;

namespace Part10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name or Press q To Exit");
            string input = Console.ReadLine();
            do
            {
                Console.WriteLine("Hello " + input);
                Console.WriteLine("Enter Name or Press q To Exit");
                input = Console.ReadLine();
            } while (input != "q");
        }
    }
}
