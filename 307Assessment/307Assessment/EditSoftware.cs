using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _307Assessment
{
    public partial class EditSoftware : Form
    {
        public EditSoftware()
        {
            InitializeComponent();
        }

        private void EditSoftwareButton_Click(object sender, EventArgs e)
        {
            mssql2203912Entities _307_Software = new mssql2203912Entities();

            string softwareIdText = SoftwareID.Text;

            if (int.TryParse(softwareIdText, out int softwareId))
            {
                var existingSoftware = _307_Software.C307_Software.Find(softwareId);

     
                if (existingSoftware != null)
                {
                    
                    if (!string.IsNullOrEmpty(SoftwareOperatingSystem.Text))
                    {
                        existingSoftware.OperatingSystem = SoftwareOperatingSystem.Text;
                    }

                    if (!string.IsNullOrEmpty(SoftwareVersion.Text))
                    {
                        existingSoftware.Version = SoftwareVersion.Text;
                    }

                    if (!string.IsNullOrEmpty(SoftwareManufacturer.Text))
                    {
                        existingSoftware.Manufacturer = SoftwareManufacturer.Text;
                    }

                    _307_Software.SaveChanges();
                }
                else
                {
                    
                    MessageBox.Show("The entered ID is not on the database please enter a valid Software ID");


                }
            }
           
        }
    }
}
