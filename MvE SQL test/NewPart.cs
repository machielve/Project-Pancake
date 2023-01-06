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
    public partial class NewPart : Form
    {
        public NewPart()
        {
            InitializeComponent();
        }

        private void btnFinnish_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewPart_Load(object sender, EventArgs e)
        {
            // Create the connection.
            string connectionstring = Properties.Settings.Default.connString;
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                // mysql string types
                const string mysqlString = "SELECT Parttype_id, Name FROM Victoriam.T_PARTTYPE";
                using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString, connection))
                {
                    try
                    {
                        connection.Open();
                        using (MySqlDataReader dr = mysqlcommand.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dr);
                            cmbPartType.DataSource = dt;
                            cmbPartType.DisplayMember = "Name";
                            cmbPartType.ValueMember = "Parttype_id";

                            dr.Close();
                        }
                        connection.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Types could not be loaded");
                    }
                }

                // mysql string units
                const string mysqlString2 = "SELECT Partunit_id, Name FROM Victoriam.T_PARTUNIT";
                using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString2, connection))
                {
                    try
                    {
                        connection.Open();
                        using (MySqlDataReader dr = mysqlcommand.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dr);
                            cmbPartUnit.DataSource = dt;
                            cmbPartUnit.DisplayMember = "Name";
                            cmbPartUnit.ValueMember = "Partunit_id";

                            dr.Close();
                        }
                        connection.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Units could not be loaded");
                    }
                }

                // mysql string materials
                const string mysqlString3 = "SELECT Material_id, Name FROM Victoriam.T_MATERIAL";
                using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString3, connection))
                {
                    try
                    {
                        connection.Open();
                        using (MySqlDataReader dr = mysqlcommand.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dr);
                            cmbMaterial.DataSource = dt;
                            cmbMaterial.DisplayMember = "Name";
                            cmbMaterial.ValueMember = "Material_id";

                            dr.Close();
                        }
                        connection.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Materials could not be loaded");
                    }
                }

                // mysql string units
                const string mysqlString4 = "SELECT * FROM Victoriam.T_UNIT WHERE uGroup = 'Weight'";
                using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString4, connection))
                {
                    try
                    {
                        connection.Open();
                        using (MySqlDataReader dr = mysqlcommand.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dr);
                            cmbWeightUnit.DataSource = dt;
                            cmbWeightUnit.DisplayMember = "Name";
                            cmbWeightUnit.ValueMember = "Unit_id";

                            dr.Close();
                        }
                        connection.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Weight units could not be loaded");
                    }
                }








            }


        }


    }
}
