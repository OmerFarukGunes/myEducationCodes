using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    public abstract class Animal //abstract metod kullanmicaksan onu yazmana gerek yok.
    {
        public int weight;
        public int length;
        public string name;
        public int energy;
        public string getProperties()
        {
            return string.Format("Name: {0} Lenght:{1} Weight: {2}", name, length, weight);
        }
        public abstract void Move(); //bu fonkun içine birşey yazamazsın boş olur. ve bunu kalıtım yaptığın tüm klasslar ezmek zorundadır.
        //bunu classlar derlemeledir.
        public virtual void sleep() //bunu kullanmak zorunda değilsindir diğer classlar isterse kullanır.
        {
            energy += 5;
        }
   
    }
}
