using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace DesignImplementation
{
    public partial class EditPerson : Form
    {

        public EditPerson()
        {
            InitializeComponent();
        }

        public static Person info { get; set; }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            TxtFirstName.Text = info.FirstName;
            TxtLastName.Text = info.LastName;
            TxtStreetAddress.Text = info.StreetAddress;
            TxtCity.Text = info.City;
            TxtState.Text = info.State;
            TxtZipCode.Text = info.ZipCode;
            TxtPhoneNumber.Text = info.PhoneNumber;
        }

        private static string GetNumbers(string input)
        {
            return new string(input.Where(c => char.IsDigit(c)).ToArray());
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mainPage = new Form1();
            mainPage.ShowDialog();
        }

        private void BtnEditPerson_Click(object sender, EventArgs e)
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
            if (!int.TryParse(TxtZipCode.Text.Trim(), out int zipResult))
            {
                isValid = false;
                missingValues += $"\nZip Code must only be numbers";
            }

            string number = GetNumbers(TxtPhoneNumber.Text.Trim());
            int phoneNumberCheck = number.Length;
            if (phoneNumberCheck != 10)
            {
                isValid = false;
                missingValues += $"\nPhone Number must be 10 characters";
            }
            if (!long.TryParse(number, out long phoneResult))
            {
                isValid = false;
                missingValues += $"\nPhone Number must only be numbers";
            }

            if (isValid)
            {
                long phoneNumber = long.Parse(number);
                string phoneFormatted = String.Format("{0:(###) ###-####}", phoneNumber);

                using DesignImplementationContext dbContext = new();

                Person? person = (from c in dbContext.Person
                                  where c.Id == info.Id
                                  select c).FirstOrDefault();

                person.FirstName = TxtFirstName.Text.Trim();
                person.LastName = TxtLastName.Text.Trim();
                person.StreetAddress = TxtStreetAddress.Text.Trim();
                person.State = TxtState.Text.Trim();
                person.City = TxtCity.Text.Trim();
                person.ZipCode = TxtZipCode.Text.Trim();
                person.PhoneNumber = phoneFormatted;

                dbContext.SaveChanges();

                MessageBox.Show($"{person.FirstName}, {person.LastName} has been successfully updated!");

                this.Hide();
                Form1 mainPage = new Form1();
                mainPage.ShowDialog();
            }
            else
            {
                MessageBox.Show(missingValues);
            }
        }
    }
}
