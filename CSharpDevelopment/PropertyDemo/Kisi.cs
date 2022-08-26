using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyDemo
{
    internal class Kisi
    {
        private string _adSoyad;
        private DateTime _dogumTarihi;
        //private int _yas;

        public string Get_AdSoyad()
        {
            //kod
            return _adSoyad;
        }

        public void Set_AdSoyad(string adSoyad)
        {
            //Kod
            _adSoyad = adSoyad;
            //Kod
        }

        public void Set_DogumTarihi(DateTime dogumTarihi)
        {
            _dogumTarihi = dogumTarihi;
        }

        //public void Set_Yas(int yas)
        //{
        //    _yas = yas;
        //}

  

        public DateTime Get_DogumTarihi() => _dogumTarihi;

        public int Get_Yas()
        {
            return DateTime.Now.Year - _dogumTarihi.Year;
        }
    }
}
