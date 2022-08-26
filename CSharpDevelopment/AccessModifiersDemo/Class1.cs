using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersDemo
{
    public class Base
    {
        public Base()
        {
            
        }

        private int MyPropertyPrivate { get; set; }
        protected int MyPropertyProtected { get; set; }
        internal int MyPropertyInternal{ get; set; }
        public int MyPropertyPublic { get; set; }

        protected internal int MyPropertyProInt { get; set; }

        private protected int MyPropertyPriPro { get; set; }
    }

    public class Derived : Base
    {
        public Derived()
        {
           
        }
    }
}
