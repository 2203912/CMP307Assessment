﻿using System;
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
        mssql2203912DataSet MyDataBase = new mssql2203912DataSet();

        mssql2203912DataSetTableAdapters._307_HardwareTableAdapter HardwareAdapter = new mssql2203912DataSetTableAdapters._307_HardwareTableAdapter();


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
            this.HardwareAdapter.Fill(this.mssql2203912DataSet._307_Hardware);
        }
    }
}
