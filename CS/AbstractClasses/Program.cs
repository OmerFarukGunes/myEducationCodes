using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new Oracle();
            database.add();
            database.Delete();
            Database database2 = new SqlServer();
            database2.add();
            database2.Delete();
        }
    }
    abstract class Database
    {
        public void add()
        {
            Console.WriteLine("Added by Default");
        }//ekleme işlemi heryerde aynı
        public abstract void Delete(); //ama silme işlemi heryerde tamamen farklı 
    }
    class SqlServer: Database
    {
        public override void Delete()
        {//override yaz boşluk bırak ulaşmak istediğin metodu (ex: delete) seç ve kod önüne gelir.

            Console.WriteLine("Deleted by SqlServer");
        }
    }
    class Oracle: Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle");
        }
    }
}//abstrack sınıflar ise ortak bir nokta vardır ama hepsinde farklı şekilde yapılır
//bunu ayırt etmek için yapılır.
