namespace DesignImplementation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCreatePerson_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddPerson addPersonForm = new();
            addPersonForm.ShowDialog();
        }
    }
}