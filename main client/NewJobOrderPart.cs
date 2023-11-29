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
    public partial class NewJobOrderPart : Form
    {
        public NewJobOrderPart()
        {
            InitializeComponent();
        }

        private void BtnFinnish_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static string ConnString { get; set; }

        private void NewProjectDetailPart_Load(object sender, EventArgs e)
        {

            txtProjectDetailID.Text = ManagerProject.DetailID;

            // Create the connection.
            string connectionstring = ConnString;
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
                            dt.DefaultView.Sort = "Name ASC";
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

        private void BtnAddPart_Click(object sender, EventArgs e)
        {

        }
    }
}
