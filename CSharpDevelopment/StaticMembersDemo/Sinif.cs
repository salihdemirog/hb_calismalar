using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMembersDemo
{
    internal class Sinif
    {
        static Sinif()
        {
            Console.WriteLine("Static Ctor çalıştı");
        }

        public Sinif()
        {
            Console.WriteLine("Normal Ctor çalıştı");
        }
    }
}
