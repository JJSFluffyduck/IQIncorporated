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

namespace Contractor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

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

        private void JobListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (JobListView.SelectedIndices.Count>0) {
                System.Diagnostics.Debug.WriteLine(JobListView.Items[JobListView.SelectedIndices[0]].SubItems[4].Text);

                Job jobTable = new Job();
                Client clientTable = new Client();

                Job job = jobTable.GetJob(Int32.Parse(JobListView.Items[JobListView.SelectedIndices[0]].SubItems[4].Text.Trim()));
                Client client = clientTable.GetClient(job.ClientID);

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
            }
            else
            {
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
            }

        }

        private void contractorID_TextChanged(object sender, EventArgs e)
        {
            JobListView.Items.Clear();

            Job jobTable = new Job();

            Job[] jobList = jobTable.JobList(contractorID.Text.Trim());

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ClientLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
