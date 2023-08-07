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
    public partial class NewAssemblyDetailSubassembly : Form
    {
        public NewAssemblyDetailSubassembly()
        {
            InitializeComponent();
        }

        public static string ConnString { get; set; }

        private void BtnFinnish_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewAssemblyDetailSubassembly_Load(object sender, EventArgs e)
        {
            txtAssemblyID.Text = ManagerAssembly.AssemblyID;
            // Create the connection.
            string connectionstring = ConnString;
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                // mysql string subassembly
                const string mysqlString = "SELECT Assembly_id, Name FROM Victoriam.T_ASSEMBLY";
                using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString, connection))
                {
                    try
                    {
                        connection.Open();
                        using (MySqlDataReader dr = mysqlcommand.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dr);
                            cmbSubs.DataSource = dt;
                            cmbSubs.DisplayMember = "Name";
                            cmbSubs.ValueMember = "Assembly_id";

                            dr.Close();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Subassemblies could not be loaded");
                    }
                }
            }

        }

        private void BtnAddSubs_Click(object sender, EventArgs e)
        {
            int AssemblyID = Convert.ToInt32(txtAssemblyID.Text);
            int SubID = Convert.ToInt32(cmbSubs.SelectedValue.ToString());
            decimal SubQuantity = Convert.ToDecimal(countSubs.Value);
            string Subname = cmbSubs.Text;

            // Create the connection.
            string connectionstring = ConnString;
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                decimal cost = 0;

                string mysqlString = "SELECT Costprice, Name FROM Victoriam.T_ASSEMBLY WHERE Assembly_id = ";
                string mysqlString2 = mysqlString + SubID.ToString();
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
                        MessageBox.Show("Subassemblies could not be loaded");
                    }
                }

                using (MySqlCommand msqlcommand = new MySqlCommand("uspNewAssemblyDetailSubassembly", connection))
                {
                    msqlcommand.CommandType = CommandType.StoredProcedure;

                    decimal costprice = cost * SubQuantity;

                    msqlcommand.Parameters.Add(new MySqlParameter("SubAssembly", MySqlDbType.Int32));
                    msqlcommand.Parameters["SubAssembly"].Value = AssemblyID;

                    msqlcommand.Parameters.Add(new MySqlParameter("SubID", MySqlDbType.Text));
                    msqlcommand.Parameters["SubID"].Value = SubID;

                    msqlcommand.Parameters.Add(new MySqlParameter("Subname", MySqlDbType.Text));
                    msqlcommand.Parameters["Subname"].Value = Subname;

                    msqlcommand.Parameters.Add(new MySqlParameter("SubQuantity", MySqlDbType.Decimal));
                    msqlcommand.Parameters["SubQuantity"].Precision = 10;
                    msqlcommand.Parameters["SubQuantity"].Scale = 2;
                    msqlcommand.Parameters["SubQuantity"].Value = SubQuantity;

                    msqlcommand.Parameters.Add(new MySqlParameter("SubCostprice", MySqlDbType.Decimal));
                    msqlcommand.Parameters["SubCostprice"].Precision = 10;
                    msqlcommand.Parameters["SubCostprice"].Scale = 2;
                    msqlcommand.Parameters["SubCostprice"].Value = costprice;

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
