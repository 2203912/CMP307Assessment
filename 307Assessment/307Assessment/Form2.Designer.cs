namespace _307Assessment
{
    partial class Form2
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
            this.mssql2203912DataSet = new _307Assessment.mssql2203912DataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.HardwareIDTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.HardwareNameTextBox = new System.Windows.Forms.TextBox();
            this.HardwareModelTextBox = new System.Windows.Forms.TextBox();
            this.HardwareManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.HardwareTypeTextBox = new System.Windows.Forms.TextBox();
            this.HardwareIPAddressTextBox = new System.Windows.Forms.TextBox();
            this.AddHardwareToDatabaseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardwareBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mssql2203912DataSet)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 300);
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
            this.hardwareBindingSource.DataSource = this.mssql2203912DataSet;
            // 
            // mssql2203912DataSet
            // 
            this.mssql2203912DataSet.DataSetName = "mssql2203912DataSet";
            this.mssql2203912DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(830, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Hardware to Database";
            // 
            // HardwareIDTextBox
            // 
            this.HardwareIDTextBox.Location = new System.Drawing.Point(798, 72);
            this.HardwareIDTextBox.Name = "HardwareIDTextBox";
            this.HardwareIDTextBox.Size = new System.Drawing.Size(199, 20);
            this.HardwareIDTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(697, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hardware ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(697, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(696, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Model";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(697, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Manufacturer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(697, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(701, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "IP address";
            // 
            // HardwareNameTextBox
            // 
            this.HardwareNameTextBox.Location = new System.Drawing.Point(798, 102);
            this.HardwareNameTextBox.Name = "HardwareNameTextBox";
            this.HardwareNameTextBox.Size = new System.Drawing.Size(199, 20);
            this.HardwareNameTextBox.TabIndex = 9;
            // 
            // HardwareModelTextBox
            // 
            this.HardwareModelTextBox.Location = new System.Drawing.Point(798, 140);
            this.HardwareModelTextBox.Name = "HardwareModelTextBox";
            this.HardwareModelTextBox.Size = new System.Drawing.Size(199, 20);
            this.HardwareModelTextBox.TabIndex = 10;
            // 
            // HardwareManufacturerTextBox
            // 
            this.HardwareManufacturerTextBox.Location = new System.Drawing.Point(798, 178);
            this.HardwareManufacturerTextBox.Name = "HardwareManufacturerTextBox";
            this.HardwareManufacturerTextBox.Size = new System.Drawing.Size(199, 20);
            this.HardwareManufacturerTextBox.TabIndex = 11;
            // 
            // HardwareTypeTextBox
            // 
            this.HardwareTypeTextBox.Location = new System.Drawing.Point(798, 215);
            this.HardwareTypeTextBox.Name = "HardwareTypeTextBox";
            this.HardwareTypeTextBox.Size = new System.Drawing.Size(199, 20);
            this.HardwareTypeTextBox.TabIndex = 12;
            // 
            // HardwareIPAddressTextBox
            // 
            this.HardwareIPAddressTextBox.Location = new System.Drawing.Point(798, 250);
            this.HardwareIPAddressTextBox.Name = "HardwareIPAddressTextBox";
            this.HardwareIPAddressTextBox.Size = new System.Drawing.Size(199, 20);
            this.HardwareIPAddressTextBox.TabIndex = 13;
            // 
            // AddHardwareToDatabaseButton
            // 
            this.AddHardwareToDatabaseButton.Location = new System.Drawing.Point(699, 290);
            this.AddHardwareToDatabaseButton.Name = "AddHardwareToDatabaseButton";
            this.AddHardwareToDatabaseButton.Size = new System.Drawing.Size(297, 31);
            this.AddHardwareToDatabaseButton.TabIndex = 14;
            this.AddHardwareToDatabaseButton.Text = "Add Hardware To Database";
            this.AddHardwareToDatabaseButton.UseVisualStyleBackColor = true;
            this.AddHardwareToDatabaseButton.Click += new System.EventHandler(this.AddHardwareToDatabaseButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 675);
            this.Controls.Add(this.AddHardwareToDatabaseButton);
            this.Controls.Add(this.HardwareIPAddressTextBox);
            this.Controls.Add(this.HardwareTypeTextBox);
            this.Controls.Add(this.HardwareManufacturerTextBox);
            this.Controls.Add(this.HardwareModelTextBox);
            this.Controls.Add(this.HardwareNameTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HardwareIDTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardwareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mssql2203912DataSet)).EndInit();
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
        private mssql2203912DataSet mssql2203912DataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox HardwareIDTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox HardwareNameTextBox;
        private System.Windows.Forms.TextBox HardwareModelTextBox;
        private System.Windows.Forms.TextBox HardwareManufacturerTextBox;
        private System.Windows.Forms.TextBox HardwareTypeTextBox;
        private System.Windows.Forms.TextBox HardwareIPAddressTextBox;
        private System.Windows.Forms.Button AddHardwareToDatabaseButton;
    }
}