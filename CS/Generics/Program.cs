using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>( "Ankara","Adana","Afyon");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            List<Customer> result2 = utilities.BuildList<Customer>(new Customer { Name="Engin"}, new Customer { Name="Derin" });
            foreach (var item in result2) //t türündeki değişkene hem customer hemde bir linked list stringi gönderebildik.
            {
                Console.WriteLine(result2);
            }
            
            Console.ReadLine();
        }
    }
    class Utilities
    {
        public List<T>BuildList<T>(params T[] items) //T türündeki T değerirlerini birden fazla parametre ile al item oarak kaydet.
        {
            return new List<T>(items);
        }
    }
    class Product:IEntity
    {

    }
    interface IProductDal:IRepository<Product>//bu şekilde o interface e asıl değişkenini atarsın 
    {
      /*  List<Product> GetAll();
        Product Get(int id);
        void add(Product product);
        void delete(Product product);
        void upda(Product product); */
    }
    class Customer:IEntity

    {
        public string Name { get; set; }
    }
    interface ICustomerDal:IRepository<Customer>
    {
        /* List<Customer> GetAll();
         Customer Get(int id);
         void add(Customer product); 
         void delete(Customer product);
         void upda(Customer product); */
        void custom(); //custom değerin olabilir.
    } //bu denli her defasında değişken adını tek değiştirererk aynı şeyleri yazmak zorunda kalmayalım
    interface IRepository<T> where T:class,IEntity,new() //büyük harfle istediğini yazabilirsin. //t yi istersen eğer referans tip olarak ayarlayabilirsin. bu şekilde int gönderemezsin. float gönderemezsin vs vs.
    { //hem referansı var hemde newlenebilir bir değer olmalıdır. istersen yaparsın.
        //t ientityden impelemnte edilmeli.
        //bu şekilde sadece ve sadece class olarak gönderilebilir t ye. new her daim en sona yazılmalı.
        //struct değer tiplere karşı gelir.
        List<T> GetAll();
        T Get(int id);
        void add(T product);
        void delete(T product);
        void update(T product);
    }
    interface IStudentDal : IRepository<Student> 
    {

    }
class Student:IEntity
{

}
interface IEntity
{

}
    
    class ProductDal : IEntity
    {
        public void add(Product product)
        {
            throw new NotImplementedException();
        }

        public void delete(Product product)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void upda(Product product)
        {
            throw new NotImplementedException();
        }
    }
    class CustomerDal : IEntity
    {
        public void add(Customer product)
        {
            throw new NotImplementedException();
        }

        public void custom() //custom değerin sadece buraya gelir.
        {
            throw new NotImplementedException();
        }

        public void delete(Customer product)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void upda(Customer product)
        {
            throw new NotImplementedException();
        }
    }
}
