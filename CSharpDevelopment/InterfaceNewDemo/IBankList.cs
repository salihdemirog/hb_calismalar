using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceNewDemo
{
    interface IBankList
    {
        public int MyProperty => 5;
        public void Sil(int index);
        public void Temizle()
        {
            Console.WriteLine("Temizlendi");
        }
    }

    abstract class BankListBase
    {
        public int MyProperty => 5;
        public abstract void Sil(int index);

        public void Temizle()
        {

        }
    }


    class HalkBankList : BankListBase
    {
        public override void Sil(int index)
        {
            throw new NotImplementedException();
        }
    }


    class Demo
    {
        private readonly IBankList list;

        public Demo(IBankList list)
        {
            this.list = list;
        }

        public void Test()
        {
            list.
        }
    }
}
