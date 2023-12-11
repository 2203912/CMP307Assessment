namespace _307Assessment
{
    partial class AddToSoftware
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
            this.mssql2203912DataSet2 = new _307Assessment.mssql2203912DataSet2();
            this.softwareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.softwareIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatingSystemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SoftwareIDTextBox = new System.Windows.Forms.TextBox();
            this.SoftwareOperatingSystemTextBox = new System.Windows.Forms.TextBox();
            this.SoftwareVersionTextBox = new System.Windows.Forms.TextBox();
            this.SoftwareManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.AddSoftwareToDatabase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mssql2203912DataSet2)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(20, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(521, 317);
            this.dataGridView1.TabIndex = 0;
            // 
            // mssql2203912DataSet2
            // 
            this.mssql2203912DataSet2.DataSetName = "mssql2203912DataSet2";
            this.mssql2203912DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // softwareBindingSource
            // 
            this.softwareBindingSource.DataMember = "307.Software";
            this.softwareBindingSource.DataSource = this.mssql2203912DataSet2;
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
            this.label1.Location = new System.Drawing.Point(644, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Software to Software Database";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(589, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Software ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(562, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Operating System";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(610, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Version";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(582, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Manufacturer";
            // 
            // SoftwareIDTextBox
            // 
            this.SoftwareIDTextBox.Location = new System.Drawing.Point(669, 73);
            this.SoftwareIDTextBox.Name = "SoftwareIDTextBox";
            this.SoftwareIDTextBox.Size = new System.Drawing.Size(179, 20);
            this.SoftwareIDTextBox.TabIndex = 6;
            // 
            // SoftwareOperatingSystemTextBox
            // 
            this.SoftwareOperatingSystemTextBox.Location = new System.Drawing.Point(668, 124);
            this.SoftwareOperatingSystemTextBox.Name = "SoftwareOperatingSystemTextBox";
            this.SoftwareOperatingSystemTextBox.Size = new System.Drawing.Size(179, 20);
            this.SoftwareOperatingSystemTextBox.TabIndex = 7;
            // 
            // SoftwareVersionTextBox
            // 
            this.SoftwareVersionTextBox.Location = new System.Drawing.Point(669, 178);
            this.SoftwareVersionTextBox.Name = "SoftwareVersionTextBox";
            this.SoftwareVersionTextBox.Size = new System.Drawing.Size(177, 20);
            this.SoftwareVersionTextBox.TabIndex = 8;
            // 
            // SoftwareManufacturerTextBox
            // 
            this.SoftwareManufacturerTextBox.Location = new System.Drawing.Point(670, 234);
            this.SoftwareManufacturerTextBox.Name = "SoftwareManufacturerTextBox";
            this.SoftwareManufacturerTextBox.Size = new System.Drawing.Size(176, 20);
            this.SoftwareManufacturerTextBox.TabIndex = 9;
            // 
            // AddSoftwareToDatabase
            // 
            this.AddSoftwareToDatabase.Location = new System.Drawing.Point(585, 287);
            this.AddSoftwareToDatabase.Name = "AddSoftwareToDatabase";
            this.AddSoftwareToDatabase.Size = new System.Drawing.Size(262, 50);
            this.AddSoftwareToDatabase.TabIndex = 10;
            this.AddSoftwareToDatabase.Text = "Add Software To Software Database";
            this.AddSoftwareToDatabase.UseVisualStyleBackColor = true;
            // 
            // AddToSoftware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 527);
            this.Controls.Add(this.AddSoftwareToDatabase);
            this.Controls.Add(this.SoftwareManufacturerTextBox);
            this.Controls.Add(this.SoftwareVersionTextBox);
            this.Controls.Add(this.SoftwareOperatingSystemTextBox);
            this.Controls.Add(this.SoftwareIDTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AddToSoftware";
            this.Text = "AddToSoftware";
            this.Load += new System.EventHandler(this.AddToSoftware_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mssql2203912DataSet2)).EndInit();
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
        private mssql2203912DataSet2 mssql2203912DataSet2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SoftwareIDTextBox;
        private System.Windows.Forms.TextBox SoftwareOperatingSystemTextBox;
        private System.Windows.Forms.TextBox SoftwareVersionTextBox;
        private System.Windows.Forms.TextBox SoftwareManufacturerTextBox;
        private System.Windows.Forms.Button AddSoftwareToDatabase;
    }
}