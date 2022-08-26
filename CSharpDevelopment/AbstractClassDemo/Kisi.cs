using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    abstract class Kisi
    {
        private string _name;
        public Kisi()
        {

        }

        public abstract string Meslek { get; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }

        protected abstract void EkstraBilgiYazdir();

        public void BilgiYazdir()
        {
            Console.WriteLine($"Ad:{Ad}");
            Console.WriteLine($"Soyad:{Soyad}");
            Console.WriteLine($"Yaş:{Yas}");
            Console.WriteLine($"Meslek:{Meslek}");

            EkstraBilgiYazdir();
        }
    }
}
