using System;

namespace Part12
{
    class Program
    {
        static void Main(string[] args)
        {
            //datatype[] name = new datatype[length];
            int[] marks = new int[4];
            marks[0] = 16;
            marks[1] = 15;
            marks[2] = 14;
            marks[3] = 17;

            //Console.WriteLine(marks[0]);
            Console.WriteLine("The Size of Array is "+marks.Length);

            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine(marks[i]);
            }
            Console.ReadKey();

        }
    }
}
