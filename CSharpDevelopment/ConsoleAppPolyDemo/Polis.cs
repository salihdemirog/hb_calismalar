using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPolyDemo
{
    internal class Polis : InheritancePolyDemo.Kisi
    {
        public string GorevYeri { get; set; }

        public override void BilgiYazdir()
        {
            base.BilgiYazdir();

            Console.WriteLine("Görev Yeri:{0}", GorevYeri);
        }
    }
}
