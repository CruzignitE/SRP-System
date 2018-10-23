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
    public partial class Inventory_UC : UserControl
    {
        private ConnectionString connString;
        private SqlDataAdapter dataAdapter;
        private DataTable table;
        private string selectCommand = @"SELECT product_id AS 'Product ID', product_name AS 'Product Name', product_stock_qty AS Quantity, product_arrival AS 'Arrival Date', product_expiry_date AS 'Expiry Date', product_description AS 'Description' FROM Product WHERE product_status = 1";
        private string id, name, qty;

        public Inventory_UC()
        {
            InitializeComponent();
            connString = new ConnectionString();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            StockAdd AddStock = new StockAdd(id, name, qty);
            AddStock.FormClosing += new FormClosingEventHandler(this.Inventory_FormClosing);
            AddStock.ShowDialog();  // Shows the StockAdd page

        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            //StockEdit EditStock = new StockEdit();
            //EditStock.ShowDialog();  // Shows the StockAdd page

        }

        private void button_delete_Click(object sender, EventArgs e)
        {

        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            dataGridInventory.DataSource = bindingSource1;
            GetData(selectCommand);
        }

        private void Inventory_FormClosing(object sender, FormClosingEventArgs e)
        {
            RefreshInventoryPage();
        }

        private void RefreshInventoryPage()
        {
            dataGridInventory.Update();
            GetData(selectCommand);
        }
        private void button_logs_Click(object sender, EventArgs e)
        {
            StockChanges stockChanged = new StockChanges();
            stockChanged.ShowDialog();
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

        private void dataGridInventory_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridInventory.CurrentCell.OwningRow;
                id = row.Cells["Product ID"].Value.ToString();
                name = row.Cells["Product Name"].Value.ToString();
                qty = row.Cells["Quantity"].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
