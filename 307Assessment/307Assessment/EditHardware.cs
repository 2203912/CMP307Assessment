using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using _307Assessment.mssql2203912DataSetTableAdapters;

namespace _307Assessment
{
    public partial class EditHardware : Form
    {
        public EditHardware()
        {
            InitializeComponent();
        }

        private void EditHardwareButton_Click(object sender, EventArgs e)
        {
            mssql2203912Entities _307_Hardware = new mssql2203912Entities();

            string hardwareIdText = HardwareID.Text;

            if (int.TryParse(hardwareIdText, out int hardwareId))
            {
                var existingAsset = _307_Hardware.C307_Hardware.Find(hardwareId);

                
                if (existingAsset != null)
                {
                   
                    if (!string.IsNullOrEmpty(HardwareName.Text))
                    {
                        existingAsset.Name = HardwareName.Text;
                    }

                    if (!string.IsNullOrEmpty(HardwareModel.Text))
                    {
                        existingAsset.Model = HardwareModel.Text;
                    }

                    if (!string.IsNullOrEmpty(HardwareManufacturer.Text))
                    {
                        existingAsset.Manufacturer = HardwareManufacturer.Text;
                    }

                    if (!string.IsNullOrEmpty(HardwareType.Text))
                    {
                        existingAsset.Type = HardwareType.Text;
                    }

                    if (!string.IsNullOrEmpty(HardwareIPAddress.Text))
                    {
                        existingAsset.IP_Address = HardwareIPAddress.Text;
                    }

                    _307_Hardware.SaveChanges();
                }
                else
                {
                    MessageBox.Show("The entered ID is not on the database please enter a valid Hardware ID");
                }
            }
            
        }
    }
}
