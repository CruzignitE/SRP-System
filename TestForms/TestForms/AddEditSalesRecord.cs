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
        private string selectState = @"SELECT Sales_Record_Details.product_id AS 'Product ID', Sales_Record_Details.quantity_order AS 'Product Qty', Product.product_name AS 'Product Name', Product.product_price AS 'Unit Price', (Sales_Record_Details.quantity_order * Product.product_price) AS 'Total Price' FROM Sales_Record_Details JOIN Product ON Sales_Record_Details.product_id = Product.product_id WHERE Sales_Record_Details.sales_record_id = 'SalesID'";
        private int maxID = 0;
        private String strMaxID = "";
        private String zeroCode = "";

        private static string productID;
        private static string productName;
        private static double productPrice;
        private int productQty;
        private double grandTotal = 0.0;
        private double tempPrice = 0.0;
        private string lastInsertedID = "";
        private bool isAdd;
        private int tableRowIndex = -1;


        public static string ProductID { get => productID; set => productID = value; }
        public new static string ProductName { get => productName; set => productName = value; }
        public static double ProductPrice { get => productPrice; set => productPrice = value; }

        public AddEditSalesRecord(bool isAdd)
        {
            InitializeComponent();
            connString = new ConnectionString();
            this.isAdd = isAdd;
        }

        public AddEditSalesRecord(bool isAdd, string id, string date, string tPrice)
        {
            InitializeComponent();
            connString = new ConnectionString();
            this.isAdd = isAdd;

            txtBoxSalesID.Text = id;
            txtBoxDate.Text = date;
            txtBoxGrandTotal.Text = tPrice;
            grandTotal = Convert.ToDouble(tPrice);
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
            if (isAdd)
            {
                table = new DataTable();
                table.Columns.AddRange(new DataColumn[5] {
                    new DataColumn("Product ID", typeof(string)),
                    new DataColumn("Product Name", typeof(string)),
                    new DataColumn("Product Qty", typeof(int)),
                    new DataColumn("Unit Price", typeof(double)),
                    new DataColumn("Total Price", typeof(double))
                });
                dataGridSalesProduct.DataSource = table;
            } else
            {
                dataGridSalesProduct.DataSource = bindingSource1;
                GetData(selectState);
            }
        }

        private void GetData(string cmd)
        {
            try
            {
                cmd = cmd.Replace("SalesID", txtBoxSalesID.Text);
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
                if(tableRowIndex != -1)
                {
                    table.Rows[tableRowIndex]["Product ID"] = txtBoxProductID.Text;
                    table.Rows[tableRowIndex]["Product Name"] = txtBoxProductName.Text;
                    table.Rows[tableRowIndex]["Product Qty"] = txtBoxProductQty.Text;
                    table.Rows[tableRowIndex]["Unit Price"] = txtBoxProductPrice.Text;
                    table.Rows[tableRowIndex]["Total Price"] = totalPrice;
                    tableRowIndex = -1;
                }
                else
                {
                    table.Rows.Add(txtBoxProductID.Text, txtBoxProductName.Text, txtBoxProductQty.Text, txtBoxProductPrice.Text, totalPrice);
                }
                grandTotal += totalPrice;
                txtBoxGrandTotal.Text = grandTotal.ToString();
                txtBoxProductID.Text = "";
                txtBoxProductName.Text = "";
                txtBoxProductQty.Value = 0;
                txtBoxProductPrice.Text = "";

            }
            catch (Exception ex) {
                MessageBox.Show("Please select a product!");
            }
        }

        private void dataGridSalesProduct_SelectionChanged(object sender, EventArgs e)
        {
            TrimTableRow();
        }

        private void TrimTableRow()
        {
            if (dataGridSalesProduct.Rows != null)
            {
                DataGridViewRow row = dataGridSalesProduct.CurrentCell.OwningRow;
                tempPrice = Convert.ToDouble(row.Cells["Total Price"].Value);
                productID = row.Cells["Product ID"].Value.ToString();
                productName = row.Cells["Product Name"].Value.ToString();
                productQty = Convert.ToInt32(row.Cells["Product Qty"].Value);
                ProductPrice = Convert.ToInt32(row.Cells["Unit Price"].Value);
            }
        }

        private void btnSubmitSalesRecord_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            string getMaxID_CMD = "SELECT MAX(id) AS maxID FROM Sales_Record";
            string insertCmd = @"INSERT INTO Sales_Record (sales_record_id, sales_record_date, sales_record_amount, sales_record_remark, sales_status)
                                    OUTPUT INSERTED.sales_record_id VALUES(@srID, @sDate, @sGrandTotal, @sRemark, 1)";
            string insertSalesDetail = @"INSERT INTO Sales_Record_Details (sales_record_id, product_id, quantity_order)
                                        VALUES(@srID, @pID, @qtyOrder)";
            string resetSalesDetail = @"DELETE FROM Sales_Record_Details WHERE sales_record_id = @sSalesID";
            string updateCommand = @"UPDATE Sales_Record SET sales_record_amount = @sGrandTotal WHERE sales_record_id = @sSalesID";

            List<string> ids = new List<string>(table.Rows.Count);
            List<int> quantities = new List<int>(table.Rows.Count);

            foreach (DataRow row in table.Rows) {
                ids.Add((string)row["Product ID"]);
                quantities.Add((int)row["Product Qty"]);
            }

            
            if (table.Rows.Count != 0)
            {
                string cmd = (isAdd) ? insertCmd : updateCommand;
                
                //INSERT SALES RECORD
                using (SqlConnection conn = new SqlConnection(connString.getConnString()))
                {
                    if (isAdd)
                    {
                        try
                        {
                            conn.Open();
                            command = new SqlCommand(getMaxID_CMD, conn);
                            using (SqlDataReader reader = command.ExecuteReader()) {
                                if (reader.Read()) {
                                    if (reader["maxID"].ToString().Equals(""))
                                    {
                                        maxID = 1;
                                    }
                                    else
                                    {
                                        maxID = Int32.Parse(reader["maxID"].ToString());
                                        maxID++;
                                    }
                                    strMaxID = maxID.ToString();
                                    for (int i = 0; i < (7 - strMaxID.Length); i++)
                                    {
                                        zeroCode += "0";
                                    }
                                    strMaxID = "SR-" + zeroCode + maxID.ToString();
                                }
                            }
                            command = new SqlCommand(cmd, conn);
                            command.Parameters.AddWithValue(@"srID", strMaxID);
                            command.Parameters.AddWithValue(@"sDate", DateTime.Today.ToString("yyyy-MM-dd"));
                            command.Parameters.AddWithValue(@"sRemark", "");
                            command.Parameters.AddWithValue(@"sGrandTotal", txtBoxGrandTotal.Text);
                            lastInsertedID = (string)command.ExecuteScalar();
                            conn.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        try
                        {
                            conn.Open();
                            command = new SqlCommand(cmd, conn);
                            command.Parameters.AddWithValue(@"sGrandTotal", txtBoxGrandTotal.Text);
                            command.Parameters.AddWithValue(@"sSalesID", txtBoxSalesID.Text);
                            command.ExecuteNonQuery();
                            conn.Close();
                                
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                //CHECK IF IT IS EDIT
                if (!isAdd)
                {
                    //RESET SALES ITEMS
                    using (SqlConnection conn = new SqlConnection(connString.getConnString()))
                    {
                        try
                        {
                            conn.Open();
                            
                            command = new SqlCommand(resetSalesDetail, conn);
                            command.Parameters.AddWithValue(@"sSalesID", txtBoxSalesID.Text);
                            command.ExecuteNonQuery();
                            
                            conn.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                //INSERT SALES ITEMS
                using (SqlConnection conn = new SqlConnection(connString.getConnString()))
                {
                    try
                    {
                        conn.Open();
                        for (int i = 0; i < ids.Count; i++)
                        {
                            command = new SqlCommand(insertSalesDetail, conn);
                            if (isAdd)
                            {
                                command.Parameters.AddWithValue(@"srID", lastInsertedID);
                            }else
                                command.Parameters.AddWithValue(@"srID", txtBoxSalesID.Text);
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

        private void dataGridSalesProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TrimTableRow();
            DialogResult dialogResult = MessageBox.Show("Do you want to edit this item?", "Edit Item", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                txtBoxProductID.Text = productID;
                txtBoxProductName.Text = productName;
                txtBoxProductQty.Value = productQty;
                txtBoxProductPrice.Text = productPrice.ToString();
                tableRowIndex = dataGridSalesProduct.CurrentCell.RowIndex;
                double totalPrice = Convert.ToDouble(table.Rows[tableRowIndex]["Total Price"]);
                grandTotal -= totalPrice; //decrease the value
            }
        }

        private void dataGridSalesProduct_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            grandTotal -= tempPrice;
            txtBoxGrandTotal.Text = grandTotal.ToString();
            TrimTableRow();
        }
    }
}
