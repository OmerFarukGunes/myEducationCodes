using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Operatorler
    {
        static void Main(string[] args)
        {
            int sayi = 55;
            int sayi2 = 10;
            int toplam = sayi + sayi2;
            int fark = sayi - sayi2;
            int carpim = sayi * sayi2;
            int bolum = sayi / sayi2;
            // % mod alma işlemide vardır. aynı kullanıma sahiptir c++ ile.
               Console.WriteLine(toplam);
            Console.WriteLine(fark);
            Console.WriteLine(carpim);
            Console.WriteLine(bolum);
            sayi++;
            ++sayi;
            Console.WriteLine(sayi);
            Console.WriteLine(sayi--);
            Console.WriteLine(--sayi);
            sayi += 10;
            Console.WriteLine(sayi);
            string metin = "Merhaba";
            string metin2 = "Dunya";
            metin += metin2;
            Console.WriteLine(metin);
        }
    }
}
