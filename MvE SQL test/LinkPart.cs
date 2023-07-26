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
    public partial class LinkPart : Form
    {
        public LinkPart()
        {
            InitializeComponent();
        }

        public static string ConnString { get; set; }

        private void btnFinnish_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LinkPart_Load(object sender, EventArgs e)
        {
            txtAssemblyID.Text = ManagerAssembly.AssemblyID;

            // Create the connection.
            string connectionstring = ConnString;
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                // mysql assembly info 
                string mysqlString00 = "SELECT Name, Weight, DrawingNumber, DrawingRevision, Partreference FROM Victoriam.T_ASSEMBLY WHERE Assembly_id = ";
                string mysqlString01 = txtAssemblyID.Text;
                string mysqlString02 = mysqlString00 + mysqlString01;

                using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString02, connection))
                {
                    try
                    {
                        connection.Open();
                        using (MySqlDataReader dr = mysqlcommand.ExecuteReader())
                        {
                            dr.Read();
                            txtAssemblyName.Text = dr.GetValue(0).ToString();
                            countAssemblyWeight.Value = Convert.ToDecimal(dr.GetValue(1).ToString());
                            txtDrawingNumber.Text = dr.GetValue(2).ToString();
                            countDrawingRevision.Value = Convert.ToInt32(dr.GetValue(3).ToString());
                            txtPartID.Text = dr.GetValue(4).ToString();
                            dr.Close();
                        }
                        connection.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Assembly info could not be loaded");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }

                // mysql string parts
                const string mysqlString = "SELECT Part_id, Name FROM Victoriam.T_PART WHERE PartType = 2";
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
                    finally
                    {
                        connection.Close();
                    }
                }

                // mysql string types
                const string mysqlString2 = "SELECT Parttype_id, Name FROM Victoriam.T_PARTTYPE WHERE Parttype_id = 2";
                using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString2, connection))
                {
                    try
                    {
                        connection.Open();
                        using (MySqlDataReader dr = mysqlcommand.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dr);
                            cmbPartType.DataSource = dt;
                            cmbPartType.DisplayMember = "Name";
                            cmbPartType.ValueMember = "Parttype_id";

                            dr.Close();
                        }
                        connection.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Types could not be loaded");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }

                // mysql string materials
                const string mysqlString3 = "SELECT Material_id, Name FROM Victoriam.T_MATERIAL";
                using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString3, connection))
                {
                    try
                    {
                        connection.Open();
                        using (MySqlDataReader dr = mysqlcommand.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dr);
                            cmbMaterial.DataSource = dt;
                            cmbMaterial.DisplayMember = "Name";
                            cmbMaterial.ValueMember = "Material_id";

                            dr.Close();
                        }
                        connection.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Materials could not be loaded");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }

                // mysql string units
                const string mysqlString4 = "SELECT Partunit_id, Name FROM Victoriam.T_PARTUNIT";
                using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString4, connection))
                {
                    try
                    {
                        connection.Open();
                        using (MySqlDataReader dr = mysqlcommand.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dr);
                            cmbPartUnit.DataSource = dt;
                            cmbPartUnit.DisplayMember = "Name";
                            cmbPartUnit.ValueMember = "Partunit_id";

                            dr.Close();
                        }
                        connection.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Units could not be loaded");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void btnLinkPart_Click(object sender, EventArgs e)
        {
            string LinkedPart = txtPartID.Text.ToString();

            string AssemblyID = txtAssemblyID.Text.ToString();

            int PartID = Convert.ToInt32(cmbPart.SelectedValue.ToString());
            int PartUnit = Convert.ToInt32(cmbPartUnit.SelectedValue.ToString());
            int Partmaterial = Convert.ToInt32(cmbMaterial.SelectedValue.ToString());
            
            decimal PartWeight = Convert.ToDecimal(countAssemblyWeight.Value);
            string PartDrawing = txtDrawingNumber.Text.ToString();
            int PartDrawingRev = Convert.ToInt32(countDrawingRevision.Value);

            if (LinkedPart == "")
            {
                // Create the connection.
                string connectionstring = ConnString;
                using (MySqlConnection connection = new MySqlConnection(connectionstring))
                {
                    // Create command assembly update
                    string MysqlString1 = "UPDATE Victoriam.T_ASSEMBLY SET PartReference = ";
                    string MysqlString2 = " WHERE Assembly_id = ";

                    string MysqlString9 = MysqlString1 + PartID.ToString() + MysqlString2 + AssemblyID;
                    using (MySqlCommand msqlcommand = new MySqlCommand(MysqlString9, connection))
                    {
                       
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

                    // Create command Part update
                    string MysqlString11 = PartWeight.ToString();
                    string MysqlString10 = "UPDATE Victoriam.T_PART SET Weight = "+ MysqlString11;

                    string MysqlString21 = PartUnit.ToString();
                    string MysqlString20 = ",PartUnit = " + MysqlString21;

                    string MysqlString31 = Partmaterial.ToString();
                    string MysqlString30 = ",Material = " + MysqlString31;

                    string MysqlString41 = PartDrawing.ToString();
                    string MysqlString40 = ",DrawingNumber = Null" ;

                    string MysqlString51 = PartDrawingRev.ToString();
                    string MysqlString50 = ",DrawingRevision = " + MysqlString51; 

                    string MysqlString81 = PartID.ToString();
                    string MysqlString80 = " WHERE Part_id = " + MysqlString81;
                    

                    string MysqlString90 = MysqlString10 + MysqlString20 + MysqlString30 + MysqlString40 + MysqlString50 + MysqlString80;
                    using (MySqlCommand msqlcommand = new MySqlCommand(MysqlString90, connection))
                    {

                        try
                        {
                            MessageBox.Show(MysqlString90);
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





            }

            else MessageBox.Show("Assembly already linked");


            this.Close();

        }
    }
}
