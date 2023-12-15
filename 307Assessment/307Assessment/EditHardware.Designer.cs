namespace _307Assessment
{
    partial class EditHardware
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hardwareIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hardwareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mssql2203912DataSet4 = new _307Assessment.mssql2203912DataSet4();
            this.EditHardwareButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.HardwareID = new System.Windows.Forms.TextBox();
            this.lab = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.HardwareName = new System.Windows.Forms.TextBox();
            this.HardwareModel = new System.Windows.Forms.TextBox();
            this.HardwareManufacturer = new System.Windows.Forms.TextBox();
            this.HardwareType = new System.Windows.Forms.TextBox();
            this.HardwareIPAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardwareBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mssql2203912DataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hardwareIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.manufacturerDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.iPAddressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hardwareBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(11, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 297);
            this.dataGridView1.TabIndex = 0;
            // 
            // hardwareIDDataGridViewTextBoxColumn
            // 
            this.hardwareIDDataGridViewTextBoxColumn.DataPropertyName = "HardwareID";
            this.hardwareIDDataGridViewTextBoxColumn.HeaderText = "HardwareID";
            this.hardwareIDDataGridViewTextBoxColumn.Name = "hardwareIDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // iPAddressDataGridViewTextBoxColumn
            // 
            this.iPAddressDataGridViewTextBoxColumn.DataPropertyName = "IP Address";
            this.iPAddressDataGridViewTextBoxColumn.HeaderText = "IP Address";
            this.iPAddressDataGridViewTextBoxColumn.Name = "iPAddressDataGridViewTextBoxColumn";
            // 
            // hardwareBindingSource
            // 
            this.hardwareBindingSource.DataMember = "307.Hardware";
            this.hardwareBindingSource.DataSource = this.mssql2203912DataSet4;
            // 
            // mssql2203912DataSet4
            // 
            this.mssql2203912DataSet4.DataSetName = "mssql2203912DataSet4";
            this.mssql2203912DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EditHardwareButton
            // 
            this.EditHardwareButton.Location = new System.Drawing.Point(381, 421);
            this.EditHardwareButton.Name = "EditHardwareButton";
            this.EditHardwareButton.Size = new System.Drawing.Size(241, 169);
            this.EditHardwareButton.TabIndex = 1;
            this.EditHardwareButton.Text = "Edit and Update";
            this.EditHardwareButton.UseVisualStyleBackColor = true;
            this.EditHardwareButton.Click += new System.EventHandler(this.EditHardwareButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Hardware ID of the record you wish to edit";
            // 
            // HardwareID
            // 
            this.HardwareID.Location = new System.Drawing.Point(285, 341);
            this.HardwareID.Name = "HardwareID";
            this.HardwareID.Size = new System.Drawing.Size(148, 20);
            this.HardwareID.TabIndex = 3;
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Location = new System.Drawing.Point(31, 384);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(270, 13);
            this.lab.TabIndex = 4;
            this.lab.Text = "Now Enter the values you wish to update for that record";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 461);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 497);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Manufacturer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 535);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 577);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "IP Address";
            // 
            // HardwareName
            // 
            this.HardwareName.Location = new System.Drawing.Point(138, 421);
            this.HardwareName.Name = "HardwareName";
            this.HardwareName.Size = new System.Drawing.Size(193, 20);
            this.HardwareName.TabIndex = 10;
            // 
            // HardwareModel
            // 
            this.HardwareModel.Location = new System.Drawing.Point(138, 458);
            this.HardwareModel.Name = "HardwareModel";
            this.HardwareModel.Size = new System.Drawing.Size(193, 20);
            this.HardwareModel.TabIndex = 11;
            // 
            // HardwareManufacturer
            // 
            this.HardwareManufacturer.Location = new System.Drawing.Point(138, 493);
            this.HardwareManufacturer.Name = "HardwareManufacturer";
            this.HardwareManufacturer.Size = new System.Drawing.Size(193, 20);
            this.HardwareManufacturer.TabIndex = 12;
            // 
            // HardwareType
            // 
            this.HardwareType.Location = new System.Drawing.Point(138, 530);
            this.HardwareType.Name = "HardwareType";
            this.HardwareType.Size = new System.Drawing.Size(193, 20);
            this.HardwareType.TabIndex = 13;
            // 
            // HardwareIPAddress
            // 
            this.HardwareIPAddress.Location = new System.Drawing.Point(138, 570);
            this.HardwareIPAddress.Name = "HardwareIPAddress";
            this.HardwareIPAddress.Size = new System.Drawing.Size(193, 20);
            this.HardwareIPAddress.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 620);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(572, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "NOTE: Not all fields have to be updated on the record only enter the values you w" +
    "ish to update and leave the rest blank";
            // 
            // EditHardware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 736);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.HardwareIPAddress);
            this.Controls.Add(this.HardwareType);
            this.Controls.Add(this.HardwareManufacturer);
            this.Controls.Add(this.HardwareModel);
            this.Controls.Add(this.HardwareName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.HardwareID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EditHardwareButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EditHardware";
            this.Text = "EditHardware";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardwareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mssql2203912DataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hardwareIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource hardwareBindingSource;
        private mssql2203912DataSet4 mssql2203912DataSet4;
        private System.Windows.Forms.Button EditHardwareButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox HardwareID;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox HardwareName;
        private System.Windows.Forms.TextBox HardwareModel;
        private System.Windows.Forms.TextBox HardwareManufacturer;
        private System.Windows.Forms.TextBox HardwareType;
        private System.Windows.Forms.TextBox HardwareIPAddress;
        private System.Windows.Forms.Label label7;
    }
}