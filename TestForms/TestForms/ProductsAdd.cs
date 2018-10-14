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

        private string path = Path.GetDirectoryName(Application.StartupPath);
        private static string databasePath;
        String conString;

        public ProductsAdd()
        {
            InitializeComponent();
            databasePath = path.Substring(0, path.Length - 3);
            conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + databasePath + @"database\SRP_SYSTEM.mdf;Integrated Security=True;Connect Timeout=30";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            string insertCmd = @"INSERT INTO Product (product_name, product_category, product_price, product_status)
                                    VALUES(@product_name, @product_category, @product_price, @product_status)";

            if (txtBoxName.Text != "" && txtBoxCategory.Text != "")
            {
                using (SqlConnection conn = new SqlConnection(conString))
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
                ProductsList productsListForm = new ProductsList();
                productsListForm.RefreshPage();
                this.Close();
            }
            else
                MessageBox.Show("The required form must be filled.");
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
