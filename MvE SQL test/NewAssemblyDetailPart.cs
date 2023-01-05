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
    public partial class NewAssemblyDetailPart : Form
    {
               
        public NewAssemblyDetailPart()
        {       
            InitializeComponent();
        }
        private void NewAssemblyDetailPart_Load(object sender, EventArgs e)
        {
            // Create the connection.
            string connectionstring = Properties.Settings.Default.connString;
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                // mysql string parts
                const string mysqlString = "SELECT Part_id, Name FROM Victoriam.T_PART";
                using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString, connection))
                {
                    try
                    {
                        connection.Open();
                        using (MySqlDataReader dr = mysqlcommand.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dr);
                            cmbPart.DataSource = dt;
                            cmbPart.DisplayMember = "Name";
                            cmbPart.ValueMember = "Part_id";

                            dr.Close();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Assembly parts could not be loaded");
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
