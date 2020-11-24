using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMSPROJECT1
{
    public partial class FacultyProfile : Form
    {
        public FacultyProfile()
        {
            InitializeComponent();
        }

        private void FacultyProfile_Load(object sender, EventArgs e)
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=ORCL;User Id=bms;Password=bmscecse;";
            string sql = "SELECT * FROM Project where Faculty_id='"+flogin.fd+"'";
            OleDbConnection connection = new OleDbConnection(connetionString);
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            DataSet ds = new DataSet();

            string sql1 = "SELECT * FROM Faculty where Faculty_id='"+flogin.fd+"'";
            OleDbDataAdapter da = new OleDbDataAdapter(sql1, connection);
            DataTable dt = new DataTable();
            
            connection.Open();
            dataadapter.Fill(ds, "Project");
            da.Fill(dt);
            connection.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Project";
            int i = 0;
            string[] Label = new string[8];
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
            label4.Text = Label[2];
            label5.Text = Label[3];
            label6.Text = Label[4];


        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            home h2 = new home();
            this.Hide();
            h2.ShowDialog();
        }
    }
}
