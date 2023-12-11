namespace _307Assessment
{
    partial class DeleteFromSoftware
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
            this.mssql2203912DataSet3 = new _307Assessment.mssql2203912DataSet3();
            this.softwareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.softwareIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatingSystemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DeleteFromSoftwareDatabase = new System.Windows.Forms.TextBox();
            this.DeleteSoftware = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mssql2203912DataSet3)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(21, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 384);
            this.dataGridView1.TabIndex = 0;
            // 
            // mssql2203912DataSet3
            // 
            this.mssql2203912DataSet3.DataSetName = "mssql2203912DataSet3";
            this.mssql2203912DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // softwareBindingSource
            // 
            this.softwareBindingSource.DataMember = "307.Software";
            this.softwareBindingSource.DataSource = this.mssql2203912DataSet3;
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
            this.label1.Location = new System.Drawing.Point(618, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Delete Asset From Software Database";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(544, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Software ID";
            // 
            // DeleteFromSoftwareDatabase
            // 
            this.DeleteFromSoftwareDatabase.Location = new System.Drawing.Point(621, 90);
            this.DeleteFromSoftwareDatabase.Name = "DeleteFromSoftwareDatabase";
            this.DeleteFromSoftwareDatabase.Size = new System.Drawing.Size(217, 20);
            this.DeleteFromSoftwareDatabase.TabIndex = 3;
            // 
            // DeleteSoftware
            // 
            this.DeleteSoftware.Location = new System.Drawing.Point(614, 145);
            this.DeleteSoftware.Name = "DeleteSoftware";
            this.DeleteSoftware.Size = new System.Drawing.Size(191, 45);
            this.DeleteSoftware.TabIndex = 4;
            this.DeleteSoftware.Text = "Delete Asset From Database";
            this.DeleteSoftware.UseVisualStyleBackColor = true;
            this.DeleteSoftware.Click += new System.EventHandler(this.DeleteSoftware_Click);
            // 
            // DeleteFromSoftware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 595);
            this.Controls.Add(this.DeleteSoftware);
            this.Controls.Add(this.DeleteFromSoftwareDatabase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DeleteFromSoftware";
            this.Text = "DeleteFromSoftware";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mssql2203912DataSet3)).EndInit();
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
        private mssql2203912DataSet3 mssql2203912DataSet3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DeleteFromSoftwareDatabase;
        private System.Windows.Forms.Button DeleteSoftware;
    }
}