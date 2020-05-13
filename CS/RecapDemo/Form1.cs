using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Button[,] buttons = new Button[8,8]; //böylelikle 8 e 8 lik dama tahtası için tam buto ayarlarsın.
            int top = 0; ;
            int left = 0;
            for (int i = 0; i <=buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button(); //butonu oluştur.
                    buttons[i, j].Height = 50; //butonu boyutlandır.
                    buttons[i, j].Width = 50;
                    buttons[i, j].Left = left; //buton sol tarafı nerede olacak.
                    buttons[i, j].Top = top;//butonun üst tarafı nerede olsun.
                    left += 50;
                    if ((i+j)%2==0) //dama tahtasını siyah beyaz yapmak için bir algoritmadır.
                    {
                        buttons[i, j].BackColor = Color.Black;

                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                    this.Controls.Add(buttons[i,j]); //butonu ekrana koy.
                }
                top += 50; //ikinci satıra geçince bir alta kayacakki 8 tane yan yana dizdiği butonlar alt atla gelmesin
                left = 0; //8 tane yan yana koyduktan sonra ikinci satıra geçecek.
           
            }
    
        
          
        }
    }
}
