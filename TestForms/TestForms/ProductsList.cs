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
        SqlDataAdapter dataAdapter;
        DataTable table;


        public ProductsList()
        {
            InitializeComponent();
            databasePath = path.Substring(0, path.Length - 3);
            conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + databasePath + @"database\SRP_SYSTEM.mdf;Integrated Security=True;Connect Timeout=30";
            AppDomain.CurrentDomain.SetData("dataPath", System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "database"));
        }

        private void ProductsList_Load(object sender, EventArgs e)
        {
            ProductGridTable.DataSource = productBinding;
            GetProductData("SELECT * FROM Product");
        }

        private void GetProductData(String cmd)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(cmd, conString);
                table = new DataTable();
                dataAdapter.Fill(table);

                productBinding.DataSource = table;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
