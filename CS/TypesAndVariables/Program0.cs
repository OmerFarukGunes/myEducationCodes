using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program0
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            //kullanıcı bir şeye basana kadar ekranın kalmasını sağlar.
            int number1 = 102134;//32 bit
            long number2 = 1000000000000;//64 bit
            short number3 = 6123; //16 bit
            byte number4 = 0;//8 bit 0-255 arası
            bool condition = false;
            char character = 'A';
            string city = "Ankara";
            double number5 = 10.5;
            decimal number6 = 10.4M; //double ın virgülden sonra daha fazla sayıya sahip hali.
            var number7 = 10; //ilk atama int olduğundan kaynaklı hep int değerle devam eder.
            number7 = 'A';
            Console.WriteLine("Number 1 is {0}",number1);
            Console.WriteLine("Number 2 is {0}", number2);
            Console.WriteLine("Number 3 is {0}", number3);
            Console.WriteLine("Number 4 is {0}", number4);
            Console.WriteLine("Number 5 is {0}", number5);
            Console.WriteLine("Number 6 is {0}", number6);
            Console.WriteLine("Number 7 is {0}", number7);
            Console.WriteLine("Character is {0}", character);
            Console.WriteLine("Character is {0}",(int) character);
            Console.WriteLine("city is {0}", city);
            if (condition == false)
            {
                Console.WriteLine(Days.Monday);
                Console.WriteLine((int)Days.Monday);
            }
            Console.ReadLine();
        }
    }
    enum Days
    {
        Monday,Tuesday=20,Wednesday,Thursday,Friday,Saturday,Sunday //tuesdayden sonra 21 22 23 olacak.
    }
}
