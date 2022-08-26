using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalkBankCore
{
    public interface IBankList
    {
        void Ekle(object eleman);

        void Sil(int index);

        void Temizle();

        int ElemanSayisi { get; }

        object this[int index]
        {
            get;
            set;
        }
    }
}
