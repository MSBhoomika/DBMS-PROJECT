using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMSPROJECT1
{
    public partial class Spro: Form
    {
        public Spro()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=ORCL;User Id=bms;Password=bmscecse;";
            string sql = "SELECT * FROM Project where usn='"+login.uid+"'";
            OleDbConnection connection = new OleDbConnection(connetionString);
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            string sql1 = "Select * from Student where usn='"+login.uid+"'";
            OleDbDataAdapter da = new OleDbDataAdapter(sql1, connection);
            DataTable dt = new DataTable();
            connection.Open();
            dataadapter.Fill(ds,"Project");
            da.Fill(dt);
            


            connection.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Project";
            int i = 0;
            string[] Label=new string[9];
            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn column in dt.Columns)
                {
                    
                    Label[i] = row[column].ToString();
                    i++;
                }
            }
            label2.Text = Label[0];
            label3.Text = Label[1];
            //label4.Text = 
            label5.Text = Label[3];
            //label6.Text = 
            label7.Text = Label[5];
            label8.Text = Label[6];
            label9.Text = Label[7];

    


        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            home h1 = new home();
            this.Hide();
            h1.ShowDialog();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form3 ob = new Form3();
            
            ob.ShowDialog();
        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
