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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
            Populate();
        }
        SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\OmerFG\Documents\EMaarifDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void Populate()
        {
            sql.Open();
            string query = "select * from UserTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, sql);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            EmployeeDGV.DataSource = ds.Tables[0];
            sql.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (UserNameInpt.Text == "" || PhoneInpt.Text == "" || AddressInpt.Text == "" || PasswordInpt.Text == "")
            {
                MessageBox.Show("Eksik Girdi");
            }
            else
            {
                try
                {
                    sql.Open();
                    string query = "insert into UserTbl values('" + UserNameInpt.Text + "','" + PhoneInpt.Text + "','" + AddressInpt.Text + "','" + PasswordInpt.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, sql);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kullanici Eklendi");
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
        private void Reset()
        {
            UserNameInpt.Text = "";
            PhoneInpt.Text = "";
            AddressInpt.Text = "";
            PasswordInpt.Text = "";
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();

        }
        int key = 0;
        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (UserNameInpt.Text == "" || PhoneInpt.Text == "" || AddressInpt.Text == "" || PasswordInpt.Text == "")
            {
                MessageBox.Show("Eksik Girdi");
            }
            else
            {
                try
                {
                    sql.Open();
                    string query = "update UserTbl set UserName ='" + UserNameInpt.Text + "',UserPhone='" + PhoneInpt.Text + "',UserAddress='" + AddressInpt.Text + "',UserPassword='" + PasswordInpt.Text + "'where UserID=" + key + "";
                    SqlCommand cmd = new SqlCommand(query, sql);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kullanici Guncellendi");
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

        private void UserDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UserNameInpt.Text = EmployeeDGV.SelectedRows[0].Cells[1].Value.ToString();
            PhoneInpt.Text = EmployeeDGV.SelectedRows[0].Cells[2].Value.ToString();
            AddressInpt.Text = EmployeeDGV.SelectedRows[0].Cells[3].Value.ToString();
            PasswordInpt.Text = EmployeeDGV.SelectedRows[0].Cells[4].Value.ToString();
            if (UserNameInpt.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(EmployeeDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Kullanici Seciniz");
            }
            else
            {
                try
                {
                    sql.Open();
                    string query = "delete from UserTbl where UserID ='" + key + "'";
                    SqlCommand cmd = new SqlCommand(query, sql);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kullanici Silindi");
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
        private void DashBoardLb_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            obj.Show();
            this.Hide();

        }
        private void ExitLbl_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

    }
}
