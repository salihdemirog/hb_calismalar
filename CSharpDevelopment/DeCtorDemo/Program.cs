using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DeCtorDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sinif = new Sinif()
            {
                Ad = "A1"
            };

            sinif = null;

            Thread.Sleep(5000);

            
            GC.Collect();

            Console.WriteLine("Bitti");
            Console.ReadLine();
        }
    }
}
