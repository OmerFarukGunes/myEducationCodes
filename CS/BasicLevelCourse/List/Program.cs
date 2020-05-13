using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilar = new List<int>();
            sayilar.Add(3);
            sayilar.Add(7);
            sayilar.Add(10);
            sayilar.Add(15);
            sayilar.Remove(3);
            sayilar.RemoveAt(0);
            Console.WriteLine(sayilar[1]);
           int uzunluk= sayilar.Count;
            sayilar.Contains(10); //listemiz 10 içeriyor mu?
            sayilar.Clear();//hepsini sil
            Console.WriteLine("bir metin gir");
            string giris = Console.ReadLine();
            foreach (char item in giris)
                {
                Console.WriteLine(item + "\t 1.");

                }
        }
    }
}
