using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba Dunya!");
           
            int sayi = 3;
            long sayi3= 3462986234;
            float sayi2= 5.4f ;// f eklemek zorundasın.
            double sayi4= 5.676;
            char a = 'a';
             decimal para = 2.222M;//m eklemek gere.
            bool isHere = true;
            DateTime tarih = DateTime.Now;//şuanın tarihini yazar.
                string metin = "taksiggm";
            int s1, s2 = 4; //kullanmı var. 
            Console.WriteLine(metin); //hepsinde aynı şekilde yazar.
            Console.ReadLine(); //konsole kapanmaması için kullanılır.
        }
    }
}
