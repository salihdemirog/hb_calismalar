using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyDemo
{
    internal class Sahis
    {
        private string _adSoyad = "Salih";

        //public string AdSoyad
        //{
        //    get
        //    {
        //        //kod
        //        return _adSoyad;
        //    }
        //    set
        //    {
        //        //kod
        //        _adSoyad = value;
        //        //kod
        //    }
        //}

        public string AdSoyad
        {
            get => _adSoyad;  //C# 7.0
            set => _adSoyad = value; //C# 7.0
        }

        //private DateTime _dogumTarihi;

        //public DateTime DogumTarihi
        //{
        //    get { return _dogumTarihi; }
        //    set { _dogumTarihi = value; }
        //}

        public DateTime DogumTarihi { get; internal set; } = DateTime.Now.AddYears(-18); //C# 6.0

        public int Yas => DateTime.Now.Year - DogumTarihi.Year; //C# 6.0
        //public int Yas
        //{
        //    get
        //    {
        //        return DateTime.Now.Year - DogumTarihi.Year;
        //    }
        //}

    }
}
