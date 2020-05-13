using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class  Animal
    {
        public Animal()
        {
            Console.WriteLine("constructor");
        }

        public int weight;
        public int age;
        public string name;
        public string getAnimalProperties()
        {
            // return "weight: " + weight + "name: " + name + "age " + age;
            return string.Format("weight: {0} Name:{1} Age : {2}", weight, name, age);//bu şekilde gönderebilirsin. 
        }
  
    }
}
