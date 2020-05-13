using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 11;
            Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10");
            if (number == 11)
            {
                Console.WriteLine("Number is 11");
            }
            else if (number == 12)
            {
                Console.WriteLine("Number is 12");
            }
            else
            {
                Console.WriteLine("nuMber is not 11 or 12");
            }
            switch (number)
            {
                case 10:
                    Console.WriteLine("Number is 10");
                    break;
                case 11:
                    Console.WriteLine("Number is 11");
                    break;
                case 12:
                    Console.WriteLine("Number is 12");
                    break;
                default:
                    Console.WriteLine("nuMber is not available");
                    break;
            }
            // && || kullanımı aynıdır.
            Console.ReadLine();

        }
    }
}
