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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=ORCL;User Id=bms;Password=bmscecse;";
            string sql = "SELECT * FROM faculty";
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
                    string sql1 = "Insert into faculty VALUES ('" + fid.Text + "', '" + name.Text + "', '" + mobile.Text + "', '" + dept.Text + "','" + email.Text + "','" + pass.Text + "')";
                    dataadapter.InsertCommand = new OleDbCommand(sql1, connection);
                    dataadapter.InsertCommand.ExecuteNonQuery();

                    connection.Close();
                    home hf = new home();
                    this.Hide();
                    hf.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Please enter Password");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            home hs = new home();
            this.Hide();
            hs.ShowDialog();
        }

        private void Pass_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
