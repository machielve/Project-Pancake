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
    public partial class NewAssemblyDetailPart : Form
    {
               
        public NewAssemblyDetailPart()
        {       
            InitializeComponent();
        }

         private void NewAssemblyDetailPart_Load(object sender, EventArgs e)
        {
            txtAssemblyID.Text = AssemblyManager.AssemblyID;
            // Create the connection.
            string connectionstring = Properties.Settings.Default.connString;
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                // mysql string parts
                const string mysqlString = "SELECT Part_id, Name FROM Victoriam.T_PART";
                using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString, connection))
                {
                    try
                    {
                        connection.Open();
                        using (MySqlDataReader dr = mysqlcommand.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dr);
                            cmbPart.DataSource = dt;
                            cmbPart.DisplayMember = "Name";
                            cmbPart.ValueMember = "Part_id";

                            dr.Close();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Assembly parts could not be loaded");
                    }
                }
            }   


        }

        private void btnFinnish_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            int AssemblyID = Convert.ToInt32(txtAssemblyID.Text);
            int PartID = Convert.ToInt32(cmbPart.SelectedValue.ToString());
            decimal PartQuantity = Convert.ToDecimal(countPart.Value);
            string PartName = cmbPart.Text;

            // Create the connection.
            string connectionstring = Properties.Settings.Default.connString;
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {


                using (MySqlCommand msqlcommand = new MySqlCommand("uspNewAssemblyDetailPart", connection))
                {
                    msqlcommand.CommandType = CommandType.StoredProcedure;

                    msqlcommand.Parameters.Add(new MySqlParameter("PartAssembly", MySqlDbType.Int32));
                    msqlcommand.Parameters["PartAssembly"].Value = AssemblyID;

                    msqlcommand.Parameters.Add(new MySqlParameter("PartID", MySqlDbType.Text));
                    msqlcommand.Parameters["PartID"].Value = PartID;

                    msqlcommand.Parameters.Add(new MySqlParameter("Partname", MySqlDbType.Text));
                    msqlcommand.Parameters["Partname"].Value = PartName;

                    msqlcommand.Parameters.Add(new MySqlParameter("PartQuantity", MySqlDbType.Decimal));
                    msqlcommand.Parameters["PartQuantity"].Value = PartQuantity;

                    msqlcommand.Parameters.Add(new MySqlParameter("PartWeight", MySqlDbType.Decimal));
                    msqlcommand.Parameters["PartWeight"].Value = 1;

                    msqlcommand.Parameters.Add(new MySqlParameter("PartCostprice", MySqlDbType.Decimal));
                    msqlcommand.Parameters["PartCostprice"].Value = 1;

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
    }
}
