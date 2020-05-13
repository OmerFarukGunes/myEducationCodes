using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //  InterfacesIntro();
            //İnterfaceyidew aynı şekilde sağ tarafta ınteface ye sağ tık yapıp ekle kısmından class ve arabirim seçerek mainde 
            //kod karmaşasını önlicek şekilde yeni bir pencere açabilirsin aynı ıcustomerdal gibi
            //NTERFACES2();
            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new SqlServerCustomerDal(),
                new OracleServerCustomerDal(),
            };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
            Console.ReadLine();
        }

        private static void NTERFACES2()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.add(new SqlServerCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            manager.Add(new Customer { Id = 1, Name = "Omer", Address = "Mardin" }); //person managerda ıperson dediğimizden kaynaklı oradan customera veya studenta bağlayabilirsin.
        }
    }
    interface IPerson //interface i yazdıysan classlar içerisinde bunları tanımlaman lazım
    {
        int Id { get; set; }
        string Name { get; set; }
    }

    internal class Customer : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
    class student:IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Departmant { get; set; }
    }
    class Worker : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Salary { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person) //ıperson yerine customer veya studentta yazabilir direk oraya erişebilirdin böyle yapınca ikisine bağlantı yapabilirsin.
        {  
            Console.WriteLine(person.Name);
        }
    }
}
