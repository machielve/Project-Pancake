﻿using System;
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
    public partial class ManagerJobOrders : Form
    {
        public ManagerJobOrders()
        {
            InitializeComponent();
        }

        public static string ConnString { get; set; }

        private void ManagerJobOrders_Load(object sender, EventArgs e)
        {
            RefreshJobOrders();
        }

        public void RefreshJobOrders()
        {
            // Create the connection.
            string connectionstring = ConnString;
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                // mysql string
                const string mysqlString1 = "SELECT * FROM Victoriam.T_JOBORDER";
                string mysqlString = mysqlString1;
                using (MySqlCommand mysqlcommand = new MySqlCommand(mysqlString, connection))
                {
                    try
                    {
                        connection.Open();

                        using (MySqlDataReader dr = mysqlcommand.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dr);
                            this.DgvJobOrders.DataSource = dt;
                            dr.Close();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Job orders could not be loaded");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

        }




        private void BtnFinnish_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLoadJobOrders_Click(object sender, EventArgs e)
        {
            RefreshJobOrders();

        }
    }
}
