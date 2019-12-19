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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnMngPerson_Click(object sender, EventArgs e)
        {
            FrmManagePerson objfrmManagePerson = new FrmManagePerson();
            objfrmManagePerson.ShowDialog();
        }

        private void کاربرانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManageUsers objfrmManageUsers = new FrmManageUsers();
            objfrmManageUsers.ShowDialog();
        }
    }
}
