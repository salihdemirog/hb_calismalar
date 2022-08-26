using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerDemo
{
    internal class Gun
    {
        private string[] _gunler = { "P.tesi", "Salı", "Çrş", "Prş", "Cuma", "C.tesi", "Pazar" };

        public string this[byte haftaninGunu]
        {
            get
            {
                if (haftaninGunu < 1 || haftaninGunu > 7)
                    throw new ArgumentException("1-7 arasında olabilir", nameof(haftaninGunu));

                return _gunler[haftaninGunu - 1];
            }
        }
    }
}
