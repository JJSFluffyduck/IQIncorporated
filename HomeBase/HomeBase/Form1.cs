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
using System.Text.RegularExpressions;

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
            if (jobDescriptionBox.Text != "" && JobLocationBox.Text != "" && jobTimeBox.Text != "")
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
        private void clientLandLineBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //forces textbox to only allow numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void clientMobileBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //forces textbox to only allow numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void contractorLandLineBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //forces textbox to only allow numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void contractorMobileBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //forces textbox to only allow numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void clientSavebtn_Click(object sender, EventArgs e)
        {
            //TODO
            if(clientFirstNameBox.Text != "" && clientLastNameBox.Text != "" && clientAddressBox.Text != "" && 
                clientLandLineBox.Text != "" && clientMobileBox.Text != "" && clientBuisinessNameBox.Text != "" && clientEmailBox.Text != "")
            {
                bool emailVal = EmailValidator(clientEmailBox.Text);
                if(emailVal == false)
                {
                    MessageBox.Show("Please enter a valid email");
                }
            }
            else
            {
                MessageBox.Show("Please complete all fields for this section");
            }
        }

        private void clientClearBtn_Click(object sender, EventArgs e)
        {
            clientFirstNameBox.Text = "";
            clientLastNameBox.Text = "";
            clientAddressBox.Text = "";
            clientLandLineBox.Text = "";
            clientMobileBox.Text = "";
            clientBuisinessNameBox.Text = "";
            clientEmailBox.Text = "";
        }

        private void contractorSaveBtn_Click(object sender, EventArgs e)
        {
            //TODO
            if (contractorFirstNameBox.Text != "" && contractorLastNameBox.Text != "" && contractorAddressBox.Text != "" &&
                contractorLandLineBox.Text != "" && contractorMobileBox.Text != "" && contractorEmployeeIdBox.Text != "" && contractorEmailBox.Text != "")
            {
                bool emailVal = EmailValidator(contractorEmailBox.Text);
                if (emailVal == false)
                {
                    MessageBox.Show("Please enter a valid email");
                }
            }
            else
            {
                MessageBox.Show("Please complete all fields for this section");
            }
        }

        private void contractorClearBtn_Click(object sender, EventArgs e)
        {
            contractorFirstNameBox.Text = "";
            contractorLastNameBox.Text = "";
            contractorAddressBox.Text = "";
            contractorLandLineBox.Text = "";
            contractorMobileBox.Text = "";
            contractorEmployeeIdBox.Text = "";
            contractorEmailBox.Text = "";

        }


        public static Boolean EmailValidator(String email)
        {
            Regex regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            return regex.IsMatch(email);
        } 
    }
}

