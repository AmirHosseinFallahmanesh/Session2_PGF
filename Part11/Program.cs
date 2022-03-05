using System;

namespace Part11
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int value=random.Next(1, 100);
            Console.WriteLine(value);
        }
    }
}
