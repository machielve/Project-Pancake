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
            txtAssemblyID.Text = ManagerAssembly.AssemblyID;
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
                        MessageBox.Show("Parts could not be loaded");
                    }
                }
            }   


        }

        private void cmbPart_SelectedIndexChanged(object sender, EventArgs e)
        {
            string PartID = cmbPart.ValueMember;
            // Create the connection.
            string connectionstring = Properties.Settings.Default.connString;
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                // mysql string drawing
                string mysqlString1 = "SELECT DrawingNumber, DrawingRevision FROM Victoriam.T_PART WHERE Part_id = ";
                string mysqlString2 = PartID;
                string mysqlString = mysqlString1 + mysqlString2;
                using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString, connection))
                { /*
                    try
                    {
                        connection.Open();
                        MySqlDataReader reader = mysqlcommand.ExecuteReader();

                        this.txtDrawingNumber.Text = reader.GetString("DrawingNumber");
                        this.txtDrawingRevision.Text = reader.GetInt32("DrawingRevision").ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Drawing information could not be loaded");
                    }
                    finally
                    {
                        connection.Close();
                    }
                    */
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
            string PartDNumber = txtDrawingNumber.Text;
            int PartDRev = Convert.ToInt32(txtDrawingRevision.Value);

            // Create the connection.
            string connectionstring = Properties.Settings.Default.connString;
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                decimal cost = 0;
                decimal weight = 0;

                string mysqlString = "SELECT Price, Part FROM Victoriam.T_PARTSUPPLIER WHERE Part = ";
                string mysqlString2 = mysqlString + PartID.ToString();
                using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString2, connection))
                {
                    try
                    {
                        connection.Open();
                        using (MySqlDataReader dr = mysqlcommand.ExecuteReader())
                        {
                            dr.Read();
                            decimal price = Convert.ToDecimal(dr.GetValue(0).ToString());
                            cost += (price* PartQuantity);
                            dr.Close();
                        }
                        connection.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Costs could not be loaded");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            

                string mysqlString5 = "SELECT Weight, Name FROM Victoriam.T_PART WHERE Part_id = ";
                string mysqlString6 = mysqlString5 + PartID.ToString();
                using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString6, connection))
                {
                    try
                    {
                        connection.Open();
                        using (MySqlDataReader dr = mysqlcommand.ExecuteReader())
                        {
                            dr.Read();
                            decimal Mass = Convert.ToDecimal(dr.GetValue(0).ToString());
                            weight += (Mass* PartQuantity);
                            dr.Close();
                        }
                        connection.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Weights could not be loaded");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }



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
                    msqlcommand.Parameters["PartWeight"].Value = weight;

                    msqlcommand.Parameters.Add(new MySqlParameter("PartCostprice", MySqlDbType.Decimal));
                    msqlcommand.Parameters["PartCostprice"].Value = cost;

                    msqlcommand.Parameters.Add(new MySqlParameter("PartDNumber", MySqlDbType.VarChar));
                    msqlcommand.Parameters["PartDNumber"].Value = PartDNumber;

                    msqlcommand.Parameters.Add(new MySqlParameter("PartDRev", MySqlDbType.Int32));
                    msqlcommand.Parameters["PartDRev"].Value = PartDRev;

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
