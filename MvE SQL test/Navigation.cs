using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

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
            RefreshUnits();
            RefreshMaterial();
            RefreshSuppliers();
            RefreshOperatons();

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        public string ConnectorString()
        {
            string ConnString = "server=" + txtIPAdres.Text + ";user id=" + txtUserName.Text + ";persistsecurityinfo=True;database=" + txtDatabse.Text + ";password=" + txtPassword.Text;

            return ConnString;
        }




        private void btnConnectSQL_Click(object sender, EventArgs e)
        {
            string connectionstring = ConnectorString();

            if (txtIPAdres.Text != "")
            {
               using (MySqlConnection connection = new MySqlConnection(connectionstring))
                {
                    try
                    {
                        connection.Open();
                        ConnectedBox.Checked = true;
                        MessageBox.Show("Connected to database");
                        return;
                    }
                    catch 
                    {
                        MessageBox.Show("Could not connect to database");
                        ConnectedBox.Checked = false;
                        return;
                    }
                }

            }

            else
            {
                MessageBox.Show("No IP adres selected");
                ConnectedBox.Checked = false;
            }

        }
        private void rdbIPAdres1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbIPAdres1.Checked) //If checked == true
            {
                txtIPAdres.Text = txtIPIntern.Text;
                //example
            }

        }
        private void rdbIPAdres2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbIPAdres2.Checked) //If checked == true
            {
                txtIPAdres.Text = txtIPExtern.Text;
                //example
            }
        }
        


        private void btnProjectManager_Click(object sender, EventArgs e)
        {   

            Form frm = new ManagerProject();
            frm.Show();

        }
        private void btnAssemblyManager_Click(object sender, EventArgs e)
        {
            Form frm = new ManagerAssembly();
            frm.Show();

        }
        private void btnPartManager_Click(object sender, EventArgs e)
        {
            Form frm = new ManagerPart();
            frm.Show();

        }
        private void btnStockManager_Click(object sender, EventArgs e)
        {
            Form frm = new ManagerStock();
            frm.Show();

        }
        private void btnJobOrderManager_Click(object sender, EventArgs e)
        {
            Form frm = new ManagerJobOrders();
            frm.Show();

        }











        public void RefreshMaterial()
        {
            // Create the connection.
            string connectionstring = Properties.Settings.Default.connString;
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                // mysql string
                const string mysqlString = "SELECT * FROM Victoriam.T_MATERIAL";

                using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString, connection))
                {
                    try
                    {
                        connection.Open();

                        using (MySqlDataReader dr = mysqlcommand.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dr);
                            dt.DefaultView.Sort = ("Name ASC");
                            this.dgvMaterials.DataSource = dt;
                            dr.Close();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Materials could not be loaded");
                    }
                }
            }

        }
        private void btnNewMaterial_Click(object sender, EventArgs e)
        {
            Form frm = new NewMaterial();
            frm.FormClosing += new FormClosingEventHandler(this.NewMaterial_Formclosing);
            frm.Show();

        }
        public void NewMaterial_Formclosing(object sender, EventArgs e)
        {
            RefreshMaterial();
        }
        private void btnLoadMaterials_Click(object sender, EventArgs e)
        {
            RefreshMaterial();

        }







        public void RefreshSuppliers()
        {
            // Create the connection.
            string connectionstring = Properties.Settings.Default.connString;
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                // mysql string
                const string mysqlString = "SELECT * FROM Victoriam.T_SUPPLIER";

                using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString, connection))
                {
                    try
                    {
                        connection.Open();

                        using (MySqlDataReader dr = mysqlcommand.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dr);
                            dt.DefaultView.Sort = ("Name ASC");
                            this.dgvSuppliers.DataSource = dt;
                            dr.Close();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Suppliers could not be loaded");
                    }
                }
            }
        }
        private void btnNewSupplier_Click(object sender, EventArgs e)
        {
            Form frm = new NewSupplier();
            frm.FormClosing += new FormClosingEventHandler(this.NewSupplier_Formclosing);
            frm.Show();

        }
        public void NewSupplier_Formclosing(object sender, EventArgs e)
        {
            RefreshSuppliers();
        }
        private void btnLoadSuppliers_Click(object sender, EventArgs e)
        {
            RefreshSuppliers();

        }





        public void RefreshUnits()
        {
            // Create the connection.
            string connectionstring = Properties.Settings.Default.connString;
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                // mysql string
                const string mysqlString = "SELECT * FROM Victoriam.T_UNIT";

                using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString, connection))
                {
                    try
                    {
                        connection.Open();

                        using (MySqlDataReader dr = mysqlcommand.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dr);
                            dt.DefaultView.Sort = ("uGroup ASC");
                            this.dgvUnits.DataSource = dt;
                            dr.Close();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Units could not be loaded");
                    }
                }
            }
        }
        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            Form frm = new NewUnit();
            frm.FormClosing += new FormClosingEventHandler(this.NewUnit_Formclosing);
            frm.Show();
        }
        public void NewUnit_Formclosing(object sender, EventArgs e)
        {
            RefreshUnits();
        }
        private void btnLoadUnits_Click(object sender, EventArgs e)
        {
            RefreshUnits();

        }





        public void RefreshOperatons()
        {
            // Create the connection.
            string connectionstring = Properties.Settings.Default.connString;
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                // mysql string
                const string mysqlString = "SELECT * FROM Victoriam.T_OPERATION";

                using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString, connection))
                {
                    try
                    {
                        connection.Open();

                        using (MySqlDataReader dr = mysqlcommand.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dr);
                            dt.DefaultView.Sort = ("Name ASC");
                            this.dgvOperations.DataSource = dt;
                            dr.Close();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Operatins could not be loaded");
                    }
                }
            }
        }
        private void btnNewOperation_Click(object sender, EventArgs e)
        {
            Form frm = new NewOperation();
            frm.FormClosing += new FormClosingEventHandler(this.NewOperation_Formclosing);
            frm.Show();
        }
        public void NewOperation_Formclosing(object sender, EventArgs e)
        {
            RefreshOperatons();
        }
        private void btnLoadOperations_Click(object sender, EventArgs e)
        {
            RefreshOperatons();

        }

        
    }
}
