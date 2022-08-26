using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolyDemo
{
    internal sealed class BasariliOgretmen : Ogretmen
    {
        public decimal Prim { get; set; }

        public override void BilgiYazdir()
        {
            base.BilgiYazdir();

            Console.WriteLine($"Prim:{Prim}");
        }
    }
}
