using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifElse
{
    class ifElse
    {
        static void Main(string[] args)
        {
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi > 10)
            {
                Console.WriteLine("Sayi 10 dan buyuktur");
            }
            else if (sayi == 5)
            {
                Console.WriteLine("sayi 5 tir");
            }
            else
            {
                Console.WriteLine("sayi 10 dan kucuktur yada esittir");
            } 
        }
    }
}
