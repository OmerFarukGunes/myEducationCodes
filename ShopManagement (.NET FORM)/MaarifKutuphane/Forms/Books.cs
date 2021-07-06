using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MaarifKutuphane.Forms
{
    public partial class Books : Form
    {
        public Books()
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
        private void Filter()
        {
            sql.Open();
            string query = "select * from Booktbl where BookCategory ='" + BookCategoryInpt.SelectedItem.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sql);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BookDGV.DataSource = ds.Tables[0];
            sql.Close();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (BookTittleInpt.Text == "" || BookAuthorInpt.Text == "" || BookQuantityInpt.Text == "" || BookPriceInpt.Text == "" || BookCategoryInpt.SelectedIndex == -1)
            {
                MessageBox.Show("Eksik Girdi");
            }
            else
            {
                try
                {
                    sql.Open();
                    string query = "insert into BookTbl values('" + BookTittleInpt.Text + "','" + BookAuthorInpt.Text + "','" + BookCategoryInpt.SelectedItem.ToString() + "','" + BookQuantityInpt.Text + "','" + BookPriceInpt.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, sql);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kitap Eklendi");
                    sql.Close();
                    Populate();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void CategoryFilterBtn_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Filter();
        }

        private void FilterBtn_Click(object sender, EventArgs e)
        {
            Populate();
            BookCategoryInpt.SelectedIndex = -1;
        }
        private void Reset()
        {
            BookTittleInpt.Text = "";
            BookAuthorInpt.Text = "";
            BookCategoryInpt.Text = "";
            BookPriceInpt.Text = "";
            BookQuantityInpt.Text = "";
        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();

        }
        int key = 0;
        private void BookDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BookTittleInpt.Text = BookDGV.SelectedRows[0].Cells[1].Value.ToString();
            BookAuthorInpt.Text = BookDGV.SelectedRows[0].Cells[2].Value.ToString();
            BookCategoryInpt.Text = BookDGV.SelectedRows[0].Cells[3].Value.ToString();
            BookQuantityInpt.Text = BookDGV.SelectedRows[0].Cells[4].Value.ToString();
            BookPriceInpt.Text = BookDGV.SelectedRows[0].Cells[5].Value.ToString();
            if (BookTittleInpt.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(BookDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Kitap Seciniz");
            }
            else
            {
                try
                {
                    sql.Open();
                    string query = "delete from BookTbl where BookID ='" + key + "'";
                    SqlCommand cmd = new SqlCommand(query, sql);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kitap Silindi");
                    sql.Close();
                    Populate();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (BookTittleInpt.Text == "" || BookAuthorInpt.Text == "" || BookQuantityInpt.Text == "" || BookPriceInpt.Text == "" || BookCategoryInpt.SelectedIndex == -1)
            {
                MessageBox.Show("Eksik Girdi");
            }
            else
            {
                try
                {
                    sql.Open();
                    string query = "update BookTbl set BookName ='" + BookTittleInpt.Text + "',BookAuthor='" + BookAuthorInpt.Text + "',BookCategory='" + BookCategoryInpt.SelectedItem.ToString() + "',BookQuantity=" + BookQuantityInpt.Text + ",BookPrice=" + BookPriceInpt.Text + "where BookID=" + key + "";
                    SqlCommand cmd = new SqlCommand(query, sql);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kitap Guncellendi");
                    sql.Close();
                    Populate();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }
        private void Books_Load(object sender, EventArgs e)
        {

            UserNameTB.Text = Login.UserName;
        }

        private void ExitLbl_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void UsersLb_Click(object sender, EventArgs e)
        {
            Employee obj = new Employee();
            obj.Show();
            this.Hide();
        }

        private void DashBoardLb_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            obj.Show();
            this.Hide();

        }

        private void ShutDownLbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
