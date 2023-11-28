using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_pancake
{
    public partial class DetailPart : Form
    {
        public DetailPart()
        {
            InitializeComponent();
        }

        private void BtnFinnish_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
