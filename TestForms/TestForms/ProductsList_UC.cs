using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TestForms
{
    public partial class ProductsList_UC : UserControl
    {
        private ConnectionString connString;
        private SqlDataAdapter dataAdapter;
        private DataTable table;
        private String productID, productName, productUnitPrice, productStatus, productCategory;

        public ProductsList_UC()
        {
            InitializeComponent();
            connString = new ConnectionString();
        }

        private void ProductsList_Load(object sender, EventArgs e)
        {
            dataGridView_inventory.DataSource = bindingSource1;
            GetData("SELECT * FROM Product");
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

        private void button_add_Click(object sender, EventArgs e)
        {
            ProductsAdd AddProducts = new ProductsAdd();
            AddProducts.FormClosing += new FormClosingEventHandler(this.ProductsList_FormClosing);
            AddProducts.Show();  // Shows the Products Add page
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            List<String> selectedRow = new List<String>();
            DataGridViewRow row = dataGridView_inventory.CurrentCell.OwningRow;

            try
            {
                productID = row.Cells["product_id"].Value.ToString();
                productName = row.Cells["product_name"].Value.ToString();
                productCategory = row.Cells["product_category"].Value.ToString();
                productUnitPrice = row.Cells["product_price"].Value.ToString();
                productStatus = row.Cells["product_status"].Value.ToString();
                ProductsEdit EditProduct = new ProductsEdit(productID, productName, productCategory, productUnitPrice, productStatus);
                EditProduct.FormClosing += new FormClosingEventHandler(this.ProductsList_FormClosing);
                EditProduct.ShowDialog(); // Shows the Products Edit page
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {

        }

        private void RefreshPage()
        {
            dataGridView_inventory.Update();
            GetData("SELECT * FROM Product");
        }

        private void ProductsList_FormClosing(object sender, FormClosingEventArgs e)
        {
            RefreshPage();
        }
    }
}
