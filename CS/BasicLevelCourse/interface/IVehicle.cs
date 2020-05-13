using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    public interface IVehicle //başa I yazmak evrenseldir.
{
    void Run();
    void Stop();
    void Move(int speed);
    void Brake();
    int GasLevel();
         //yukarıdaki bütün özellikler oyunumuzdaki tüm araçlar için standar halini alacaktır.
}
}
