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
    public partial class SalesRecords : Form
    {
        //DATABASE CONNECTION VARIABLES
        private ConnectionString connString;
        private SqlDataAdapter dataAdapter;
        private DataTable table;

        private string selectState = @"SELECT sales_record_id AS 'Sales ID', sales_record_date AS 'Sales Date', sales_record_amount AS 'Sales Total Price', tax_amount AS 'Tax Amount', sales_record_description AS 'Description' FROM Sales_Record WHERE sales_status = 1";
        public SalesRecords()
        {
            InitializeComponent();
            connString = new ConnectionString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dropDownName n1 = new dropDownName("Sale ID");
            comboBox1.Items.Add(n1);
            dropDownName n2 = new dropDownName("Item ID");
            comboBox1.Items.Add(n2);
            dropDownName n3 = new dropDownName("Item");
            comboBox1.Items.Add(n3);
            dropDownName n4 = new dropDownName("Category");
            comboBox1.Items.Add(n4);
            dropDownName n5 = new dropDownName("Price");
            comboBox1.Items.Add(n5);
        }

            public class dropDownName
            {

                private string dataName;

                public dropDownName(string dataName)
                {
                    DataName = dataName;
                }

                public string DataName
                {
                    get { return dataName; }
                    set { dataName = value; }
                }

                public override string ToString()
                {
                    return dataName;
                }

            }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddEditSalesRecord AddRecord = new AddEditSalesRecord();
            AddRecord.ShowDialog();  // Shows the AddEditSalesRecord page
        }

        private void editButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        //DATABASE UDPATE 12/10/2018 BY FELIX
        private void SalesRecords_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;
            GetData(selectState);
        }

        private void GetData(String cmd)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(cmd, connString.getConnString());
                table = new DataTable();
                dataAdapter.Fill(table);

                bindingSource1.DataSource = table;

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ToInventoryFromSalesRecord(object sender, EventArgs e)
        {
            Inventory goInventory = new Inventory(); // Shows the Inventory page
            this.Hide();
            goInventory.FormClosed += (s, args) => this.Close();
            goInventory.Show();
            goInventory.Focus();
        }

        private void ToProductListFromSalesRecord(object sender, EventArgs e)
        {
            ProductsList goProductList = new ProductsList();  // Shows the Product List page
            this.Hide();
            goProductList.FormClosed += (s, args) => this.Close();
            goProductList.Show();
            goProductList.Focus();
        }
    }
}

