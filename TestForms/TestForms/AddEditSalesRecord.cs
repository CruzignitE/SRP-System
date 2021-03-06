﻿using System;
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
        private string selectState = @"SELECT Sales_Record_Details.product_id AS 'Product ID', Sales_Record_Details.quantity_order AS 'Product Qty', Product.product_name AS 'Product Name', Sales_Record_Details.Discount_Percentage AS 'Discount Percentage', Product.product_price AS 'Unit Price', (Sales_Record_Details.quantity_order * Product.product_price) AS 'Total Price' FROM Sales_Record_Details JOIN Product ON Sales_Record_Details.product_id = Product.product_id WHERE Sales_Record_Details.sales_record_id = 'SalesID'";
     
        private int maxID = 0;
        private String strMaxID = "";
        private String zeroCode = "";

        private double productFinalPrice = 0.0;

        private static string productID;
        private static string productName;
        private static double productPrice;
        private int productQty;
        private int productDiscount;
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

            txtBox_saleID.Text = id;
            txtBox_date.Text = date;
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
                table.Columns.AddRange(new DataColumn[6] {
                    new DataColumn("Product ID", typeof(string)),
                    new DataColumn("Product Name", typeof(string)),
                    new DataColumn("Product Qty", typeof(int)),
                    new DataColumn("Discount Percentage", typeof(int)),
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
                cmd = cmd.Replace("SalesID", txtBox_saleID.Text);
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
            txtBox_productID.Text = ProductID;
            txtBox_productName.Text = ProductName;
            txtBox_productPrice.Text = ProductPrice.ToString();
            txtBox_discount.Text = "0";
            txtBox_finalPrice.Text = ProductPrice.ToString();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                double totalPrice = (Convert.ToDouble(txtBox_productPrice.Text) * Convert.ToDouble(txtBox_productQty.Text));
                if(tableRowIndex != -1)
                {
                    table.Rows[tableRowIndex]["Product ID"] = txtBox_productID.Text;
                    table.Rows[tableRowIndex]["Product Name"] = txtBox_productName.Text;
                    table.Rows[tableRowIndex]["Product Qty"] = txtBox_productQty.Text;
                    table.Rows[tableRowIndex]["Discount Percentage"] = txtBox_discount.Text;
                    table.Rows[tableRowIndex]["Unit Price"] = txtBox_productPrice.Text;
                    table.Rows[tableRowIndex]["Total Price"] = productFinalPrice;
                    tableRowIndex = -1;
                }
                else
                {
                    table.Rows.Add(txtBox_productID.Text, txtBox_productName.Text, txtBox_productQty.Text, txtBox_discount.Text, txtBox_productPrice.Text, productFinalPrice);
                }
                grandTotal += productFinalPrice;
                txtBoxGrandTotal.Text = grandTotal.ToString();
                txtBox_productID.Text = "";
                txtBox_productName.Text = "";
                txtBox_productQty.Value = 0;
                txtBox_productPrice.Text = "";
                txtBox_discount.Text = "";

            }
            catch {
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
                productDiscount = Convert.ToInt32(row.Cells["Discount Percentage"].Value);
                ProductPrice = Convert.ToInt32(row.Cells["Unit Price"].Value);
            }
        }

        private void btnSubmitSalesRecord_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            string getMaxID_CMD = "SELECT MAX(id) AS maxID FROM Sales_Record";
            string insertCmd = @"INSERT INTO Sales_Record (sales_record_id, sales_record_date, sales_record_amount, sales_record_remark, sales_status)
                                    OUTPUT INSERTED.sales_record_id VALUES(@srID, @sDate, @sGrandTotal, @sRemark, 1)";
            string insertSalesDetail = @"INSERT INTO Sales_Record_Details (sales_record_id, product_id, quantity_order, Discount_Percentage)
                                        VALUES(@srID, @pID, @qtyOrder, @discount_percentage)";
            string resetSalesDetail = @"DELETE FROM Sales_Record_Details WHERE sales_record_id = @sSalesID";
            string updateCommand = @"UPDATE Sales_Record SET sales_record_amount = @sGrandTotal WHERE sales_record_id = @sSalesID";

            List<string> ids = new List<string>(table.Rows.Count);
            List<int> quantities = new List<int>(table.Rows.Count);
            List<int> discountPercentage = new List<int>(table.Rows.Count);

            foreach (DataRow row in table.Rows) {
                ids.Add((string)row["Product ID"]);
                quantities.Add((int)row["Product Qty"]);
                discountPercentage.Add((int)row["Discount Percentage"]);
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

                            // Lee: For manipulating database date for Sales Record seeding
                            //DateTime saleDate = Convert.ToDateTime(txtBox_date.Text);
                            //command.Parameters.AddWithValue(@"sDate", saleDate.ToString("yyyy-MM-dd"));

                            command.Parameters.AddWithValue(@"sRemark", "");
                            command.Parameters.AddWithValue(@"sGrandTotal", Math.Round(Double.Parse(txtBoxGrandTotal.Text), 2));
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
                            command.Parameters.AddWithValue(@"sGrandTotal", Math.Round(Double.Parse(txtBoxGrandTotal.Text), 2));
                            command.Parameters.AddWithValue(@"sSalesID", txtBox_saleID.Text);
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
                            command.Parameters.AddWithValue(@"sSalesID", txtBox_saleID.Text);
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
                                command.Parameters.AddWithValue(@"srID", txtBox_saleID.Text);
                            command.Parameters.AddWithValue(@"pID", ids[i]);
                            command.Parameters.AddWithValue(@"qtyOrder", quantities[i]);
                            command.Parameters.AddWithValue(@"discount_percentage", discountPercentage[i]);
                            command.ExecuteNonQuery();
                        }
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                StockDeduct(ids, quantities);
                
            this.Close();
            }
            else
                MessageBox.Show("Please select a product!");
        }

        private void StockDeduct(List<String> id, List<int> qty) {
            SqlCommand command;
            int currentStock, newStock;
            string currentStockCommand = @"SELECT product_stock_qty FROM Product WHERE product_id = @productID";
            string updateStockCommand = @"UPDATE Product SET product_stock_qty = @salesQty WHERE product_id = @productID";

            using (SqlConnection conn = new SqlConnection(connString.getConnString())) {

                conn.Open();
                
                for (int i = 0; i < id.Count; i++) {
                    command = new SqlCommand(currentStockCommand, conn);
                    command.Parameters.AddWithValue(@"productID", id[i]);

                    using (SqlDataReader reader = command.ExecuteReader()) {
                        if (reader.Read()) {
                            currentStock = Int32.Parse(reader["product_stock_qty"].ToString());
                            newStock = currentStock - qty[i];

                            reader.Close();

                            command = new SqlCommand(updateStockCommand, conn);
                            command.Parameters.AddWithValue(@"salesQty", newStock);
                            command.Parameters.AddWithValue(@"productID", id[i]);
                            command.ExecuteNonQuery();
                        }
                    }
                }
                conn.Close();
            }

        }

        private void dataGridSalesProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TrimTableRow();
            DialogResult dialogResult = MessageBox.Show("Do you want to edit this item?", "Edit Item", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                txtBox_productID.Text = productID;
                txtBox_productName.Text = productName;
                txtBox_productQty.Value = productQty;
                txtBox_productPrice.Text = productPrice.ToString();
                tableRowIndex = dataGridSalesProduct.CurrentCell.RowIndex;
                txtBox_discount.Text = table.Rows[tableRowIndex]["Discount Percentage"].ToString();
                double totalPrice = Convert.ToDouble(table.Rows[tableRowIndex]["Total Price"]);
                grandTotal -= totalPrice; //decrease the value
                if (!isAdd)
                    btnRefundProduct.Enabled = true;
            }
        }

        private void dataGridSalesProduct_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            grandTotal -= tempPrice;
            txtBoxGrandTotal.Text = grandTotal.ToString();
            TrimTableRow();
        }

        private void PriceCalculate(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtBox_discount.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtBox_discount.Text = txtBox_discount.Text.Remove(txtBox_discount.Text.Length - 1);
            }
            else if (txtBox_discount.Text != "") {
                CalculateFinalPrice();
            }
        }

        private void ValueChanged(object sender, EventArgs e)
        {
            CalculateFinalPrice();
            SqlCommand command;

            using (SqlConnection conn = new SqlConnection(connString.getConnString())) {
                conn.Open();

                command = new SqlCommand(@"SELECT product_stock_qty AS 'stock_qty' FROM Product WHERE product_id = '" + txtBox_productID.Text + "'", conn);
                using (SqlDataReader reader = command.ExecuteReader()) {
                    if (reader.Read())
                    {
                        if (Int32.Parse(txtBox_productQty.Value.ToString()) > Int32.Parse(reader["stock_qty"].ToString())) {
                            MessageBox.Show("Current stock have only " + reader["stock_qty"].ToString());
                            txtBox_productQty.Value = Int32.Parse(reader["stock_qty"].ToString());
                        }
                    }
                }
                conn.Close();
            }
        }

        private void CalculateFinalPrice() {
            double DiscountPercent;
            double DiscountPrice;
            double productQty;
            double productPrice;

            if (txtBox_discount.Text == "")
                txtBox_discount.Text = "0";

            if (txtBox_productQty.Value.ToString() != "" && txtBox_productPrice.Text != "")
            {
                productQty = Convert.ToDouble(txtBox_productQty.Value);
                productPrice = Convert.ToDouble(txtBox_productPrice.Text);
                productFinalPrice = Convert.ToDouble(productQty * productPrice);
                DiscountPercent = Convert.ToDouble(txtBox_discount.Text);

                if (DiscountPercent > 0)
                {
                    DiscountPrice = (productFinalPrice * (DiscountPercent / 100));
                    productFinalPrice = Math.Round(Convert.ToDouble(productFinalPrice) - Convert.ToDouble(DiscountPrice), 2);
                }

                txtBox_finalPrice.Text = productFinalPrice.ToString();
            }
        }

        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            CalculateFinalPrice();
        }

        private void btnRefundProduct_Click(object sender, EventArgs e)
        {
            RefundAdd addRefund = new RefundAdd(txtBox_productID.Text, txtBox_productName.Text, Convert.ToInt32(txtBox_productQty.Value));
            addRefund.ShowDialog();
            btnRefundProduct.Enabled = false;
            txtBox_productID.Text = "";
            txtBox_productName.Text = "";
            txtBox_productQty.Value = 0;
            txtBox_productPrice.Text = "";
            txtBox_discount.Text = "";
            txtBox_finalPrice.Text = "";
        }
    }
}
