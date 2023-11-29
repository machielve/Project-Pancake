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

namespace Project_pancake
{
    public partial class NewProjectAssembly : Form
    {
        public NewProjectAssembly()
        {
            InitializeComponent();
        }


        public static string ConnString { get; set; }

        private void BtnFinnish_Click(object sender, EventArgs e)
        {
            this.Close();

        }



        private void NewProjectAssembly_Load(object sender, EventArgs e)
        {

            txtProjectID.Text = ManagerProject.ProjectID;

            // Create the connection.
            string connectionstring = ConnString;
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                // mysql string parts
                const string mysqlString = "SELECT Assembly_id, Name FROM Victoriam.T_ASSEMBLY";
                using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString, connection))
                {
                    try
                    {
                        connection.Open();
                        using (MySqlDataReader dr = mysqlcommand.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dr);
                            cmbAssembly.DataSource = dt;
                            cmbAssembly.DisplayMember = "Name";
                            cmbAssembly.ValueMember = "Assembly_id";

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
}
