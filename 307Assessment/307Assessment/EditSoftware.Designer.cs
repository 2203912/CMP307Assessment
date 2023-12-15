namespace _307Assessment
{
    partial class EditSoftware
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
            this.mssql2203912DataSet5 = new _307Assessment.mssql2203912DataSet5();
            this.softwareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.softwareIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatingSystemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.SoftwareID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SoftwareOperatingSystem = new System.Windows.Forms.TextBox();
            this.SoftwareVersion = new System.Windows.Forms.TextBox();
            this.SoftwareManufacturer = new System.Windows.Forms.TextBox();
            this.EditSoftwareButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mssql2203912DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwareBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.softwareIDDataGridViewTextBoxColumn,
            this.operatingSystemDataGridViewTextBoxColumn,
            this.versionDataGridViewTextBoxColumn,
            this.manufacturerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.softwareBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 292);
            this.dataGridView1.TabIndex = 0;
            // 
            // mssql2203912DataSet5
            // 
            this.mssql2203912DataSet5.DataSetName = "mssql2203912DataSet5";
            this.mssql2203912DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // softwareBindingSource
            // 
            this.softwareBindingSource.DataMember = "307.Software";
            this.softwareBindingSource.DataSource = this.mssql2203912DataSet5;
            // 
            // softwareIDDataGridViewTextBoxColumn
            // 
            this.softwareIDDataGridViewTextBoxColumn.DataPropertyName = "SoftwareID";
            this.softwareIDDataGridViewTextBoxColumn.HeaderText = "SoftwareID";
            this.softwareIDDataGridViewTextBoxColumn.Name = "softwareIDDataGridViewTextBoxColumn";
            // 
            // operatingSystemDataGridViewTextBoxColumn
            // 
            this.operatingSystemDataGridViewTextBoxColumn.DataPropertyName = "OperatingSystem";
            this.operatingSystemDataGridViewTextBoxColumn.HeaderText = "OperatingSystem";
            this.operatingSystemDataGridViewTextBoxColumn.Name = "operatingSystemDataGridViewTextBoxColumn";
            // 
            // versionDataGridViewTextBoxColumn
            // 
            this.versionDataGridViewTextBoxColumn.DataPropertyName = "Version";
            this.versionDataGridViewTextBoxColumn.HeaderText = "Version";
            this.versionDataGridViewTextBoxColumn.Name = "versionDataGridViewTextBoxColumn";
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Software ID of the record you wish to edit";
            // 
            // SoftwareID
            // 
            this.SoftwareID.Location = new System.Drawing.Point(286, 345);
            this.SoftwareID.Name = "SoftwareID";
            this.SoftwareID.Size = new System.Drawing.Size(103, 20);
            this.SoftwareID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(622, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Now enter the values you wish to update for this record, Not all fields have to b" +
    "e updated, only enter the values you wish to update";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 442);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Operating System";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 493);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Version";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 545);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Manufacturer";
            // 
            // SoftwareOperatingSystem
            // 
            this.SoftwareOperatingSystem.Location = new System.Drawing.Point(152, 439);
            this.SoftwareOperatingSystem.Name = "SoftwareOperatingSystem";
            this.SoftwareOperatingSystem.Size = new System.Drawing.Size(259, 20);
            this.SoftwareOperatingSystem.TabIndex = 7;
            // 
            // SoftwareVersion
            // 
            this.SoftwareVersion.Location = new System.Drawing.Point(152, 486);
            this.SoftwareVersion.Name = "SoftwareVersion";
            this.SoftwareVersion.Size = new System.Drawing.Size(259, 20);
            this.SoftwareVersion.TabIndex = 8;
            // 
            // SoftwareManufacturer
            // 
            this.SoftwareManufacturer.Location = new System.Drawing.Point(152, 542);
            this.SoftwareManufacturer.Name = "SoftwareManufacturer";
            this.SoftwareManufacturer.Size = new System.Drawing.Size(259, 20);
            this.SoftwareManufacturer.TabIndex = 9;
            // 
            // EditSoftwareButton
            // 
            this.EditSoftwareButton.Location = new System.Drawing.Point(454, 438);
            this.EditSoftwareButton.Name = "EditSoftwareButton";
            this.EditSoftwareButton.Size = new System.Drawing.Size(188, 123);
            this.EditSoftwareButton.TabIndex = 10;
            this.EditSoftwareButton.Text = "Edit and Update";
            this.EditSoftwareButton.UseVisualStyleBackColor = true;
            this.EditSoftwareButton.Click += new System.EventHandler(this.EditSoftwareButton_Click);
            // 
            // EditSoftware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 689);
            this.Controls.Add(this.EditSoftwareButton);
            this.Controls.Add(this.SoftwareManufacturer);
            this.Controls.Add(this.SoftwareVersion);
            this.Controls.Add(this.SoftwareOperatingSystem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SoftwareID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EditSoftware";
            this.Text = "EditSoftware";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mssql2203912DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwareBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn softwareIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatingSystemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn versionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource softwareBindingSource;
        private mssql2203912DataSet5 mssql2203912DataSet5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SoftwareID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SoftwareOperatingSystem;
        private System.Windows.Forms.TextBox SoftwareVersion;
        private System.Windows.Forms.TextBox SoftwareManufacturer;
        private System.Windows.Forms.Button EditSoftwareButton;
    }
}