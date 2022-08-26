using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal class FileLog : ILog
    {
        public void LogAl(string message)
        {
            Console.WriteLine("File ile log aındı:{0}",message);
        }
    }
}
