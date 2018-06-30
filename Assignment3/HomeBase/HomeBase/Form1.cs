using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeBase
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\Administrator\\Desktop\\New folder\\HomeBase\\HomeBase\\agileassignment3.mdf;Integrated Security = True");

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agileassignment3DataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.agileassignment3DataSet.Table);

        }

        private void clear_Click(object sender, EventArgs e)
        {
            jobDescriptionBox.Clear();
            jobDateBox.Refresh();
            JobLocationBox.Clear();
            jobTimeBox.Clear();
            jobPriorityBox.Refresh();
        }
        public void diaplay_data()
        {
            //opens sql connection
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [job]";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            data.Fill(dt);
            jobDataGridView1.DataSource = dt;
            con.Close();
        }
        private void save_Click(object sender, EventArgs e)
        {
            //checks if boxes are not empty
            if (jobDescriptionBox.Text != "" & JobLocationBox.Text != "" & jobTimeBox.Text != "")
            {
                //opens sql connection
                con.Open();
                //puts the input data into a readable sql query
                string query = "Insert into job (Description,Location,Date,Time,Priority) Values('" + jobDescriptionBox.Text + "','" + JobLocationBox.Text + "','" + jobDateBox.Text + "','" + jobTimeBox.Text + "','" + jobPriorityBox.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                //displays that data has been saved
                MessageBox.Show("Data is successful saved");
                //clears the input fields
                jobDescriptionBox.Clear();
                jobDateBox.Refresh();
                JobLocationBox.Clear();
                jobTimeBox.Clear();
                jobPriorityBox.ResetText();
                diaplay_data();
            }
        }
        //don't delete it breaks. damm auto generate
        private void jobLbl_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

