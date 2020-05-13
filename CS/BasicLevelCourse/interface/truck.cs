using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    class truck : IVehicle //IVehicle üzerine gel alt tab enter enter yap aşağıdakileri direk doldurur.
    {
        public void Brake()
        {
            throw new NotImplementedException();
        }

        public int GasLevel()
        {
            throw new NotImplementedException();
        }

        public void Move(int speed)
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
