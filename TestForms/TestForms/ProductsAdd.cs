using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SRP_System
{
    public partial class ProductsAdd : Form
    {
        private ConnectionString connString;
        private int maxID = 0;
        private String strMaxID = "";
        private String zeroCode = "";

        public ProductsAdd()
        {
            InitializeComponent();
            connString = new ConnectionString();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            string getMaxID_CMD = "SELECT MAX(id) AS 'maxID' FROM Product";
            string insertCmd = @"INSERT INTO Product (product_id, product_name, product_stock_qty, product_category, product_price, product_status)
                                    VALUES(@product_ID, @product_name, 0, @product_category, @product_price, @product_status)";

            if (txtBoxName.Text != "" && sltCategory.SelectedItem.ToString() != "")
            {
                using (SqlConnection conn = new SqlConnection(connString.getConnString()))
                {
                    try
                    {
                        conn.Open();
                        command = new SqlCommand(getMaxID_CMD, conn);
                        using (SqlDataReader reader = command.ExecuteReader()) {
                            if (reader.Read()) {
                                if (reader["maxID"].ToString().Equals("")) {
                                    maxID = 1;
                                }
                                else {
                                    maxID = Int32.Parse(reader["maxID"].ToString());
                                    maxID++;
                                }
                                strMaxID = maxID.ToString();
                                for (int i = 0; i < (8 - strMaxID.Length); i++) {
                                    zeroCode += "0";
                                }
                                strMaxID = "P-" + zeroCode + maxID.ToString();
                            }
                        }
                        command = new SqlCommand(insertCmd, conn);
                        command.Parameters.AddWithValue(@"product_ID", strMaxID);
                        command.Parameters.AddWithValue(@"product_name", txtBoxName.Text);
                        command.Parameters.AddWithValue(@"product_category", sltCategory.SelectedItem.ToString());
                        double price = Convert.ToDouble(txtBoxPrice.Text);
                        command.Parameters.AddWithValue(@"product_price", price);
                        command.Parameters.AddWithValue(@"product_status", 1);
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                this.Close();
            }
            else
                MessageBox.Show("The required form must be filled.");
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
