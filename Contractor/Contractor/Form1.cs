using LiteDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Contractor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //initializes required outputs, to be populated later
            DescriptionOutput.Text = "";
            LocationOutput.Text = "";
            TimeOutput.Text = "";
            NameOutput.Text = "";
            AddressOutput.Text = "";
            LandLineOutput.Text = "";
            MobileOutput.Text = "";
            BusinessOutput.Text = "";
            EmailOutput.Text = "";
        }

        //Exports database ready to be taken in by homebase
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
                File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "ContractorExport.json", JsonSerializer.Serialize(data));
            }

            MessageBox.Show("Exported Successfully");
        }

        //Reads json file in form homebase
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
                    //deletes old db ready for new data
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

        //User select a job to be loaded in
        private void JobListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (JobListView.SelectedIndices.Count>0) {
                System.Diagnostics.Debug.WriteLine(JobListView.Items[JobListView.SelectedIndices[0]].SubItems[4].Text);

                Job jobTable = new Job();
                Client clientTable = new Client();

                Job job = jobTable.GetJob(Int32.Parse(JobListView.Items[JobListView.SelectedIndices[0]].SubItems[4].Text.Trim()));
                Client client = clientTable.GetClient(job.ClientID);

                //Update all fields with text
                DescriptionOutput.Text = job.Description;
                LocationOutput.Text = job.Location;
                TimeOutput.Text = job.DateTime.ToString();
                PriorityOutput.Checked = job.Priority;

                NameOutput.Text = client.Name;
                AddressOutput.Text = client.Address;
                LandLineOutput.Text = client.LandLine;
                MobileOutput.Text = client.Mobile;
                BusinessOutput.Text = client.Business;
                EmailOutput.Text = client.Business;

                CompleteCost.Text = job.Cost;
                CompleteDescription.Text = job.CompleteDescription;
                FinishedCheck.Checked = job.Finished;
            }
            else
            {
                //Clears if a job is unselected
                DescriptionOutput.Text = "";
                LocationOutput.Text = "";
                TimeOutput.Text = "";
                PriorityOutput.Checked = false;

                NameOutput.Text = "";
                AddressOutput.Text = "";
                LandLineOutput.Text = "";
                MobileOutput.Text = "";
                BusinessOutput.Text = "";
                EmailOutput.Text = "";

                CompleteCost.Text = "";
                CompleteDescription.Text = "";
                FinishedCheck.Checked = false;
            }

        }

        //Customer entered a contractor ID
        private void contractorID_TextChanged(object sender, EventArgs e)
        {
            JobListView.Items.Clear();

            Job jobTable = new Job();

            Job[] jobList = jobTable.JobList(contractorID.Text.Trim());

            //Loads all jobs assigned to that contractor
            if (jobList != null)
            {
                System.Diagnostics.Debug.WriteLine("Count: " + jobList.Count());
                foreach(Job job in jobList) {
                    Client clientTable = new Client();
                    Client client = clientTable.GetClient(job.ClientID);

                    ListViewItem jobItem = new ListViewItem();
                    jobItem.Text = client.Name;                 
                    jobItem.SubItems.Add(job.DateTime.ToString());
                    jobItem.SubItems.Add(job.Priority.ToString());
                    jobItem.SubItems.Add(client.Email);
                    jobItem.SubItems.Add(job.ID.ToString());
                    JobListView.Items.Add(jobItem);
                }
            }
            JobListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            JobListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void CompleteSave_Click(object sender, EventArgs e)
        {
            //checks if the cost and description are empty
            if(CompleteCost.Text != "" && CompleteDescription.Text != "")
            {
                Job jobTable = new Job();
                Contractor contractorTable = new Contractor();
                Client clientTable = new Client();

                //Updates job with new information
                if (JobListView.SelectedIndices.Count > 0)
                {
                    jobTable.UpdateJob(Int32.Parse(JobListView.Items[JobListView.SelectedIndices[0]].SubItems[4].Text.Trim()), CompleteCost.Text, CompleteDescription.Text, FinishedCheck.Checked);
                }
                else
                {
                    MessageBox.Show("Please reselect the current job");

                }
                

            }
            else
            {
                MessageBox.Show("Please add the price and/or the description and/or select a valid job");
            }
        }

        //Export a invoice for the customer
        private void Invoice_Click(object sender, EventArgs e)
        {
            //only checks is descritionOutput for the auto fills as if it is null the rest of the auto fill fields are also null
            if (DescriptionOutput.Text != "" && CompleteCost.Text != "" && DescriptionOutput.Text != "")
            {
                Job jobTable = new Job();
                //works but has extra unnecacary code from the copy of above
                Job job = jobTable.GetJob(Int32.Parse(JobListView.Items[JobListView.SelectedIndices[0]].SubItems[4].Text.Trim()));

                //writes to a txt file called invoice
                //locaiton is \Contractor\Contractor\bin\Debug
                using (StreamWriter writer = new StreamWriter("invoice.txt"))
                {
                    writer.WriteLine("Invoice Number: " + job.ID);
                    writer.WriteLine("Job");
                    writer.WriteLine("Descriton: " + DescriptionOutput.Text);
                    writer.WriteLine("Location: " + LocationOutput.Text);
                    writer.WriteLine("Date and Time: " + TimeOutput.Text);
                    writer.WriteLine("Priority: " + PriorityOutput.Checked);
                    writer.WriteLine("Client");
                    writer.WriteLine("Name: " + NameOutput.Text);
                    writer.WriteLine("Address: " + AddressOutput.Text);
                    writer.WriteLine("LandLine Number: " + LandLineOutput.Text);
                    writer.WriteLine("Mobile Number: " + MobileOutput.Text);
                    writer.WriteLine("Business: " + BusinessOutput.Text);
                    writer.WriteLine("Email: " + EmailOutput.Text);
                    writer.WriteLine("Completion ");
                    writer.WriteLine("Completion Description: " + CompleteDescription.Text);                 
                    writer.WriteLine("Finished: " + FinishedCheck.Checked);
                    writer.WriteLine("Cost: " + CompleteCost.Text);
                }
            }
            else
            {
                MessageBox.Show("Please add the price and/or the description and/or select a valid job");
            }
        }

        private void CompleteCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            //forces cost to only use numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            //forces the textbox to not allow more inputs after a secound decimal place
            if (Regex.IsMatch(CompleteCost.Text, @"\.\d\d") && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void contractorID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //forces id to only use numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
