using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
