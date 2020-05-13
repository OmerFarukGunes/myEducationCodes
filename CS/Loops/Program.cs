using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {

        static void Main(string[] args)
        {
            //ForLoop();
            //WhileLoop();
            //DoWhileLoop();
            //ForEachLoop();
            if (IsPrimeNumber(7919))
            {
                Console.WriteLine("This is a prime number");
            }
            else
            {
                Console.WriteLine("This is not a prime number");
            }
            Console.ReadLine();
        }
        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for(int i = 2; i < number - 1; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    i = number; //döngü bitsin diye yapaarız bunuki program boşa çalışmasın
                }
            }
            return result;
        }
        private static void ForEachLoop()
        {
            string[] students2 = new string[3] { "Engin", "ali", "ahu" };
            foreach (var student in students2) //for each yazıp iki kez taba basarsan tamamlar.
            {//foreach içerisinde elemanları değiştiremezsin. sadece elemanlarda gezersin.
                Console.WriteLine(student);
            }
        }

        private static void DoWhileLoop()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 0);
        }

        private static void WhileLoop()
        {
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
        }

        private static void ForLoop()
        {
            for (int i = 0; i < 100; i++/*i+=2 yapablirdin*/) //for yaz ve taba iki kez bas ve tam bir for döngüsü oluşur böyle
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished");
        }
    }
}
