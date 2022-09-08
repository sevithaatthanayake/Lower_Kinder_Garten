using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lower_Kinder_Garten
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime dt1 = DateTime.Now;
            DateTime dt2 = DateTime.Parse("04/20/2022");
            if (dt1.Date > dt2.Date)
            {
                MessageBox.Show("Application Expired Contact The Developer For The Update Version        077 8638332 ");
                this.Close();
            }
            else
            {
                Alphabet next = new Alphabet();
                next.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Guide next = new Guide();
            next.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime dt1 = DateTime.Now;
            DateTime dt2 = DateTime.Parse("04/20/2022");
            if (dt1.Date > dt2.Date)
            {
                MessageBox.Show("Application Expired Contact The Developer For The Update Version        077 8638332 ");
                this.Close();
            }
            else
            {
                words next = new  words();
                next.Show();
            }
        }
    }
}
