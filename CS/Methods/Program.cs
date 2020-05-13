using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            int number1 = 20;
            int number2 = 100;
            var result = Add2(4, 6);
            Console.WriteLine(result);
            Console.WriteLine(Add2(2, 5));
            Console.WriteLine(Add3(10, 20));
            Console.WriteLine(add4(ref number1, number2)); //ref yazılmasaydı number 1 değeri değişmezdi. 
            //yukarıda aynı şekilde ref yerine out ta yazabilirsin. outun farkı değişkenin başlangıçte değere sahip olmamasında sıkıntı olmamasıdır.
            Console.WriteLine(number1);
            Console.WriteLine(mutiply(2,4));
            Console.WriteLine(mutiply(2,4,8));
            Console.Write(add5(1, 2, 3, 4, 5, 6, 7, 8, 0)); //istediğin kdadar yazabilirsin.
            Console.ReadLine();
        }
        static void Add()
        {
            Console.WriteLine("ADDED!");
        }
        static int Add2(int num1,int num2)
        {
            return num1 + num2;
        }
        static int Add3(int num1, int num2,int num3=30) //default değerler sonda verilir.
        {
            return num1 + num2+num3;
        }
        static int add4(ref int num1,int num2)
        {
            num1 = 30;
            return num1 + num2;
        } 
        static int mutiply(int num1,int num2) {
            return num1 * num2;
        }
        static int mutiply(int num1, int num2,int num3)  //aynı isimde metod kullanabilirsin farklı değerlere sahip olursa eğer.
        {
            return num1 * num2*num3;
        }
        static int add5(int number1,params int[] numbers) //params son parametre olmak zorunda çünkü sınırı yoktur. ama öncesine değişken atanabilir.
        {
            return numbers.Sum(); //dizideki tüm sayilari toplar hazır fonksiyondur.
        }
    }
}
