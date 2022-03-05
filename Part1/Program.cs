using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
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

            float average = (csharp + sql + mvc)/3;


            if (average>=10)
            {
                Console.WriteLine("You passed :)))");
            }
            else
            {
                Console.WriteLine("You Failed");
            }
            Console.ReadKey();
        }
    }
}
