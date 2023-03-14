namespace DesignImplementation
{
    partial class DeletePerson
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
            this.label1 = new System.Windows.Forms.Label();
            this.LbFullName = new System.Windows.Forms.Label();
            this.LbCity = new System.Windows.Forms.Label();
            this.LbStreetAddress = new System.Windows.Forms.Label();
            this.LbPhoneNumber = new System.Windows.Forms.Label();
            this.LbZipCode = new System.Windows.Forms.Label();
            this.LbState = new System.Windows.Forms.Label();
            this.BtnDismiss = new System.Windows.Forms.Button();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(81, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Are you sure you want to delete the \r\nfollowing person?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LbFullName
            // 
            this.LbFullName.AutoSize = true;
            this.LbFullName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbFullName.Location = new System.Drawing.Point(96, 86);
            this.LbFullName.Name = "LbFullName";
            this.LbFullName.Size = new System.Drawing.Size(86, 25);
            this.LbFullName.TabIndex = 1;
            this.LbFullName.Text = "FullName";
            // 
            // LbCity
            // 
            this.LbCity.AutoSize = true;
            this.LbCity.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbCity.Location = new System.Drawing.Point(96, 158);
            this.LbCity.Name = "LbCity";
            this.LbCity.Size = new System.Drawing.Size(42, 25);
            this.LbCity.TabIndex = 4;
            this.LbCity.Text = "City";
            // 
            // LbStreetAddress
            // 
            this.LbStreetAddress.AutoSize = true;
            this.LbStreetAddress.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbStreetAddress.Location = new System.Drawing.Point(96, 122);
            this.LbStreetAddress.Name = "LbStreetAddress";
            this.LbStreetAddress.Size = new System.Drawing.Size(77, 25);
            this.LbStreetAddress.TabIndex = 3;
            this.LbStreetAddress.Text = "Address";
            // 
            // LbPhoneNumber
            // 
            this.LbPhoneNumber.AutoSize = true;
            this.LbPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbPhoneNumber.Location = new System.Drawing.Point(96, 266);
            this.LbPhoneNumber.Name = "LbPhoneNumber";
            this.LbPhoneNumber.Size = new System.Drawing.Size(132, 25);
            this.LbPhoneNumber.TabIndex = 7;
            this.LbPhoneNumber.Text = "Phone Number";
            // 
            // LbZipCode
            // 
            this.LbZipCode.AutoSize = true;
            this.LbZipCode.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbZipCode.Location = new System.Drawing.Point(96, 230);
            this.LbZipCode.Name = "LbZipCode";
            this.LbZipCode.Size = new System.Drawing.Size(84, 25);
            this.LbZipCode.TabIndex = 6;
            this.LbZipCode.Text = "Zip Code";
            // 
            // LbState
            // 
            this.LbState.AutoSize = true;
            this.LbState.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbState.Location = new System.Drawing.Point(96, 194);
            this.LbState.Name = "LbState";
            this.LbState.Size = new System.Drawing.Size(51, 25);
            this.LbState.TabIndex = 5;
            this.LbState.Text = "State";
            // 
            // BtnDismiss
            // 
            this.BtnDismiss.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnDismiss.Location = new System.Drawing.Point(96, 315);
            this.BtnDismiss.Name = "BtnDismiss";
            this.BtnDismiss.Size = new System.Drawing.Size(129, 39);
            this.BtnDismiss.TabIndex = 8;
            this.BtnDismiss.Text = "No";
            this.BtnDismiss.UseVisualStyleBackColor = true;
            this.BtnDismiss.Click += new System.EventHandler(this.BtnDismiss_Click);
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnConfirm.ForeColor = System.Drawing.Color.Red;
            this.BtnConfirm.Location = new System.Drawing.Point(321, 315);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(129, 39);
            this.BtnConfirm.TabIndex = 9;
            this.BtnConfirm.Text = "Yes";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(24, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Phone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(2, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Zip Code:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(35, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "State:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(44, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "City:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(9, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(27, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Name:";
            // 
            // DeletePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 366);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.BtnDismiss);
            this.Controls.Add(this.LbPhoneNumber);
            this.Controls.Add(this.LbZipCode);
            this.Controls.Add(this.LbState);
            this.Controls.Add(this.LbCity);
            this.Controls.Add(this.LbStreetAddress);
            this.Controls.Add(this.LbFullName);
            this.Controls.Add(this.label1);
            this.Name = "DeletePerson";
            this.Text = "DeletePerson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label LbFullName;
        private Label LbCity;
        private Label LbStreetAddress;
        private Label LbPhoneNumber;
        private Label LbZipCode;
        private Label LbState;
        private Button BtnDismiss;
        private Button BtnConfirm;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}