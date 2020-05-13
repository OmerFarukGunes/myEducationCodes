using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AccesModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Customer
    {
     private int id; //default olan erişim izni private dir. başka classta kullanılmaz
        protected int iq { get; set; }//iki yazım şekli var hem private hem protecteın ikisinide ikisi gibi yazabilirsin.
        public void save()
        { 
            string name; //aynı şekilde farklı bloktada ulaşılmaz.
            iq = 10; //protected aynı blokta heryerde kullanılabilir.
        }
        public void Delete()
        {
            id = 10;
            //name e burada ulaşamazsın ama int bunların üzerinde kapsayıcı olduğundan
            //ulaşabilirsin
            iq = 10; 
        }
    }
    class Student:Customer //referans sağlasan bile private e ulaşamazsın
    {
        public void save()
        {
            Customer customer = new Customer();
            iq = 20; //ama referans varsa protecteda ulaşılabilir.
        }
    }
    internal class Course //default internaldır. yazmak bişi değiştirmez.
    {//referans ihtiyacı duymadan kullanabilirsin içindekileri.
        public string name { get; set; }
        //coursemanager sınıfındaki örnek gibi.
    }
    public class Course2
    {
        public string name { get; set; }
    }

    //private en az özellikli protected sonrası internal bir sonrasıdır.
}//internal o proje içerisinde istenen noktada çağırılabilir demektir.<
//bir class ya internal yada publictir.
//iç içe classlarda private olabilir.
//public en kapsamlı olandır. farklı bir projede dahii kullanılabilir.
//accesmodifiersdemodaki gibidir