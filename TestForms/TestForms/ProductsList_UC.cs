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
    public partial class ProductsList_UC : UserControl
    {
        private ConnectionString connString;
        private SqlDataAdapter dataAdapter;
        private DataTable table;
        private String productID, productName, productUnitPrice, productStatus, productCategory;
        private String selectQuery_Products = "SELECT product_id AS 'Product ID', product_name AS 'Product Name', product_category AS 'Product Category', product_price AS 'Product Price', product_description AS 'Product Description', CASE WHEN product_status=1 THEN 'Active' ELSE 'Inactive' END AS 'Product Status' FROM Product";

        public ProductsList_UC()
        {
            InitializeComponent();
            connString = new ConnectionString();
        }

        private void ProductsList_Load(object sender, EventArgs e)
        {
            dataGridView_inventory.DataSource = bindingSource1;
            GetData(selectQuery_Products);
        }

        private void RemovePlaceholder(object sender, EventArgs e) {
            textBox_search.Text = "";
        }

        private void AddPlaceholder(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(textBox_search.Text))
                textBox_search.Text = "Search";
        }

        private void GetData(string cmd)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(cmd, connString.getConnString());
                table = new DataTable();
                dataAdapter.Fill(table);

                bindingSource1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            ProductsAdd AddProducts = new ProductsAdd();
            AddProducts.FormClosing += new FormClosingEventHandler(this.ProductsList_FormClosing);
            AddProducts.Show();  // Shows the Products Add page
        }

        private void FilterProductList_OnKeyUp(object sender, KeyEventArgs e)
        {
            string keyword = textBox_search.Text;
            string options = "";
            string filter_cmd = "";

            if (comboBox_filter.SelectedItem != null)
            {
                options = comboBox_filter.SelectedItem.ToString();
            }
            if (options.Equals("Category"))
                filter_cmd = @"SELECT product_id AS 'Product ID', product_name AS 'Product Name', product_category AS 'Product Category', product_unit AS 'Product Unit', product_price AS 'Product Price', product_description AS 'Product Description', product_status AS 'Product Status' FROM Product WHERE product_category LIKE '%" + keyword + "%'";
            else if (options.Equals("Name"))
                filter_cmd = @"SELECT product_id AS 'Product ID', product_name AS 'Product Name', product_category AS 'Product Category', product_unit AS 'Product Unit', product_price AS 'Product Price', product_description AS 'Product Description', product_status AS 'Product Status' FROM Product WHERE product_name LIKE '%" + keyword + "%'";


            if (!keyword.Equals(""))
                GetData(filter_cmd);
            else
                GetData(selectQuery_Products);
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            List<String> selectedRow = new List<String>();
            DataGridViewRow row = dataGridView_inventory.CurrentCell.OwningRow;

            try
            {
                productID = row.Cells["Product ID"].Value.ToString();
                productName = row.Cells["Product Name"].Value.ToString();
                productCategory = row.Cells["Product Category"].Value.ToString();
                productUnitPrice = row.Cells["Product Price"].Value.ToString();
                productStatus = row.Cells["Product Status"].Value.ToString();
                ProductsEdit EditProduct = new ProductsEdit(productID, productName, productCategory, productUnitPrice, productStatus);
                EditProduct.FormClosing += new FormClosingEventHandler(this.ProductsList_FormClosing);
                EditProduct.ShowDialog(); // Shows the Products Edit page
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Del_Click(object sender, EventArgs e)
        {
            string deleteProduct = @"UPDATE Product SET product_status = 0 WHERE product_id = @Param";
            DataGridViewRow row = dataGridView_inventory.CurrentCell.OwningRow;
            string id = row.Cells["Product ID"].Value.ToString();
            SqlCommand command;
            using (SqlConnection conn = new SqlConnection(connString.getConnString()))
            {
                try
                {
                    conn.Open();
                    command = new SqlCommand(deleteProduct, conn);
                    command.Parameters.AddWithValue(@"Param", id);

                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            dataGridView_inventory.Update();
            GetData(selectQuery_Products);
        }

        private void RefreshPage()
        {
            dataGridView_inventory.Update();
            GetData(selectQuery_Products);
        }

        private void ProductsList_FormClosing(object sender, FormClosingEventArgs e)
        {
            RefreshPage();
        }
    }
}
