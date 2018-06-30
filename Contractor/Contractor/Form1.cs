using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            TimePicker.Value.ToShortTimeString();
        }

        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {

            DateTime jobDateTime = new DateTime(DatePicker.Value.Year, DatePicker.Value.Month, DatePicker.Value.Day, TimePicker.Value.Hour, TimePicker.Value.Minute, TimePicker.Value.Second);

            System.Diagnostics.Debug.WriteLine(jobDateTime);
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {

        }
    }
}
