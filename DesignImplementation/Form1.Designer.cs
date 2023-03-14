namespace DesignImplementation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BtnCreatePerson = new System.Windows.Forms.Button();
            this.BtnEditPerson = new System.Windows.Forms.Button();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.designImplementationContextBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewPerson = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnDeletePerson = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.designImplementationContextBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCreatePerson
            // 
            this.BtnCreatePerson.Location = new System.Drawing.Point(12, 12);
            this.BtnCreatePerson.Name = "BtnCreatePerson";
            this.BtnCreatePerson.Size = new System.Drawing.Size(126, 50);
            this.BtnCreatePerson.TabIndex = 0;
            this.BtnCreatePerson.Text = "Add New Person";
            this.BtnCreatePerson.UseVisualStyleBackColor = true;
            this.BtnCreatePerson.Click += new System.EventHandler(this.BtnCreatePerson_Click);
            // 
            // BtnEditPerson
            // 
            this.BtnEditPerson.Location = new System.Drawing.Point(144, 12);
            this.BtnEditPerson.Name = "BtnEditPerson";
            this.BtnEditPerson.Size = new System.Drawing.Size(126, 50);
            this.BtnEditPerson.TabIndex = 2;
            this.BtnEditPerson.Text = "Edit Person";
            this.BtnEditPerson.UseVisualStyleBackColor = true;
            this.BtnEditPerson.Click += new System.EventHandler(this.BtnEditPerson_Click);
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(DesignImplementation.Person);
            // 
            // personBindingSource1
            // 
            this.personBindingSource1.DataSource = typeof(DesignImplementation.Person);
            // 
            // designImplementationContextBindingSource
            // 
            this.designImplementationContextBindingSource.DataSource = typeof(DesignImplementation.DesignImplementationContext);
            // 
            // dataGridViewPerson
            // 
            this.dataGridViewPerson.AutoGenerateColumns = false;
            this.dataGridViewPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPerson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.streetAddressDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.zipCodeDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn});
            this.dataGridViewPerson.DataSource = this.personBindingSource;
            this.dataGridViewPerson.Location = new System.Drawing.Point(12, 68);
            this.dataGridViewPerson.Name = "dataGridViewPerson";
            this.dataGridViewPerson.RowTemplate.Height = 25;
            this.dataGridViewPerson.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPerson.Size = new System.Drawing.Size(816, 424);
            this.dataGridViewPerson.TabIndex = 4;
            this.dataGridViewPerson.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPerson_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // streetAddressDataGridViewTextBoxColumn
            // 
            this.streetAddressDataGridViewTextBoxColumn.DataPropertyName = "StreetAddress";
            this.streetAddressDataGridViewTextBoxColumn.HeaderText = "StreetAddress";
            this.streetAddressDataGridViewTextBoxColumn.Name = "streetAddressDataGridViewTextBoxColumn";
            this.streetAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zipCodeDataGridViewTextBoxColumn
            // 
            this.zipCodeDataGridViewTextBoxColumn.DataPropertyName = "ZipCode";
            this.zipCodeDataGridViewTextBoxColumn.HeaderText = "ZipCode";
            this.zipCodeDataGridViewTextBoxColumn.Name = "zipCodeDataGridViewTextBoxColumn";
            this.zipCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BtnDeletePerson
            // 
            this.BtnDeletePerson.Location = new System.Drawing.Point(276, 12);
            this.BtnDeletePerson.Name = "BtnDeletePerson";
            this.BtnDeletePerson.Size = new System.Drawing.Size(126, 50);
            this.BtnDeletePerson.TabIndex = 3;
            this.BtnDeletePerson.Text = "Delete Person";
            this.BtnDeletePerson.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 504);
            this.Controls.Add(this.dataGridViewPerson);
            this.Controls.Add(this.BtnDeletePerson);
            this.Controls.Add(this.BtnEditPerson);
            this.Controls.Add(this.BtnCreatePerson);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.designImplementationContextBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPerson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnCreatePerson;
        private Button BtnEditPerson;
        private BindingSource personBindingSource;
        private BindingSource personBindingSource1;
        private BindingSource designImplementationContextBindingSource;
        private DataGridView dataGridViewPerson;
        private Button BtnDeletePerson;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn streetAddressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn zipCodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
    }
}