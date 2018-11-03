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
    public partial class BrowseProductForm : Form
    {
        //DATABASE CONNECTION VARIABLES
        private ConnectionString connString;
        private SqlDataAdapter dataAdapter;
        private DataTable table;
        
        public BrowseProductForm()
        {
            InitializeComponent();
            connString = new ConnectionString();
        }

        private void BrowseProductForm_Load(object sender, EventArgs e)
        {
            dataGVBrowseProduct.DataSource = bindingSource1;
            GetData("SELECT product_id AS 'Product ID', product_name AS 'Product Name', product_stock_qty AS 'Product Stock', product_expiry_date AS 'Expiry Date', product_price AS 'Product Price' FROM Product");
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

        private void dataGVBrowseProduct_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGVBrowseProduct.CurrentCell.OwningRow;
                string productID = row.Cells["Product ID"].Value.ToString();
                string productName = row.Cells["Product Name"].Value.ToString();
                double productPrice = Convert.ToDouble(row.Cells["Product Price"].Value);
                AddEditSalesRecord.ProductID = productID;
                AddEditSalesRecord.ProductName = productName;
                AddEditSalesRecord.ProductPrice = productPrice;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
