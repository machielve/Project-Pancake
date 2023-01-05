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
    public partial class NewAssemblyDetailOps : Form
    {
        public NewAssemblyDetailOps()
        {
            InitializeComponent();
        }

        private void NewAssemblyDetailOps_Load()
        {
            txtAssemblyID.Text = AssemblyManager.AssemblyID;
            // Create the connection.
            string connectionstring = Properties.Settings.Default.connString;
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                // mysql string parts
                const string mysqlString = "SELECT Operation_id, Name FROM Victoriam.T_OPERATON";
                using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString, connection))
                {
                    try
                    {
                        connection.Open();
                        using (MySqlDataReader dr = mysqlcommand.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dr);
                            cmbOps.DataSource = dt;
                            cmbOps.DisplayMember = "Name";
                            cmbOps.ValueMember = "Operation_id";

                            dr.Close();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Operations could not be loaded");
                    }
                }
            }

        }

        private void btnFinnish_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
