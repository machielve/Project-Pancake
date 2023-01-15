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
    public partial class ManagerPart : Form
    {

        public static string PartID = "";
        public void PartRefresh()
        {
            // Create the connection.
            string connectionstring = Properties.Settings.Default.connString;
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                // mysql string
                const string mysqlString = "SELECT * FROM Victoriam.T_PART";

                using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString, connection))
                {
                    try
                    {
                        connection.Open();

                        using (MySqlDataReader dr = mysqlcommand.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dr);
                            this.dgvParts.DataSource = dt;
                            dr.Close();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Parts could not be loaded");
                    }
                }
            }

        }
        
        public void TotalRefresh()
        {

            string AssemblyId = (txtPartID.Text);

            if (dgvParts.SelectedRows.Count == 0)
            {
                MessageBox.Show("No part selected");
            }

            else if (dgvParts.SelectedRows.Count == 1)
            {
                // Create the connection.
                string connectionstring = Properties.Settings.Default.connString;
                using (MySqlConnection connection = new MySqlConnection(connectionstring))
                {
                    // mysql string parts
                    string mysqlString1 = "SELECT PartSupplier_id, " +
                                                    "T_PART.Name, " +
                                                    "T_SUPPLIER.Name, " +
                                                    "Price ";
                    string mysqlString2 = "FROM Victoriam.T_PARTSUPPLIER "; 
                    string mysqlString3 = "LEFT JOIN Victoriam.T_PART ON Victoriam.T_PARTSUPPLIER.Part=Victoriam.T_PART.Part_id ";
                    string mysqlString4 = "LEFT JOIN Victoriam.T_SUPPLIER ON Victoriam.T_PARTSUPPLIER.Supplier= Victoriam.T_SUPPLIER.Supplier_id ";

                    string mysqlString10 = "WHERE Part = ";

                    string mysqlString = mysqlString1 + mysqlString2 + mysqlString3 + mysqlString4 + mysqlString10 + AssemblyId;
                    using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString, connection))
                    {
                        try
                        {
                            connection.Open();
                            using (MySqlDataReader dr = mysqlcommand.ExecuteReader())
                            {
                                DataTable dt = new DataTable();
                                dt.Load(dr);
                                this.dgvSuppliers.DataSource = dt;
                                dr.Close();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Suppliers could not be loaded");
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }

                }
            }

            else if (dgvParts.SelectedRows.Count > 1)
            {
                MessageBox.Show("More than one part selected. Please select one part");
            }


        }
        
        public ManagerPart()
        {
            InitializeComponent();
        }

        private void btnFinnish_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoadParts_Click(object sender, EventArgs e)
        {
            PartRefresh();
            
        }

        private void btnNewPart_Click(object sender, EventArgs e)
        {
            Form frm = new NewPart();
            frm.FormClosing += new FormClosingEventHandler(this.NewPart_Formclosing);
            frm.Show();
        }

        private void btnLoadSuppliers_Click(object sender, EventArgs e)
        {
            Int32 selectedrowindex = dgvParts.SelectedCells[0].RowIndex;
            DataGridViewRow SelectedRow = dgvParts.Rows[selectedrowindex];
            string PartID = Convert.ToString(SelectedRow.Cells["Part_id"].Value);

            txtPartID.Text = PartID;


            TotalRefresh();
        }

        private void NewPart_Formclosing(object sender, EventArgs e)
        {
            PartRefresh();

        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {

            Int32 selectedrowindex = dgvParts.SelectedCells[0].RowIndex;
            DataGridViewRow SelectedRow = dgvParts.Rows[selectedrowindex];
            string PartId = Convert.ToString(SelectedRow.Cells["Part_id"].Value);
            PartID = PartId;

            Form frm = new NewPartSupplier();
            frm.FormClosing += new FormClosingEventHandler(this.NewPartSUpplier_Formclosing);
            frm.Show();

        }

        public void NewPartSUpplier_Formclosing(object sender, EventArgs e)
        {
            TotalRefresh();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 selectedrowindex = dgvSuppliers.SelectedCells[0].RowIndex;
            DataGridViewRow SelectedRow = dgvSuppliers.Rows[selectedrowindex];
            string AssemblyOpsId = Convert.ToString(SelectedRow.Cells["PartSupplier_id"].Value);

            if (dgvSuppliers.SelectedRows.Count == 0)
            {
                MessageBox.Show("No supplier selected");
            }

            else if (dgvSuppliers.SelectedRows.Count == 1)
            {
                // Create the connection.
                string connectionstring = Properties.Settings.Default.connString;
                using (MySqlConnection connection = new MySqlConnection(connectionstring))
                {
                    // mysql string parts
                    const string mysqlString1 = "DELETE FROM Victoriam.T_PARTSUPPLIER WHERE PartSupplier_id = ";
                    string mysqlString = mysqlString1 + AssemblyOpsId;
                    using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString, connection))
                    {
                        try
                        {
                            connection.Open();
                            mysqlcommand.ExecuteNonQuery();
                        }
                        catch
                        {
                            MessageBox.Show("Supplier could not be removed");
                        }
                    }

                }
            }

            else if (dgvSuppliers.SelectedRows.Count > 1)
            {
                MessageBox.Show("More than one supplier selected. Please select one supplier");
            }

            TotalRefresh();
        }
    }
}
