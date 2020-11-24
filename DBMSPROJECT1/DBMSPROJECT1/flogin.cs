using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Text.RegularExpressions;

namespace DBMSPROJECT1
{
    public partial class flogin : Form
    {
        public static string fd = "";
        public flogin()
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter user-id")
            {
                textBox1.Text = "";
               
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "Enter password")
            {
                textBox2.Text = "";
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Enter password";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Enter user-id";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=ORCL;User Id=bms;Password=bmscecse;";
            OleDbConnection connection = new OleDbConnection(connetionString);
            connection.Open();

            string sql_search = "select count(*) from faculty where faculty_id='" + textBox1.Text + "'and password='" + textBox2.Text + "'";
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql_search, connection);
            fd = textBox1.Text;
            DataTable dt = new DataTable();
            dataadapter.Fill(dt);
            string MatchNumberPattern = "^.*(?=.{6,})(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=]).*$";
            if (!string.IsNullOrEmpty(textBox2.Text))
            {
                if (!Regex.IsMatch(textBox2.Text, MatchNumberPattern))
                {
                    MessageBox.Show("Password is not valid");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Password");
            }

            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Login Successfull");
                FacultyProfile obj1 = new FacultyProfile();
                this.Hide();
                obj1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Enter a valid user id and password");
            }

            connection.Close();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            home hs = new home();
            this.Hide();
            hs.ShowDialog();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

            
        }
    }
}
