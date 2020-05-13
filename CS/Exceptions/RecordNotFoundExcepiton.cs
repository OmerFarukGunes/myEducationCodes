using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class RecordNotFoundExcepiton:Exception
    {
        public RecordNotFoundExcepiton(string message):base(message)
        {
                
        }
    }
}
