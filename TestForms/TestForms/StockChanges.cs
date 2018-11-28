using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRP_System
{
    public partial class StockChanges : Form
    {
        ConnectionString connString;
        private SqlDataAdapter dataAdapter;
        private DataTable table;
        string selectStatement = @"SELECT log_changes_id AS 'Log Changes ID', log_changes.product_id AS 'Product ID', product_name AS 'Product Name', product_category AS 'Product Category', log_changes_date AS 'Changes Date', log_changes_time AS 'Changes Time', log_changes_info AS 'Changes Info', product_stock_qty AS 'Current Quantity' FROM Log_Changes JOIN Product ON Log_Changes.product_id = Product.product_id";
        //string selectStatement = @"SELECT * FROM Log_Changes";

        public StockChanges()
        {
            InitializeComponent();
            connString = new ConnectionString();
        }

        private void StockChanges_Load(object sender, EventArgs e)
        {
            dataGVStockChanges.DataSource = bindingSource1;
            GetData(selectStatement);
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

        private void dataGVStockChanges_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGVStockChanges.CurrentCell.OwningRow;
                txtBoxProductID.Text = row.Cells["Product ID"].Value.ToString();
                string date = row.Cells["Changes Date"].Value.ToString();
                txtBoxDate.Text = date.Substring(0, 10);
                txtBoxQuantity.Text = row.Cells["Current Quantity"].Value.ToString();
                txtBoxCategory.Text = row.Cells["Product Category"].Value.ToString();
                string info = row.Cells["Changes Info"].Value.ToString();
                string name = row.Cells["Product Name"].Value.ToString();
                txtBoxDescription.Text = info + " to " + name;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
