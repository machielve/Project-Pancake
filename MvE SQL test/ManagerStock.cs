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
    public partial class ManagerStock : Form
    {
        public ManagerStock()
        {
            InitializeComponent();
        }

        public static string ConnString { get; set; }
        private void ManagerStock_Load(object sender, EventArgs e)
        {

            RefreshStock();
            RefreshPartIN();
            RefreshPartOUT();

        }
        private void BtnFinnish_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnLoadStock_Click(object sender, EventArgs e)
        {
            RefreshStock();
        }

        public void RefreshPartIN()
        {
            // Create the connection.
            string connectionstring = ConnString;
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                // mysql string StockIn
                const string mysqlString20 = "SELECT Quantity, " +
                                                "T_PART.Name," +
                                                "T_RELATION.Name, " +
                                                "JobOrder, " +
                                                "PurchaseOrderNumber, " +
                                                "TotalPrice, " +
                                                "Received, " +
                                                "Locked, " +
                                                "PartIn_id " +

                                                "FROM Victoriam.T_PARTIN " +
                                                "LEFT JOIN Victoriam.T_PART       ON Victoriam.T_PARTIN.Part        =Victoriam.T_PART.Part_id " +
                                                "LEFT JOIN Victoriam.T_RELATION   ON Victoriam.T_PARTIN.Relation    =Victoriam.T_RELATION.Relation_id ";
                using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString20, connection))
                {
                    try
                    {
                        connection.Open();

                        using (MySqlDataReader dr = mysqlcommand.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dr);
                            dt.DefaultView.Sort = "PartIn_id DESC";
                            this.DgvStockIn.DataSource = dt;
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
                            this.DgvStockOut.DataSource = dt;
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
                            this.DgvStock.DataSource = dt;
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









        private void BtnStockIn_Click(object sender, EventArgs e)
        {
            string connectionstring = ConnString;
            Form frm = new NewPartIn();
            NewPartIn.ConnString = connectionstring;
            frm.FormClosing += new FormClosingEventHandler(this.NewPartIn_Formclosing);
            frm.Show();

        }
        private void BtnReceiveStock_Click(object sender, EventArgs e)
        {

        }
        private void BtnCreatePart_Click(object sender, EventArgs e)
        {

        }

        public void NewPartIn_Formclosing(object sender, EventArgs e)
        {

            RefreshPartIN();

        }


    }
}
