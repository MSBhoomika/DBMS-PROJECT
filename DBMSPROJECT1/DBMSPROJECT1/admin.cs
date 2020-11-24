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

namespace DBMSPROJECT1
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=ORCL;User Id=bms;Password=bmscecse;";
            OleDbConnection connection = new OleDbConnection(connetionString);
            connection.Open();
            string sql = "Select * from student ";
            string sq2 = "Select * from project ";
            string sq = "select * from faculty";
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            OleDbDataAdapter dataadapter1 = new OleDbDataAdapter(sq, connection);
            OleDbDataAdapter dataadapter2 = new OleDbDataAdapter(sq2, connection);
            DataSet ds = new DataSet();
            dataadapter.Fill(ds, "student");
            emprec.DataSource = ds;
            emprec.DataMember = "student";
            dataadapter1.Fill(ds, "faculty");
            patrec.DataSource = ds;
            patrec.DataMember = "faculty";
            dataadapter2.Fill(ds, "project");
            prorec.DataSource = ds;
            prorec.DataMember = "project";

            connection.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void sid_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=ORCL;User Id=bms;Password=bmscecse;";
            OleDbConnection connection = new OleDbConnection(connetionString);
            connection.Open();
          /*  if (sid.Text() ==null )
            {
                MessageBox.Show("Enter a Valid Info");
                Refresh();
            }
            else
            {*/
            /*    int res = int.Parse(sid.Text);
                OleDbCommand cmd1 = connection.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "Update  Patient set patient_Type='" + stat.Text + "' where Pid='" + res + "'";
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Update Successfull");
                button1_Click(sender, e);*/


                /* string sql = "Select patient_Type from Patient where pid=" + res;
                 OleDbCommand cmd = new OleDbCommand(sql, connection);
                 OleDbDataReader dr = cmd.ExecuteReader();
                 if (dr.Read())
                 {
                     if ((dr["patient_Type"].ToString()) == "In")
                     {
                         label3.Text="njaahcn";
                         // String s = "Update table Patient set patient_Type=Out where Pid=" + res;
                         OleDbCommand cmd1 = connection.CreateCommand();
                         cmd1.CommandType = CommandType.Text;
                         cmd1.CommandText = "Update  Patient set patient_Type=OUT where Pid=" + res;
                         cmd1.ExecuteNonQuery();

                     }
                     else
                     {

                         String s = "Update table patient set patient_Type=In where Pid=" + res;
                         OleDbDataAdapter dataadapter = new OleDbDataAdapter(s, connection);

                     }
                 }*/
            //}
        }

        private void stat_TextChanged(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            home f2 = new home();
            this.Hide();
            f2.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            label2.Text = "Student Record";
            button1_Click(sender, e);
            patrec.Visible = true;
            emprec.Visible = false;
            prorec.Visible = false;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            label2.Text = "Faculty Record";
            button1_Click(sender, e);
            emprec.Visible = true;
            patrec.Visible = false;
            prorec.Visible = false;
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            label2.Text = "Project Record";
            button1_Click(sender, e);
            prorec.Visible = true;
            emprec.Visible = false;
            patrec.Visible = false;
        }
    }
    }

