using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal class HalkBankList : IBankList, IEnumerable
    {
        private readonly ILog _log;
        public HalkBankList(ILog log)
        {
            _log = log;
        }

        public object this[int index] { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }

        public int ElemanSayisi => throw new NotImplementedException();

        public void Ekle(object eleman)
        {
            //Ekleme işlemleri

            _log.LogAl(eleman.ToString());
        }

        public IEnumerator GetEnumerator()
        {
            return null;
        }

        public void Sil(int index)
        {
            
        }

        public void Temizle()
        {
           
        }
    }
}
