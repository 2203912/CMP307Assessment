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
    public partial class DeleteFromDatabase : Form
    {

        mssql2203912DataSetTableAdapters._307_HardwareTableAdapter HardwareAdapter = new mssql2203912DataSetTableAdapters._307_HardwareTableAdapter();

        private void DeleteFromDatabase_Load(object sender, EventArgs e)
        {

            //this.HardwareAdapter.Fill(this.mssql2203912DataSet1._307_Hardware);

        }

        public DeleteFromDatabase()
        {
            InitializeComponent();
        }

        private void DeleteFromHardwareButton_Click(object sender, EventArgs e)
        {
            mssql2203912Entities _307_Hardware = new mssql2203912Entities();

            {
                bool oldValidateOnSaveEnabled = _307_Hardware.Configuration.ValidateOnSaveEnabled;

                try
                {
                    _307_Hardware.Configuration.ValidateOnSaveEnabled = false;

                    if (byte.TryParse(HardwareIDDelete.Text, out byte hardwareId))
                    {
                        var hardwareToDelete = new C307_Hardware { HardwareID = hardwareId };

                        _307_Hardware.C307_Hardware.Attach(hardwareToDelete);
                        _307_Hardware.C307_Hardware.Remove(hardwareToDelete);

                        _307_Hardware.SaveChanges();
                    }
                    else
                    {
                        // Handle the case where the entered text is not a valid byte
                        MessageBox.Show("Please enter a valid Software ID.");
                    }
                }
                finally
                {
                    _307_Hardware.Configuration.ValidateOnSaveEnabled = oldValidateOnSaveEnabled;
                }
            }
        }
    }
}
