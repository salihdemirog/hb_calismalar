using System.Collections;

namespace CollectionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayListDemo();

            //ListDemo();

            //ListDemo2();


            var sozluk = new Dictionary<int, string>();
            sozluk.Add(1, "Bir");
            sozluk.Add(2, "İki");

            if (!sozluk.ContainsKey(3))
                sozluk.Add(3, "Üç");

            sozluk[1] = "One";
            sozluk[2] = "Two";
            sozluk[3] = "Three";
            sozluk[4] = "Four";
            sozluk[5] = "Five";

            var five = sozluk[5];

            //foreach (var key in sozluk.Keys)
            //{
            //    Console.WriteLine($"Key:{key}");
            //}

            //foreach (var value in sozluk.Values)
            //{
            //    Console.WriteLine($"Value:{value}");
            //}

            sozluk.Remove(5);

            foreach (var eleman in sozluk)
            {
                Console.WriteLine($"Key:{eleman.Key} -> Value:{eleman.Value}");
            }

            var elemanSayisi = sozluk.Count;

            sozluk.Clear();

            Console.WriteLine("Bitti");

            Console.ReadLine();
        }

        private static void ListDemo2()
        {
            var isimler = new List<string>
            {
                "Salih",
                "Mehmet",
                "Ahmet"
            };

            isimler.Add("Engin");
            isimler.Insert(1, "Umut");

            Console.WriteLine("Listede Engin Varmı ?: {0}", isimler.Contains("Engin"));

            foreach (var isim in isimler)
            {
                Console.WriteLine(isim);
            }
        }

        private static void ListDemo()
        {
            var sayilar = new List<int>();
            sayilar.Add(1);
            sayilar.Add(2);
            sayilar.Add(3);
            //sayilar.Add("4");

            sayilar[0] = 100;
            object? ilkSayi = sayilar[0];

            sayilar.RemoveAt(0);

            var toplam = 0;
            foreach (var sayi in sayilar)
            {
                toplam += sayi;
            }

            Console.WriteLine($"Toplam: {toplam}");

            Console.WriteLine($"Eleman Sayısı: {sayilar.Count}");

            sayilar.Clear();
        }

        private static void ArrayListDemo()
        {
            ArrayList sayilar = new ArrayList();
            sayilar.Add(1);
            sayilar.Add(2);
            sayilar.Add(3);
            sayilar.Add(4);

            sayilar[0] = 100;
            object? ilkSayi = sayilar[0];

            sayilar.RemoveAt(0);
            //sayilar.Add("5");
            //sayilar.Add("Altı");
            //sayilar.Add(false);

            var toplam = 0;
            foreach (var sayi in sayilar)
            {
                toplam += (int)sayi;
            }

            Console.WriteLine($"Toplam: {toplam}");

            Console.WriteLine($"Eleman Sayısı: {sayilar.Count}");

            sayilar.Clear();
        }
    }
}