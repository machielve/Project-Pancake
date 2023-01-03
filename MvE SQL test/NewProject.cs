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
    public partial class NewProject : Form
    {
        private int parsedProjectID;

        public NewProject()
        {
            InitializeComponent();
        }
        private bool IsProjectNameValid()
        {
            if (txtProjectName.Text == "")
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

        private void btnNewProject_Click(object sender, EventArgs e)
        {
            if (IsProjectNameValid())
            {
                //Create connection
                string connectionstring = Properties.Settings.Default.connString;
                using (MySqlConnection connection = new MySqlConnection(connectionstring))
                {
                    using (MySqlCommand msqlcommand = new MySqlCommand("uspNewProject", connection))
                    {
                        msqlcommand.CommandType = CommandType.StoredProcedure;

                        msqlcommand.Parameters.Add(new MySqlParameter("ProjectName", MySqlDbType.Text));
                        msqlcommand.Parameters["ProjectName"].Value = txtProjectName.Text;

                        msqlcommand.Parameters.Add(new MySqlParameter("ProjectID", MySqlDbType.Int32));
                        msqlcommand.Parameters["ProjectID"].Direction = ParameterDirection.Output;

                        try
                        {
                            connection.Open();

                            msqlcommand.ExecuteNonQuery();

                            this.parsedProjectID = (int)msqlcommand.Parameters["ProjectID"].Value;
                            this.txtProjectID.Text = Convert.ToString(parsedProjectID);
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show("error " + ex.Number + " has occurd " + ex.Message);

                            MessageBox.Show("Project ID was not returned. Project could not be created.");
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
