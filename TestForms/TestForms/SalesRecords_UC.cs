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

namespace TestForms
{
    public partial class SalesRecords_UC : UserControl
    {
        //DATABASE CONNECTION VARIABLES
        private ConnectionString connString;
        private SqlDataAdapter dataAdapter;
        private DataTable table;

        private string selectState = @"SELECT sales_record_id AS 'Sales ID', sales_record_date AS 'Sales Date', sales_record_amount AS 'Sales Total Price', tax_amount AS 'Tax Amount', sales_record_description AS 'Description' FROM Sales_Record WHERE sales_status = 1";

        public SalesRecords_UC()
        {
            InitializeComponent();
            connString = new ConnectionString();
        }

        private void button_sr_add_Click(object sender, EventArgs e)
        {
            AddEditSalesRecord AddRecord = new AddEditSalesRecord(true);
            AddRecord.ShowDialog();  // Shows the AddEditSalesRecord page
        }

        //DATABASE UDPATE 12/10/2018 BY FELIX
        private void SalesRecords_Load(object sender, EventArgs e)
        {
            //dataGridView_salesRecords.DataSource = bindingSource1;
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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refundsPopupButton_Click(object sender, EventArgs e)
        {
            Refunds AddRefund = new Refunds();
            AddRefund.ShowDialog();  // Shows the Refund page
        }

        private void popupPieButton_Click(object sender, EventArgs e)
        {
            SalesRecordsPie generatePieChart = new SalesRecordsPie();
            generatePieChart.ShowDialog(); // Shows the Pie chart
        }

        private void popupGraphButton_Click(object sender, EventArgs e)
        {
            SalesRecordsGraph generateGraph = new SalesRecordsGraph();
            generateGraph.ShowDialog(); // Shows the Graph
        }
    }
}
