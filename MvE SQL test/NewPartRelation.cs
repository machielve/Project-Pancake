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
    public partial class NewPartRelation : Form
    {
        

        public NewPartRelation()
        {
            InitializeComponent();
        }

        public static string ConnString { get; set; }

        public void RefreshRelations()
        {
            // Create the connection.
            string connectionstring = ConnString;
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                // mysql string types
                const string mysqlString = "SELECT Relation_id, Name FROM Victoriam.T_RELATION";
                using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString, connection))
                {
                    try
                    {
                        connection.Open();
                        using (MySqlDataReader dr = mysqlcommand.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dr);
                            cmbRelation.DataSource = dt;
                            cmbRelation.DisplayMember = "Name";
                            cmbRelation.ValueMember = "Relation_id";

                            dr.Close();
                        }
                        connection.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Relations could not be loaded");
                    }
                }
            }
        }

        private void BtnFinnish_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewPartRelation_Load(object sender, EventArgs e)
        {
            txtPartID.Text = ManagerPart.PartID;

            RefreshRelations();
            
        }

        private void BtnNewSupplier_Click(object sender, EventArgs e)
        {
            decimal pricetotal = Convert.ToDecimal(countPrice.Value);
            decimal totalquant = Convert.ToDecimal(CountQuantity.Value);

            decimal unitprice = pricetotal / totalquant;

            int PartID = Convert.ToInt32(txtPartID.Text);
            int RelationID = Convert.ToInt32(cmbRelation.SelectedValue.ToString());

            // Create the connection.
            string connectionstring = ConnString;
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {

                using (MySqlCommand msqlcommand = new MySqlCommand("uspNewPartRelation", connection))
                {
                    msqlcommand.CommandType = CommandType.StoredProcedure;

                    msqlcommand.Parameters.Add(new MySqlParameter("nPart", MySqlDbType.Int32));
                    msqlcommand.Parameters["nPart"].Value = PartID;

                    msqlcommand.Parameters.Add(new MySqlParameter("nRelation", MySqlDbType.Int32));
                    msqlcommand.Parameters["nRelation"].Value = RelationID;

                    msqlcommand.Parameters.Add(new MySqlParameter("nPrice", MySqlDbType.Decimal));
                    msqlcommand.Parameters["nPrice"].Precision = 10;
                    msqlcommand.Parameters["nPrice"].Scale = 4;
                    msqlcommand.Parameters["nPrice"].Value = unitprice;

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

        public void NewRelation_Formclosing(object sender, EventArgs e)
        {
            RefreshRelations();

        }

        private void BtnCreateSupplier_Click(object sender, EventArgs e)
        {
            string connectionstring = ConnString; 
            Form frm = new NewRelation();
            NewRelation.ConnString = connectionstring;
            frm.FormClosing += new FormClosingEventHandler(this.NewRelation_Formclosing);
            frm.Show();
        }

        private void BtnAddAnotherRelation_Click(object sender, EventArgs e)
        {
            txtPartID.Clear();

        }
    }
}
