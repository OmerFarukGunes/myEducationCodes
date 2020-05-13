using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Product HDD = new Product(50);
            HDD.ProductName = "Hard Disk";
            Product GSM = new Product(50);
            GSM.StockControlEvent += GSM_StockControlEvent;
            for (int i = 0; i < 10; i++)
            {
                HDD.Sell(10);
                GSM.Sell(10);
                Console.ReadLine();
            }
            Console.ReadLine();
        }        private static void GSM_StockControlEvent() //bu şekilde gsm aboneliği oluşturup azaldığı zaman ekrana uyarı verdik.
            //Sadece bu kod parçacıığı ve yukarıdaki gsm stockcontrolevet += gsm_ ... diye giden kodu yazman kontolü yapmanı sağlar.
        {
            Console.WriteLine("GSM is about finished");
    }
    }

}
