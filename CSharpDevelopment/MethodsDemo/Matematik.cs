using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDemo
{
    class Matematik
    {
        //public void PiSayisiYazdir()
        //{
        //    Console.WriteLine("3.1415");
        //}

        public void PiSayisiYazdir() => Console.WriteLine("3.1415");

        //5!= 5*4*3*2*1;
        public long FaktoriyelHesapla(int sayi)
        {
            var sonuc = 1L;

            for (int i = 1; i <= sayi; i++)
            {
                sonuc *= i;
            }

            return sonuc;
        }

        //5!= 5 * 4!;
        //4!= 4 * 3!;
        //1!=1;
        //0!=1;
        public long FaktoriyelHesaplaRec(int sayi)
        {
            if (sayi < 0)
                throw new ArgumentException("Sayı sıfırdan küçük olamaz", nameof(sayi));

            if (sayi == 0)
                return 1L;

            return sayi * FaktoriyelHesaplaRec(sayi - 1);
        }


        //public double OrtalamaAl(int a, int b)
        //{
        //    return (a + b) / 2d;
        //}
        public double OrtalamaAl(int a, int b) => (a + b) / 2d; //C# 6.0 Expression Bodied

        //public double OrtalamaAl(int a, int b, int c)
        //{
        //    return (a + b + c) / 3d;
        //}
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

        public void DortIslem(int a, int b, out int toplama, out int cikarma, out long carpma, out double bolme)
        {
            toplama = a + b;
            cikarma = a - b;
            carpma = a * b;
            bolme = a / b;

            //int sonuc = a + toplama;
        }

        //public Tuple<int, int, long, double> DortIslemTuple(int a, int b)
        //{
        //    return new Tuple<int, int, long, double>(a + b, a - b, a * b, a / b);
        //}

        public (int ToplamaSonuc, int CikarmaSonuc, long CarpmaSonuc, double) DortIslemTuple(int a, int b) //C# 7.0
        {
            return (a + b, a - b, a * b, a / b);
        }

        public void DemoValueType(int x)
        {
            x = 10;
        }

        public void DemoReferenceType(int[] xArray)
        {
            xArray[0] = 10;
        }

        public void DemoValueTypeRef(ref int x)
        {
            x = 10;
        }
    }
}
