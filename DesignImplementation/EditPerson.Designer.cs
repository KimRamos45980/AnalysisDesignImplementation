namespace DesignImplementation
{
    partial class EditPerson
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
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnEditPerson = new System.Windows.Forms.Button();
            this.TxtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtZipCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtState = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtCity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtStreetAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(464, 226);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(149, 44);
            this.BtnBack.TabIndex = 31;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnEditPerson
            // 
            this.BtnEditPerson.Location = new System.Drawing.Point(464, 13);
            this.BtnEditPerson.Name = "BtnEditPerson";
            this.BtnEditPerson.Size = new System.Drawing.Size(149, 43);
            this.BtnEditPerson.TabIndex = 30;
            this.BtnEditPerson.Text = "Save Changes";
            this.BtnEditPerson.UseVisualStyleBackColor = true;
            this.BtnEditPerson.Click += new System.EventHandler(this.BtnEditPerson_Click);
            // 
            // TxtPhoneNumber
            // 
            this.TxtPhoneNumber.Location = new System.Drawing.Point(109, 247);
            this.TxtPhoneNumber.Name = "TxtPhoneNumber";
            this.TxtPhoneNumber.Size = new System.Drawing.Size(331, 23);
            this.TxtPhoneNumber.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "Phone Number:";
            // 
            // TxtZipCode
            // 
            this.TxtZipCode.Location = new System.Drawing.Point(109, 202);
            this.TxtZipCode.Name = "TxtZipCode";
            this.TxtZipCode.Size = new System.Drawing.Size(331, 23);
            this.TxtZipCode.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "Zip Code:";
            // 
            // TxtState
            // 
            this.TxtState.Location = new System.Drawing.Point(109, 163);
            this.TxtState.Name = "TxtState";
            this.TxtState.Size = new System.Drawing.Size(331, 23);
            this.TxtState.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "State:";
            // 
            // TxtCity
            // 
            this.TxtCity.Location = new System.Drawing.Point(109, 124);
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.Size = new System.Drawing.Size(331, 23);
            this.TxtCity.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "City:";
            // 
            // TxtStreetAddress
            // 
            this.TxtStreetAddress.Location = new System.Drawing.Point(109, 90);
            this.TxtStreetAddress.Name = "TxtStreetAddress";
            this.TxtStreetAddress.Size = new System.Drawing.Size(331, 23);
            this.TxtStreetAddress.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Street Address:";
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(109, 53);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(331, 23);
            this.TxtLastName.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Last Name:";
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(109, 16);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(331, 23);
            this.TxtFirstName.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "First Name:";
            // 
            // EditPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 284);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnEditPerson);
            this.Controls.Add(this.TxtPhoneNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtZipCode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtState);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtCity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtStreetAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtFirstName);
            this.Controls.Add(this.label1);
            this.Name = "EditPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnBack;
        private Button BtnEditPerson;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        public TextBox TxtPhoneNumber;
        public TextBox TxtZipCode;
        public TextBox TxtState;
        public TextBox TxtCity;
        public TextBox TxtStreetAddress;
        public TextBox TxtLastName;
        public TextBox TxtFirstName;
    }
}