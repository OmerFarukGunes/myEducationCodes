using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient; //sql işlemlerde eklenmesi gerekiyor.
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
    public class ProductDal
    { //ilk olarak bizim datadaki verileri çekmemiz lazım
        //sql veri oluşturmak için
        //view -> sql server object explorer->databases->sağ tık->new database->tables->sağtık->new table
        //tabloya istenilen bilgileri ve değerlerini yazar update edersin.
        //tablo içini görmek için dbo.product-> sağ tık -> view yaparsın.
          SqlConnection _connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;initial catalog=ETrade;integrated security=true");
        //serveri açar yeni açmış database ismini yazar ve veritabanına erişmek için güvenilirliliği açarsın.
        //ha yok güvenlik için id ve şifre istersen security= false;uid=OmerFG;password=12345 yaparsın.
        public List<Product> GetAll()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from Products", _connection);
            SqlDataReader reader = command.ExecuteReader();

            List<Product> products = new List<Product>();
            while (reader.Read())//tabloyu okuyabildiğin sürece döngüyü devam ettir
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    StockAmount = Convert.ToInt32(reader["StockAmount"]),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"])
                };
                products.Add(product); //ürünü okuyup ürünlere ekliyor ve oradanda tabloya atıyor.
            }

              reader.Close();
            _connection.Close();
            return products;
        }

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open(); //bağlantı aç demek
            }
        }

        //bu şekildede yapılabilir. genelde tercih edilmez çünkü datatable biraz ağırdır. pahallıdır. 
     /*   public DataTable GetAll2()
        {
          
          
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open(); //bağlantı aç demek
            }
            SqlCommand command = new SqlCommand("Select * from Products", _connection);
            SqlDataReader reader = command.ExecuteReader();

            DataTable dataTable = new DataTable(); //datatable oluşturuldu
            dataTable.Load(reader); //ve bu reader ile dolduruldu.
            reader.Close();
            _connection.Close();
            return dataTable;
      }*/
        public void Add( Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Insert into Productsvalues (@Name,@unitPrice,@stockAmount)", _connection);
            command.Parameters.AddWithValue("@name",product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            try
            {
           command.ExecuteNonQuery(); //kayıt kontrolü yapar.
            }
            catch (Exception exception)
            {

                Console.WriteLine(exception.Message);
            } 
            _connection.Close();
        }
    }
}
