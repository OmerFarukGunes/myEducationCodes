using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama1
{
    class Uygulama1
    {
        static void Main(string[] args)
        {
            string girdi =Console.ReadLine(); //ilk atama string olmalı. kullanıcıdan alınan.
            int toplam = 2 + Convert.ToInt32(girdi);
            Console.WriteLine("sayinin 2 fazlasi "+ toplam);
   
        }
    }
}
