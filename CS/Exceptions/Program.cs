using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro();
            //TyrCatch();
            //her daim try catch yazmak yerine aşağıdakini kısa bir şekilde bir fonksiyona göndererek yeazarsın
            HandleException(() =>
            {
                Find();
            });//ben parametresiz bir method gönderecem be bunun karşılığı bu.
            Func<int, int, int> add = Topla; //2 parametre alıp onu int e dönüştürüyor.
            Console.WriteLine(add(3, 5)); //func şeklinde kullanımla metod göndermi yapabilirsin.
            Console.WriteLine(Topla(2, 3));
            Func<int> getRandomNumber = delegate () //buradaki func burada parametresiz metodu alıp int döndürcek anlamına geliyor.
            {
                Random random = new Random();
                return random.Next(1, 100); //random sayı üretmek. (1 - 100 arası)
            };
            Console.WriteLine(getRandomNumber()); //random sayıyı ekrana yazmak
            Thread.Sleep(100); //farklıs ayı üretmesini sağar.
            Func<int> getRandomNumber2 = () => new Random().Next(1, 100); //buda farklı yoldan random sayı üretmektir.
          
            Console.WriteLine(getRandomNumber2()); //random sayıyı ekrana yazmak

            Console.ReadLine();
        }
        static int Topla (int x, int y)
        {
            return x + y;
        }
        private static void TyrCatch()
        {
            try
            {
                Find();
            }
            catch (RecordNotFoundExcepiton exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke(); //actionu çalıştır demek.
            }
            catch (Exception exception)//hata ne olursa olsun bul 
            {

                Console.WriteLine(exception.Message); //ve ekrana yaz.
            }
        }//bu fonkla try catch yapabilirsin ve her hatalı olabilecek mesajı metod yapar gönderirsin buraya ve kontrolü sağlarsın.

        private static void Find()
        {
            List<String> Students = new List<string> { "Engin", "Ahmet", "Salih" };
            if (Students.Contains("Ahmet"))
            {
                throw new RecordNotFoundExcepiton("Record which cannot be inside is Found!"); //ahmet varsa hatayı fırlat ve bunu bu mesajla yap.
                
            }
            else
            {
                Console.WriteLine("Record not Found");
            }
        }

        private static void ExceptionIntro()
        {
            try //try yaz iki kere bas taba
            {
                string[] students = new string[3] { "Engin", "Derin", "Salih" };

                students[3] = "Ahmet";//diyelimki coder böyle bir hata yaptı. ve bunu trya aldı. 
            }
            catch (IndexOutOfRangeException exception) //altdığı hatanın türü buysa buraya gir ve bunu yap. (out of bounds)
            {
                Console.WriteLine(exception.Message);
            }
            catch (DivideByZeroException exception)//0 a bölünmeyle ilgili hata ise buraya gir 
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception) //yakaladığı hatayı exceptiona atar. diğer tüm hatalar buraya gider.
            {

                Console.WriteLine(exception.Message); //exception.ınnerexception daha detaylı bir hata mesajı varsa gösterir.
            }
        }
    }
}
