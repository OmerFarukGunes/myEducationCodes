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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\OmerFG\Documents\EMaarifDb.mdf;Integrated Security=True;Connect Timeout=30");
        public static string UserName = "";
        

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from UserTbl where UserName= '" + UserNameInpt.Text + "' and UserPassword='" + PasswordInpt.Text + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                UserName = UserNameInpt.Text;
                Books obj = new Books();
                obj.Show();
                this.Hide();

                Con.Close();

            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız");
            }
            Con.Close();
        }
        private void ShutDownLbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
