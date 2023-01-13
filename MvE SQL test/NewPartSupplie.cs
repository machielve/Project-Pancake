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
    public partial class NewPartSupplier : Form
    {
        public void RefreshSuppliers()
        {
            // Create the connection.
            string connectionstring = Properties.Settings.Default.connString;
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                // mysql string types
                const string mysqlString = "SELECT Supplier_id, Name FROM Victoriam.T_SUPPLIER";
                using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString, connection))
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
                }
            }
        }

        public NewPartSupplier()
        {
            InitializeComponent();
        }

        private void btnFinnish_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewPartSupplier_Load(object sender, EventArgs e)
        {
            txtPartID.Text = PartManager.PartID;

            RefreshSuppliers();
            
        }

        private void btnNewSupplier_Click(object sender, EventArgs e)
        {
            decimal pricetotal = Convert.ToDecimal(countPrice.Value);
            decimal totalquant = Convert.ToDecimal(CountQuantity.Value);

            decimal unitprice = pricetotal / totalquant;

            int PartID = Convert.ToInt32(txtPartID.Text);
            int SupplierID = Convert.ToInt32(cmbSupplier.SelectedValue.ToString());

            // Create the connection.
            string connectionstring = Properties.Settings.Default.connString;
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {

                using (MySqlCommand msqlcommand = new MySqlCommand("uspNewPartSupplier", connection))
                {
                    msqlcommand.CommandType = CommandType.StoredProcedure;

                    msqlcommand.Parameters.Add(new MySqlParameter("nPart", MySqlDbType.Int32));
                    msqlcommand.Parameters["nPart"].Value = PartID;

                    msqlcommand.Parameters.Add(new MySqlParameter("nSupplier", MySqlDbType.Int32));
                    msqlcommand.Parameters["nSupplier"].Value = SupplierID;

                    msqlcommand.Parameters.Add(new MySqlParameter("nPrice", MySqlDbType.Decimal));
                    msqlcommand.Parameters["nPrice"].Precision = 10;
                    msqlcommand.Parameters["nPrice"].Scale = 4;
                    msqlcommand.Parameters["nPrice"].Value = unitprice;

                    try
                    {
                        connection.Open();
                        msqlcommand.ExecuteNonQuery();

                    }

                    catch (MySqlException ex)
                    {
                        MessageBox.Show("error " + ex.Number + " has occurd " + ex.Message);
                    }

                    finally
                    {
                        connection.Close();
                    }

                }
            }
            this.Close();

        }

        public void NewSupplier_Formclosing(object sender, EventArgs e)
        {
            RefreshSuppliers();

        }

        private void btnCreateSupplier_Click(object sender, EventArgs e)
        {
            Form frm = new NewSupplier();
            frm.FormClosing += new FormClosingEventHandler(this.NewSupplier_Formclosing);
            frm.Show();
        }

        private void btnAddAnotherSupplier_Click(object sender, EventArgs e)
        {
            txtPartID.Clear();

        }
    }
}
