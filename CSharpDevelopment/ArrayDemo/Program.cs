using System;

namespace ArrayDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] sayilar = new int[3];
            //sayilar[0] = 100;
            //sayilar[1] = 200;
            //sayilar[2] = 300;

            int[] sayilar = { 100, 200, 300, 400 };

            string[,] damaTahtasi = new string[8, 8];
            damaTahtasi[0, 0] = "A1";
            damaTahtasi[8, 8] = "H8";

            int[][] karisikBoyutlu = new int[3][];
            karisikBoyutlu[0] = new int[] { 1, 2, 3 };
            karisikBoyutlu[1] = new int[] { 8,9 };
            karisikBoyutlu[2] = new int[] { 8, 9,8,9 };

            //Console.WriteLine($"İlk Eleman:{sayilar[0]}");
            //Console.WriteLine($"İkinci Eleman:{sayilar[1]}");
            //Console.WriteLine($"Üçüncü Eleman:{sayilar[2]}");


            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    var sayi = sayilar[i];
            //    Console.WriteLine(sayi);
            //}

            foreach (var sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }

            Console.ReadLine();
        }
    }
}