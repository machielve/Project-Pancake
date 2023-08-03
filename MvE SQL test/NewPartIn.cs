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
    public partial class NewPartIn : Form
    {
        public NewPartIn()
        {
            InitializeComponent();
        }

        public static string ConnString { get; set; }

        private void btnFinnish_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewPartIn_Load(object sender, EventArgs e)
        {
            // Create the connection.
            string connectionstring = ConnString;
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                // mysql string parts
                const string mysqlString = "SELECT Part_id, Name FROM Victoriam.T_PART WHERE PartType <> 2";
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
                            cmbPart.DataSource = dt;
                            cmbPart.DisplayMember = "Name";
                            cmbPart.ValueMember = "Part_id";

                            dr.Close();
                        }
                        connection.Close();
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
                // mysql string Relations
                const string mysqlString10 = "SELECT Relation_id, Name FROM Victoriam.T_RELATION";
                using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString10, connection))
                {
                    try
                    {
                        connection.Open();
                        using (MySqlDataReader dr = mysqlcommand.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dr);
                            cmbRelation.DataSource = dt;
                            cmbRelation.DisplayMember = "Name";
                            cmbRelation.ValueMember = "Relation_id";

                            dr.Close();
                        }
                        connection.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Relations could not be loaded");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }



            }
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            decimal Quantity = countQuantity.Value;
            int PartID = Convert.ToInt32(cmbPart.SelectedValue);
            int RelationID = Convert.ToInt32(cmbRelation.SelectedValue);
            string PONumber = txtPONumber.Text;
            string SerialNumber = txtSerialNumber.Text;
            decimal TPrice = countPrice.Value;

            // Create the connection.
            string connectionstring = ConnString;
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                using (MySqlCommand msqlcommand = new MySqlCommand("uspNewPartIn", connection))
                {
                    msqlcommand.CommandType = CommandType.StoredProcedure;

                    msqlcommand.Parameters.Add(new MySqlParameter("InQuantity", MySqlDbType.Decimal));
                    msqlcommand.Parameters["InQuantity"].Scale = 2;
                    msqlcommand.Parameters["InQuantity"].Precision = 10;
                    msqlcommand.Parameters["InQuantity"].Value = Quantity;

                    msqlcommand.Parameters.Add(new MySqlParameter("InPartID", MySqlDbType.Int32));
                    msqlcommand.Parameters["InPartID"].Value = PartID;

                    msqlcommand.Parameters.Add(new MySqlParameter("InRelationID", MySqlDbType.Int32));
                    msqlcommand.Parameters["InRelationID"].Value = RelationID;

                    msqlcommand.Parameters.Add(new MySqlParameter("InPONumber", MySqlDbType.VarChar));
                    msqlcommand.Parameters["InPONumber"].Value = PONumber;

                    msqlcommand.Parameters.Add(new MySqlParameter("InSerialNumber", MySqlDbType.VarChar));
                    msqlcommand.Parameters["InSerialNumber"].Value = SerialNumber;

                    msqlcommand.Parameters.Add(new MySqlParameter("InTPrice", MySqlDbType.Decimal));
                    msqlcommand.Parameters["InTPrice"].Scale = 2;
                    msqlcommand.Parameters["InTPrice"].Precision = 10;
                    msqlcommand.Parameters["InTPrice"].Value = TPrice;

                    try
                    {
                        connection.Open(); 
                        msqlcommand.ExecuteNonQuery();
                    }
                    catch
                    {
                        MessageBox.Show("Parts could not be added");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            this.Close();

        }
    }
}
