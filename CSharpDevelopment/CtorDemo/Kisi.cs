using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtorDemo
{
    internal class Kisi
    {
        public Kisi()
        {
            Console.WriteLine("Ctor 0 çalıştı");

            AdSoyad = "Salih";
            Yas = 18;
            EvliMi = true;
            UgurluSayi = 5;
        }

        public Kisi(string adSoyad) : this()
        {
            Console.WriteLine("Ctor 1 çalıştı");

            AdSoyad = adSoyad;
            //Yas = 20;
            //EvliMi = false;
        }

        public Kisi(string adSoyad, int yas) : this(adSoyad)
        {
            Console.WriteLine("Ctor 2 çalıştı");

            //AdSoyad = adSoyad;
            //EvliMi = false;
            Yas = yas;
        }

        public Kisi(string adSoyad, int yas, bool evliMi) : this(adSoyad, yas)
        {
            Console.WriteLine("Ctor 3 çalıştı");
            //AdSoyad = adSoyad;
            //Yas = yas;
            EvliMi = evliMi;
        }

        public string AdSoyad { get; set; }
        public int Yas { get; set; }
        public bool EvliMi { get; set; }

        public int UgurluSayi { get; }

        public void Degistir()
        {
            //UgurluSayi = 5;
        }
    }
}
