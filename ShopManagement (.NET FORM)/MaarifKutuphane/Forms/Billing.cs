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
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();

            Populate();
        }
         SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\OmerFG\Documents\EMaarifDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void Populate()
        {
            sql.Open();
            string query = "select * from Booktbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, sql);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BookDGV.DataSource = ds.Tables[0];
            sql.Close();
        }
        private void UpdateBook()
        {
            int newQty = stock - Convert.ToInt32(BookQuantityInpt.Text);
            try
            {
                sql.Open();
                string query = "update BookTbl set BookQuantity=" + newQty + "where BookID=" + key + "";
                SqlCommand cmd = new SqlCommand(query, sql);
                cmd.ExecuteNonQuery();
                sql.Close();
                Populate();
                Reset();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        int n = 0,Grdtotal= 0;
        private void SaveBtn_Click(object sender, EventArgs e)
        {
           
            if(BookQuantityInpt.Text == "" || Convert.ToInt32(BookQuantityInpt.Text) > stock)
            {
                MessageBox.Show("Not Enough Stock");
            }
            else
            {
                int total = Convert.ToInt32(BookQuantityInpt.Text) * Convert.ToInt32(BookPriceInpt.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(BillDGV);
                newRow.Cells[0].Value = n;
                newRow.Cells[1].Value = BookTittleInpt.Text;
                newRow.Cells[2].Value = BookPriceInpt.Text ;
                newRow.Cells[3].Value = BookQuantityInpt.Text;
                newRow.Cells[4].Value = total;
                BillDGV.Rows.Add(newRow);
                UpdateBook();
                Grdtotal = Grdtotal + total;
             
                totalBillTB.Text = " "+ Grdtotal +"TL";
             }
        }
        int key = 0 ,stock = 0;
        private void BookDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            n= (int)BookDGV.SelectedRows[0].Cells[0].Value;
            BookTittleInpt.Text = BookDGV.SelectedRows[0].Cells[1].Value.ToString();
            BookQuantityInpt.Text = BookDGV.SelectedRows[0].Cells[4].Value.ToString();
            BookPriceInpt.Text = BookDGV.SelectedRows[0].Cells[5].Value.ToString();
            if (BookTittleInpt.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(BookDGV.SelectedRows[0].Cells[0].Value.ToString());
                stock = Convert.ToInt32(BookDGV.SelectedRows[0].Cells[4].Value.ToString());
            }
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
           
            if (ClientNameInpt.Text == "" || BookTittleInpt.Text=="")
            {
                MessageBox.Show("Kitap Seçiniz");
            }
            else
            {
                try
                {
                    sql.Open();
                    string query = "insert into BillTbl values('" + UserNameTB.Text + "','" + ClientNameInpt.Text + "'," + Grdtotal + ")";
                    SqlCommand cmd = new SqlCommand(query, sql);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Fiş Kesildi");
                    sql.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprm", 285, 600);
                if (printDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
        }

        private void ExitLb_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }
        private void ShutDown_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Billing_Load(object sender, EventArgs e)
        {
            UserNameTB.Text = Login.UserName;
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }



      
        private void Reset()
        {
            for (int i=0; i < BillDGV.Rows.Count;i++)
            {   
                stock = (int)BillDGV.Rows[i].Cells[4].Value;

                sql.Open();
                string query = "select * from Booktbl where BookId = "+ BillDGV.Rows[i].Cells[0].Value;
                SqlDataAdapter sda = new SqlDataAdapter(query, sql);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                sql.Close();
            }
            BookTittleInpt.Text = "";
            BookPriceInpt.Text = "";
            BookQuantityInpt.Text = "";
            ClientNameInpt.Text = "";
        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
