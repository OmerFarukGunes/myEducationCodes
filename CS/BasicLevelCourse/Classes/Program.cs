using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Animal();
            cat.name = "pisicik";
            cat.age = 5;
            cat.weight = 5;
            Console.WriteLine(cat.getAnimalProperties());
            Animal bird = new Animal();
            bird.name = "cik";
            bird.age = 10;
            bird.weight = 1;
            Console.WriteLine(bird.getAnimalProperties());
        }
    }
}
