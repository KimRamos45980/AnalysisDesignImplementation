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
    public partial class DeletePerson : Form
    {
        public DeletePerson()
        {
            InitializeComponent();
        }

        public static Person delete { get; set; }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            LbFullName.Text = delete.FirstName + " " + delete.LastName;
            LbStreetAddress.Text = delete.StreetAddress;
            LbCity.Text = delete.City;
            LbState.Text = delete.State;
            LbZipCode.Text = delete.ZipCode;
            LbPhoneNumber.Text = delete.PhoneNumber;
        }

        private void BtnDismiss_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mainPage = new Form1();
            mainPage.ShowDialog();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            using DesignImplementationContext dbContext = new();

            var person = dbContext.Person.Find(delete.Id);

            dbContext.Person.Remove(person);
            dbContext.SaveChanges();

            this.Hide();
            Form1 mainPage = new Form1();
            mainPage.ShowDialog();
        }
    }
}
