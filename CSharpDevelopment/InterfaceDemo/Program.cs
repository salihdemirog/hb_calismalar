using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var list = new IBankList();
            //var sayilar = new ArrayList() { 1, 2, 3 };
            //var isimler = new List<string> { "sa" };

            //var arrayList = new ArrayList(isimler);
            //arrayList.Add(4);

            var bankList = new HalkBankList(new EventLog());
            bankList.Ekle("Salih");
            bankList.Ekle("Mehmet");

            Console.ReadLine();
        }
    }
}
