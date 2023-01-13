using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MvE_SQL_test
{
    public partial class Navigation : Form
    {
        public Navigation()
        {
            InitializeComponent();
        }

        private void Navigation_Load(object sender, EventArgs e)
        {

        }



        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            Form frm = new NewUnit();
            frm.Show();
        }

        private void btnProjectManager_Click(object sender, EventArgs e)
        {   

            Form frm = new ProjectManager();
            frm.Show();

        }

        private void btnAssemblyManager_Click(object sender, EventArgs e)
        {
            Form frm = new AssemblyManager();
            frm.Show();

        }

        private void btnPartManager_Click(object sender, EventArgs e)
        {
            Form frm = new PartManager();
            frm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new NewMaterial();
            frm.Show();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
