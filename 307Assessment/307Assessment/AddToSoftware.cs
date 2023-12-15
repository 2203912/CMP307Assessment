using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using _307Assessment.mssql2203912DataSetTableAdapters;
using System.Data.Entity;

namespace _307Assessment
{
    public partial class AddToSoftware : Form
    {
        public AddToSoftware()
        {
            InitializeComponent();
        }

        private void AddToSoftware_Load(object sender, EventArgs e)
        {
            this._307_SoftwareTableAdapter1.Fill(this.mssql2203912DataSet2._307_Software);
        }

        private void AddSoftwareToDatabase_Click(object sender, EventArgs e)
        {
            mssql2203912Entities _307_Software = new mssql2203912Entities();

            C307_Software newSoftware = new C307_Software();
            newSoftware.SoftwareID = Convert.ToByte(SoftwareIDTextBox.Text);
            newSoftware.OperatingSystem = SoftwareOperatingSystemTextBox.Text;
            newSoftware.Version = SoftwareVersionTextBox.Text; 
            newSoftware.Manufacturer = SoftwareManufacturerTextBox.Text;


            _307_Software.C307_Software.Add(newSoftware);

            _307_Software.SaveChanges();
        }
    }
}
