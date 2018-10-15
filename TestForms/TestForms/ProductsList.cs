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

        private string path = Path.GetDirectoryName(Application.StartupPath);
        private static string databasePath;
        String conString;

        public ProductsList()
        {
            InitializeComponent();
            databasePath = path.Substring(0, path.Length - 3);
            conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + databasePath + @"SRP_SYSTEM.mdf;Integrated Security=True;Connect Timeout=30";
        }

        private void ProductsList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sRP_SYSTEMDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.sRP_SYSTEMDataSet.Product);
        }

        public void Refresh_Product_List()
        {
            SqlDataAdapter productAdapter = new SqlDataAdapter("SELECT * FROM Product", conString);
            DataSet productDataSet = new DataSet();
            productAdapter.Fill(productDataSet, "Product"); 
            productGridTable.DataSource = productDataSet.Tables["Product"];
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ProductsAdd AddProducts = new ProductsAdd(this);
            AddProducts.ShowDialog();  // Shows the Products Add page
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
            ProductsList goProductsList = new ProductsList(); // Shows the Product List page
            this.Hide();
            goProductsList.FormClosed += (s, args) => this.Close();
            goProductsList.Show();
            goProductsList.Focus();
        }
    }
}
