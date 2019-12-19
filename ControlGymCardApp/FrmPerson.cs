using ControlGymCardApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlGymCardApp
{
    public partial class FrmPerson : Form
    {
        public FrmPerson()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var NewItem = new vmPerson
            {
                FirstName = txtFisrtName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                FatherName=txtFatherName.Text.Trim(),
                National_Number=txtNoNumber.Text.Trim(),
                Birthday=txtBirthday.Text.Trim(),
                Mobile=txtMobile.Text.Trim()
            };
        }
    }
}
