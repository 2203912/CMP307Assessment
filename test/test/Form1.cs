using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
