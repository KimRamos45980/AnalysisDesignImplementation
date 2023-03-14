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

        public static Person person = new Person();

        private void BtnEditPerson_Click(Object sender, EventArgs e)
        {

        }

        private void dataGridViewPerson_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int row = dataGridViewPerson.CurrentRow.Index;
            //person.Id = int.Parse(dataGridViewPerson[0, row].Value.ToString());
            //person.FirstName = dataGridViewPerson[1, row].Value.ToString();
            //person.LastName = dataGridViewPerson[2, row].Value.ToString();
            //person.StreetAddress = dataGridViewPerson[3, row].Value.ToString();
            //person.City = dataGridViewPerson[4, row].Value.ToString();
            //person.State = dataGridViewPerson[5, row].Value.ToString();
            //person.ZipCode = dataGridViewPerson[6, row].Value.ToString();
            //person.PhoneNumber = dataGridViewPerson[7, row].Value.ToString();
        }
    }
}