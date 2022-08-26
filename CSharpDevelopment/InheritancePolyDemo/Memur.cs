using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolyDemo
{
    internal class Memur : Kisi
    {
        public string Kurum { get; set; }

        public override void BilgiYazdir()
        {
            Console.WriteLine($"{Ad} {Soyad} {Yas}");
        }
    }
}
