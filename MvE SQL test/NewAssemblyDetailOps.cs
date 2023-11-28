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

namespace Project_pancake
{
    public partial class NewAssemblyDetailOps : Form
    {
        public NewAssemblyDetailOps()
        {
            InitializeComponent();
        }

        public static string ConnString { get; set; }


        private void BtnFinnish_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewAssemblyDetailOps_Load(object sender, EventArgs e)
        {
            txtAssemblyID.Text = ManagerAssembly.AssemblyID;
            // Create the connection.
            string connectionstring = ConnString;
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                // mysql string parts
                const string mysqlString = "SELECT Operation_id, Name FROM Victoriam.T_OPERATION";
                using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString, connection))
                {
                    try
                    {
                        connection.Open();
                        using (MySqlDataReader dr = mysqlcommand.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dr);
                            cmbOps.DataSource = dt;
                            dt.DefaultView.Sort = "Name ASC";
                            cmbOps.DisplayMember = "Name";
                            cmbOps.ValueMember = "Operation_id";

                            dr.Close();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Operations could not be loaded");
                    }
                }
            }

        }

        private void BtnAddOperation_Click(object sender, EventArgs e)
        {
            int AssemblyID = Convert.ToInt32(txtAssemblyID.Text);
            int OpsID = Convert.ToInt32(cmbOps.SelectedValue.ToString());
            decimal OpsQuantity = Convert.ToDecimal(countOps.Value);
            string Opsname = cmbOps.Text;

            // Create the connection.
            string connectionstring = ConnString;
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                decimal cost = 0;

                string mysqlString = "SELECT Cost, Name FROM Victoriam.T_OPERATION WHERE Operation_id = ";
                string mysqlString2 = mysqlString + OpsID.ToString();
                using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString2, connection))
                {
                    try
                    {
                        connection.Open();
                        using (MySqlDataReader dr = mysqlcommand.ExecuteReader())
                        {
                            dr.Read();
                            decimal price = Convert.ToDecimal(dr.GetValue(0).ToString());
                            cost += price;
                            dr.Close();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Operations could not be loaded");
                    }
                }

                using (MySqlCommand msqlcommand = new MySqlCommand("uspNewAssemblyDetailOperation", connection))
                {
                    msqlcommand.CommandType = CommandType.StoredProcedure;

                    decimal costprice = cost * OpsQuantity;

                    msqlcommand.Parameters.Add(new MySqlParameter("OpsAssembly", MySqlDbType.Int32));
                    msqlcommand.Parameters["OpsAssembly"].Value = AssemblyID;

                    msqlcommand.Parameters.Add(new MySqlParameter("OpsID", MySqlDbType.Text));
                    msqlcommand.Parameters["OpsID"].Value = OpsID;

                    msqlcommand.Parameters.Add(new MySqlParameter("Opsname", MySqlDbType.Text));
                    msqlcommand.Parameters["Opsname"].Value = Opsname;

                    msqlcommand.Parameters.Add(new MySqlParameter("OpsQuantity", MySqlDbType.Decimal));
                    msqlcommand.Parameters["OpsQuantity"].Precision = 10;
                    msqlcommand.Parameters["OpsQuantity"].Scale = 2;
                    msqlcommand.Parameters["OpsQuantity"].Value = OpsQuantity;

                    msqlcommand.Parameters.Add(new MySqlParameter("OpsCostprice", MySqlDbType.Decimal));
                    msqlcommand.Parameters["OpsCostprice"].Precision = 10;
                    msqlcommand.Parameters["OpsCostprice"].Scale = 2;
                    msqlcommand.Parameters["OpsCostprice"].Value = costprice;

                    try
                    {
                        // connection.Open();

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
