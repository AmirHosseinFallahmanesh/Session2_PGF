using System;

namespace Part6
{
    class Program
    {
        static void Main(string[] args)
        {
            int caseSwitch = new Random().Next(1, 4);
            Console.WriteLine(caseSwitch);
            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    Console.WriteLine("this is case 1 ");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                case 3:
                    Console.WriteLine("Case 3");
                    break;
                default:
                    Console.WriteLine("Value didn't match earlier.");
                    break;
            }
        }
    }
}
