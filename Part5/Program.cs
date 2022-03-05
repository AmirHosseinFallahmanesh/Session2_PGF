using System;

namespace Part5
{//0 - 5  D
 //5-10 C
 //10-15 B
 //15-20  A
 //20 A+
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter sql Mark");
            float sql = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter mvc Mark");
            float mvc = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter c# Mark");
            float csharp = Convert.ToSingle(Console.ReadLine());

            float average = (csharp + sql + mvc) / 3;


            if (average>=0 && average<5)
            {
                Console.WriteLine("D");
            }
            else if(average >= 5 && average < 10)
            {
                Console.WriteLine("C");
            }
            else if (average >= 10 && average < 15)
            {
                Console.WriteLine("B");
            }
            else if (average >= 15 && average < 20)
            {
                Console.WriteLine("A");
            }
            else if (average == 20)
            {
                Console.WriteLine("A+");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            Console.ReadKey();
        }
    }
}
