﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForms
{
    public partial class StockAdd : Form
    {
        ConnectionString connString;
        private int maxID = 0;
        private string strMaxID = "";
        private string zeroCode = "";

        public StockAdd()
        {
            InitializeComponent();
        }

        public StockAdd(string id, string name, string qty)
        {
            InitializeComponent();
            connString = new ConnectionString();
            txtBoxProductID.Text = id;
            txtBoxProductName.Text = name;
            txtBoxProductQty.Text = qty;
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            string getMaxID_CMD = "SELECT MAX(id) AS 'maxID' FROM Log_Changes";
            string updateState = @"UPDATE Product SET product_stock_qty = @addStockQty, product_arrival = @arrivalDate, product_expiry_date = @expiryDate WHERE product_id = @productID";
            string addLogState = @"INSERT INTO Log_Changes (log_changes_id, log_changes_date, log_changes_time, log_changes_info, product_id)
                                   VALUES (@logID, @date, @time, @info, @productID)";

            using (SqlConnection conn = new SqlConnection(connString.getConnString()))
            {
                //add stock 
                try
                {
                    conn.Open();
                    command = new SqlCommand(updateState, conn);
                    int newQty = Convert.ToInt32(txtBoxProductQty.Text) + Convert.ToInt32(txtBoxAddQty.Text);
                    command.Parameters.AddWithValue(@"addStockQty", newQty);
                    DateTime dateArrival = Convert.ToDateTime(txtBoxArrival.Text);
                    command.Parameters.AddWithValue(@"arrivalDate", dateArrival.ToString("yyyy-MM-dd"));
                    DateTime dateExpiry = Convert.ToDateTime(txtBoxExpiry.Text);
                    command.Parameters.AddWithValue(@"expiryDate", dateExpiry.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue(@"productID", txtBoxProductID.Text);
                    command.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //log changes
                try
                {
                    conn.Open();
                    command = new SqlCommand(getMaxID_CMD, conn);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (reader["maxID"].ToString().Equals(""))
                            {
                                maxID = 1;
                            }
                            else
                            {
                                maxID = Int32.Parse(reader["maxID"].ToString());
                                maxID++;
                            }
                            strMaxID = maxID.ToString();
                            for (int i = 0; i < (7 - strMaxID.Length); i++)
                            {
                                zeroCode += "0";
                            }
                            strMaxID = "LS-" + zeroCode + maxID.ToString();
                        }
                    }
                    command = new SqlCommand(addLogState, conn);
                    command.Parameters.AddWithValue(@"logID", strMaxID);
                    command.Parameters.AddWithValue(@"date", DateTime.Today.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue(@"time", DateTime.Now.ToString("hh:mm:ss tt"));
                    command.Parameters.AddWithValue(@"info", "Add " + txtBoxAddQty.Text + " Stocks");
                    command.Parameters.AddWithValue(@"productID", txtBoxProductID.Text);
                    command.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            this.Close();
        }
    }
}
