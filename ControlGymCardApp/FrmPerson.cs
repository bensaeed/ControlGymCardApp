using ControlGymCardApp.Helpers;
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
            bool ValidateFlag = true;
            if (  Utility.IsNull(txtFirstName.Text.Trim()) 
                || Utility.IsNull(txtLastName.Text.Trim())
                || Utility.IsNull(txtNoNumber.Text.Trim()))
            { 
                ValidateFlag = false;
                MessageBox.Show("لطفا فيلدهاي ستاره دار را وارد كنيد");
                return;
            }
            var NewItem = new vmPerson
            {
                FirstName = txtFirstName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                FatherName = Utility.CheckNullString(txtFatherName.Text.Trim()),
                National_Number = txtNoNumber.Text.Trim(),
                Birthday = Utility.CheckNullString(txtBirthday.Text.Trim()),
                Mobile = Utility.CheckNullString(txtMobile.Text.Trim()),
                Phone = Utility.CheckNullString(txtPhone.Text.Trim()),
                Address = Utility.CheckNullString(txtAddress.Text.Trim()),
                Description = Utility.CheckNullString(txtDesc.Text.Trim()),
                Is_Active = rBtnDiActive.Checked ? true : false,
                Is_Deleted=false
            };
        }
    }
}
