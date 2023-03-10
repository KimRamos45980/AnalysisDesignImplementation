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
            this.BtnCreatePerson = new System.Windows.Forms.Button();
            this.BtnSortList = new System.Windows.Forms.Button();
            this.BtnEditPerson = new System.Windows.Forms.Button();
            this.BtnDeletePerson = new System.Windows.Forms.Button();
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
            // BtnSortList
            // 
            this.BtnSortList.Location = new System.Drawing.Point(12, 180);
            this.BtnSortList.Name = "BtnSortList";
            this.BtnSortList.Size = new System.Drawing.Size(126, 50);
            this.BtnSortList.TabIndex = 1;
            this.BtnSortList.Text = "Sort List";
            this.BtnSortList.UseVisualStyleBackColor = true;
            // 
            // BtnEditPerson
            // 
            this.BtnEditPerson.Location = new System.Drawing.Point(12, 68);
            this.BtnEditPerson.Name = "BtnEditPerson";
            this.BtnEditPerson.Size = new System.Drawing.Size(126, 50);
            this.BtnEditPerson.TabIndex = 2;
            this.BtnEditPerson.Text = "Edit Person";
            this.BtnEditPerson.UseVisualStyleBackColor = true;
            // 
            // BtnDeletePerson
            // 
            this.BtnDeletePerson.Location = new System.Drawing.Point(12, 124);
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
            this.Controls.Add(this.BtnDeletePerson);
            this.Controls.Add(this.BtnEditPerson);
            this.Controls.Add(this.BtnSortList);
            this.Controls.Add(this.BtnCreatePerson);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnCreatePerson;
        private Button BtnSortList;
        private Button BtnEditPerson;
        private Button BtnDeletePerson;
    }
}