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
    public partial class ManagerAssembly : Form
    {
        public ManagerAssembly()
        {
            InitializeComponent();
        }

        public static string AssemblyID = "";

        public static string ConnString { get; set; }

        public void AssemblyRefresh()
        {            
            // Create the connection.
            string connectionstring = ConnString;
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
                            dt.DefaultView.Sort = ("Name ASC");
                            this.DgvAssemblies.DataSource = dt;
                            dr.Close();
                        }

                    }
                    catch (ArgumentOutOfRangeException argumentOutOfRangeException)
                    {
                        MessageBox.Show("Error: "+ argumentOutOfRangeException.Message.ToString());
                       // MessageBox.Show("Assemblies could not be loaded");
                        
                    }

                    finally
                    {
                        DgvAssemblies.AutoResizeColumns();
                        connection.Close();

                    }
                 
                }
            }

        }
        public void TotalRefresh()
        {

            string AssemblyId=(txtAssemblyID.Text);

            if (AssemblyId == "")
            {
                MessageBox.Show("No assembly selected");
            }

            else 
            {
                // Create the connection.
                string connectionstring = ConnString;
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
                                this.DgvAssemblyParts.DataSource = dt;
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
                                this.DgvAssemblyOps.DataSource = dt;
                                dr.Close();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Assembly operations could not be loaded");
                        }
                    }

                    // mysql string subassemblies
                    const string mysqlString4 = "SELECT * FROM Victoriam.T_ASSEMBLYDETAILSUBASSEMBLY WHERE Assembly = ";
                    string mysqlString5 = mysqlString4 + AssemblyId;
                    using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString5, connection))
                    {

                        try
                        {
                            // connection.Open();
                            using (MySqlDataReader dr = mysqlcommand.ExecuteReader())
                            {
                                DataTable dt = new DataTable();
                                dt.Load(dr);
                                this.DgvAssemblySubAssembly.DataSource = dt;
                                dr.Close();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Subassemblies could not be loaded");
                        }
                    }


                }
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
                string connectionstring = ConnString;
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
                    string mysqlString20 = "SELECT SUM(CostPrice) FROM Victoriam.T_ASSEMBLYDETAILOPERATION WHERE Assembly = ";
                    string mysqlString21 = AssemblyId;
                    string mysqlString22 = mysqlString20 + mysqlString21;
                    using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString22, connection))
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


                    //mysql string detail subs price
                    string mysqlString40 = "SELECT SUM(CostPrice) FROM Victoriam.T_ASSEMBLYDETAILSUBASSEMBLY WHERE Assembly = ";
                    string mysqlString41 = AssemblyId;
                    string mysqlString42 = mysqlString40 + mysqlString41;
                    using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString42, connection))
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
                            MessageBox.Show("Assembly detail subassembly price could not be loaded");
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }

                    //mysql string detail subs weight
                    string mysqlString50 = "SELECT SUM(Weight) FROM Victoriam.T_ASSEMBLYDETAILSUBASSEMBLY WHERE Assembly = ";
                    string mysqlString51 = AssemblyId;
                    string mysqlString52 = mysqlString50 + mysqlString51;
                    using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString52, connection))
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
                            MessageBox.Show("Assembly detail subassembly weight could not be loaded");
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }






                    // mysql string assembly price
                    string mysqlString80 = "UPDATE Victoriam.T_ASSEMBLY SET CostPrice = ";
                    string mysqlString81 = TotalCostprice.ToString();
                    string mysqlString82 = "WHERE Assembly_id = ";
                    string mysqlString83 = AssemblyId.ToString();
                    string mysqlString84 = mysqlString80 + mysqlString81 + mysqlString82 + mysqlString83;

                    using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString84, connection))
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
                    string mysqlString90 = "UPDATE Victoriam.T_ASSEMBLY SET Weight = ";
                    string mysqlString91 = TotalWeight.ToString();
                    string mysqlString92 = "WHERE Assembly_id = ";
                    string mysqlString93 = AssemblyId.ToString();
                    string mysqlString94 = mysqlString90 + mysqlString91 + mysqlString92 + mysqlString93;

                    using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString94, connection))
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

        private void AssemblyManager_Load(object sender, EventArgs e)
        {
            AssemblyRefresh();

        }

        private void BtnFinnish_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void BtnLoadAssemblies_Click(object sender, EventArgs e)
        {
            AssemblyRefresh();
        }
        private void BtnNewAssembly_Click(object sender, EventArgs e)
        {
            string connectionstring = ConnString; 
            Form frm = new NewAssembly();
            NewAssembly.ConnString = connectionstring;
            frm.Show();
        }              
        public void DgvAssemblies_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvAssemblies.Focused)
            {

                Int32 selectedrowindex = DgvAssemblies.SelectedCells[0].RowIndex;
                DataGridViewRow SelectedRow = DgvAssemblies.Rows[selectedrowindex];
                string AssemblyId = Convert.ToString(SelectedRow.Cells["Assembly_id"].Value);

                txtAssemblyID.Text = AssemblyId;

                TotalRefresh();
            }
        }
        private void BtnAssemblyLock_Click(object sender, EventArgs e)
        {
            string AssemblyId = txtAssemblyID.Text;

            if (AssemblyId == "")
            {
                MessageBox.Show("No assembly selected");
            }

            else 
            {
                // Create the connection.
                string connectionstring = ConnString;
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

            TotalRefresh();
            AssemblyRefresh();

        }
        private void BtnAssemblyUnlock_Click(object sender, EventArgs e)
        {
            string AssemblyId = txtAssemblyID.Text;

            if (AssemblyId == "")
            {
                MessageBox.Show("No assembly selected");
            }

            else
            {
                // Create the connection.
                string connectionstring = ConnString;
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

            TotalRefresh();
            AssemblyRefresh();

        }
        private void BtnUpdateAssembly_Click(object sender, EventArgs e)
        {
            Assemblyupdate();

          //  TotalRefresh();
          //  AssemblyRefresh();

        }





        public void BtnAddPart_Click(object sender, EventArgs e)
        {
            string AssemblyId = txtAssemblyID.Text;
            AssemblyID = AssemblyId;
            string connectionstring = ConnString; 
            Form frm = new NewAssemblyDetailPart();
            NewAssemblyDetailPart.ConnString = connectionstring;
            frm.FormClosing += new FormClosingEventHandler(this.NewAssemblyDetailPart_Formclosing);
            frm.Show();

        }
        private void BtnRemovePart_Click(object sender, EventArgs e)
        {
            Int32 selectedrowindex = DgvAssemblyParts.SelectedCells[0].RowIndex;
            DataGridViewRow SelectedRow = DgvAssemblyParts.Rows[selectedrowindex];
            string AssemblyPartId = Convert.ToString(SelectedRow.Cells["Assemblydetailpart_id"].Value);

            if (DgvAssemblyParts.SelectedRows.Count == 0)
            {
                MessageBox.Show("No part selected");
            }

            else if (DgvAssemblyParts.SelectedRows.Count == 1)
            {
                // Create the connection.
                string connectionstring = ConnString;
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

            else if (DgvAssemblyParts.SelectedRows.Count > 1)
            {
                MessageBox.Show("More than one part selected. Please select one part");
            }

            TotalRefresh();

        }
        public void NewAssemblyDetailPart_Formclosing(object sender, EventArgs e)
        {
            AssemblyRefresh();
            TotalRefresh();

        }


        private void BtnAddOperation_Click(object sender, EventArgs e)
        {
            string AssemblyId = txtAssemblyID.Text;
            AssemblyID = AssemblyId;
            string connectionstring = ConnString;
            Form frm = new NewAssemblyDetailOps();
            NewAssemblyDetailOps.ConnString = connectionstring;
            frm.FormClosing += new FormClosingEventHandler(this.NewAssemblyDetailOperation_Formclosing);
            frm.Show();

        }
        private void BtnRemoveOperation_Click(object sender, EventArgs e)
        {
            Int32 selectedrowindex = DgvAssemblyOps.SelectedCells[0].RowIndex;
            DataGridViewRow SelectedRow = DgvAssemblyOps.Rows[selectedrowindex];
            string AssemblyOpsId = Convert.ToString(SelectedRow.Cells["Assemblydetailoperation_id"].Value);

            if (DgvAssemblyOps.SelectedRows.Count == 0)
            {
                MessageBox.Show("No operation selected");
            }

            else if (DgvAssemblyOps.SelectedRows.Count == 1)
            {
                // Create the connection.
                string connectionstring = ConnString;
                using (MySqlConnection connection = new MySqlConnection(connectionstring))
                {
                    // mysql string operation
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

            else if (DgvAssemblyOps.SelectedRows.Count > 1)
            {
                MessageBox.Show("More than one operation selected. Please select one operation");
            }

            TotalRefresh();
        }            
        public void NewAssemblyDetailOperation_Formclosing(object sender, EventArgs e)
        {
            AssemblyRefresh();
            TotalRefresh();

        }


        private void BtnAddSubAssembly_Click(object sender, EventArgs e)
        {
            string AssemblyId = txtAssemblyID.Text;
            AssemblyID = AssemblyId;
            string connectionstring = ConnString;
            Form frm = new NewAssemblyDetailSubassembly();
            NewAssemblyDetailSubassembly.ConnString = connectionstring;
            frm.FormClosing += new FormClosingEventHandler(this.NewAssemblyDetailSubassembly_Formclosing);
            frm.Show();

        }
        private void BtnRemoveSubAssembly_Click(object sender, EventArgs e)
        {
            Int32 selectedrowindex = DgvAssemblySubAssembly.SelectedCells[0].RowIndex;
            DataGridViewRow SelectedRow = DgvAssemblySubAssembly.Rows[selectedrowindex];
            string AssemblySubId = Convert.ToString(SelectedRow.Cells["AssemblyDetailSubAssembly_id"].Value);

            if (DgvAssemblySubAssembly.SelectedRows.Count == 0)
            {
                MessageBox.Show("No subassembly selected");
            }

            else if (DgvAssemblySubAssembly.SelectedRows.Count == 1)
            {
                // Create the connection.
                string connectionstring = ConnString;
                using (MySqlConnection connection = new MySqlConnection(connectionstring))
                {
                    // mysql string subassembly
                    const string mysqlString1 = "DELETE FROM Victoriam.T_ASSEMBLYDETAILSUBASSEMBLY WHERE AssemblyDetailSubAssembly_id = ";
                    string mysqlString = mysqlString1 + AssemblySubId;
                    using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString, connection))
                    {
                        try
                        {
                            connection.Open();
                            mysqlcommand.ExecuteNonQuery();
                        }
                        catch
                        {
                            MessageBox.Show("Subassembly could not be removed");
                        }
                    }

                }
            }

            else if (DgvAssemblySubAssembly.SelectedRows.Count > 1)
            {
                MessageBox.Show("More than one subassembly selected. Please select one subassembly");
            }

            TotalRefresh();

        }
        public void NewAssemblyDetailSubassembly_Formclosing(object sender, EventArgs e)
        {
            AssemblyRefresh();
            TotalRefresh();

        }






        private void BtnLinkPart_Click(object sender, EventArgs e)
        {
            string AssemblyId = txtAssemblyID.Text;
            AssemblyID = AssemblyId;
            string connectionstring = ConnString; 
            Form frm = new LinkPart();
            LinkPart.ConnString = connectionstring;
            frm.FormClosing += new FormClosingEventHandler(this.LinkPart_Formclosing);
            frm.Show();

        }
        public void LinkPart_Formclosing(object sender, EventArgs e)
        {
            AssemblyRefresh();
            TotalRefresh();

        }        
        private void BtnCreatePart_Click(object sender, EventArgs e)
        {

        }

        
    }
}
