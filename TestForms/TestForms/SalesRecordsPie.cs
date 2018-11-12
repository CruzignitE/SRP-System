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
    public partial class SalesRecordsPie : Form
    {
        //DATABASE CONNECTION VARIABLES
        private ConnectionString connString;
        private SqlDataAdapter dataAdapter;
        private DataTable table;
        System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
        System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();

        List<String> categories = new List<String>();

        // TODO: Pass starting and ending dates in constructor for chart generation
        //private string selectQuery_part1 = @"SELECT sr.sales_record_date AS 'Sales Date', SUM(p.product_price * srd.quantity_order) AS 'Sales Total Price' FROM Sales_Record AS sr JOIN Sales_Record_Details  srd ON sr.sales_record_id = srd.sales_record_id JOIN Product as p ON srd.product_id = p.product_id WHERE product_category = '";
        //private string selectQuery_part2 = @"' GROUP BY sr.sales_record_date";
        //private string selectQuery_date1 = @"' AND sr.sales_record_date BETWEEN '";
        //private string selectQuery_date2 = @"' AND '";

        private string selectQuery_part1 = @"SELECT SUM(p.product_price * srd.quantity_order) AS 'Sales Total Price', p.product_category AS 'Category' FROM Sales_Record AS sr JOIN Sales_Record_Details srd ON sr.sales_record_id = srd.sales_record_id JOIN Product as p ON srd.product_id = p.product_id ";
        private string selectQuery_part2 = @"GROUP BY p.product_category";
        private string selectQuery_date1 = @"WHERE sr.sales_record_date BETWEEN '";
        private string selectQuery_date2 = @"' AND '";
        private string selectQuery_date3 = @"' ";


        public SalesRecordsPie(bool useDates, DateTime startDate, DateTime endDate)
        {
            InitializeComponent();
            connString = new ConnectionString();

            chart1.DataSource = bindingSource1;
            
            try
            {
                if (useDates)
                    dataAdapter = new SqlDataAdapter(selectQuery_part1 +
                        selectQuery_date1 + startDate.ToString("yyyy-MM-dd") +
                        selectQuery_date2 + endDate.ToString("yyyy-MM-dd") + selectQuery_date3 +
                        selectQuery_part2, connString.getConnString());
                else
                    dataAdapter = new SqlDataAdapter(selectQuery_part1 + selectQuery_part2, connString.getConnString());

                table = new DataTable();
                dataAdapter.Fill(table);

                // Prompts user if they selected a period with no data
                if (table.Rows.Count == 0)
                    MessageBox.Show("No data available for the selected period", "No data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                bindingSource1.DataSource = table;

                series1.ChartArea = "ChartArea1";
                series1.Name = "Pie";
                series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
                series1.XValueMember = "Category";
                series1.YValueMembers = "Sales Total Price";

                legend1.Name = "Legend1";
                series1.ChartArea = "ChartArea1";
                series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                series1.Legend = "Legend1";
                series1.Name = "Series1";
                this.chart1.Legends.Add(legend1);
                this.chart1.Series.Add(series1);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
