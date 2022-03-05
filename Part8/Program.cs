using System;

namespace Part8
{
    class Program
    {
        static void Main(string[] args)
        {  
            //markCount
            //mark_count

            Console.WriteLine("Enter Marks Count");
            int markCount = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < markCount; i++)
            {
                Console.WriteLine("enter Mark");
                int mark = Convert.ToInt32(Console.ReadLine());
                sum += mark;
            }
            int average = sum / markCount;
            Console.WriteLine("the average is "+average);
            Console.ReadKey();
        }
    }
}
