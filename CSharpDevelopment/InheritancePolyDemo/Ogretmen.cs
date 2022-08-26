using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolyDemo
{
    public class Ogretmen : Kisi
    {
        public decimal Maas { get; set; }

        public override void BilgiYazdir()
        {
            base.BilgiYazdir();

            Console.WriteLine($"Maaş:{Maas}");
        }

        public override string ToString()
        {
            return "TamAd";
        }
    }
}
