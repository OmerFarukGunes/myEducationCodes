using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork
{
    class ETradeContext:DbContext
    {
        public DbSet<Product> products { get;set; }
    }
}
