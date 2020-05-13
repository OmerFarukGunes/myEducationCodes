using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Refleksion
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //     Math math = new Math(1, 2);
            // Console.WriteLine(math.Topla2()); BU ikişekilde tanım yaarsın ama biz bunu çalışma anında yapmak istiyoruz
            //Console.WriteLine(math.Carp(3, 5));
            var type = typeof(Math); //mathın tiplerinde işlemler yapacaz.
         //   Math math=(Math)Activator.CreateInstance(type,6,7);//bu çalışma anında math math =new math yapmakla aynı mantıktadır.y ani gelen tipe göre yeni yer açarsın.,
                                                               // Console.WriteLine(math.Carp(5, 4)) ;
                                                               // Console.WriteLine(math.Topla2()); bu üç satır gibi çalıştırabilirsin.
            var ınstance= Activator.CreateInstance(type, 6, 7);
           Console.WriteLine(ınstance.GetType().GetMethod("Topla2").Invoke(ınstance,null)) ; //get methodla eğer o metod varsa ulaşabilir invoke ilede çalıştırabilirsin.
            MethodInfo methodInfo = ınstance.GetType().GetMethod("Topla2"); //metod bilgisi alabilirsin.
            Console.WriteLine(methodInfo.Invoke(ınstance, null));// ve bunu yazabilirsin.
            var metods = type.GetMethods();
            foreach (var info in metods)
            {
                Console.WriteLine(info.Name); //bu şekilde metodların adına ulaşabilirsin.
                foreach (var parameters in info.GetParameters())
                {
                    Console.WriteLine(parameters.Name); //bu şekilde metodların aldıkları parametreleri yazdırabilirsin.
                }
                foreach (var attribute in info.GetCustomAttributes())
                {
                    Console.WriteLine(attribute.GetType().Name); //bu şekilde attributeları görebilrsin.
                }
            }
             
            Console.ReadLine();
        }
    }
    class Math
    {
        private int _sayi1;
        private int _sayi2;
        public Math(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }
        public int Toplam(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }
        [MetodName("Carpma")] //çarp2 çarpma attribute una sahip. bir imzaya sahip.
        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }
    }
    public class MetodNameAttribute:Attribute
    {
        public MetodNameAttribute(string name)
        {

        }
    }
}//uygulama çalıştığı anda bir nesnenin örneğini oluşturmak isteyip çalıştırma anına ekleyebilirsin.
//çalışma anında hangi nesneyle çalışacağını bilmezsen kullanırsın. kullanıcı seçimler yapar ve o şekil ortaya çıkar.
