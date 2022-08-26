using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalkBankCore
{
    public class HalkBankList : IBankList, IEnumerable
    {
        private object[] _dizi;

        public HalkBankList()
        {
            _dizi = new object[0];
        }

        public object this[int index]
        {
            get => _dizi[index];
            set => _dizi[index] = value;
        }

        public int ElemanSayisi => _dizi.Length;

        public void Ekle(object eleman)
        {
            var yedekDizi = _dizi;
            _dizi = new object[ElemanSayisi + 1];

            yedekDizi.CopyTo(_dizi, 0);

            _dizi[ElemanSayisi-1] = eleman;
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void KosulluSil(Func<object, bool> kosul)
        {
            throw new NotImplementedException();
        }

        public void Sil(int index)
        {
            var yedekDizi = _dizi;
            _dizi = new object[ElemanSayisi - 1];

            int sayac = 0;

            for (int i = 0; i < yedekDizi.Length; i++)
            {
                if (i == index)
                    continue;

                _dizi[sayac] = yedekDizi[i];

                sayac++;
            }
        }

        public void Temizle()
        {
            _dizi = new object[0];
        }
    }
}
