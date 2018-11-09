using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Diagnostics;

namespace TestForms
{
    public partial class SalesRecords_UC : UserControl
    {
        //DATABASE CONNECTION VARIABLES
        private ConnectionString connString;
        private SqlDataAdapter dataAdapter;
        private DataTable table;
        private string id, date, tPrice;

        private string selectQuery_SR = @"SELECT sales_record_id AS 'Sales ID', sales_record_date AS 'Sales Date', sales_record_amount AS 'Sales Total Price', sales_record_remark AS 'Remark' FROM Sales_Record WHERE sales_status = 1";

        public SalesRecords_UC()
        {
            InitializeComponent();
            connString = new ConnectionString();
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {

            DataGridViewRow row = dataGridView_salesRecords.CurrentCell.OwningRow;
            id = row.Cells["Sales ID"].Value.ToString();
            date = row.Cells["Sales Date"].Value.ToString();
            tPrice = row.Cells["Sales Total Price"].Value.ToString();

            AddEditSalesRecord EditRecord = new AddEditSalesRecord(false, id, date, tPrice);
            EditRecord.FormClosing += new FormClosingEventHandler(SalesRecords_FormClosing);
            EditRecord.ShowDialog();  // Shows the Edit sales page
        }

        private void Btn_Del_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to delete this sales record?", "Delete Sales", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string deleteStatement = @"UPDATE Sales_Record SET sales_status = 0 WHERE sales_record_id = @salesID";
                DataGridViewRow row = dataGridView_salesRecords.CurrentCell.OwningRow;
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
                dataGridView_salesRecords.Update();
                GetData(selectQuery_SR);
            }
        }

        //DATABASE UDPATE 12/10/2018 BY FELIX
        private void SalesRecords_Load(object sender, EventArgs e)
        {
            dataGridView_salesRecords.DataSource = bindingSource1;
            GetData(selectQuery_SR);
        }

        private void GetData(String cmd)
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

        private void button_csvExport_Click(object sender, EventArgs e)
        {

            string selectStateForCSV = @"SELECT Sales_Record.sales_record_id AS 'Sales ID', CONVERT(VARCHAR(10), sales_record_date) AS 'Sales Date', product_name AS 'Product Name', quantity_order AS 'Quantity Order' FROM Sales_Record JOIN Sales_Record_Details ON Sales_Record.sales_record_id = Sales_Record_Details.sales_record_id JOIN Product ON Product.product_id = Sales_Record_Details.product_id WHERE sales_status = 1";
            SqlDataAdapter adapter = new SqlDataAdapter(selectStateForCSV, connString.getConnString());
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            try
            {
                StreamWriter streamWriter = new StreamWriter("D:\\csvData.csv", false);

                int colCount = dt.Columns.Count;
                for (int i = 0; i < colCount; i++)
                {
                    streamWriter.Write(dt.Columns[i]);
                    if (i < colCount - 1)
                    {
                        streamWriter.Write(",");
                    }
                }
                streamWriter.Write(streamWriter.NewLine);
                //write all the rows
                foreach (DataRow dr in dt.Rows)
                {
                    for (int i = 0; i < colCount; i++)
                    {
                        if (!Convert.IsDBNull(dr[i]))
                        {
                            streamWriter.Write(dr[i].ToString());
                        }
                        if (i < colCount - 1)
                        {
                            streamWriter.Write(",");
                        }
                    }
                    streamWriter.Write(streamWriter.NewLine);
                }
                streamWriter.Close();
                MessageBox.Show("Successfully Exported");
                Process.Start(@"D:\\csvData.csv");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        

        private void button_add_Click(object sender, EventArgs e)
        {
            AddEditSalesRecord AddRecord = new AddEditSalesRecord(true);
            AddRecord.FormClosing += new FormClosingEventHandler(SalesRecords_FormClosing);
            AddRecord.ShowDialog();  // Shows the Add Sakes page
        }

        private void SalesRecords_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataGridView_salesRecords.Update();
            GetData(selectQuery_SR);
        }
    }
}
