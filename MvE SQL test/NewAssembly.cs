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
    public partial class NewAssembly : Form
    {
        private int parsedAssemblyID;

        public static string ConnString { get; set; }

        private bool IsAssemblyNameValid()
        {
            if (txtAssemblyName.Text == "")
            {
                MessageBox.Show("Please enter a name.");
                return false;
            }
            else
            {
                return true;
            }
        }
        public NewAssembly()
        {
            InitializeComponent();
        }

        private void btnFinnish_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddAnotherAssembly_Click(object sender, EventArgs e)
        {
            txtAssemblyName.Clear();
            txtAssemblyID.Clear();
            this.parsedAssemblyID = 0;
        }

        private void btnNewAssembly_Click(object sender, EventArgs e)
        {
            if (IsAssemblyNameValid())
            {
                // Create the connection.
                string connectionstring = ConnString;
                using (MySqlConnection connection = new MySqlConnection(connectionstring))
                {
                    using (MySqlCommand msqlcommand = new MySqlCommand("uspNewAssembly", connection))
                    {
                        msqlcommand.CommandType = CommandType.StoredProcedure;

                        msqlcommand.Parameters.Add(new MySqlParameter("Name", MySqlDbType.Text));
                        msqlcommand.Parameters["Name"].Value = txtAssemblyName.Text;

                        msqlcommand.Parameters.Add(new MySqlParameter("AssemblyID", MySqlDbType.Int32));
                        msqlcommand.Parameters["AssemblyID"].Direction = ParameterDirection.Output;

                        try
                        {
                            connection.Open();

                            msqlcommand.ExecuteNonQuery();

                            this.parsedAssemblyID = (int)msqlcommand.Parameters["AssemblyID"].Value;
                            this.txtAssemblyID.Text = Convert.ToString(parsedAssemblyID);

                        }

                        catch (MySqlException ex)
                        {
                            MessageBox.Show("error " + ex.Number + " has occurd " + ex.Message);

                            MessageBox.Show("Assembly ID was not returned. Assembly could not be created.");
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
