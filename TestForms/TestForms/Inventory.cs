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

namespace TestForms
{
    public partial class Inventory : Form
    {
        private ConnectionString connString;
        private SqlDataAdapter dataAdapter;
        private DataTable table;
        private string selectCommand = @"SELECT product_id AS 'Product ID', product_name AS 'Product Name', product_stock_qty AS Quantity, product_arrival AS 'Arrival Date', product_expiry_date AS 'Expiry Date', product_description AS 'Description' FROM Product WHERE product_status = 1";
        private string id, name, qty;

        public Inventory()
        {
            InitializeComponent();
            connString = new ConnectionString();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            StockAdd AddStock = new StockAdd(id, name, qty);
            AddStock.FormClosing += new FormClosingEventHandler(this.Inventory_FormClosing);
            AddStock.ShowDialog();  // Shows the StockAdd page
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            StockEdit EditStock = new StockEdit();
            EditStock.ShowDialog();  // Shows the StockAdd page
        }

        private void ToSalesRecordFromInventory(object sender, EventArgs e)
        {
            SalesRecords goSalesRecords = new SalesRecords(); // Shows the Sales Records page
            this.Hide();
            goSalesRecords.FormClosed += (s, args) => this.Close();
            goSalesRecords.Show();
            goSalesRecords.Focus();
        }

        private void ToProductListFromInventory(object sender, EventArgs e)
        {
            ProductsList goProductsList = new ProductsList(); // Shows the Product List page
            this.Hide();
            goProductsList.FormClosed += (s, args) => this.Close();
            goProductsList.Show();
            goProductsList.Focus();
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

        private void showStockLog(object sender, EventArgs e)
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
