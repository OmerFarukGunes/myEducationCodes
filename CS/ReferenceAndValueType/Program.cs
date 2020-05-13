using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30;
            Console.WriteLine(number2); //number 2 20 olur bu şekilde.
            string[] cities1 = new string[] { "Ankara", "Adana", "Afyon" }; //referansı 101
            string[] cities2 = new string[] { "Bursa", "Bolu", "Balıkesir" }; //referansı 102 olsun
            cities2 = cities1;//ama bu şekilde olunca cities 2 nin referansı cities 1 e eşitleniyor
                              //yani cities 2 101 oluyor.
            cities1[0] = "Istanbul";
            //ankara istanbul olur.
            //bursada istanbul olur
            //diğer değerler garbagecollector ile c# tarafından otomatik atılacaktır.
            Console.WriteLine(cities2[0]); //çünkü bubnlar referans tipelerdir. classlar structurler 
           //cclasslarda misal böyle eşitleme kullanacaksan ne eşitleme işlemince başta olacaksa onu newle bir şiekilde tanımlamana gerek yoktur.
            Console.ReadLine();
        }
    }
}
