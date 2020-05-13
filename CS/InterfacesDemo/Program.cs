using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    class Program
    {
        //şirkette çeşitli rütbeden çalışanlar var. 3 sınıf.
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3] {
                new Manager(),
                new Worker(),
                new Robot()
            };
            foreach (var Worker in workers)
            {
                Worker.work();
            }
            IEat[] eats = new IEat[2]
            {
                new Manager(),
                new Worker(),
            };
        }
    }
    interface IWorker
    {
        void work(); //günde kaç saat vs vs çalışma diye devam ettirebilirsin.
    }
    interface IEat
    {
        void Eat(); //kaç öğün limit ne vs ekleyebilirsin 
    }
    interface ISalary
    {
        void GetSalary(); //primler vs ekleyebilirsin.
    }
    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void work()
        {
            throw new NotImplementedException();
        }
    }
    class Worker : ISalary, IEat,IWorker
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void work()
        {
            throw new NotImplementedException();
        }
    }
    class Robot : IWorker
    {
        public void work()
        {
            throw new NotImplementedException();
        }
    }
}
