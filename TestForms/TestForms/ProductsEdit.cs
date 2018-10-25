using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TestForms
{
    public partial class ProductsEdit : Form
    {
        private ConnectionString connString;
        private SqlCommand command;

        public ProductsEdit(String productID, String productName, String productCategory, String productUnitPrice, String productStatus)
        {
            InitializeComponent();
            PutValueToForm(productID, productName, productCategory, productUnitPrice, productStatus);
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PutValueToForm(String productID, String productName, String productCategory, String productUnitPrice, String productStatus)
        {
            txtEditProductID.Text = productID;
            txtEditProductName.Text = productName;
            txtEditProductCategory.Text = productCategory;
            txtEditProductUnitPrice.Value = Int32.Parse(productUnitPrice);
            if (Int32.Parse(productStatus) == 1)
                sltEditPruductStatus.SelectedIndex = 0;
            else
                sltEditPruductStatus.SelectedIndex = 1;
        }

        private void SubmitEditProductFormButton_Click(object sender, EventArgs e)
        {
            connString = new ConnectionString();
            String updateProduct_SQL = @"UPDATE Product SET product_name = @productName, product_category = @productCategory, product_price = @productPrice, product_status = @productStatus WHERE product_id = @productID"; ;

            using (SqlConnection conn = new SqlConnection(connString.getConnString()))
            {
                try
                {
                    conn.Open();
                    command = new SqlCommand(updateProduct_SQL, conn);
                    command.Parameters.AddWithValue(@"productName", txtEditProductName.Text);
                    command.Parameters.AddWithValue(@"productCategory", txtEditProductCategory.Text);
                    command.Parameters.AddWithValue(@"productPrice", txtEditProductUnitPrice.Value);

                    int idx;
                    idx = (sltEditPruductStatus.SelectedIndex == 0) ? 1 : 0; 

                    command.Parameters.AddWithValue(@"productStatus", idx);
                    command.Parameters.AddWithValue(@"productID", txtEditProductID.Text);
                    command.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Product updated successfully!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
