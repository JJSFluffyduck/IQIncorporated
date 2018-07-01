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
using LiteDB;

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
            jobClientEmailBox.Clear();
            jobContractorEmailBox.Clear();
            jobDescriptionBox.Clear();
            jobDateBox.Refresh();
            JobLocationBox.Clear();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if(jobClientEmailBox.Text != "" && jobContractorEmailBox.Text != "" && jobDescriptionBox.Text != ""
                && jobDateBox.Text != "" && JobLocationBox.Text != "")
            {
                bool contractorEmailVal = EmailValidator(jobContractorEmailBox.Text);
                bool clientEmailVal = EmailValidator(jobClientEmailBox.Text);
                if (contractorEmailVal == false || clientEmailVal == false)
                {
                    MessageBox.Show("Please enter Valid Emails");
                }
                else
                {
                    Client clientTable = new Client();
                    Contractor contractorTable = new Contractor();
                    DateTime jobDateTime = new DateTime(jobDateBox.Value.Year, jobDateBox.Value.Month, 
                        jobDateBox.Value.Day, jobTimeBox.Value.Hour, jobTimeBox.Value.Minute, jobTimeBox.Value.Second);

                    Job jobTable = new Job();
                    //checks if entered email is in the database
                    if(clientTable.GetClient(jobClientEmailBox.Text) == null || 
                        contractorTable.GetContractor(jobContractorEmailBox.Text) == null)
                    {
                        MessageBox.Show("Email/'s not in database, please check spelling and try again");
                    }
                    else
                    {
                        jobTable.AddJob(clientTable.GetClient(jobClientEmailBox.Text).ID, 
                            contractorTable.GetContractor(jobContractorEmailBox.Text).ID,
                            jobDescriptionBox.Text, JobLocationBox.Text, jobDateTime , jobPriorityCbx.Checked);

                        MessageBox.Show("Saved Successfully");

                    }

                }
               
            }
            else
            {
                MessageBox.Show("Please Complete all fields");
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
            //checks if any of the fields are empty
            if(clientFirstNameBox.Text != "" && clientLastNameBox.Text != "" && clientAddressBox.Text != "" && 
                clientLandLineBox.Text != "" && clientMobileBox.Text != "" && clientBuisinessNameBox.Text != "" && clientEmailBox.Text != "")
            {
                //runs the valid email function
                bool emailVal = EmailValidator(clientEmailBox.Text);
                if(emailVal == false)
                {
                    MessageBox.Show("Please enter a valid email");
                }
                else
                {
                    //adds the info in the fields into the database
                    Client clientTable = new Client();
                    clientTable.AddClient(clientFirstNameBox.Text + " " + clientLastNameBox.Text,
                        clientAddressBox.Text, clientLandLineBox.Text, 
                        clientMobileBox.Text, clientBuisinessNameBox.Text, clientEmailBox.Text);

                    MessageBox.Show("Saved Successfully");
                }


            }
            else
            {
                MessageBox.Show("Please complete all fields for this section");
            }
        }

        private void clientClearBtn_Click(object sender, EventArgs e)
        {
            //clears the fields
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
            //checks if any of the fields are empty
            if (contractorFirstNameBox.Text != "" && contractorLastNameBox.Text != "" && contractorAddressBox.Text != "" &&
                contractorLandLineBox.Text != "" && contractorMobileBox.Text != "" && contractorEmployeeIdBox.Text != "" && contractorEmailBox.Text != "")
            {
                //runs the valid email function
                bool emailVal = EmailValidator(contractorEmailBox.Text);
                if (emailVal == false)
                {
                    MessageBox.Show("Please enter a valid email");
                }
                else
                {
                    Contractor contractorTable = new Contractor();
                    contractorTable.AddContractor(contractorFirstNameBox.Text + " " + contractorLastNameBox.Text,
                        contractorAddressBox.Text, contractorLandLineBox.Text,
                        contractorMobileBox.Text, contractorEmployeeIdBox.Text, contractorEmailBox.Text);

                    MessageBox.Show("Saved Successfully");
                }

            }
            else
            {
                MessageBox.Show("Please complete all fields for this section");
            }
        }

        private void contractorClearBtn_Click(object sender, EventArgs e)
        {
            //clears the fields
            contractorFirstNameBox.Text = "";
            contractorLastNameBox.Text = "";
            contractorAddressBox.Text = "";
            contractorLandLineBox.Text = "";
            contractorMobileBox.Text = "";
            contractorEmployeeIdBox.Text = "";
            contractorEmailBox.Text = "";

        }

        //makes sure entered emails are valid
        public static Boolean EmailValidator(String email)
        {
            Regex regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            return regex.IsMatch(email);
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            // export data TO JSON
            using (var db = new LiteDatabase(@"IQIncorporated.db"))
            {
                var data = new BsonDocument();
                foreach (var name in db.GetCollectionNames())
                {
                    data[name] = new BsonArray(db.GetCollection(name).FindAll());
                }
                File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "HomeBaseExport.json", JsonSerializer.Serialize(data));
            }

            MessageBox.Show("Exported Successfully");
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {

            //Opens a file explorer to grab the file
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Roborts File Explorer";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;

            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var db = new LiteDatabase(@"IQIncorporated.db"))
                    {
                        string[] tableNames = new string[db.GetCollectionNames().Count()];

                        for (int i = 0; i < db.GetCollectionNames().Count(); i++)
                        {
                            tableNames[i] = db.GetCollectionNames().ElementAt(i);
                        }

                        foreach (var name in tableNames)
                        {
                            System.Diagnostics.Debug.WriteLine(name);
                            db.DropCollection(name);
                        }

                    }

                    // import data FROM JSON
                    using (var db = new LiteDatabase(@"IQIncorporated.db"))
                    {
                        var data = JsonSerializer.Deserialize(File.ReadAllText(fdlg.FileName)).AsDocument;
                        foreach (var name in data.Keys)
                        {
                            db.GetCollection(name).Insert(data[name].AsArray.Select(x => x.AsDocument));
                        }
                    }

                    MessageBox.Show("Imported Successfully");

                }
                catch (Exception excep)
                {
                    MessageBox.Show("Invalid file, please try again ");

                }
            }
        }
    }
}

