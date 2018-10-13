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
    public partial class ProductsList : Form
    {
        public ProductsList()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ProductsAdd AddProducts = new ProductsAdd();
            AddProducts.ShowDialog();  // Shows the Products Add page
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            ProductsEdit EditProduct = new ProductsEdit();
            EditProduct.ShowDialog(); // Shows the Products Edit page
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SalesRecords goSalesRecords = new SalesRecords();
            goSalesRecords.ShowDialog(); // Shows the Sales Records page
            Hide(); // Lee: Needs debugging
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductsList goProductList = new ProductsList();
            goProductList.ShowDialog(); // Shows the Product List page
            Hide(); // Lee: Needs debugging
        }
    }
}
