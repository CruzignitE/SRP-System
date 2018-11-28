using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace SRP_System
{
    public partial class StockEdit : Form
    {
        RegistryKey myKey, srpKey;
        private ConnectionString connString;
        private int maxID = 0;
        private string strMaxID = "";
        private string zeroCode = "";

        public StockEdit(string id, string name, string qty, string arrival, string expiry)
        {
            InitializeComponent();
            connString = new ConnectionString();
            txtBoxProductID.Text = id;
            txtBoxProductName.Text = name;
            txtBoxCurrentQty.Text = qty;
            txtBoxArrival.Text = arrival;
            txtBoxExpiry.Text = expiry;
            
            // Get registry subkey for the software
            if (Environment.Is64BitOperatingSystem)
                myKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
            else
                myKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32);

            srpKey = myKey.OpenSubKey(@"SOFTWARE\SRPsystem");
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            // Validates manager password
            if (textBox4.Text == Decrypt((string)srpKey.GetValue("SRPvalue1")))
            {
                SqlCommand command;
                string getMaxID_CMD = "SELECT MAX(id) AS 'maxID' FROM Log_Changes";
                string updateState = @"UPDATE Product SET product_stock_qty = @StockQty, product_arrival = @arrivalDate, product_expiry_date = @expiryDate WHERE product_id = @productID";
                string editLogState = @"INSERT INTO Log_Changes (log_changes_id, log_changes_date, log_changes_time, log_changes_info, product_id)
                                       VALUES (@logID, @date, @time, @info, @productID)";

                using (SqlConnection conn = new SqlConnection(connString.getConnString()))
                {
                    //edit stock
                    try
                    {
                        conn.Open();
                        command = new SqlCommand(updateState, conn);
                        if (txtBoxEditQty.Text == "") txtBoxEditQty.Text = "0";
                        int newQty = Convert.ToInt32(txtBoxCurrentQty.Text) + Convert.ToInt32(txtBoxEditQty.Text);
                        command.Parameters.AddWithValue(@"StockQty", newQty);
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
                    //log changes for edit
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
                        command = new SqlCommand(editLogState, conn);
                        command.Parameters.AddWithValue(@"logID", strMaxID);
                        command.Parameters.AddWithValue(@"date", DateTime.Today.ToString("yyyy-MM-dd"));
                        command.Parameters.AddWithValue(@"time", DateTime.Now.ToString("hh:mm:ss tt"));
                        string action = "";
                        int qty = Convert.ToInt32(txtBoxEditQty.Text);
                        action = (qty < 0) ? "Deduct " : "Add ";
                        command.Parameters.AddWithValue(@"info", action + txtBoxEditQty.Text + " Stocks");
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
            else
                MessageBox.Show("Incorrect manager password.", "Wrong password", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static string Decrypt(string text)
        {
            return Encoding.Unicode.GetString(
                ProtectedData.Unprotect(Convert.FromBase64String(text), null, DataProtectionScope.CurrentUser));
        }
    }
}
