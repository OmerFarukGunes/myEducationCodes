using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_Each
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar=new int[] { 1,2,3,4,5,6,7,8,9,10 };
            foreach (int sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }
        }
    }
}
