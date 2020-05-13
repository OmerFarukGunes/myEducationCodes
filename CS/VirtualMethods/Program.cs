using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            MySql mySql = new MySql();
            mySql.Add();
            Console.ReadLine();
        }
    }
    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Added By Default");
        }
        public virtual void Delete()
        {
            Console.WriteLine("Deleted By Default");
        }
    }
    class SqlServer:Database
    {
        public override void Add() //virtual yazdığın yerde eğer bir ortamda farklılık gösterebileceği yere böyle kodu yazar değiştirirsin.
        { //bunu yazmak için önce override yaz boşluk at ve değişmek istediğin metodu(ex: add) seç kalan kodlar hazır gelecek.
        //süslü parantez içini istediğin gibi değiştir.
            Console.WriteLine("Added by Sql code");
            //base.Add(); 
        }
    }
    class MySql:Database
    {

    }
}//virtualmethodsun amacı classlarda bulunan bir özelliği ezip yerine
//farklı birşeyi getirmektir.
//inheritance tek ortak yönlü çoklu gruplar.
//interface çoklu gruplar içerisinde az ortak yönlerde kullanılır
