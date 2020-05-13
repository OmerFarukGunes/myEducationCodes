using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int tahmin = rnd.Next(1,10);  //rasgele sayi üretir
            Console.WriteLine(tahmin);
        }
    }
}
