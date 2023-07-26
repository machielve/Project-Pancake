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
    public partial class ManagerStock : Form
    {
        public ManagerStock()
        {
            InitializeComponent();
        }

        public static string ConnString { get; set; }

        public void RefreshPartIN()
        {
            // Create the connection.
            string connectionstring = ConnString;
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                // mysql string StockIn
                const string mysqlString20 = "SELECT * FROM Victoriam.T_PARTIN";
                using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString20, connection))
                {
                    try
                    {
                        connection.Open();

                        using (MySqlDataReader dr = mysqlcommand.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dr);
                            this.dgvStockIn.DataSource = dt;
                            dr.Close();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Stock in could not be loaded");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        public void RefreshPartOUT()
        {
            // Create the connection.
            string connectionstring = ConnString;
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                // mysql string Stockout
                const string mysqlString30 = "SELECT * FROM Victoriam.T_PARTOUT";
                using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString30, connection))
                {
                    try
                    {
                        connection.Open();

                        using (MySqlDataReader dr = mysqlcommand.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dr);
                            this.dgvStockOut.DataSource = dt;
                            dr.Close();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Stock out could not be loaded");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }


        public void RefreshStock()
        {
            // Create the connection.
            string connectionstring = ConnString;
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                // mysql string Stock
                const string mysqlString10 = "SELECT * FROM Victoriam.T_STOCK";
                using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString10, connection))
                {
                    try
                    {
                        connection.Open();

                        using (MySqlDataReader dr = mysqlcommand.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dr);
                            this.dgvStock.DataSource = dt;
                            dr.Close();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Stock could not be loaded");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }

                
            }

        }

        private void btnFinnish_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoadStock_Click(object sender, EventArgs e)
        {
            RefreshStock();
        }

        private void btnReceiveStock_Click(object sender, EventArgs e)
        {
            
        }

        private void btnStockIn_Click(object sender, EventArgs e)
        {
            string connectionstring = ConnString; 
            Form frm = new NewPartIn();
            NewPartIn.ConnString = connectionstring;
            frm.FormClosing += new FormClosingEventHandler(this.NewPartIn_Formclosing);
            frm.Show();

        }

        public void NewPartIn_Formclosing(object sender, EventArgs e)
        {

            RefreshPartIN();

        }

        private void ManagerStock_Load(object sender, EventArgs e)
        {

            RefreshStock();
            RefreshPartIN();
            RefreshPartOUT();

        }
    }
}
