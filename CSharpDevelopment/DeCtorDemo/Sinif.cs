using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeCtorDemo
{
    internal class Sinif
    {
        public string Ad { get; set; }

        ~Sinif()
        {
            Console.WriteLine("Yıkıcı blok çalıştı");
        }
    }
}
