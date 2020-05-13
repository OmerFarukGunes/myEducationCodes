using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[10];
            for (int i = 0; i < 10; i++)
                sayilar[i] = i;
            string[] isimler = { "Ahmet", "mehmet" };
            Console.WriteLine(isimler[1]);
        }
    }
}
