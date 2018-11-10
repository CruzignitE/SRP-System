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
    public partial class SalesRecordsGraph : Form
    {
        //DATABASE CONNECTION VARIABLES
        private ConnectionString connString;
        private SqlDataAdapter dataAdapter;
        private DataTable table;

        List<String> categories = new List<String>();
        
        // TODO: Pass starting and ending dates in constructor for chart generation
        private string selectQuery_part1 = @"SELECT sr.sales_record_date AS 'Sales Date', SUM(p.product_price * srd.quantity_order) AS 'Sales Total Price' FROM Sales_Record AS sr JOIN Sales_Record_Details as srd ON sr.sales_record_id = srd.sales_record_id JOIN Product as p ON srd.product_id = p.product_id WHERE product_category = '";
        private string selectQuery_part2 = @"' GROUP BY sr.sales_record_date";

        public SalesRecordsGraph()
        {
            InitializeComponent();
            connString = new ConnectionString();

            chart1.DataSource = bindingSource1;

            // Declaration of categories
            categories.Add("Pain Medication");
            categories.Add("Fitness");
            categories.Add("First Aid");
            categories.Add("Vitamins & Supplements");

            // Generating the graph areas based on the categories - just add any more categories above
            foreach (String s in categories) {
                try
                {
                    dataAdapter = new SqlDataAdapter(selectQuery_part1 + s + selectQuery_part2, connString.getConnString());
                    table = new DataTable();
                    dataAdapter.Fill(table);
                    
                    bindingSource1.DataSource = table;

                    chart1.Series.Add(s);
                    chart1.Series[s].ChartArea = "ChartArea1";
                    chart1.Series[s].Name = s;
                    chart1.Series[s].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea;
                    chart1.Series[s].Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
                    chart1.Series[s].XValueMember = "Sales Date";
                    chart1.Series[s].YValueMembers = "Sales Total Price";
                    chart1.Series[s].YValuesPerPoint = 6;

                    chart1.Legends.Add(s);
                    chart1.Legends[s].Name = s;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


    }
}
