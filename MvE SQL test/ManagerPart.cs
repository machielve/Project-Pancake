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

        public ManagerPart()
        {
            InitializeComponent();
        }

        public static string PartID = "";
        public static string ConnString { get; set; }

        
        public void PartRefresh()
        {
            // Create the connection.
            string connectionstring = ConnString;
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
                            dt.DefaultView.Sort = ("Name ASC");                            
                            this.dgvParts.DataSource = dt;
                            dr.Close();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Parts could not be loaded");
                    }
                    finally
                    {
                        // connection.Close();
                        dgvParts.AutoResizeColumns();
                    }
                }
            }

        }        
        public void RelationRefresh()
        {

            string AssemblyId = (txtPartID.Text);

            if (AssemblyId == "")
            {
                MessageBox.Show("No part selected");
            }

            else 
            {
                // Create the connection.
                string connectionstring = ConnString;
                using (MySqlConnection connection = new MySqlConnection(connectionstring))
                {
                    // mysql string parts
                    string mysqlString1 = "SELECT PartRelation_id, " +
                                                    "T_PART.Name, " +
                                                    "T_RELATION.Name, " +
                                                    "Price ";
                    string mysqlString2 = "FROM Victoriam.T_PARTRELATION "; 
                    string mysqlString3 = "LEFT JOIN Victoriam.T_PART ON Victoriam.T_PARTRELATION.Part=Victoriam.T_PART.Part_id ";
                    string mysqlString4 = "LEFT JOIN Victoriam.T_SUPPLIER ON Victoriam.T_PARTRELATION.Relation= Victoriam.T_RELATION.Relation_id ";

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
                                this.dgvRelations.DataSource = dt;
                                dr.Close();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Relations could not be loaded");
                        }
                        finally
                        {
                            connection.Close();
                            dgvRelations.AutoResizeColumns();
                        }
                    }

                }
            }

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
            string connectionstring = ConnString; 
            Form frm = new NewPart();
            NewPart.ConnString = connectionstring;
            frm.FormClosing += new FormClosingEventHandler(this.NewPart_Formclosing);
            frm.Show();
        }
        private void NewPart_Formclosing(object sender, EventArgs e)
        {
            PartRefresh();
        }



        public void dgvPart_SelectionChanged(object sender, EventArgs e)
        {
            Int32 selectedrowindex = dgvParts.SelectedCells[0].RowIndex;
            DataGridViewRow SelectedRow = dgvParts.Rows[selectedrowindex];
            string PartID = Convert.ToString(SelectedRow.Cells["Part_id"].Value);

            txtPartID.Text = PartID;

            RelationRefresh();

        }

        

        private void btnAddRelation_Click(object sender, EventArgs e)
        {

            Int32 selectedrowindex = dgvParts.SelectedCells[0].RowIndex;
            DataGridViewRow SelectedRow = dgvParts.Rows[selectedrowindex];
            string PartId = Convert.ToString(SelectedRow.Cells["Part_id"].Value);
            PartID = PartId;

            string connectionstring = ConnString; 
            Form frm = new NewPartRelation();
            NewPartRelation.ConnString = connectionstring;
            frm.FormClosing += new FormClosingEventHandler(this.NewPartRelation_Formclosing);
            frm.Show();

        }
        public void NewPartRelation_Formclosing(object sender, EventArgs e)
        {
            RelationRefresh();

        }
        private void btnRemoveRelation_Click(object sender, EventArgs e)
        {
            Int32 selectedrowindex = dgvRelations.SelectedCells[0].RowIndex;
            DataGridViewRow SelectedRow = dgvRelations.Rows[selectedrowindex];
            string AssemblyOpsId = Convert.ToString(SelectedRow.Cells["PartRelation_id"].Value);

            if (dgvRelations.SelectedRows.Count == 0)
            {
                MessageBox.Show("No relation selected");
            }

            else if (dgvRelations.SelectedRows.Count == 1)
            {
                // Create the connection.
                string connectionstring = ConnString;
                using (MySqlConnection connection = new MySqlConnection(connectionstring))
                {
                    // mysql string parts
                    const string mysqlString1 = "DELETE FROM Victoriam.T_PARTRELATION WHERE PartRelation_id = ";
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
                            MessageBox.Show("Relation could not be removed");
                        }
                    }

                }
            }

            else if (dgvRelations.SelectedRows.Count > 1)
            {
                MessageBox.Show("More than one relation selected. Please select one relation");
            }

            RelationRefresh();
        }
    }
}
