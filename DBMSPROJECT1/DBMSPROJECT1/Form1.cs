using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace DBMSPROJECT1
{
    public partial class stud : Form
    {
        public stud()
        {
            InitializeComponent();
        }

        

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        public void ConnectString()
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=ORCL;User Id=bms;Password=bmscecse;";
            string sql = "SELECT * FROM student";
            OleDbConnection connection = new OleDbConnection(connetionString);
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            string MatchNumberPattern = "^.*(?=.{6,})(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=]).*$";
            if (!string.IsNullOrEmpty(pass.Text))
            {
                if (!Regex.IsMatch(pass.Text, MatchNumberPattern))
                {
                    MessageBox.Show("Password is not valid");
                }

                else
                {

                    string sql1 = "Insert into student VALUES ('" + usn.Text + "', '" + name.Text + "', '" + dob.Text + "', '" + mobile.Text + "','" + cat.Text + "','" + dept.Text + "','" + ban.Text + "','" + email.Text + "','" + pass.Text + "')";
                    dataadapter.InsertCommand = new OleDbCommand(sql1, connection);
                    dataadapter.InsertCommand.ExecuteNonQuery();


                    connection.Close();

                    home hs = new home();
                    this.Hide();
                    hs.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Please enter Password");
            }


        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
            //ConnectString();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void mobile_TextChanged(object sender, EventArgs e)
        {


        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            home hs = new home();
            this.Hide();
            hs.ShowDialog();
        }
    }
}
