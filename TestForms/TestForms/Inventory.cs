using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForms
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            StockAdd AddStock = new StockAdd();
            AddStock.ShowDialog();  // Shows the StockAdd page
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            StockEdit EditStock = new StockEdit();
            EditStock.ShowDialog();  // Shows the StockAdd page
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SalesRecords goSalesRecords = new SalesRecords(); // Shows the Sales Records page
            this.Hide();
            goSalesRecords.FormClosed += (s, args) => this.Close();
            goSalesRecords.Show();
            goSalesRecords.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProductsList goProductsList = new ProductsList(); // Shows the Product List page
            this.Hide();
            goProductsList.FormClosed += (s, args) => this.Close();
            goProductsList.Show();
            goProductsList.Focus();
        }
    }
}
