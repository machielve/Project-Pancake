using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace MvE_SQL_test
{
    public partial class NewUnit : Form
    {
        private int parsedUnitID;

        private bool IsUnitNameValid()
        {
            if (txtUnitName.Text == "")
            {
                MessageBox.Show("Please enter a name.");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ClearForm()
        {
            txtUnitName.Clear();
            txtUnitID.Clear();
            this.parsedUnitID = 0;
        }

        public NewUnit()
        {
            InitializeComponent();
        }

        private void btnFinnish_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewUnit_Click(object sender, EventArgs e)
        {
            // Create the connection.
            string connectionstring = Properties.Settings.Default.connString;
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                using (MySqlCommand msqlcommand = new MySqlCommand("uspNewUnit", connection))
                {
                    msqlcommand.CommandType = CommandType.StoredProcedure;

                    msqlcommand.Parameters.Add(new MySqlParameter("UnitName", MySqlDbType.Text));
                    msqlcommand.Parameters["UnitName"].Value = txtUnitName.Text;

                    msqlcommand.Parameters.Add(new MySqlParameter("UnitID", MySqlDbType.Int32));
                    msqlcommand.Parameters["UnitID"].Direction = ParameterDirection.Output;

                    try
                    {
                        connection.Open();
                        
                        msqlcommand.ExecuteNonQuery();

                        this.parsedUnitID = (int)msqlcommand.Parameters["UnitID"].Value;
                        this.txtUnitID.Text = Convert.ToString(parsedUnitID);

                    }

                    catch (MySqlException ex)
                    {
                        Console.WriteLine("error " + ex.Number + " has occurd" + ex.Message);
                        MessageBox.Show("Unit ID was not returned. Account could not be created.");
                    }

                    finally
                    {
                        connection.Close();
                    }

                    /*
                                   
                                           /// <summary>
/// Creates a new customer by calling the Sales.uspNewCustomer stored procedure.
/// </summary>
private void btnCreateAccount_Click(object sender, EventArgs e)
{
    if (IsCustomerNameValid())
    {
        // Create the connection.
        using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
        {
            // Create a SqlCommand, and identify it as a stored procedure.
            using (SqlCommand sqlCommand = new SqlCommand("Sales.uspNewCustomer", connection))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;

                // Add input parameter for the stored procedure and specify what to use as its value.
                sqlCommand.Parameters.Add(new SqlParameter("@CustomerName", SqlDbType.NVarChar, 40));
                sqlCommand.Parameters["@CustomerName"].Value = txtCustomerName.Text;

                // Add the output parameter.
                sqlCommand.Parameters.Add(new SqlParameter("@CustomerID", SqlDbType.Int));
                sqlCommand.Parameters["@CustomerID"].Direction = ParameterDirection.Output;

                try
                {
                    connection.Open();

                    // Run the stored procedure.
                    sqlCommand.ExecuteNonQuery();

                    // Customer ID is an IDENTITY value from the database.
                    this.parsedCustomerID = (int)sqlCommand.Parameters["@CustomerID"].Value;

                    // Put the Customer ID value into the read-only text box.
                    this.txtCustomerID.Text = Convert.ToString(parsedCustomerID);
                }
                catch
                {
                    MessageBox.Show("Customer ID was not returned. Account could not be created.");
                }
                finally
                {
                    connection.Close();
                }
  


                                    */
                }
            }

        


    }

        private void btnAddAnotherUnit_Click(object sender, EventArgs e)
        {
            this.ClearForm();
        }

 
    }
}
