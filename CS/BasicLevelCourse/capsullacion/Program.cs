using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capsullacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectange rectange = new Rectange();
            rectange.a = 4;
            rectange.b = 3;
            Console.WriteLine(rectange.calculateArea());
        }
    }
}
