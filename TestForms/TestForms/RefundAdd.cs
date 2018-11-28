using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace SRP_System
{
    public partial class RefundAdd : Form
    {
        private RegistryKey myKey, srpKey;
        private int qty;
        private ConnectionString connString;
        private int maxID = 0;
        private string strMaxID = "";
        private string zeroCode = "";

        public RefundAdd(string productID, string productName, int qty)
        {
            InitializeComponent();
            connString = new ConnectionString();
            txtBoxProductID.Text = productID;
            txtBoxProductName.Text = productName;
            this.qty = qty;
            txtBoxQty.Value = 1; //default value for refund item

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

        private void txtBoxQty_ValueChanged(object sender, EventArgs e)
        {
            if (txtBoxQty.Value > qty)
                txtBoxQty.Value = qty;
            else if (txtBoxQty.Value < 1)
                txtBoxQty.Value = 1;
        }

        private void addButton_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to refund " + txtBoxProductName.Text + " ?", "Refund Product", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // Validates manager password
                if (textBox_managerPass.Text == Decrypt((string)srpKey.GetValue("SRPvalue1")))
                {
                    // Insert code
                    SqlCommand command;
                    string getMaxID_CMD = "SELECT MAX(id) AS 'maxID' FROM Log_Refunds";
                    string insertStatement = @"INSERT INTO Log_Refunds (log_refunds_id, log_refunds_date, log_refunds_time, log_refunds_description, product_id, refunds_product_qty) VALUES (@logID, @date, @time, @desc, @productID, @productQty)";

                    using (SqlConnection conn = new SqlConnection(connString.getConnString()))
                    {
                        //log Refunds
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
                                    strMaxID = "LR-" + zeroCode + maxID.ToString();
                                }
                            }
                            command = new SqlCommand(insertStatement, conn);
                            command.Parameters.AddWithValue(@"logID", strMaxID);
                            command.Parameters.AddWithValue(@"date", DateTime.Today.ToString("yyyy-MM-dd"));
                            command.Parameters.AddWithValue(@"time", DateTime.Now.ToString("hh:mm:ss tt"));
                            command.Parameters.AddWithValue(@"desc", txtBoxDescription.Text);
                            command.Parameters.AddWithValue(@"productID", txtBoxProductID.Text);
                            command.Parameters.AddWithValue(@"productQty", txtBoxQty.Value);
                            command.ExecuteNonQuery();
                            conn.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        this.Close();
                    }

                }
                else
                    MessageBox.Show("Incorrect manager password.", "Wrong password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static string Decrypt(string text)
        {
            return Encoding.Unicode.GetString(
                ProtectedData.Unprotect(Convert.FromBase64String(text), null, DataProtectionScope.CurrentUser));
        }
    }
}
