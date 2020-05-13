using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchCase
{
    class switchCase
    {
        static void Main(string[] args)
        {
            int sayi = Convert.ToInt32(Console.ReadLine());
            switch (sayi)
            {
                case 1:
                    Console.WriteLine("1");
                    break;
                case 2:
                    Console.WriteLine("2");
                    goto case 4;
                    break;
                case 4:
                    Console.WriteLine("sayi 4 degildir");
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}
