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

        private void btnFinnish_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewPartIn_Load(object sender, EventArgs e)
        {
            // Create the connection.
            string connectionstring = Properties.Settings.Default.connString;
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
                // mysql string Suppliers
                const string mysqlString10 = "SELECT Supplier_id, Name FROM Victoriam.T_SUPPLIER";
                using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString10, connection))
                {
                    try
                    {
                        connection.Open();
                        using (MySqlDataReader dr = mysqlcommand.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dr);
                            cmbSupplier.DataSource = dt;
                            cmbSupplier.DisplayMember = "Name";
                            cmbSupplier.ValueMember = "Supplier_id";

                            dr.Close();
                        }
                        connection.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Suppliers could not be loaded");
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
            int SupplierID = Convert.ToInt32(cmbSupplier.SelectedValue);
            string PONumber = txtPONumber.Text;
            string SerialNumber = txtSerialNumber.Text;
            decimal TPrice = countPrice.Value;

            // Create the connection.
            string connectionstring = Properties.Settings.Default.connString;
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

                    msqlcommand.Parameters.Add(new MySqlParameter("InSupplierID", MySqlDbType.Int32));
                    msqlcommand.Parameters["InSupplierID"].Value = SupplierID;

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
