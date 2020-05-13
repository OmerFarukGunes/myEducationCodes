using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_While
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            do
            {
                sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(sayi);
            } while (sayi != 0);
            Console.Clear(); //ekranı temizler
            //random rnd=new Random();
            //int tahmin = rnd.next(1,10);  //rasgele sayi üretir
        }
    }
}
