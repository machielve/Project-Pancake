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

        public static string AssemblyID = "";

        public void AssemblyRefresh()
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
        public void TotalRefresh()
        {

            string AssemblyId=(txtAssemblyID.Text);

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

        public void Assemblyupdate()
        {
            string AssemblyId = txtAssemblyID.Text;


            if (AssemblyId == "")
            {
                MessageBox.Show("No assembly selected");
            }

            else
            {
                // Create the connection.
                string connectionstring = Properties.Settings.Default.connString;
                using (MySqlConnection connection = new MySqlConnection(connectionstring))
                {
                    decimal TotalCostprice = 0;
                    decimal TotalWeight = 0;

                    //mysql string detail parts price
                    string mysqlString1 = "SELECT SUM(CostPrice) FROM Victoriam.T_ASSEMBLYDETAILPART WHERE Assembly = ";
                    string mysqlString2 = AssemblyId;
                    string mysqlString3 = mysqlString1 + mysqlString2;
                    using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString3, connection))
                    {
                        try
                        {
                            connection.Open();
                            mysqlcommand.ExecuteNonQuery();
                            using (MySqlDataReader dr = mysqlcommand.ExecuteReader())
                            {
                                dr.Read();
                                decimal Cost = Convert.ToDecimal(dr.GetValue(0).ToString());
                                TotalCostprice += Cost;
                                dr.Close();
                            }

                        }
                        catch
                        {
                            MessageBox.Show("Assembly detail parts price could not be loaded");
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }

                    //mysql string detail parts weight
                    string mysqlString30 = "SELECT SUM(Weight) FROM Victoriam.T_ASSEMBLYDETAILPART WHERE Assembly = ";
                    string mysqlString31 = AssemblyId;
                    string mysqlString33 = mysqlString30 + mysqlString31;
                    using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString33, connection))
                    {
                        try
                        {
                            connection.Open();
                            mysqlcommand.ExecuteNonQuery();
                            using (MySqlDataReader dr = mysqlcommand.ExecuteReader())
                            {
                                dr.Read();
                                decimal Weight = Convert.ToDecimal(dr.GetValue(0).ToString());
                                TotalWeight += Weight;
                                dr.Close();
                            }

                        }
                        catch
                        {
                            MessageBox.Show("Assembly detail parts weight could not be loaded");
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }

                    //mysql string detail ops price
                    string mysqlString10 = "SELECT SUM(CostPrice) FROM Victoriam.T_ASSEMBLYDETAILOPERATION WHERE Assembly = ";
                    string mysqlString11 = AssemblyId;
                    string mysqlString12 = mysqlString10 + mysqlString11;
                    using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString12, connection))
                    {
                        try
                        {
                            connection.Open();
                            mysqlcommand.ExecuteNonQuery();
                            using (MySqlDataReader dr = mysqlcommand.ExecuteReader())
                            {
                                dr.Read();
                                decimal Cost = Convert.ToDecimal(dr.GetValue(0).ToString());
                                TotalCostprice += Cost;
                                dr.Close();
                            }

                        }
                        catch
                        {
                            MessageBox.Show("Assembly detail operation price could not be loaded");
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }

                    // mysql string assembly price
                    string mysqlString20 = "UPDATE Victoriam.T_ASSEMBLY SET CostPrice = ";
                    string mysqlString21 = TotalCostprice.ToString();
                    string mysqlString22 = "WHERE Assembly_id = ";
                    string mysqlString23 = AssemblyId.ToString();
                    string mysqlString24 = mysqlString20 + mysqlString21 + mysqlString22 + mysqlString23;

                    using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString24, connection))
                    {
                        try
                        {
                            connection.Open();
                            mysqlcommand.ExecuteNonQuery();
                        }
                        catch
                        {
                            MessageBox.Show("Assembly price could not be Updated");
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }

                    // mysql string assembly weight
                    string mysqlString40 = "UPDATE Victoriam.T_ASSEMBLY SET Weight = ";
                    string mysqlString41 = TotalWeight.ToString();
                    string mysqlString42 = "WHERE Assembly_id = ";
                    string mysqlString43 = AssemblyId.ToString();
                    string mysqlString44 = mysqlString40 + mysqlString41 + mysqlString42 + mysqlString43;

                    using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString44, connection))
                    {
                        try
                        {
                            connection.Open();
                            mysqlcommand.ExecuteNonQuery();
                        }
                        catch
                        {
                            MessageBox.Show("Assembly weight could not be Updated");
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }

                }
            }

           
        }




        private void btnFinnish_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoadAssemblies_Click(object sender, EventArgs e)
        {
            AssemblyRefresh();
        }

        private void btnNewAssembly_Click(object sender, EventArgs e)
        {
            Form frm = new NewAssembly();
            
            frm.Show();
        }
              

        private void btnSeeDetails_Click(object sender, EventArgs e)
        {
            Int32 selectedrowindex = dgvAssemblies.SelectedCells[0].RowIndex;
            DataGridViewRow SelectedRow = dgvAssemblies.Rows[selectedrowindex];
            string AssemblyId = Convert.ToString(SelectedRow.Cells["Assembly_id"].Value);

            txtAssemblyID.Text = AssemblyId;


            TotalRefresh();
        }

        private void btnAssemblyLock_Click(object sender, EventArgs e)
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
                    // mysql string assembly
                    const string mysqlString1 = "UPDATE Victoriam.T_ASSEMBLY SET Locked = 1 WHERE Assembly_id = ";
                    string mysqlString = mysqlString1 + AssemblyId;
                    using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString, connection))
                    {
                        try
                        {
                            connection.Open();
                            mysqlcommand.ExecuteNonQuery();
                        }
                        catch
                        {
                            MessageBox.Show("Assembly could not be locked");
                        }
                    }

                    //mysql string detail parts
                    const string mysqlString4 = "UPDATE Victoriam.T_ASSEMBLYDETAILPART SET Locked = 1 WHERE Assembly = ";
                    string mysqlString5 = mysqlString4 + AssemblyId;
                    using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString5, connection))
                    {
                        try
                        {                            
                            mysqlcommand.ExecuteNonQuery();
                        }
                        catch
                        {
                            MessageBox.Show("Assembly detail parts could not be locked");
                        }
                    }

                    //mysql string detail ops
                    const string mysqlString7 = "UPDATE Victoriam.T_ASSEMBLYDETAILOPERATION SET Locked = 1 WHERE Assembly = ";
                    string mysqlString8 = mysqlString7 + AssemblyId;
                    using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString8, connection))
                    {
                        try
                        {
                            mysqlcommand.ExecuteNonQuery();
                        }
                        catch
                        {
                            MessageBox.Show("Assembly detail operations could not be locked");
                        }
                    }

                }
            }

            else if (dgvAssemblies.SelectedRows.Count > 1)
            {
                MessageBox.Show("More than one assembly selected. Please select one assembly");
            }

            TotalRefresh();
            AssemblyRefresh();

        }              
        
        public void btnAddPart_Click(object sender, EventArgs e)
        {
            Int32 selectedrowindex = dgvAssemblies.SelectedCells[0].RowIndex;
            DataGridViewRow SelectedRow = dgvAssemblies.Rows[selectedrowindex];
            string AssemblyId = Convert.ToString(SelectedRow.Cells["Assembly_id"].Value);
            
            AssemblyID = AssemblyId;

            Form frm = new NewAssemblyDetailPart();
            frm.FormClosing += new FormClosingEventHandler(this.NewAssemblyDetailPart_Formclosing);
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

        private void btnRemoveOperation_Click(object sender, EventArgs e)
        {
            Int32 selectedrowindex = dgvAssemblyOps.SelectedCells[0].RowIndex;
            DataGridViewRow SelectedRow = dgvAssemblyOps.Rows[selectedrowindex];
            string AssemblyOpsId = Convert.ToString(SelectedRow.Cells["Assemblydetailoperation_id"].Value);

            if (dgvAssemblyOps.SelectedRows.Count == 0)
            {
                MessageBox.Show("No operation selected");
            }

            else if (dgvAssemblyOps.SelectedRows.Count == 1)
            {
                // Create the connection.
                string connectionstring = Properties.Settings.Default.connString;
                using (MySqlConnection connection = new MySqlConnection(connectionstring))
                {
                    // mysql string parts
                    const string mysqlString1 = "DELETE FROM Victoriam.T_ASSEMBLYDETAILOPERATION WHERE Assemblydetailoperation_id = ";
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
                            MessageBox.Show("Operation could not be removed");
                        }
                    }

                }
            }

            else if (dgvAssemblyOps.SelectedRows.Count > 1)
            {
                MessageBox.Show("More than one operation selected. Please select one operation");
            }

            TotalRefresh();
        }

        private void btnAssemblyUnlock_Click(object sender, EventArgs e)
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
                    // mysql string assembly
                    const string mysqlString1 = "UPDATE Victoriam.T_ASSEMBLY SET Locked = 0 WHERE Assembly_id = ";
                    string mysqlString = mysqlString1 + AssemblyId;
                    using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString, connection))
                    {
                        try
                        {
                            connection.Open();
                            mysqlcommand.ExecuteNonQuery();
                        }
                        catch
                        {
                            MessageBox.Show("Assembly could not be unlocked");
                        }
                    }

                    //mysql string detail parts
                    const string mysqlString4 = "UPDATE Victoriam.T_ASSEMBLYDETAILPART SET Locked = 0 WHERE Assembly = ";
                    string mysqlString5 = mysqlString4 + AssemblyId;
                    using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString5, connection))
                    {
                        try
                        {
                            mysqlcommand.ExecuteNonQuery();
                        }
                        catch
                        {
                            MessageBox.Show("Assembly detail parts could not be unlocked");
                        }
                    }

                    //mysql string detail ops
                    const string mysqlString7 = "UPDATE Victoriam.T_ASSEMBLYDETAILOPERATION SET Locked = 0 WHERE Assembly = ";
                    string mysqlString8 = mysqlString7 + AssemblyId;
                    using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString8, connection))
                    {
                        try
                        {
                            mysqlcommand.ExecuteNonQuery();
                        }
                        catch
                        {
                            MessageBox.Show("Assembly detail operations could not be unlocked");
                        }
                    }

                }
            }

            else if (dgvAssemblies.SelectedRows.Count > 1)
            {
                MessageBox.Show("More than one assembly selected. Please select one assembly");
            }

            TotalRefresh();
            AssemblyRefresh();

        }

        private void btnAddOperation_Click(object sender, EventArgs e)
        {
            Int32 selectedrowindex = dgvAssemblies.SelectedCells[0].RowIndex;
            DataGridViewRow SelectedRow = dgvAssemblies.Rows[selectedrowindex];
            string AssemblyId = Convert.ToString(SelectedRow.Cells["Assembly_id"].Value);
            AssemblyID = AssemblyId;

            Form frm = new NewAssemblyDetailOps();
            frm.FormClosing += new FormClosingEventHandler(this.NewAssemblyDetailOperation_Formclosing);
            frm.Show();

        }

        private void AssemblyManager_Load(object sender, EventArgs e)
        {
            AssemblyRefresh();

        }

        public void NewAssemblyDetailPart_Formclosing(object sender, EventArgs e)
        {           
            AssemblyRefresh();
            TotalRefresh();

        }
        public void NewAssemblyDetailOperation_Formclosing(object sender, EventArgs e)
        {
            AssemblyRefresh();
            TotalRefresh();

        }

        private void btnUpdateAssembly_Click(object sender, EventArgs e)
        {
            Assemblyupdate();

            TotalRefresh();
            AssemblyRefresh();

        }
    }
}
