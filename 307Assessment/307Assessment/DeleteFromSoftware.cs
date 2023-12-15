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
    public partial class DeleteFromSoftware : Form
    {
        public DeleteFromSoftware()
        {
            InitializeComponent();
        }
         
        private void DeleteSoftware_Click(object sender, EventArgs e)
        {
            mssql2203912Entities _307_Software = new mssql2203912Entities();

            {
                bool oldValidateOnSaveEnabled = _307_Software.Configuration.ValidateOnSaveEnabled;

                try
                {
                    _307_Software.Configuration.ValidateOnSaveEnabled = false;

                    if (byte.TryParse(DeleteSoftware.Text, out byte softwareId))
                    {
                        var softwareToDelete = new C307_Software { SoftwareID = softwareId };

                        _307_Software.C307_Software.Attach(softwareToDelete);
                        _307_Software.C307_Software.Remove(softwareToDelete);

                        _307_Software.SaveChanges();
                    }
                    else
                    {
                        // Handle the case where the entered text is not a valid byte
                        MessageBox.Show("Please enter a valid Software ID.");
                    }
                }
                finally
                {
                    _307_Software.Configuration.ValidateOnSaveEnabled = oldValidateOnSaveEnabled;
                }
            }
        }

        private void DeleteFromSoftware_Load(object sender, EventArgs e)
        {
            //this._307_SoftwareTableAdapter.Fill(this.mssql2203912DataSet3._307_Software);
        }
    }
}
