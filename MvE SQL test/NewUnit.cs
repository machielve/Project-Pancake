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

        public static string ConnString { get; set; }

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
            if (IsUnitNameValid())
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

                        msqlcommand.Parameters.Add(new MySqlParameter("UnitGroup", MySqlDbType.Text));
                        msqlcommand.Parameters["UnitGroup"].Value = txtUnitGroup.Text;

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
                            MessageBox.Show("error " + ex.Number + " has occurd " + ex.Message);

                            MessageBox.Show("Unit ID was not returned. Unit could not be created.");
                        }

                        finally
                        {
                            connection.Close();
                        }

                    }
                }

            }


        }

        private void btnAddAnotherUnit_Click(object sender, EventArgs e)
        {
            this.ClearForm();
        }


    }
}