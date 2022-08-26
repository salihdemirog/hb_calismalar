namespace MethodsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Demo1();

            //Demo2();

            //Demo3();

            //Demo4();

            //DemoRecursive();

            var matematik = new Matematik();
            var sonuc = matematik.DortIslemTuple(10, 5);

            Console.WriteLine("10+5={0}", sonuc.ToplamaSonuc);
            Console.WriteLine("10-5={0}", sonuc.CikarmaSonuc);
            Console.WriteLine("10*5={0}", sonuc.CarpmaSonuc);

            Console.ReadLine();
        }

        private void DemoRecursive()
        {
            var matematik = new Matematik();
            var sonuc = matematik.FaktoriyelHesaplaRec(5);

            Console.WriteLine(sonuc);
            Console.ReadLine();
        }

        private static void Demo4()
        {
            var matematik = new Matematik();

            var x = 5;
            matematik.DemoValueType(x);
            Console.WriteLine("X={0}", x);

            int[] xArray = { 1, 2, 3 };
            matematik.DemoReferenceType(xArray);
            Console.WriteLine("XArray={0}", string.Join(",", xArray));


            var y = 5;
            matematik.DemoValueTypeRef(ref y);
            Console.WriteLine("Y={0}", y);
        }

        private static void Demo3()
        {
            var matematik = new Matematik();

            int toplamaSonuc;
            matematik.DortIslem(10, 5, out toplamaSonuc, out var cikarmaSonuc, out long carpmaSonuc, out _); //C# 6.0

            Console.WriteLine("10+5={0}", toplamaSonuc);
            Console.WriteLine("10-5={0}", cikarmaSonuc);
            Console.WriteLine("10*5={0}", carpmaSonuc);

            if (int.TryParse("100 $", out int paraMiktari))
            {
                int sonuc = paraMiktari + 100;
            }
        }

        private static void Demo2()
        {
            var matematik = new Matematik();
            var sonuc = matematik.FaktoriyelHesapla(5);
            var sonuc2 = matematik.FaktoriyelHesapla(6);
            var sonuc3 = matematik.FaktoriyelHesapla(12);
            _ = matematik.FaktoriyelHesapla(8); //C# 6.0

            Console.WriteLine(sonuc);
            Console.WriteLine(sonuc2);
            Console.WriteLine(sonuc3);

            //var sayilar = new int[] { 7, 20, 5, 6, 1, 25, 14 };
            var ortSonuc = matematik.OrtalamaAl(7, 5, 9, 6, 4, 1, 2);
            Console.WriteLine("Ortalama Sonuc:{0}", ortSonuc);

            var toplam = matematik.Topla(5, 4, e: 20);
            Console.WriteLine("Toplam:{0}", toplam);
        }

        private static void Demo1()
        {
            //5!=5*4*3*2*1= 120

            int sayi = 5;

            var sonuc = 1;

            for (int i = 1; i <= sayi; i++)
            {
                sonuc *= i;
            }

            Console.WriteLine("5!={0}", sonuc);

            int sayi2 = 6;

            var sonuc2 = 1;

            for (int i = 1; i <= sayi2; i++)
            {
                sonuc2 *= i;
            }

            Console.WriteLine("6!={0}", sonuc2);
        }
    }
}