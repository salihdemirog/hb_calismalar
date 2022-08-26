using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    class Matematik
    {
        public void PiSayisiYazdir() => Console.WriteLine("3.1415");

        public void Yazdir(string ifade) => Console.WriteLine(ifade);

        public long FaktoriyelHesapla(int sayi)
        {
            var sonuc = 1L;

            for (int i = 1; i <= sayi; i++)
            {
                sonuc *= i;
            }

            return sonuc;
        }

        public long FaktoriyelHesaplaRec(int sayi)
        {
            if (sayi < 0)
                throw new ArgumentException("Sayı sıfırdan küçük olamaz", nameof(sayi));

            if (sayi == 0)
                return 1L;

            return sayi * FaktoriyelHesaplaRec(sayi - 1);
        }

        public double OrtalamaAl(int a, int b) => (a + b) / 2d; //C# 6.0 Expression Bodied

        public double OrtalamaAl(int a, int b, int c) => (a + b + c) / 3d;

        public double OrtalamaAl(params int[] sayilar)
        {
            var toplam = 0d;

            foreach (var sayi in sayilar)
            {
                toplam += sayi;
            }

            return toplam / sayilar.Length;
        }

        public int Topla(int a, int b, int c = 0, int d = 0, int e = 0)
        {
            return a + b + c + d + e;
        }

        public int Topla(int a, int b, int c, int d, int e, int f)
        {
            return Topla(a, b, c, d, e) + f;
        }

        public static long KareAl(int sayi) => sayi * sayi;

    }
}
