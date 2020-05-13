using System;
using System.Collections;
using System.Collections.Generic; //linked listlerde bunu kullanmalısın.
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // ArrayList();
            //List();

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("Computer", "Bilgisayar");
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "tablo");
            Console.WriteLine(dictionary["table"]);
            foreach (var item in dictionary)
            {
                Console.Write(item);
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }
            Console.WriteLine(dictionary.ContainsKey("glass")); //keyde glass varmı
            Console.WriteLine(dictionary.ContainsValue("kitap"));
            Console.ReadLine();

        }

        private static void List()
        {
            List<string> cities = new List<string>();//sadece ve sadece string türünden bir list oluşturmuş olursun
            cities.Add("Ankara");
            cities.Add("Adana");
            Console.WriteLine(cities.Contains("Ankara"));//içerisinde ankara varsa sonucu 1 olarak döner. contains içeriği kontrol eder.
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { Id = 1, Name = "Engin" });
            //customers.Add(new Customer { Id = 2, Name = "Arzu" });
            //bi üstteki bi alttaki gibi tanımlama yapabilirsin

            List<Customer> customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "Engin" },
                new Customer { Id = 2, Name = "Arzu" }
            };
            var count = customers.Count; //listede kaç eleman vardır öğrenirsin.
            var customer2 = new Customer
            {
                Id = 3,
                Name = "Salih"
            };
            customers.Add(customer2);
            customers.AddRange(new Customer[2]{
                new Customer { Id = 4, Name = "Omer" },
                new Customer { Id = 5, Name = "Faruk" },
            });
            // customers.Clear();  //listeyi temizler.
            Console.WriteLine(customers.Contains(new Customer { Id = 1, Name = "Engin" }));//new yapıldığından kaynaklı yeni bir referans sağlarsın ve oda listede olmaz.
            Console.WriteLine(customers.Contains(customer2));//true doner
            var index = customers.IndexOf(customer2);//listede kaçıncı sırada olduğunu söyler.
            Console.WriteLine(index);
            customers.Add(customer2);//2. kez en sona tekrar ekliyoruz ve listede iki tane oluyor. bu şekilde last indexof bunu buluyor.
            var index2 = customers.LastIndexOf(customer2);//listede Sondaki elemanının  kaçıncı sırada olduğunu söyler.
            Console.WriteLine(index2);
            customers.Insert(0, customer2);//insert nereye ne eklemek istiyorsun.
            customers.Remove(customer2);//remove bulduğu ilk değeri siler.
            customers.Remove(customer2);//bu şekilde 2. sinide silersin.
            customers.RemoveAll(c => c.Name == "Salih");//salih olanların hepsini bul ve hepsini sil demektir buda.
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Name); //sadece customer yazamazsın.
            }
            Console.WriteLine("count: {0}", count); //count 2 olacak  çünkü o zaman sayıldığında kaç eleman varsa onu gösterir.
        }

        private static void ArrayList()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");
            cities.Add(1);
            cities.Add('a');
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            cities.Add("Istanbul");

            Console.WriteLine(cities[4]);
        }
    }
    class Customer
    {
       public int Id { get; set; }
        public string Name { get; set; }
    }
} //koleksionlar misal 100 tane müşterin var ve o kadarlık dizi yeri açtın ancak yeni bir müşteri geldiğinde dizide yer kalmayacağından kodunda tıkanıklık olacaktır.
//o yüzden koleksiyonlar kullanılır.
//kısaca linked list