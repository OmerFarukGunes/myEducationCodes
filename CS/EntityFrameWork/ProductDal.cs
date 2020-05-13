using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork
{
   public class ProductDal
    {
      public List<Product> GetAll()
        {
            using (ETradeContext context = new ETradeContext())//etradecontext bellek için pahallı bir nesene bu bağlamda bu tip nesneleri 
                                                               //metod bittiği zaman bellekten atmaya başlar bu şekilde kullanmanın avantajı olarak söylenir.
                                                               //using kullanınca işi biter bitmez direk olarak bellekten atmakla uğraşır.
            {
                return  context.products.ToList();
            }
        }
        public void Add(Product product)
        {
            using (ETradeContext context = new ETradeContext()) {

                context.products.Add(product);
                context.SaveChanges();
            }
        }
    }
}
