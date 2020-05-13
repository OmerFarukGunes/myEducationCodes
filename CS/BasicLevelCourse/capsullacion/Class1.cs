using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capsullacion
{
    public class Rectange
    {

        private int _a;
        private int _b;
        public int a {
            get { return _a; }
            set { if(value < 0)
                {
                    _a = 0;
                }
                else { _a = value;}
                
            }
        } //prop yaz iki kez taba bas.
        public int b {
            get { return _b; }
            set
            {
                if (value < 0)
                {
                    _b = 0;
                }
                else
                {
                     _b=value;
                }
            }
        }
        public int calculateArea()
        {
            return a * b;
        }
    }
}
