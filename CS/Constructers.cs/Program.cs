using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructers.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(10);//10 counta eşit olur.
            customerManager.list();
            Product product = new Product { id = 1, name = "Laptop" };
            Product product2 = new Product();
            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLoger());
            employeeManager.Add();  
            //     employeeManager.Logger = new DatabaseLoger();
            //   employeeManager.Add(); istersen bu şekilde yapar ve database e eklenmişçesine yada database yerine file yazar file a eklenmişçesine 
            //gösterir ve kodu yazabilirsin.
            // ancak daha stabil bir şekilde bunu yapabilirsin. aşağı classın içerisinde sana gösterildiği gibi yazar (aşağıs)
            //ve employeemanager parantez içerisine göndereceğin logger türünü yazarsın.
          
            PersonManager personManager = new PersonManager("love");
            personManager.Add();
            Teacher.number = 10;
            Utilities.Validate();
            Manager.DoSomething();
            Manager manager = new Manager();
            manager.DoSomething2();

            Console.ReadLine();
        }
    }
    class CustomerManager
    {
        private int _count; //private bir field _ kullanılı başında
        public CustomerManager(int count)
        {
            //ctor yaz ve iki kez taba bas.
            _count = count;
        }
        /* parametresiz verirsin ve yukarıya 10 yazmaz direk _countu 15 e eşitlersende aynı sonucu alırsın
        public CustomerManager()
        {
        yeterki constructor içindeki veriler ve tipler sıralı olsun.
        } */
        public void list()
        {
            Console.WriteLine("Listed {0} items",_count);
        }
        public void add()
        {
            Console.WriteLine("Added");

        }
      
    }  class Product
        {
        public Product()
        {

        }
        private int _id;
        private string _name;

            public Product (int id,string name)
            {
            _id = id;
            _name = name;
            }
        //bu şekilde hem parametreleri göndererek hemde en başta tanımlayarak kullanırsın.
        public int id { get; set; }
        public string name { get; set; }
        }
    interface ILogger
    {
        void log();
    }
    class DatabaseLoger: ILogger
    {
 public void log()
    {
            Console.WriteLine("Logging to Database");
    }
    }
    class FileLogger:ILogger
    {
        public void log()
        {
            Console.WriteLine("Logging to File");
        }
    }
    class EmployeeManager
    {
        public ILogger Logger { get; set; }
        // aşağısı
        private ILogger _Logger;
        public EmployeeManager(ILogger logger)
        {
            _Logger = logger;
        }
        public void Add()
        {

         //Logger.log();
            //aşağısı
            _Logger.log();
            Console.WriteLine("Added");
        }
    }
    class BaseClass
    {
        private string _entity;
        public BaseClass(string entity)
        {
            _entity = entity;
        }
        public void message()
        {
            Console.WriteLine("{0} message", _entity);
        }
    }
    class PersonManager:BaseClass
    {
        public PersonManager(string entity):base(entity)//bu şekilde constructorlar arası parametreleri alabilir aracılık yapabilirsin
        {

        }
        public void Add()
        {
            Console.WriteLine("Added!");
            message();//inherit yaptığından kaynaklı baseclassı buradan çağırabilirisnb
        }
    }
    static class Teacher //static olan classlarda techer teacher= new teacher yazamazsın.
    {
       static public int number { get; set; } //her tanıma static koymalısın.
  //bu herkeste aynı sonucu verir. herkes aynı değeri görür bir sayfada değişirse diğer sayfalardada değişir.
  //herkes tarafından kullanılan ortak kullanılan nesnelerdir.
  //biri değişirse diğerindende değişmesini istersen kullanırsın..
    }
    static class Utilities //isim evrenseldir //sabit değer demektir
    {
        public static void Validate() //validate sabit söylenen şeryler min 6 haneli şifre lazım
        {
            Console.WriteLine("Validation is done");
        }
    }
    class Manager
    {
        //sadece classı değil özelliklerinide static yapabilirsin.
        public static void DoSomething()
        {
            Console.WriteLine("DONE");
        }
        public  void DoSomething2()
        {
            Console.WriteLine("DONE2");
        }
    }
}
