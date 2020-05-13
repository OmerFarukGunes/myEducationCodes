using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Giris();
            string sentence = "My Name Is Omer";
            var Result = sentence.Length;
            var Result2 = sentence.Clone();
            bool Result3 = sentence.EndsWith("g"); // cümle g ile bitiyormu
            bool Result4 = sentence.StartsWith("My Name"); //cümle my name ile başıyormu
            var Result5 = sentence.IndexOf("name");//cümledeki İLK name kaçıncı karakterden başlıyor.
            var Result6 = sentence.LastIndexOf(" "); //cümlenin en sondaki boşluk kaçıncı karakterde başlıyor söyler.
            var Result7 = sentence.Insert(0, "hELLO");//cümleyi resulta 0. karaktere hello yazzarak ekler.
            var Result9 = sentence.Substring(3, 4);//3. karakterden itibaren 4 tane al ///4 ü yazmasanda olur.
            var Result10 = sentence.ToLower(); //karakterleri küçültür
            var Result8 = sentence.ToUpper(); //karakterleri büyültür
            var Result11 = sentence.Replace(" ", "-"); //boşluklar yerine - geçer
            var Result12 = sentence.Remove(2);//2 den itibaren kalanı siler. //aynı şekilde 2,5 yazsaydık 2 den itibaren 5 karakteri silerdi.
            sentence = "My name is FG"; //klone denen şey aslında referans sağlamaktır yani ana şeyde değişirse klonda değişir.
            Console.WriteLine(Result);
            Console.WriteLine(Result2);
            Console.WriteLine(Result3);
            Console.WriteLine(Result4);
            Console.WriteLine(Result5);
            Console.WriteLine(Result6);
            Console.WriteLine(Result7);
            Console.WriteLine(Result8);
            Console.WriteLine(Result9);
            Console.WriteLine(Result10);
            Console.WriteLine(Result11);
            Console.WriteLine(Result12);

            Console.ReadLine();
        }

        private static void Giris()
        {
            string city = "Ankara";
            Console.WriteLine(city);
            Console.WriteLine(city[0]); //stringler aynı zamanda bir char arrayidir.
            foreach (var iitem in city)
            {
                Console.WriteLine(city);
            }
            string city2 = "Istanbuıl";
            string result = city + city2;
            Console.WriteLine(result);
            Console.WriteLine(String.Format(" {0} {1}", city, city2));
            Console.ReadLine();
        }
    }
}
