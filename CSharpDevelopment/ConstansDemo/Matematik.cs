using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstansDemo
{
    internal class Matematik
    {
        public const double PI_SAYISI = 3.1415;
        public readonly int UgurluSayi;
        private readonly int _sayi;

        public Matematik()
        {
            //PI_SAYISI = 4.0;
            UgurluSayi = 5;
            UgursuzSayi = 13;
        }

        public Matematik(int sayi)
        {
            _sayi = sayi;
        }

        public int UgursuzSayi { get; }

        public void Degistir()
        {
            //PI_SAYISI = 5.0;
            //UgurluSayi = 6;
            //UgursuzSayi = 7;
            //_sayi = 0;
        }

    }
}
