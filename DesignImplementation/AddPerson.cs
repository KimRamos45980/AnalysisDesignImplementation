using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignImplementation
{
    public partial class AddPerson : Form
    {
        public AddPerson()
        {
            InitializeComponent();
        }

        private void BtnAddPerson_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            string missingValues = "Some inputs are missing, please check all textboxes for input";

            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                if (tb.Text.Trim() == "")
                {
                    isValid = false;
                }
            }

            int zipCodeCheck = TxtZipCode.Text.Trim().Length;
            if (zipCodeCheck != 5) 
            {
                isValid = false;
                missingValues += $"\nZip Code must be 5 characters";
            }
            if(!int.TryParse(TxtZipCode.Text.Trim(), out int zipResult))
            {
                isValid = false;
                missingValues += $"\nZip Code must only be numbers";
            }

            int phoneNumberCheck = TxtPhoneNumber.Text.Trim().Length;
            if (phoneNumberCheck != 10)
            { 
                isValid = false;
                missingValues += $"\nPhone Number must be 10 characters";
            }
            if (!long.TryParse(TxtPhoneNumber.Text.Trim(), out long phoneResult))
            {
                isValid = false;
                missingValues += $"\nPhone Number must only be numbers";
            }

            if (isValid)
            {
                long phoneNumber = long.Parse(TxtPhoneNumber.Text.Trim());
                string phoneFormatted = String.Format("{0:(###) ###-####}", phoneNumber);

                using DesignImplementationContext dbContext = new();

                Person person = new()
                {
                    FirstName = TxtFirstName.Text.Trim(),
                    LastName = TxtLastName.Text.Trim(),
                    StreetAddress = TxtStreetAddress.Text.Trim(),
                    State = TxtState.Text.Trim(),
                    City = TxtCity.Text.Trim(),
                    ZipCode = TxtZipCode.Text.Trim(),
                    PhoneNumber = phoneFormatted,
                };

                dbContext.Person.Add(person);
                dbContext.SaveChanges();

                MessageBox.Show($"{person.FirstName}, {person.LastName} has been successfully added!");
                
                foreach(TextBox tb in this.Controls.OfType<TextBox>())
                {
                    tb.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show(missingValues);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mainPage = new Form1();
            mainPage.ShowDialog();
        }
    }
}
