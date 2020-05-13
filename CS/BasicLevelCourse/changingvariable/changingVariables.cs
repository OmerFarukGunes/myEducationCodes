using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace changingvariable
{
    class changingVariables
    {
        static void Main(string[] args)
        {
            int sayi = 4;
            long buyuksayi = 9;
            long sayi3 = sayi; //küçük tipten büyük tipe değiştirme sıkıntı yok
            int sayi5 = (int)buyuksayi; //büyükten küçük için ben biliyoreum demek zorundasın
            string a = "3";
            string b = "9";
            int toplam = Convert.ToInt32(a) + Convert.ToInt32(b); //stringi inte çevirmek.
            int sayi2 = Convert.ToInt32(Console.ReadLine()); //bu şekildede okuma işlemi yapabilirsin.
            string girdi = Console.ReadLine(); //ilk atama string olmalı. kullanıcıdan alınan. //veya bu şekilde alıp
            int sayii = Convert.ToInt32(girdi); //çevirme yapabilirsin.
            Console.WriteLine(toplam);
        }
    }
}
