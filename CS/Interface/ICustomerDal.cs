using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete(); 
    }
    class SqlServerCustomerDal : ICustomerDal //ıcustomer üzerine gelen ampüle bas ve arabirimi ayıkla diyince aşağıdaki gibi olur kod.
    {
        public void Add()
        {
            Console.WriteLine("Sql Added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Delete");
        }

        public void Update()
        {
            Console.WriteLine("Sql Update");
        }
    }
    class OracleServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Delete");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Update");
        }
    }
    class CustomerManager
    {
        public void add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
