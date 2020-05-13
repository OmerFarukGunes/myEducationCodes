using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//yapmak istediğimiz işlemleri gruplar üzerinden yapmak gruplara ayırmak onlara rahatça aerişmek içindir
namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(); //claslarda isimlendirme ilk harf küçük ikinci baş harf büyük olur !!
            customerManager.add();
            customerManager.Update();
            Customer customer = new Customer();
            customer.City = "Mardin";
            customer.Id = 1;
            customer.Name = "Omer"; 
            Customer customer2 = new Customer
            {
                Id = 2,
                City = "Istanbul",
                Name = "Faruk"
            };
            Console.WriteLine(customer2.Name);
            Console.WriteLine(customer.Name);
            Console.ReadLine();
        }
        //projenin içerisine sağda class a sağ tıkla ekle de ve sınıf ekle kısmına yaz böylece proje içerisinde main code dışında
        //sınıf açmış olur ve kullanabilirsin böylece mainde karmaşıklıktan kurtulursun.
        //istersen customer manageri aynı şekilde tam olarak buradan sonrasına yapıştırp kullanabilirsin.
       class Customer
        {
            public int Id { get; set; } //neden böyle tanımladık ? public string Name neden yapmadık.  çünkü bu fielddir.
            public string Name { get; set; } //bunlar property dir.
           public string City { get; set; }// bunların kullanımı açılım yaptığın zaman setten öcne girilen kelimeye o açılımlarla ekleme yapabilir öyle get alabilir.
    }
        }

    }

