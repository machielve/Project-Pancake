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
    public partial class NewPart : Form
    {
        private int parsedUnitID;

        private void ClearForm()
        {
            txtDrawingNumber.Clear();
            txtPartName.Clear();
            txtPartMemo.Clear();

            this.parsedUnitID = 0;
        }

        public NewPart()
        {
            InitializeComponent();
        }

        private void btnFinnish_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewPart_Load(object sender, EventArgs e)
        {
            // Create the connection.
            string connectionstring = Properties.Settings.Default.connString;
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                // mysql string types
                const string mysqlString = "SELECT Parttype_id, Name FROM Victoriam.T_PARTTYPE";
                using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString, connection))
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

                // mysql string units
                const string mysqlString2 = "SELECT Partunit_id, Name FROM Victoriam.T_PARTUNIT";
                using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString2, connection))
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
                const string mysqlString4 = "SELECT * FROM Victoriam.T_UNIT WHERE uGroup = 'Weight'";
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
                        MessageBox.Show("Weight units could not be loaded");
                    }
                }

                // mysql string traceabiliy
                const string mysqlString5 = "SELECT traceability_id, Description FROM Victoriam.T_TRACEABILITY";
                using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString5, connection))
                {
                    try
                    {
                        connection.Open();
                        using (MySqlDataReader dr = mysqlcommand.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dr);
                            cmbTrace.DataSource = dt;
                            cmbTrace.DisplayMember = "Description";
                            cmbTrace.ValueMember = "traceability_id";

                            dr.Close();
                        }
                        connection.Close();
                    }
                    catch
                    {
                        MessageBox.Show("traceability could not be loaded");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }


            }


        }

        private void btnNewUnit_Click(object sender, EventArgs e)
        {
            string PartName = txtPartName.Text;
            string PartMemo = txtPartMemo.Text;
            int Parttype = Convert.ToInt32(cmbPartType.SelectedValue);
            int PartRevision = Convert.ToInt32(countRevision.Value);
            int PartUnit = Convert.ToInt32(cmbPartUnit.SelectedValue);
            int PartMaterial = Convert.ToInt32(cmbMaterial.SelectedValue);
            decimal PartWeight = Convert.ToDecimal(numericUpDown1.Value);
            int PartWeightU = Convert.ToInt32(cmbWeightUnit.SelectedValue);
            string PartDNumber = txtDrawingNumber.Text;
            int PartDRev = Convert.ToInt32(txtDrawingRevision.Text);
            int PartTrace = Convert.ToInt32(cmbTrace.SelectedValue);

            // Create the connection.
            string connectionstring = Properties.Settings.Default.connString;
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                using (MySqlCommand msqlcommand = new MySqlCommand("uspNewPart", connection))
                {
                    msqlcommand.CommandType = CommandType.StoredProcedure;

                    msqlcommand.Parameters.Add(new MySqlParameter("PartName", MySqlDbType.Text));
                    msqlcommand.Parameters["PartName"].Value = PartName;

                    msqlcommand.Parameters.Add(new MySqlParameter("PartMemo", MySqlDbType.Text));
                    msqlcommand.Parameters["PartMemo"].Value = PartMemo;

                    msqlcommand.Parameters.Add(new MySqlParameter("PartType", MySqlDbType.Int32));
                    msqlcommand.Parameters["PartType"].Value = Parttype;

                    msqlcommand.Parameters.Add(new MySqlParameter("PartRevision", MySqlDbType.Int32));
                    msqlcommand.Parameters["PartRevision"].Value = PartRevision;

                    msqlcommand.Parameters.Add(new MySqlParameter("PartUnit", MySqlDbType.Int32));
                    msqlcommand.Parameters["PartUnit"].Value = PartUnit;

                    msqlcommand.Parameters.Add(new MySqlParameter("PartMaterial", MySqlDbType.Int32));
                    msqlcommand.Parameters["PartMaterial"].Value = PartMaterial;

                    msqlcommand.Parameters.Add(new MySqlParameter("PartWeight", MySqlDbType.Decimal));
                    msqlcommand.Parameters["Partweight"].Scale = 2;
                    msqlcommand.Parameters["Partweight"].Precision = 10;
                    msqlcommand.Parameters["PartWeight"].Value = PartWeight;

                    msqlcommand.Parameters.Add(new MySqlParameter("PartWeightUnit", MySqlDbType.Int32));
                    msqlcommand.Parameters["PartWeightUnit"].Value = PartWeightU;

                    msqlcommand.Parameters.Add(new MySqlParameter("PartDrawngNumber", MySqlDbType.Text));
                    msqlcommand.Parameters["PartDrawngNumber"].Value = PartDNumber;

                    msqlcommand.Parameters.Add(new MySqlParameter("PartDrawngRev", MySqlDbType.Int32));
                    msqlcommand.Parameters["PartDrawngRev"].Value = PartDRev;

                    msqlcommand.Parameters.Add(new MySqlParameter("PartTrace", MySqlDbType.VarChar));
                    msqlcommand.Parameters["PartTrace"].Value = PartTrace;

                    msqlcommand.Parameters.Add(new MySqlParameter("PartID", MySqlDbType.Int32));
                    msqlcommand.Parameters["PartID"].Direction = ParameterDirection.Output;

                    try
                    {
                        connection.Open();

                        msqlcommand.ExecuteNonQuery();
                        this.parsedUnitID = (int)msqlcommand.Parameters["PartID"].Value;
                        this.txtUnitID.Text = Convert.ToString(parsedUnitID);

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

        private void btnAddAnotherUnit_Click(object sender, EventArgs e)
        {
            this.ClearForm();
        }


    }
}
