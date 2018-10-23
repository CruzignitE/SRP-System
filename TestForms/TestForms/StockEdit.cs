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
    public partial class StockEdit : Form
    {
        private ConnectionString connString;
        public StockEdit(string id, string name, string qty, string arrival, string expiry)
        {
            InitializeComponent();
            connString = new ConnectionString();
            txtBoxProductID.Text = id;
            txtBoxProductName.Text = name;
            txtBoxCurrentQty.Text = qty;
            txtBoxArrival.Text = arrival;
            txtBoxExpiry.Text = expiry;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            string updateState = @"UPDATE Product SET product_stock_qty = @StockQty, product_arrival = @arrivalDate, product_expiry_date = @expiryDate WHERE product_id = @productID";

            using (SqlConnection conn = new SqlConnection(connString.getConnString()))
            {
                try
                {
                    conn.Open();
                    command = new SqlCommand(updateState, conn);
                    int newQty = Convert.ToInt32(txtBoxCurrentQty.Text) + Convert.ToInt32(txtBoxEditQty.Text);
                    command.Parameters.AddWithValue(@"StockQty", newQty);
                    DateTime dateArrival = Convert.ToDateTime(txtBoxArrival.Text);
                    command.Parameters.AddWithValue(@"arrivalDate", dateArrival.ToString("yyyy-MM-dd"));
                    DateTime dateExpiry = Convert.ToDateTime(txtBoxExpiry.Text);
                    command.Parameters.AddWithValue(@"expiryDate", dateExpiry.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue(@"productID", txtBoxProductID.Text);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            this.Close();
        }
    }
}
