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
    public partial class NewRelation : Form
    {
        private int parsedRelationID;

        public NewRelation()
        {
            InitializeComponent();
        }
        public static string ConnString { get; set; }

        private bool IsNameValid()
        {
            if (txtRelationName.Text == "")
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

        private void btnNewRelation_Click(object sender, EventArgs e)
        {
            if (IsNameValid())
            {
                // Create the connection.
                string connectionstring = ConnString;
                using (MySqlConnection connection = new MySqlConnection(connectionstring))
                {
                    using (MySqlCommand msqlcommand = new MySqlCommand("uspNewRelation", connection))
                    {
                        msqlcommand.CommandType = CommandType.StoredProcedure;

                        msqlcommand.Parameters.Add(new MySqlParameter("RelationName", MySqlDbType.Text));
                        msqlcommand.Parameters["RelationName"].Value = txtRelationName.Text;

                        msqlcommand.Parameters.Add(new MySqlParameter("RelationID", MySqlDbType.Int32));
                        msqlcommand.Parameters["RelationID"].Direction = ParameterDirection.Output;

                        try
                        {
                            connection.Open();

                            msqlcommand.ExecuteNonQuery();

                            this.parsedRelationID = (int)msqlcommand.Parameters["RelationID"].Value;
                            this.txtRelationID.Text = Convert.ToString(parsedRelationID);

                        }

                        catch (MySqlException ex)
                        {
                            MessageBox.Show("error " + ex.Number + " has occurd " + ex.Message);

                            MessageBox.Show("Relation ID was not returned. Relation could not be created.");
                        }

                        finally
                        {
                            connection.Close();
                        }

                    }
                }

            }

        }

        private void btnAddAnotherRelation_Click(object sender, EventArgs e)
        {
            txtRelationID.Clear();
            txtRelationName.Clear();
        }
    }
}
