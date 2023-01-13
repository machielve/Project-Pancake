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
    public partial class LinkPart : Form
    {
        public LinkPart()
        {
            InitializeComponent();
        }

        private void btnFinnish_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LinkPart_Load(object sender, EventArgs e)
        {
            // Create the connection.
            string connectionstring = Properties.Settings.Default.connString;
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                // mysql string parts
                const string mysqlString = "SELECT Part_id, Name FROM Victoriam.T_PART WHERE PartType = 2";
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
                        MessageBox.Show("Parts could not be loaded");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }

                // mysql string types
                const string mysqlString2 = "SELECT Parttype_id, Name FROM Victoriam.T_PARTTYPE WHERE Parttype_id = 2";
                using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString2, connection))
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
                    finally
                    {
                        connection.Close();
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
                    finally
                    {
                        connection.Close();
                    }
                }

                // mysql string units
                const string mysqlString4 = "SELECT Partunit_id, Name FROM Victoriam.T_PARTUNIT";
                using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString4, connection))
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
                    finally
                    {
                        connection.Close();
                    }
                }


            }
        }


    }
}
