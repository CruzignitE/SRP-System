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
        private string id, date, tPrice;

        //private string selectState = @"SELECT sales_record_id AS 'Sales ID', sales_record_date AS 'Sales Date', sales_record_amount AS 'Sales Total Price', tax_amount AS 'Tax Amount', sales_record_description AS 'Description' FROM Sales_Record WHERE sales_status = 1";
        private string selectState = @"SELECT * FROM Sales_Record";
        public SalesRecords()
        {
            InitializeComponent();
            connString = new ConnectionString();
        }
    
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            AddEditSalesRecord AddRecord = new AddEditSalesRecord(true);
            AddRecord.FormClosing += new FormClosingEventHandler(SalesRecords_FormClosing);
            AddRecord.ShowDialog();  // Shows the Add Sakes page
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            AddEditSalesRecord EditRecord = new AddEditSalesRecord(false, id, date, tPrice);
            EditRecord.FormClosing += new FormClosingEventHandler(SalesRecords_FormClosing);
            EditRecord.ShowDialog();  // Shows the Edit sales page
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to delete this sales record?", "Delete Sales", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string deleteStatement = @"UPDATE Sales_Record SET sales_status = 0 WHERE sales_record_id = @salesID";
                DataGridViewRow row = dataGridViewSalesRecord.CurrentCell.OwningRow;
                string id = row.Cells["Sales ID"].Value.ToString();
                SqlCommand command;
                using (SqlConnection conn = new SqlConnection(connString.getConnString()))
                {
                    try
                    {
                        conn.Open();
                        command = new SqlCommand(deleteStatement, conn);
                        command.Parameters.AddWithValue(@"salesID", id);
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                dataGridViewSalesRecord.Update();
                GetData(selectState);
            }
            
        }

        //DATABASE UDPATE 12/10/2018 BY FELIX
        private void SalesRecords_Load(object sender, EventArgs e)
        {
            dataGridViewSalesRecord.DataSource = bindingSource1;
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

        private void RefundsPopupButton_Click(object sender, EventArgs e)
        {
            Refunds AddRefund = new Refunds();
            AddRefund.ShowDialog();  // Shows the Refund page
        }

        private void PopupPieButton_Click(object sender, EventArgs e)
        {
            SalesRecordsPie generatePieChart = new SalesRecordsPie();
            generatePieChart.ShowDialog(); // Shows the Pie chart
        }

        private void PopupGraphButton_Click(object sender, EventArgs e)
        {
            SalesRecordsGraph generateGraph = new SalesRecordsGraph();
            generateGraph.ShowDialog(); // Shows the Graph
        }

        private void SalesRecords_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataGridViewSalesRecord.Update();
            GetData(selectState);
        }

        private void ManagerControl_Click(object sender, EventArgs e)
        {
            ManagerControl managerControl = new ManagerControl();
            managerControl.ShowDialog();
        }

        private void dataGridViewSales_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewSalesRecord.CurrentCell.OwningRow;
            id = row.Cells["Sales ID"].Value.ToString();
            date = row.Cells["Sales Date"].Value.ToString();
            tPrice = row.Cells["Sales Total Price"].Value.ToString();
        }
    }
}

