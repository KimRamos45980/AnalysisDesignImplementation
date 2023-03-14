using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace DesignImplementation
{
    public partial class Form1 : Form
    {

        private DesignImplementationContext? DbContext;

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.DbContext = new DesignImplementationContext();

            this.DbContext.Database.EnsureCreated();

            this.DbContext.Person.Load();

            this.personBindingSource.DataSource = DbContext.Person.Local.ToBindingList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.DbContext?.Dispose();
            this.DbContext = null;
        }


        private void BtnCreatePerson_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddPerson addPersonForm = new();
            addPersonForm.ShowDialog();
        }

        public static Person personInfo = new Person();

        private void BtnEditPerson_Click(Object sender, EventArgs e)
        {
            if (personInfo.Id == 0)
            {
                MessageBox.Show("Please select a person to edit");
            }
            else
            {
                this.Hide();
                EditPerson editForm = new();
                EditPerson.info = personInfo;
                editForm.ShowDialog();
            }
        }

        private void dataGridViewPerson_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewPerson.Rows[e.RowIndex];
                int selectedPerson = int.Parse(row.Cells[0].Value.ToString());

                Person ? person = (from c in DbContext.Person
                                   where c.Id == selectedPerson
                                   select c).FirstOrDefault();

                if (person != null)
                {
                    personInfo.Id = person.Id;
                    personInfo.FirstName = person.FirstName;
                    personInfo.LastName = person.LastName;
                    personInfo.StreetAddress = person.StreetAddress;
                    personInfo.City = person.City;
                    personInfo.State = person.State;
                    personInfo.ZipCode = person.ZipCode;
                    personInfo.PhoneNumber = person.PhoneNumber;
                }
            }
        }

        private void dataGridViewPerson_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewPerson_CellClick(sender, e);
            BtnEditPerson_Click(sender, e);
        }

        private void BtnDeletePerson_Click(object sender, EventArgs e)
        {
            if (personInfo.Id == 0)
            {
                MessageBox.Show("Please select a person to Delete");
            }
            else
            {
                this.Hide();
                DeletePerson deleteForm = new();
                DeletePerson.delete = personInfo;
                deleteForm.ShowDialog();
            }
        }
    }
}