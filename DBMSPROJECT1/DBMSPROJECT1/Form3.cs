using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DBMSPROJECT1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=ORCL;User Id=bms;Password=bmscecse;";
            string sql = "SELECT * FROM project";
            OleDbConnection connection = new OleDbConnection(connetionString);
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();

            string sql1 = "Insert into project VALUES ('" + pid.Text + "', '" + title.Text + "', '" + dur.Text + "', '" + mcost.Text + "','" + lcost.Text + "','" + oc.Text + "','" + ml.Text + "','" + imp.Text + "','" + usn.Text + "','" + fid.Text + "')";
            dataadapter.InsertCommand = new OleDbCommand(sql1, connection);
            dataadapter.InsertCommand.ExecuteNonQuery();
            
            connection.Close();
            this.Hide();
            

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }
    }
}
