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
        private static double productPrice;
        private double grandTotal = 0.0;
        private double tempPrice = 0.0;
        private int lastInsertedID = 0;


        public static string ProductID { get => productID; set => productID = value; }
        public new static string ProductName { get => productName; set => productName = value; }
        public static double ProductPrice { get => productPrice; set => productPrice = value; }

        public AddEditSalesRecord()
        {
            InitializeComponent();
            connString = new ConnectionString();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowseProduct_Click(object sender, EventArgs e)
        {
            BrowseProductForm browseProduct = new BrowseProductForm();
            browseProduct.FormClosing += new FormClosingEventHandler(this.AddEditSalesRecord_FormClosing);
            browseProduct.ShowDialog();
        }

        private void AddEditSalesRecord_Load(object sender, EventArgs e)
        {
            //dataGridSalesProduct.DataSource = bindingSource1;
            //GetData("SELECT * FROM Sales_Record_Details");
            table = new DataTable();
            table.Columns.AddRange(new DataColumn[5] {
                new DataColumn("Product ID", typeof(int)),
                new DataColumn("Product Name", typeof(string)),
                new DataColumn("Product Qty", typeof(int)),
                new DataColumn("Unit Price", typeof(double)),
                new DataColumn("Total Price", typeof(double))
            });

            dataGridSalesProduct.DataSource = table;
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
            txtBoxProductPrice.Text = ProductPrice.ToString();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                double totalPrice = (Convert.ToDouble(txtBoxProductPrice.Text) * Convert.ToDouble(txtBoxProductQty.Text));
                grandTotal += totalPrice;
                table.Rows.Add(txtBoxProductID.Text, txtBoxProductName.Text, txtBoxProductQty.Text, txtBoxProductPrice.Text, totalPrice);
                txtBoxProductID.Text = "";
                txtBoxProductName.Text = "";
                txtBoxProductQty.Value = 0;
                txtBoxProductPrice.Text = "";
                txtBoxGrandTotal.Text = grandTotal.ToString();
            }
            catch (Exception ex) {
                MessageBox.Show("Please select a product!");
            }
        }

        private void dataGridSalesProduct_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            grandTotal -= tempPrice;
            txtBoxGrandTotal.Text = grandTotal.ToString();
        }

        private void dataGridSalesProduct_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridSalesProduct.CurrentCell.OwningRow;
            tempPrice = Convert.ToDouble(row.Cells["Total Price"].Value);
        }

        private void btnSubmitSalesRecord_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            string insertCmd = @"INSERT INTO Sales_Record (sales_record_date, sales_record_amount, sales_record_description, sales_status)
                                    OUTPUT INSERTED.sales_record_id VALUES(@sDate, @sGrandTotal, @sDescription, 1)";
            string insertSalesDetail = @"INSERT INTO Sales_Record_Details (sales_record_id, product_id, quantity_order)
                                        VALUES(@srID, @pID, @qtyOrder)";

            List<int> ids = new List<int>(table.Rows.Count);
            List<int> quantities = new List<int>(table.Rows.Count);
            foreach (DataRow row in table.Rows) {
                ids.Add((int)row["Product ID"]);
                quantities.Add((int)row["Product Qty"]);
            }

            if (true)
            {
                using (SqlConnection conn = new SqlConnection(connString.getConnString()))
                {
                    try
                    {
                        conn.Open();
                        command = new SqlCommand(insertCmd, conn);
                        command.Parameters.AddWithValue(@"sDate", DateTime.Today.ToString("yyyy-MM-dd"));
                        command.Parameters.AddWithValue(@"sGrandTotal", txtBoxGrandTotal.Text);
                        command.Parameters.AddWithValue(@"sDescription", "");
                        lastInsertedID = (int)command.ExecuteScalar();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                using (SqlConnection conn = new SqlConnection(connString.getConnString()))
                {
                    try
                    {
                        conn.Open();
                        for (int i = 0; i < ids.Count; i++)
                        {
                            command = new SqlCommand(insertSalesDetail, conn);
                            command.Parameters.AddWithValue(@"srID", lastInsertedID);
                            command.Parameters.AddWithValue(@"pID", ids[i]);
                            command.Parameters.AddWithValue(@"qtyOrder", quantities[i]);
                            command.ExecuteNonQuery();
                        }
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }


                this.Close();
            }
            else
                MessageBox.Show("Please select a product!");
        }
    }
}
