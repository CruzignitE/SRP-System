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
        private string selectQuery_date1 = @"AND sales_record_date BETWEEN '";
        private string selectQuery_date1_csv = @" WHERE sales_record_date BETWEEN '";
        private string selectQuery_date2 = @"' AND '";
        private string selectQuery_date3 = @"' ";

        public SalesRecords_UC()
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
                GetData();
            }
        }

        //DATABASE UDPATE 12/10/2018 BY FELIX
        private void SalesRecords_Load(object sender, EventArgs e)
        {
            dataGridView_salesRecords.DataSource = bindingSource1;
            GetData();

            dateTimePicker_from.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dateTimePicker_until.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, 1);
        }

        private void GetData()
        {
            try
            {
                if (checkBox_filterDate.Checked)
                {
                    string dateFrom = dateTimePicker_from.Value.Date.ToString("yyyy-MM-dd");
                    string dateUntil = dateTimePicker_until.Value.Date.ToString("yyyy-MM-dd");

                    dataAdapter = new SqlDataAdapter(selectQuery_SR + selectQuery_date1 + dateFrom + selectQuery_date2 + dateUntil + selectQuery_date3, connString.getConnString());
                }
                else
                    dataAdapter = new SqlDataAdapter(selectQuery_SR, connString.getConnString());
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
            SalesRecordsPie generatePieChart = new SalesRecordsPie(checkBox_filterDate.Checked, dateTimePicker_from.Value.Date, dateTimePicker_until.Value.Date);
            generatePieChart.ShowDialog(); // Shows the Pie chart
        }

        private void PopupGraphButton_Click(object sender, EventArgs e)
        {
            SalesRecordsGraph generateGraph = new SalesRecordsGraph(checkBox_filterDate.Checked, dateTimePicker_from.Value.Date, dateTimePicker_until.Value.Date);
            generateGraph.ShowDialog(); // Shows the Graph
        }

        private void Btn_CsvExport_Click(object sender, EventArgs e)
        {
            string selectStateForCSV = @"SELECT sr.sales_record_id AS 'Sales ID', CONVERT(VARCHAR(10), sales_record_date) AS 'Sales Date', product_name AS 'Product Name', quantity_order AS 'Quantity Order' FROM Sales_Record AS sr JOIN Sales_Record_Details AS srd ON sr.sales_record_id = srd.sales_record_id JOIN Product AS p ON p.product_id = srd.product_id";
            SqlDataAdapter adapter;

            if (checkBox_filterDate.Checked)
            {
                string dateFrom = dateTimePicker_from.Value.Date.ToString("yyyy-MM-dd");
                string dateUntil = dateTimePicker_until.Value.Date.ToString("yyyy-MM-dd");

                adapter = new SqlDataAdapter(selectStateForCSV + selectQuery_date1_csv + dateFrom + selectQuery_date2 + dateUntil + selectQuery_date3, connString.getConnString());
            }
            else
            {
                adapter = new SqlDataAdapter(selectStateForCSV, connString.getConnString());
            }
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

        private void UpdateTable(object sender, EventArgs e)
        {
            dataGridView_salesRecords.Update();
            GetData();
        }

        private void SalesRecords_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataGridView_salesRecords.Update();
            GetData();
        }
    }
}
