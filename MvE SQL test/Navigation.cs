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


        private void btnGoToAdd_Click_1(object sender, EventArgs e)
        {
            Form frm = new NewCustomer();
            frm.Show();

        }

        private void btnGoToFillOrCancel_Click_1(object sender, EventArgs e)
        {
            Form frm = new FillOrCancel();
            frm.ShowDialog();

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
