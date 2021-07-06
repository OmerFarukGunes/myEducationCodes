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
    public partial class Borrower : Form
    {
        public Borrower()
        {
            InitializeComponent();
            Populate();
        }
        SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\OmerFG\Documents\EMaarifDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void Populate()
        {
            sql.Open();
            string query = "select * from BorrowerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, sql);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BorrowerDGV.DataSource = ds.Tables[0];
            sql.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (UserNameInpt.Text == "" || PhoneInpt.Text == "" || EmailInpt.Text == "" || TCInpt.Text == "" || AddressInpt.Text == "" || UserSurnameInpt.Text == "")
            {
                MessageBox.Show("Eksik Girdi");
            }
            else
            {
                try
                {
                    sql.Open();
                    string query = "insert into BorrowerTbl values('" + UserNameInpt.Text + "','" + UserSurnameInpt.Text + "','" + AddressInpt.Text + "','" + PhoneInpt.Text + "','" + EmailInpt.Text + "','" + TCInpt.Text  + "','" + Ogrenci.Checked + "')";
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
            EmailInpt.Text = "";
            TCInpt.Text = "";
            AddressInpt.Text = "";
            UserSurnameInpt.Text = "";
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();

        }
        int key = 0;
        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (UserNameInpt.Text == "" || PhoneInpt.Text == "" || EmailInpt.Text == "" || TCInpt.Text == "" || AddressInpt.Text == "" || UserSurnameInpt.Text == "")
            {
                MessageBox.Show("Eksik Girdi");
            }
            else
            {
                try
                {
                    sql.Open();
                    string query = "update BorrowerTbl set BorrowerName ='" + UserNameInpt.Text + "',BorrowerPhone='" + PhoneInpt.Text + "',BorrowerSeriNo='" + TCInpt.Text + "',BorrowerIsStudent='" + Ogrenci.Checked + "',BorrowerAddress='" + AddressInpt.Text + "',BorrowerEmail='" + EmailInpt.Text + "',BorrowerSurname='" + UserSurnameInpt.Text + "'where BorrowerID=" + key + "";
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

        private void BorrowerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UserNameInpt.Text = BorrowerDGV.SelectedRows[0].Cells[1].Value.ToString();
            UserSurnameInpt.Text = BorrowerDGV.SelectedRows[0].Cells[2].Value.ToString();
            EmailInpt.Text = BorrowerDGV.SelectedRows[0].Cells[3].Value.ToString();
            PhoneInpt.Text = BorrowerDGV.SelectedRows[0].Cells[4].Value.ToString();
            EmailInpt.Text = BorrowerDGV.SelectedRows[0].Cells[5].Value.ToString();
            TCInpt.Text = BorrowerDGV.SelectedRows[0].Cells[6].Value.ToString();
            Ogrenci.Checked = (bool)BorrowerDGV.SelectedRows[0].Cells[7].Value;
            if (UserNameInpt.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(BorrowerDGV.SelectedRows[0].Cells[0].Value.ToString());
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
                    string query = "delete from BorrowerTbl where BorrowerID ='" + key + "'";
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

        private void ExitLbl_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

    }
}
