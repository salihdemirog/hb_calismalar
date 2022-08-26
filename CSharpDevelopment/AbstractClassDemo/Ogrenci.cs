using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    interface ISahis
    {

    }

    interface ISahis2
    {

    }

    class Sahis
    {

    }

    internal class Ogrenci :Kisi, ISahis, ISahis2
    {
        public override string Meslek => "Öğrenci";
        public string OkulAdi { get; set; }

        protected override void EkstraBilgiYazdir()
        {
            Console.WriteLine("Okul Adı:{0}", OkulAdi);
        }
    }
}
