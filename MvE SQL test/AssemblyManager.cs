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
    public partial class AssemblyManager : Form
    {
        public AssemblyManager()
        {
            InitializeComponent();
        }

        public void TotalRefresh()
        {

            Int32 selectedrowindex = dgvAssemblies.SelectedCells[0].RowIndex;
            DataGridViewRow SelectedRow = dgvAssemblies.Rows[selectedrowindex];
            string AssemblyId = Convert.ToString(SelectedRow.Cells["Assembly_id"].Value);

            if (dgvAssemblies.SelectedRows.Count == 0)
            {
                MessageBox.Show("No assembly selected");
            }

            else if (dgvAssemblies.SelectedRows.Count == 1)
            {
                // Create the connection.
                string connectionstring = Properties.Settings.Default.connString;
                using (MySqlConnection connection = new MySqlConnection(connectionstring))
                {
                    // mysql string parts
                    const string mysqlString1 = "SELECT * FROM Victoriam.T_ASSEMBLYDETAILPART WHERE Assembly = ";
                    string mysqlString = mysqlString1 + AssemblyId;
                    using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString, connection))
                    {
                        try
                        {
                            connection.Open();
                            using (MySqlDataReader dr = mysqlcommand.ExecuteReader())
                            {
                                DataTable dt = new DataTable();
                                dt.Load(dr);
                                this.dgvAssemblyParts.DataSource = dt;
                                dr.Close();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Assembly parts could not be loaded");
                        }
                    }

                    // mysql string operations
                    const string mysqlString2 = "SELECT * FROM Victoriam.T_ASSEMBLYDETAILOPERATION WHERE Assembly = ";
                    string mysqlString3 = mysqlString2 + AssemblyId;
                    using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString3, connection))
                    {

                        try
                        {
                            // connection.Open();
                            using (MySqlDataReader dr = mysqlcommand.ExecuteReader())
                            {
                                DataTable dt = new DataTable();
                                dt.Load(dr);
                                this.dgvAssemblyOps.DataSource = dt;
                                dr.Close();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Assembly operations could not be loaded");
                        }
                    }


                }
            }

            else if (dgvAssemblies.SelectedRows.Count > 1)
            {
                MessageBox.Show("More than one assembly selected. Please select one assembly");
            }


        }
        
        private void btnFinnish_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoadAssemblies_Click(object sender, EventArgs e)
        {
            // Create the connection.
            string connectionstring = Properties.Settings.Default.connString;
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                // mysql string
                const string mysqlString = "SELECT * FROM Victoriam.T_ASSEMBLY";
                using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString, connection))
                {
                    try
                    {
                        connection.Open();

                        using (MySqlDataReader dr = mysqlcommand.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dr);
                            this.dgvAssemblies.DataSource = dt;
                            dr.Close();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Assemblies could not be loaded");
                    }
                }
            }
        }

        private void btnSeeDetails_Click(object sender, EventArgs e)
        {
            TotalRefresh();
        }

        private void btnAssemblyLock_Click(object sender, EventArgs e)
        {
            Int32 selectedrowindex = dgvAssemblies.SelectedCells[0].RowIndex;
            DataGridViewRow SelectedRow = dgvAssemblies.Rows[selectedrowindex];
            string AssemblyId = Convert.ToString(SelectedRow.Cells["Assembly_id"].Value);



            // Create the connection.
            string connectionstring = Properties.Settings.Default.connString;
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                MessageBox.Show("Nog te doen");              

            }

        }

        private void btnNewAssembly_Click(object sender, EventArgs e)
        {
            Form frm = new NewAssembly();
            frm.Show();
        }

        
        
        public static string AssemblyID = "";
        public void btnAddPart_Click(object sender, EventArgs e)
        {
            Int32 selectedrowindex = dgvAssemblies.SelectedCells[0].RowIndex;
            DataGridViewRow SelectedRow = dgvAssemblies.Rows[selectedrowindex];
            string AssemblyId = Convert.ToString(SelectedRow.Cells["Assembly_id"].Value);
            AssemblyID = AssemblyId;

            Form frm = new NewAssemblyDetailPart();
            frm.Show();

        }

        private void btnRemovePart_Click(object sender, EventArgs e)
        {
            Int32 selectedrowindex = dgvAssemblyParts.SelectedCells[0].RowIndex;
            DataGridViewRow SelectedRow = dgvAssemblyParts.Rows[selectedrowindex];
            string AssemblyPartId = Convert.ToString(SelectedRow.Cells["Assemblydetailpart_id"].Value);

            if (dgvAssemblyParts.SelectedRows.Count == 0)
            {
                MessageBox.Show("No part selected");
            }

            else if (dgvAssemblyParts.SelectedRows.Count == 1)
            {
                // Create the connection.
                string connectionstring = Properties.Settings.Default.connString;
                using (MySqlConnection connection = new MySqlConnection(connectionstring))
                {
                    // mysql string parts
                    const string mysqlString1 = "DELETE FROM Victoriam.T_ASSEMBLYDETAILPART WHERE Assemblydetailpart_id = ";
                    string mysqlString = mysqlString1 + AssemblyPartId;
                    using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString, connection))
                    {
                        try
                        {
                            connection.Open();
                            mysqlcommand.ExecuteNonQuery();
                        }
                        catch
                        {
                            MessageBox.Show("Part could not be removed");
                        }
                    }                   

                }
            }

            else if (dgvAssemblyParts.SelectedRows.Count > 1)
            {
                MessageBox.Show("More than one part selected. Please select one part");
            }

            TotalRefresh();

        }


    }
}
