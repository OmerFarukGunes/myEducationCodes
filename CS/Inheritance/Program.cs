using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer{Name="Engin" },
                new Student{Name="omer"},
                new Person{Name="Salih" }
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.Name);
            }
            Console.ReadLine();
        }
    }
    interface IPerson
    {

    }
    class Person
    {
        public int id  { get; set; }
        public string Name { get; set; }
    }
    class Customer:Person,IPerson// customer personun çocuğudur. ve ebeveynindeki özellikler dışında kendi özellikleride vardır.
    { //her class için bir ebeveyn evet ama o ebeveyni yazdıktan sonra interface kullanabilirsin istediğin kadar.
        public string City { get; set; }     
    }
    class Student : Person// customer personun çocuğudur. ve ebeveynindeki özellikler dışında kendi özellikleride vardır.
    { //bir classa bir ebeveyn(class) yazılır maksimum.
        public string Department { get; set; }
    }
}
//interface ile inheritance birbirine çok benzer ama
//grupların birbirinden bağımsız ama bir o kadarda ortak çok yönü varsa
//interface.
//ama misal herkesin ortak yönü belli ve kendisine özgü yönleri varsa inheritance
