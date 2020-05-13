using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, Name = "Engin", age = 32 };
            CustomerDal customerDal = new CustomerDal();
            customerDal.AddNew(customer); //bunu .add yaparsan kullanılmaması öngörüldüğünü söyler sana
            Console.WriteLine(customerDal);
        } 
    }
    [ToTable("Customers")]
    class Customer
    {
        public int Id { get; set; }
        [RequiredProperty]
        public string Name { get; set; }
        [RequiredProperty]
        public string LName { get; set; }
        [RequiredProperty]
        public int age { get; set; }
    }
    class CustomerDal
    {
        [Obsolete("Dont use add, instead use addnew method")]//bu uyarmaktır aşağıdakini kullanma bir alttaki yeni methoddur onu kullan diye. hazır metottur.
        public void Add(Customer customer)
        {
            Console.WriteLine("{0}, {1},{2},{3} added",
                customer.Id, customer.Name,customer.LName, customer.age);
        }
        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0}, {1},{2},{3} added",
                customer.Id, customer.Name, customer.LName, customer.age);
        }

    }
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]//bu attribte ı herşeye kullanabailirsin. .allı class vs değişebilirsin yada all yaar herşeye uyar.
    class RequiredPropertyAttribute:Attribute
    {

    } //buda requiredpropertyi sisteme tanımlamak.
    [AttributeUsage(AttributeTargets.Class,AllowMultiple =true )]//multiple birden fala bu atrtribute ı kullanabilirsin demek.
    class ToTableAttribute : Attribute
    {
      private  string _tableName;
        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        } //buranın amacı totable ı tanımlamak
    }
    //amaç istenilen özelliklerin boş bırakılmamasını her daim onun girilmesini sağlamak.
}
