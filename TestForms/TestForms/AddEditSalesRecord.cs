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
    public partial class AddEditSalesRecord : Form
    {
        //DATABASE CONNECTION VARIABLES
        private ConnectionString connString;
        private SqlDataAdapter dataAdapter;
        private DataTable table;

        private static string productID;
        private static string productName;

        public static string ProductID { get => productID; set => productID = value; }
        public new static string ProductName { get => productName; set => productName = value; }

        public AddEditSalesRecord()
        {
            InitializeComponent();
            connString = new ConnectionString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBrowseProduct_Click(object sender, EventArgs e)
        {
            BrowseProductForm browseProduct = new BrowseProductForm();
            browseProduct.FormClosing += new FormClosingEventHandler(this.AddEditSalesRecord_FormClosing);
            browseProduct.ShowDialog();
        }

        private void AddEditSalesRecord_Load(object sender, EventArgs e)
        {
            dataGridSalesProduct.DataSource = bindingSource1;
            GetData("SELECT * FROM Sales_Record_Details");
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

        private void AddEditSalesRecord_FormClosing(object sender, FormClosingEventArgs e)
        {
            txtBoxProductID.Text = ProductID;
            txtBoxProductName.Text = ProductName;
        }
    }
}
