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

namespace SRP_System
{
    public partial class Refunds : Form
    {
        //DATABASE CONNECTION VARIABLES
        private ConnectionString connString;
        private SqlDataAdapter dataAdapter;
        private DataTable table;
        private string selectState = @"SELECT log_refunds_id AS 'Log Refund ID', product_name AS 'Product Name', log_refunds_description AS 'Reason', log_refunds_date AS 'Refund Date', log_refunds_time  AS 'Refund Time', refunds_product_qty AS 'Stock Refunded ' FROM Log_Refunds JOIN Product ON Log_Refunds.product_id = Product.product_id";

        public Refunds()
        {
            InitializeComponent();
            connString = new ConnectionString();
        }

        private void Refunds_Load(object sender, EventArgs e)
        {
            dataGridView_logRefunds.DataSource = refundBSource;
            GetData(selectState);
        }

        private void GetData(string cmd)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(cmd, connString.getConnString());
                table = new DataTable();
                dataAdapter.Fill(table);

                refundBSource.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
