using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates //türkçe karşılıpı elçi.
{
    public delegate void MyDelegate();
    public delegate void MyDelegate2(string text);
    public delegate int MyDelegate3(int num1, int num2); //bunda dönen bir nesne var
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.SendMessage();
            customerManager.Alert();
            MyDelegate myDelegate = customerManager.SendMessage; //bu elçi artık sendmessage in elçisi olmuş o mesaja sahip olacak.
            myDelegate += customerManager.Alert; //bu şekilde ek bir operasyon atayabilirsin.
            myDelegate(); //ex: bir kral bir elçisine mesajları veriyor ve başka bir devlet adamına ilet diyor oda iletiyor
            myDelegate -= customerManager.SendMessage; //işlemi geri alabilirsin.
            myDelegate();

            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            myDelegate2 += customerManager.Alert2;
            myDelegate2("Hello"); //aynı parametreyi iki operasyon için gönderiyor.
            Math math = new Math();
            MyDelegate3 myDelegate3 = math.Topla;
            myDelegate3 += math.Carp;
            var sonuc = myDelegate3(6, 3);
            Console.WriteLine(sonuc); //bhaşta toplama verdik sonra çarpmayı ekledik ve 6 ile 3 ü gönderdik.
            //delegelerde return var ise en son gelen return sonuç olarak ekrana yazılır.
            Console.ReadLine();
        }
    }
    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello");
        }
        public void Alert()
        {
            Console.WriteLine("Be careful");
        }
        public void SendMessage2(string message)
        {
            Console.WriteLine(message);
        }
        public void Alert2(string alert)
        {
            Console.WriteLine(alert);
        }
    }
    public class Math
    {
        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
    }
}
