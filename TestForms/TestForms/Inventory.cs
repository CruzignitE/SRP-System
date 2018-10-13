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
            SalesRecords goSalesRecords = new SalesRecords();
            goSalesRecords.ShowDialog(); // Shows the Sales Records page
            Hide(); // Lee: Needs debugging
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProductsList goProductsList = new ProductsList();
            goProductsList.ShowDialog(); // Shows the Product List page
            Hide(); // Lee: Needs debugging
        }
    }
}
