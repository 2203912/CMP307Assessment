using _307Assessment.mssql2203912DataSetTableAdapters;
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

namespace _307Assessment
{
    public partial class Form2 : Form
    {

        mssql2203912DataSetTableAdapters._307_HardwareTableAdapter HardwareAdapter = new mssql2203912DataSetTableAdapters._307_HardwareTableAdapter();


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
            this.HardwareAdapter.Fill(this.mssql2203912DataSet._307_Hardware);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AddHardwareToDatabaseButton_Click(object sender, EventArgs e)
        {

            mssql2203912Entities _307_Hardware = new mssql2203912Entities();

            C307_Hardware newHardware = new C307_Hardware();
            newHardware.HardwareID = HardwareIDTextBox.Text;
            newHardware.Name = HardwareNameTextBox.Text;
            newHardware.Model = HardwareModelTextBox.Text;
            newHardware.Manufacturer = HardwareManufacturerTextBox.Text;
            newHardware.Type = HardwareTypeTextBox.Text;
            newHardware.IP_Address = HardwareIPAddressTextBox.Text;

            _307_Hardware.C307_Hardware.Add(newHardware);

            _307_Hardware.SaveChanges();

        }
    }
}
