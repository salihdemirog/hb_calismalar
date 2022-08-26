using System.Collections;
using System.Text;

namespace BasicTopicsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StringConcatDemo();

            //TypeConversionDemo();

            //NullableTypeDemo();

            //ObjectDemo();

            //DynamicDemo();

            //VarDemo();

            var sayi = 100;
            var sayi2 = 100L; //long
            var sayi3 = 100d; //double
            var sayi4 = 100m; //decimal
            var sayi5 = 100UL; //ulong
            var sayi6 = 100f; //float

            float deger = 100.5f;

            Console.ReadLine();
        }

        private static void VarDemo()
        {
            //var
            var sayi = 100;
            var liste = new List<string>();

            var kisi = new
            {
                Ad = "Salih",
                Soyad = "Demiroğ"
            };

            var kisi2 = new
            {
                Ad = "Salih",
                Soyad = "Demiroğ",
                Yas = 35
            };

            Console.WriteLine(kisi.Ad);
            Console.WriteLine(kisi.Soyad);

            Console.WriteLine(kisi.GetType().Name);
            Console.WriteLine(kisi2.GetType().Name);
        }

        private static void DynamicDemo()
        {
            //dynamic 
            dynamic dyn = "Salih";
            Console.WriteLine(dyn.GetType());
            dyn = 100;
            Console.WriteLine(dyn.GetType());
            dyn = false;
            Console.WriteLine(dyn.GetType());
            dyn = new ArrayList();
            Console.WriteLine(dyn.GetType());
            dyn = 200;
            Console.WriteLine(dyn.GetType());


            int toplam = dyn + 100;
            Console.WriteLine(toplam);
        }

        private static void ObjectDemo()
        {
            //object 
            object obj = "Salih";
            Console.WriteLine(obj.GetType());
            obj = 100;
            Console.WriteLine(obj.GetType());
            obj = false;
            Console.WriteLine(obj.GetType());
            obj = new ArrayList();
            Console.WriteLine(obj.GetType());
            obj = 200;
            Console.WriteLine(obj.GetType());


            int toplam = (int)obj + 100;
            Console.WriteLine(toplam);
        }

        private static void NullableTypeDemo()
        {
            int? sayi = null;

            int rakam = 0;

            if (sayi.HasValue)
            {
                int deger = sayi.Value;
            }

            if (sayi != null)
            {

            }

            string ifade = null;
            string? ad = null; //C# 8.0 nullable reference type
        }

        private static void TypeConversionDemo()
        {

            //Implicit
            //byte kucukSayi = 5;
            //int buyukSayi = kucukSayi;

            checked
            {
                //
                unchecked
                {
                    int sayi = 258;
                    byte kucukSayi = (byte)sayi;
                    //byte kucukSayi = Convert.ToByte(sayi);
                    //byte kucukSayi = byte.Parse(sayi.ToString());



                    Console.WriteLine(kucukSayi);
                }
                //
            }
        }

        private static void StringConcatDemo()
        {
            string ad = "Salih";
            string soyad = "Demiroğ";
            string tel = "0546 439 4340";

            //string adSoyad = ad + " " + soyad + " (" + tel + ")";
            //string adSoyad = string.Format("{0} {1} ({2})", ad, soyad, tel);
            //string adSoyad = $"{ad} {soyad} ({tel})"; //C# 6.0 string interpolation

            StringBuilder adSoyadBuilder = new StringBuilder();

            if (true)
                adSoyadBuilder.Append(ad).Append(" ");

            for (int i = 0; i < 1; i++)
            {
                adSoyadBuilder.Append(soyad);
            }

            adSoyadBuilder.Append(" (").Append(tel).Append(")");

            string adSoyad = adSoyadBuilder.ToString();

            Console.WriteLine(adSoyad);
        }
    }
}