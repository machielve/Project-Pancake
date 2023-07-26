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
    public partial class NewSupplier : Form
    {
        private int parsedSupplierID;

        public NewSupplier()
        {
            InitializeComponent();
        }
        public static string ConnString { get; set; }

        private bool IsNameValid()
        {
            if (txtSupplierName.Text == "")
            {
                MessageBox.Show("Please enter a name.");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnFinnish_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewSupplier_Click(object sender, EventArgs e)
        {
            if (IsNameValid())
            {
                // Create the connection.
                string connectionstring = ConnString;
                using (MySqlConnection connection = new MySqlConnection(connectionstring))
                {
                    using (MySqlCommand msqlcommand = new MySqlCommand("uspNewSupplier", connection))
                    {
                        msqlcommand.CommandType = CommandType.StoredProcedure;

                        msqlcommand.Parameters.Add(new MySqlParameter("SupplierName", MySqlDbType.Text));
                        msqlcommand.Parameters["SupplierName"].Value = txtSupplierName.Text;

                        msqlcommand.Parameters.Add(new MySqlParameter("SupplierID", MySqlDbType.Int32));
                        msqlcommand.Parameters["SupplierID"].Direction = ParameterDirection.Output;

                        try
                        {
                            connection.Open();

                            msqlcommand.ExecuteNonQuery();

                            this.parsedSupplierID = (int)msqlcommand.Parameters["SupplierID"].Value;
                            this.txtSupplierID.Text = Convert.ToString(parsedSupplierID);

                        }

                        catch (MySqlException ex)
                        {
                            MessageBox.Show("error " + ex.Number + " has occurd " + ex.Message);

                            MessageBox.Show("Supplier ID was not returned. Supplier could not be created.");
                        }

                        finally
                        {
                            connection.Close();
                        }

                    }
                }

            }

        }

        private void btnAddAnotherSupplier_Click(object sender, EventArgs e)
        {
            txtSupplierID.Clear();
            txtSupplierName.Clear();
        }
    }
}
