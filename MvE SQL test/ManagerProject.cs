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
        public static string AssemblyID = "";
        public static string DetailID = "";

        public static string ConnString { get; set;  }

        private void LoadContent()
        {

            Int32 selectedrowindex = DgvJobOrders.SelectedCells[0].RowIndex;
            DataGridViewRow SelectedRow = DgvJobOrders.Rows[selectedrowindex];
            string DetailtId = Convert.ToString(SelectedRow.Cells["JobOrder_id"].Value);

            txtDetailID.Text = DetailtId;

            if (DetailtId == "")
            {
                MessageBox.Show("No job order selected");
            }

            else
            {
                // Create the connection.
                string connectionstring = ConnString;
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
                                this.DgvJobOrderParts.DataSource = dt;
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
                                this.DgvJobOrderOperations.DataSource = dt;
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

        private void BtnLoadProjects_Click(object sender, EventArgs e)
        {
            // Create the connection.
            string connectionstring = ConnString;
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
                            this.DgvProject.DataSource = dt;
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

        private void BtnFinnish_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void BtnNewProject_Click(object sender, EventArgs e)
        {
            string connectionstring = ConnString; 
            Form frm = new NewProject();
            NewProject.ConnString = connectionstring;
            frm.Show();
        }

        

        private void BtnSeeDetails_Click(object sender, EventArgs e)
        {
            Int32 selectedrowindex = DgvProject.SelectedCells[0].RowIndex;
            DataGridViewRow SelectedRow = DgvProject.Rows[selectedrowindex];
            string ProjectId = Convert.ToString(SelectedRow.Cells["Project_id"].Value);

            txtProjectID.Text = ProjectId;

            if (ProjectId == "")
            {
                MessageBox.Show("No project selected");
            }

            else 
            {
                // Create the connection job orders
                string connectionstring = ConnString;
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
                                this.DgvJobOrders.DataSource = dt;
                                dr.Close();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Job orders could not be loaded");
                        }
                    }
                }
                
                // Create the connection project assemblies                
                using (MySqlConnection connection = new MySqlConnection(connectionstring))
                {
                    // mysql string
                    const string mysqlString1 = "SELECT * FROM Victoriam.T_PROJECTASSEMBLY WHERE Project = ";
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
                                this.DgvProjectAssemblies.DataSource = dt;
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

        }

        private void BtnCreateJobOrder_Click(object sender, EventArgs e)
        {

        }

        private void BtnSeeContent_Click(object sender, EventArgs e)
        {
            LoadContent();
        }




        public void BtnAddPart_Click(object sender, EventArgs e)
        {
            string DetailID = txtDetailID.Text;
            string connectionstring = ConnString; 
            Form frm = new NewJobOrderPart();
            NewJobOrderPart.ConnString = connectionstring;
            frm.FormClosing += new FormClosingEventHandler(this.NewProjectDetailPart_Formclosing);
            frm.Show();
        }

        public void NewProjectDetailPart_Formclosing(object sender, EventArgs e)
        {

        }


    }
}
