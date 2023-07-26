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
    public partial class NewOperation : Form
    {

        private int parsedOperationID;
        public NewOperation()
        {
            InitializeComponent();
        }

        public static string ConnString { get; set; }

        private void btnFinnish_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool IsNameValid()
        {
            if (txtOperationName.Text == "")
            {
                MessageBox.Show("Please enter a name.");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnAddAnotherOperation_Click(object sender, EventArgs e)
        {
                txtOperationName.Clear();
                txtOperationID.Clear();
                this.parsedOperationID = 0;
        }

        private void btnNewOperation_Click(object sender, EventArgs e)
        {
            if (IsNameValid())
            {
                // Create the connection.
                string connectionstring = Properties.Settings.Default.connString;
                using (MySqlConnection connection = new MySqlConnection(connectionstring))
                {
                    using (MySqlCommand msqlcommand = new MySqlCommand("uspNewOperation", connection))
                    {
                        msqlcommand.CommandType = CommandType.StoredProcedure;

                        msqlcommand.Parameters.Add(new MySqlParameter("OperationName", MySqlDbType.Text));
                        msqlcommand.Parameters["OperationName"].Value = txtOperationName.Text;

                        msqlcommand.Parameters.Add(new MySqlParameter("OperationUnit", MySqlDbType.Int32));
                        msqlcommand.Parameters["OperationUnit"].Value = 8;

                        msqlcommand.Parameters.Add(new MySqlParameter("MaterialModification", MySqlDbType.Text));
                        msqlcommand.Parameters["MaterialModification"].Value = txtMatMod.Text;                        

                        msqlcommand.Parameters.Add(new MySqlParameter("OperationID", MySqlDbType.Int32));
                        msqlcommand.Parameters["OperationID"].Direction = ParameterDirection.Output;

                        try
                        {
                            connection.Open();
                            msqlcommand.ExecuteNonQuery();

                            this.parsedOperationID = (int)msqlcommand.Parameters["OperationID"].Value;
                            this.txtOperationID.Text = Convert.ToString(parsedOperationID);
                        }

                        catch (MySqlException ex)
                        {
                            MessageBox.Show("error " + ex.Number + " has occurd " + ex.Message);

                            MessageBox.Show("Operation ID was not returned. Operation could not be added.");
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
}
