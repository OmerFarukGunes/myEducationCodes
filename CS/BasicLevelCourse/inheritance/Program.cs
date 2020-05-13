using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            kedi cat = new kedi() { weight = 3, length = 5, name = "pisi",runSpeed=20 }; //abstract kısımları silersen kod çalışır.
            Console.WriteLine(cat.getProperties());
        }
    }
}
