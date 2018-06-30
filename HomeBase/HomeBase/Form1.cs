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
            //Load data
            //to do
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

            //TODO
            if (clientFirstNameBox.Text != "" && clientLastNameBox.Text != "" && clientAddressBox.Text != "" &&
                clientLandLineBox.Text != "" && clientMobileBox.Text != "" && clientBuisinessNameBox.Text != "" && clientEmailBox.Text != "")
            {
                bool emailVal = EmailValidator(clientEmailBox.Text);
                if (emailVal == false)
                {
                    MessageBox.Show("Please enter a valid email");
                }
            }
            else
            {
                MessageBox.Show("Please complete all fields for this section");
            }

            //clears the input fields
                jobDescriptionBox.Clear();
                jobDateBox.Refresh();
                JobLocationBox.Clear();
                jobTimeBox.Clear();
                jobPriorityBox.ResetText();
                diaplay_data();
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

