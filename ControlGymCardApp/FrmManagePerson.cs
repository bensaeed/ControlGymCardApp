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
    public partial class FrmManagePerson : Form
    {
        public FrmManagePerson()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmPerson frmPerson = new FrmPerson();
            frmPerson.ShowDialog();
        }
    }
}
