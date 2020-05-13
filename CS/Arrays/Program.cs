using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            string[] students2 = new[] { "Engin", "ali", "ahu"};
             string[]students3 ={ "Engin", "ali", "ahmet"};
            students[0] = "engin";
            students[1] = "Derin";
            students[2] = "asli";
            foreach(var student in students) //dizide gezebilmek için kullanılır foreach
            {
                Console.WriteLine(student);
     
            }

            string[,] regions = new string[3, 3]
            {
                {"istanbul","izmit","balikesir"  },
                {"Ankara","konya","kırıkkale" },
                {"Antalya","Adana","Mersin" }
            };
            for (int i = 0; i <= regions.GetUpperBound(0); i++)//get upper bound 0 ıncı diamondun en üst değeri
            {      
                for(int j=0; j <= regions.GetUpperBound(1); j++) // <= çünkü oranın uzunluğunu alırken 0-1-2-3-4 diye alıyor zaten 5 demiyor ondan.
                {
                    Console.WriteLine(regions[i, j]);
                }
            }
            Console.ReadLine();
        }
    }
}