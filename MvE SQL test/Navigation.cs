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
            

        }

        private void BtnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        public string ConnectorString()
        {
            string ConnString = "server=" + txtIPAdres.Text + ";user id=" + txtUserName.Text + ";persistsecurityinfo=True;database=" + txtDatabse.Text + ";password=" + txtPassword.Text;

            return ConnString;
        }




        private void BtnConnectSQL_Click(object sender, EventArgs e)
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
                        RefreshUnits();
                        RefreshMaterial();
                        RefreshRelations();
                        RefreshOperatons();
                        RefreshMachines();
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
        private void RdbIPAdres1_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbIPAdres1.Checked) //If checked == true
            {
                txtIPAdres.Text = txtIPIntern.Text;
                //example
            }

        }
        private void RdbIPAdres2_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbIPAdres2.Checked) //If checked == true
            {
                txtIPAdres.Text = txtIPExtern.Text;
                //example
            }
        }
        


        private void BtnProjectManager_Click(object sender, EventArgs e)
        {
            string connectionstring = ConnectorString();
            Form frm = new ManagerProject();
            ManagerProject.ConnString = connectionstring;
            frm.Show();

        }
        private void BtnAssemblyManager_Click(object sender, EventArgs e)
        {
            string connectionstring = ConnectorString(); 
            Form frm = new ManagerAssembly();
            ManagerAssembly.ConnString = connectionstring;
            frm.Show();

        }
        private void BtnPartManager_Click(object sender, EventArgs e)
        {
            string connectionstring = ConnectorString(); 
            Form frm = new ManagerPart();
            ManagerPart.ConnString = connectionstring;
            frm.Show();

        }
        private void BtnStockManager_Click(object sender, EventArgs e)
        {
            string connectionstring = ConnectorString(); 
            Form frm = new ManagerStock();
            ManagerStock.ConnString = connectionstring;
            frm.Show();

        }
        private void BtnJobOrderManager_Click(object sender, EventArgs e)
        {
            string connectionstring = ConnectorString(); 
            Form frm = new ManagerJobOrders();
            ManagerJobOrders.ConnString = connectionstring;
            frm.Show();

        }











        public void RefreshMaterial()
        {
            // Create the connection.
            string connectionstring = ConnectorString();
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
                            this.DgvMaterials.DataSource = dt;
                            dr.Close();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Materials could not be loaded");
                    }
                    finally
                    {
                        DgvMaterials.AutoResizeColumns();
                        connection.Close();

                    }
                }
            }

        }
        private void BtnNewMaterial_Click(object sender, EventArgs e)
        {
            string connectionstring = ConnectorString(); 
            Form frm = new NewMaterial();
            NewMaterial.ConnString = connectionstring;
            frm.FormClosing += new FormClosingEventHandler(this.NewMaterial_Formclosing);
            frm.Show();

        }
        public void NewMaterial_Formclosing(object sender, EventArgs e)
        {
            RefreshMaterial();
        }
        private void BtnLoadMaterials_Click(object sender, EventArgs e)
        {
            RefreshMaterial();

        }


        public void RefreshRelations()
        {
            // Create the connection.
            string connectionstring = ConnectorString();
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                // mysql string
                const string mysqlString = "SELECT * FROM Victoriam.T_RELATION";

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
                            this.DgvRelations.DataSource = dt;
                            dr.Close();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Relations could not be loaded");
                    }
                    finally
                    {
                        DgvRelations.AutoResizeColumns();
                        connection.Close();

                    }
                }
            }
        }
        private void BtnNewRelation_Click(object sender, EventArgs e)
        {
            string connectionstring = ConnectorString(); 
            Form frm = new NewRelation();
            NewRelation.ConnString = connectionstring;
            frm.FormClosing += new FormClosingEventHandler(this.NewRelation_Formclosing);
            frm.Show();

        }
        public void NewRelation_Formclosing(object sender, EventArgs e)
        {
            RefreshRelations();
        }
        private void BtnLoadRelations_Click(object sender, EventArgs e)
        {
            RefreshRelations();

        }





        public void RefreshUnits()
        {
            // Create the connection.
            string connectionstring = ConnectorString();
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
                            this.DgvUnits.DataSource = dt;
                            dr.Close();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Units could not be loaded");
                    }
                    finally
                    {
                        DgvUnits.AutoResizeColumns();
                        connection.Close();

                    }
                }
            }
        }
        private void BtnAddUnit_Click(object sender, EventArgs e)
        {
            string connectionstring = ConnectorString(); 
            Form frm = new NewUnit();
            NewUnit.ConnString = connectionstring;
            frm.FormClosing += new FormClosingEventHandler(this.NewUnit_Formclosing);
            frm.Show();
        }
        public void NewUnit_Formclosing(object sender, EventArgs e)
        {
            RefreshUnits();
        }
        private void BtnLoadUnits_Click(object sender, EventArgs e)
        {
            RefreshUnits();

        }


        public void RefreshOperatons()
        {
            // Create the connection.
            string connectionstring = ConnectorString();
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
                            this.DgvOperations.DataSource = dt;
                            DgvOperations.AutoResizeColumns();
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
        private void BtnNewOperation_Click(object sender, EventArgs e)
        {
            string connectionstring = ConnectorString(); 
            Form frm = new NewOperation();
            NewOperation.ConnString = connectionstring;
            frm.FormClosing += new FormClosingEventHandler(this.NewOperation_Formclosing);
            frm.Show();
        }
        public void NewOperation_Formclosing(object sender, EventArgs e)
        {
            RefreshOperatons();
        }
        private void BtnLoadOperations_Click(object sender, EventArgs e)
        {
            RefreshOperatons();

        }


        public void RefreshMachines()
        {
            // Create the connection.
            string connectionstring = ConnectorString();
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                // mysql string
                const string mysqlString = "SELECT * FROM Victoriam.T_MACHINE";

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
                            this.DgvMachines.DataSource = dt;
                            DgvMachines.AutoResizeColumns();
                            dr.Close();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Machines could not be loaded");
                    }
                    
                }
            }
        }

        private void BtnLoadMachines_Click(object sender, EventArgs e)
        {
            RefreshMachines();
        }
    }
}
