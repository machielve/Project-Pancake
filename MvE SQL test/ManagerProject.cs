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
    public partial class ManagerProject : Form
    {
        public ManagerProject()
        {
            InitializeComponent();
        }

        public static string ProjectID = "";

        public static string DetailID = "";

        private void LoadContent()
        {
            Int32 selectedrowindex = dgvJobOrders.SelectedCells[0].RowIndex;
            DataGridViewRow SelectedRow = dgvJobOrders.Rows[selectedrowindex];
            string DetailtId = Convert.ToString(SelectedRow.Cells["JobOrder_id"].Value);

            txtDetailID.Text = DetailtId;

            if (DetailtId == "")
            {
                MessageBox.Show("No job order selected");
            }

            else
            {
                // Create the connection.
                string connectionstring = Properties.Settings.Default.connString;
                using (MySqlConnection connection = new MySqlConnection(connectionstring))
                {
                    // mysql string parts
                    const string mysqlString1 = "SELECT * FROM Victoriam.T_JOBORDERPART WHERE JobOrder = ";
                    string mysqlString = mysqlString1 + DetailtId;
                    using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString, connection))
                    {
                        try
                        {
                            connection.Open();

                            using (MySqlDataReader dr = mysqlcommand.ExecuteReader())
                            {
                                DataTable dt = new DataTable();
                                dt.Load(dr);
                                this.dgvJobOrderParts.DataSource = dt;
                                dr.Close();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Job order parts could not be loaded");
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                    // mysql string ops
                    const string mysqlString10 = "SELECT * FROM Victoriam.T_JOBORDEROPERATION WHERE JobOrder = ";
                    string mysqlString00 = mysqlString10 + DetailtId;
                    using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString00, connection))
                    {
                        try
                        {
                            connection.Open();

                            using (MySqlDataReader dr = mysqlcommand.ExecuteReader())
                            {
                                DataTable dt = new DataTable();
                                dt.Load(dr);
                                this.dgvJobOrderOperations.DataSource = dt;
                                dr.Close();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Job order operations could not be loaded");
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

        private void btnNewProject_Click(object sender, EventArgs e)
        {
            Form frm = new NewProject();
            frm.Show();
        }

        private void btnLoadProjects_Click(object sender, EventArgs e)
        {
            // Create the connection.
            string connectionstring = Properties.Settings.Default.connString;
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                // mysql string
                const string mysqlString = "SELECT * FROM Victoriam.T_PROJECT";

                using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString, connection))
                {
                    try
                    {
                        connection.Open();                        

                        using (MySqlDataReader dr = mysqlcommand.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dr);
                            this.dgvProject.DataSource = dt;
                            dr.Close();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Projects could not be loaded");
                    }
                }
            }
        }

        private void btnSeeDetails_Click(object sender, EventArgs e)
        {
            Int32 selectedrowindex = dgvProject.SelectedCells[0].RowIndex;
            DataGridViewRow SelectedRow = dgvProject.Rows[selectedrowindex];
            string ProjectId = Convert.ToString(SelectedRow.Cells["Project_id"].Value);

            txtProjectID.Text = ProjectId;

            if (ProjectId == "")
            {
                MessageBox.Show("No project selected");
            }

            else 
            {
                // Create the connection.
                string connectionstring = Properties.Settings.Default.connString;
                using (MySqlConnection connection = new MySqlConnection(connectionstring))
                {
                    // mysql string
                    const string mysqlString1 = "SELECT * FROM Victoriam.T_JOBORDER WHERE Project = ";
                    string mysqlString = mysqlString1 + ProjectId;
                    using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString, connection))
                    {
                        try
                        {
                            connection.Open();

                            using (MySqlDataReader dr = mysqlcommand.ExecuteReader())
                            {
                                DataTable dt = new DataTable();
                                dt.Load(dr);
                                this.dgvJobOrders.DataSource = dt;
                                dr.Close();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Job orders could not be loaded");
                        }
                    }
                }                   
            }

        }

        private void txtSeeContent_Click(object sender, EventArgs e)
        {
            LoadContent();

        }

        public void txtAddPart_Click(object sender, EventArgs e)
        {
            string DetailID = txtDetailID.Text;

            Form frm = new NewJobOrderPart();
            frm.FormClosing += new FormClosingEventHandler(this.NewProjectDetailPart_Formclosing);
            frm.Show();
        }

        public void NewProjectDetailPart_Formclosing(object sender, EventArgs e)
        {

        }
    }
}
