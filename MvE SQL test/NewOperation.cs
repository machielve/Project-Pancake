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

        private void NewOperation_Load(object sender, EventArgs e)
        {
            // Create the connection.
            string connectionstring = ConnString;
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                // mysql string units
                const string mysqlString4 = "SELECT * FROM Victoriam.T_UNIT";
                using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString4, connection))
                {
                    try
                    {
                        connection.Open();
                        using (MySqlDataReader dr = mysqlcommand.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dr);
                            cmbWeightUnit.DataSource = dt;
                            cmbWeightUnit.DisplayMember = "Name";
                            cmbWeightUnit.ValueMember = "Unit_id";

                            dr.Close();
                        }
                        connection.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Operation units could not be loaded");
                    }
                }

            }


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





        private void btnFinnish_Click(object sender, EventArgs e)
        {
            this.Close();
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
                decimal OperationPrice = Convert.ToDecimal(numericUpDown1.Value);
                int OperationUnit = Convert.ToInt32(cmbWeightUnit.SelectedValue);

                // Create the connection.
                string connectionstring = ConnString;
                using (MySqlConnection connection = new MySqlConnection(connectionstring))
                {
                    using (MySqlCommand msqlcommand = new MySqlCommand("uspNewOperation", connection))
                    {
                        msqlcommand.CommandType = CommandType.StoredProcedure;

                        msqlcommand.Parameters.Add(new MySqlParameter("OperationPrice", MySqlDbType.Decimal));
                        msqlcommand.Parameters["OperationPrice"].Scale = 2;
                        msqlcommand.Parameters["OperationPrice"].Precision = 10;
                        msqlcommand.Parameters["OperationPrice"].Value = OperationPrice;

                        msqlcommand.Parameters.Add(new MySqlParameter("OperationName", MySqlDbType.Text));
                        msqlcommand.Parameters["OperationName"].Value = txtOperationName.Text;

                        msqlcommand.Parameters.Add(new MySqlParameter("OperationUnit", MySqlDbType.Int32));
                        msqlcommand.Parameters["OperationUnit"].Value = OperationUnit;

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
