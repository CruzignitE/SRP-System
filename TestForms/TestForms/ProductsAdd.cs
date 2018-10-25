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

namespace TestForms
{
    public partial class ProductsAdd : Form
    {
        private ConnectionString connString;

        public ProductsAdd()
        {
            InitializeComponent();
            connString = new ConnectionString();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            string insertCmd = @"INSERT INTO Product (product_name, product_stock_qty, product_category, product_price, product_status)
                                    VALUES(@product_name, 0, @product_category, @product_price, @product_status)";

            if (txtBoxName.Text != "" && txtBoxCategory.Text != "")
            {
                using (SqlConnection conn = new SqlConnection(connString.getConnString()))
                {
                    try
                    {
                        conn.Open();
                        command = new SqlCommand(insertCmd, conn);
                        command.Parameters.AddWithValue(@"product_name", txtBoxName.Text);
                        command.Parameters.AddWithValue(@"product_category", txtBoxCategory.Text);
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
