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
    public partial class ProductsList : Form
    {
        private ConnectionString connString;
        private SqlDataAdapter dataAdapter;
        private DataTable table;

        public ProductsList()
        {
            InitializeComponent();
            connString = new ConnectionString();
        }

        private void ProductsList_Load(object sender, EventArgs e)
        {
            productGridTable.DataSource = bindingSource1;
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
        
        private void RefreshPage()
        {
            productGridTable.Update();
            GetData("SELECT * FROM Product");
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ProductsAdd AddProducts = new ProductsAdd();
            AddProducts.FormClosing += new FormClosingEventHandler(this.ProductsList_FormClosing);
            AddProducts.Show();  // Shows the Products Add page
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            ProductsEdit EditProduct = new ProductsEdit();
            EditProduct.ShowDialog(); // Shows the Products Edit page
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SalesRecords goSalesRecords = new SalesRecords(); // Shows the Sales Records page
            this.Hide();
            goSalesRecords.FormClosed += (s, args) => this.Close();
            goSalesRecords.Show();
            goSalesRecords.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inventory goInventory = new Inventory(); // Shows the Inventory page
            this.Hide();
            goInventory.FormClosed += (s, args) => this.Close();
            goInventory.Show();
            goInventory.Focus();
        }

        private void ProductsList_FormClosing(object sender, FormClosingEventArgs e)
        {
            RefreshPage();
        }
    }
}
