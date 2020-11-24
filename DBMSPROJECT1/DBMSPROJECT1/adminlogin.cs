using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMSPROJECT1
{
    public partial class adminlogin : Form
    {
        public adminlogin()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            home adl = new home();
            adl.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && (!string.IsNullOrEmpty(textBox2.Text)))
            {

                if (textBox1.Text == "admin" && textBox2.Text == "admin")
                {
                    MessageBox.Show("Login Successfull");
                    this.Hide();
                    admin al = new admin();
                    al.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Enter a valid user id and password");
                }
            }
            else
            {
                MessageBox.Show("user id and password cannot be empty");
            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
