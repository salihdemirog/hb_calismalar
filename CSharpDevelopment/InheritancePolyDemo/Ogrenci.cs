using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolyDemo
{
    public class Ogrenci : Kisi
    {
        public string OkulAdi { get; set; }

        public override void BilgiYazdir()
        {
            base.BilgiYazdir();

            Console.WriteLine($"Okul Adı:{OkulAdi}");
        }
    }
}
