using System;

namespace Part7
{//for - while - do while
    class Program
    {
        static void Main(string[] args)
        {
            int k = 10;
            k = k + 1;
            k += 5;
            k++;
         
            for (int i = 1; i < 100 ; i++)
            {
                if (i==5)
                {
                    // continue;
                    break;
                }
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
