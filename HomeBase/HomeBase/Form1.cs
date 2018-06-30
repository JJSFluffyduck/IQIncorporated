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
        //SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\Administrator\\Desktop\\New folder\\HomeBase\\HomeBase\\agileassignment3.mdf;Integrated Security = True");
        
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
            descriptionbox.Clear();
            datebox.Refresh();
            locationbox.Clear();
            timebox.Clear();
            prioritybox.Refresh();
        }
        public void diaplay_data()
        {

            /*con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [job]";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            data.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();*/
        }
        private void save_Click(object sender, EventArgs e)
        {
            Client clientTable = new Client();

            clientTable.AddClient("Jack Hall", "1 adelaide road", "82838383", "0443434323", "ha11", "haljy021@mymail.unisa.edu.au");
            System.Diagnostics.Debug.WriteLine(clientTable.GetClient("haljy021@mymail.unisa.edu.au").Email);

            Contractor contractorTable = new Contractor();

            contractorTable.AddContractor("Hall Jack", "90 Vic road", "83749785", "047294343", "01", "Jack@mymail.unisa.edu.au");
            System.Diagnostics.Debug.WriteLine(contractorTable.GetContractor("Jack@mymail.unisa.edu.au").Email);

            Job jobTable = new Job();

            jobTable.AddJob(clientTable.GetClient("haljy021@mymail.unisa.edu.au").ID, contractorTable.GetContractor("Jack@mymail.unisa.edu.au").ID, "FIx computer", "7 Melbourne street", DateTime.Now, true);
            System.Diagnostics.Debug.WriteLine(jobTable.GetJob(clientTable.GetClient("haljy021@mymail.unisa.edu.au").ID, contractorTable.GetContractor("Jack@mymail.unisa.edu.au").ID).Description);
            System.Diagnostics.Debug.WriteLine(jobTable.GetJob(clientTable.GetClient("haljy021@mymail.unisa.edu.au").ID, contractorTable.GetContractor("Jack@mymail.unisa.edu.au").ID).ClientID);
            System.Diagnostics.Debug.WriteLine(jobTable.GetJob(clientTable.GetClient("haljy021@mymail.unisa.edu.au").ID, contractorTable.GetContractor("Jack@mymail.unisa.edu.au").ID).ContractorID);

            if (descriptionbox.Text != "" & locationbox.Text != "" & timebox.Text != "")
            {
                //to do
                //Insert into database
                
                /*con.Open();
                string query = "Insert into job (Description,Location,Date,Time,Priority) Values('" + descriptionbox.Text + "','" + locationbox.Text + "','" + datebox.Text + "','" + timebox.Text + "','" + prioritybox.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data is successful saved");
                descriptionbox.Clear();
                datebox.Refresh();
                locationbox.Clear();
                timebox.Clear();
                prioritybox.ResetText();
                diaplay_data();*/
            } 
        }
    }
}
