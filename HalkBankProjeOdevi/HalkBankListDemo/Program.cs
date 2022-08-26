using HalkBankCore;

namespace HalkBankListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new HalkBankList();
            list.Ekle("Salih");
            list.Ekle("Engin");
            list.Ekle("Mustafa");
            list.Ekle("Ahmet");

            list[2] = "Mehmet";

            list.Sil(3);

            Console.WriteLine("Eleman Sayısı:{0}", list.ElemanSayisi);

            //for (int i = 0; i < list.ElemanSayisi; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}

            foreach (var eleman in list)
            {
                Console.WriteLine(eleman);
            }

            list.Temizle();

            Console.WriteLine("Eleman Sayısı:{0}", list.ElemanSayisi);

            Console.ReadLine();
        }
    }
}