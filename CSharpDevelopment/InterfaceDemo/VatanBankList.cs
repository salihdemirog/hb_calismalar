using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal class VatanBankList : IBankList
    {
        private readonly ILog _log;

        public VatanBankList(ILog log)
        {
            _log = log;
        }

        public object this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int ElemanSayisi => throw new NotImplementedException();

        public void Ekle(object eleman)
        {


            //Ekleme işlemleri

            _log.LogAl(eleman.ToString());
        }

        public void Sil(int index)
        {
            //Ekleme işlemleri

            _log.LogAl(index.ToString());
        }

        public void Temizle()
        {
            throw new NotImplementedException();
        }
    }
}
