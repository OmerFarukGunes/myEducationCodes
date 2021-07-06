using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaarifKutuphane.Forms
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\OmerFG\Documents\EMaarifDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void ShutDownLbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BooksLb_Click(object sender, EventArgs e)
        {
            Books obj = new Books();
            obj.Show();
            this.Hide();
        }
        private void UsersLbl_Click(object sender, EventArgs e)
        {
            Employee obj = new Employee();
            obj.Show();
            this.Hide();

        }
        private void ExitLbl_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            sql.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select sum(BookQuantity) from BookTbl", sql);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BookStockCountTB.Text = dt.Rows[0][0].ToString();
            SqlDataAdapter sda1 = new SqlDataAdapter("select sum(Amount) from BillTbl", sql);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            BillCountTB.Text = dt1.Rows[0][0].ToString();
            SqlDataAdapter sda2 = new SqlDataAdapter("select Count(*) from UserTbl", sql);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            EmployeeCountTB.Text = dt2.Rows[0][0].ToString();
            sql.Close();
        }
    }
}
