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
    public partial class ProjectManager : Form
    {
        public ProjectManager()
        {
            InitializeComponent();
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
                            MessageBox.Show("Test");
                            
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
    }
}
