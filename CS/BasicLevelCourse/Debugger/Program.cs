using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugger
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(toplam(5, 9));
            int sayi = 3;
            Console.WriteLine(kupal(ref sayi));
            int toplami = Topla(3, 4, 5, 6, 7, 8, 9);
            Console.WriteLine(toplami);

        }
        static int Topla(params int[] sayi)
        {
            int toplam = 0;
            
            for (int i = 0; i < sayi.Length; i++)
                toplam+=sayi[i];
            return toplam;
        }
        static int toplam(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        static int kupal(ref int sayi){ //direk stack üzerindeki verileri çağır ve yükü hafiflet.
return sayi*sayi*sayi;            
}
        

    }
}
