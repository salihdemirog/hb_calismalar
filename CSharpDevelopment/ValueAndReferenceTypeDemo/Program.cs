using System;
using System.Text;

namespace ValueAndReferenceTypeDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = a;
            int c = new int();

            a = 10;
            b = 20;

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            int[] aArray = { 1, 2, 3 };
            int[] bArray = aArray;
            int[] cArray = new int[3];
            aArray.CopyTo(cArray, 0);

            aArray[0] = 10;
            bArray[1] = 20;
            cArray[0] = 100;

            Console.WriteLine("aArray = " + string.Join(",", aArray));
            Console.WriteLine("bArray = " + string.Join(",", bArray));
            Console.WriteLine("cArray = " + string.Join(",", cArray));

            Console.ReadLine();
        }
    }
}