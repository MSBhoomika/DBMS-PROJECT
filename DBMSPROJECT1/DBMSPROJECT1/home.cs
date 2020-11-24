using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBMSPROJECT1
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            stud ss = new stud();
            this.Hide();
            ss.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            flogin of = new flogin();
            this.Hide();
            of.ShowDialog();
        }

        private void Bt1_Click(object sender, EventArgs e)
        {
            login ol = new login();
            this.Hide();
            ol.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form2 fs = new Form2();
            this.Hide();
            fs.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminlogin a = new adminlogin();
            a.ShowDialog();
        }
    }
}
