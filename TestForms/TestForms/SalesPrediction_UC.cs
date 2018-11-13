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
using System.Windows.Forms.DataVisualization.Charting;

namespace TestForms
{
    public partial class SalesPrediction_UC : UserControl
    {
        private ConnectionString connString;
        private string selectStateForCSV;

        public SalesPrediction_UC()
        {
            InitializeComponent();
            connString = new ConnectionString();
        }

        private string[] generateQuery()
        {
            selectStateForCSV = @"SELECT TOP 3 product_name AS 'Product Name', SUM(quantity_order) AS 'Quantity Order' FROM Product JOIN Sales_Record_Details ON Product.product_id = Sales_Record_Details.product_id JOIN Sales_Record ON Sales_Record.sales_record_id = Sales_Record_Details.sales_record_id WHERE Product.product_status = 1 AND Sales_Record.sales_status = 1";

            //CONDITION FOR CATEGORY
            if (cmbBoxCategory.SelectedIndex != 0)
            {
                string category = @" AND product_category = '" + cmbBoxCategory.SelectedItem + "'";
                selectStateForCSV += category;
            }

            //CONDITION FOR DATE RANGE
            string dateFrom = dateTimePicker_from.Value.ToString("yyyy-MM-dd");
            string dateMiddle1 = dateTimePicker_from.Value.AddDays(7).ToString("yyyy-MM-dd");
            string dateMiddle2 = dateTimePicker_from.Value.AddDays(14).ToString("yyyy-MM-dd");
            string dateMiddle3 = dateTimePicker_from.Value.AddDays(21).ToString("yyyy-MM-dd");
            string dateUntil = dateTimePicker_until.Value.ToString("yyyy-MM-dd");
            string dateRangeWeek1 = " AND (Sales_Record.sales_record_date BETWEEN '" + dateFrom + "' AND '" + dateMiddle1 + "')";
            string dateRangeWeek2 = " AND (Sales_Record.sales_record_date BETWEEN '" + dateMiddle1 + "' AND '" + dateMiddle2 + "')";
            string dateRangeWeek3 = " AND (Sales_Record.sales_record_date BETWEEN '" + dateMiddle2 + "' AND '" + dateMiddle3 + "')";
            string dateRangeWeek4 = " AND (Sales_Record.sales_record_date BETWEEN '" + dateMiddle3 + "' AND '" + dateUntil + "')";
            string[] weeks = { selectStateForCSV += dateRangeWeek1, selectStateForCSV += dateRangeWeek2, selectStateForCSV += dateRangeWeek3, selectStateForCSV += dateRangeWeek4}; 

            //GROUP BY PRODUCT NAME
            string groupBy = @" GROUP BY product_name";
            for(int i = 0; i <= 3; i++)
            {
                weeks[i] += groupBy;
            }
           

            //ORDER BY QUANTITY ORDER
            string orderBy = @" ORDER BY SUM(quantity_order) DESC";
            for (int i = 0; i <= 3; i++)
            {
                weeks[i] += orderBy;
            }

            return weeks;
        }

        private void InitDate(object sender, EventArgs e)
        {
            //dateTimePicker_from.Value = DateTime.Today.AddMonths(-1);
            dateTimePicker_from.Value = new Date(2018, 11, 5);
            dateTimePicker_until.Value = new Date(2018, 12, 5);
            
            cmbBoxCategory.SelectedIndex = 0;

            prediction_chart.Series.Clear();
            SqlCommand command;
            string[] weeks =  generateQuery(); //generate select statement query
            MessageBox.Show(weeks[0]);
            using (SqlConnection conn = new SqlConnection(connString.getConnString()))
            {
                conn.Open();
                command = new SqlCommand(weeks[0], conn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
                        {
                            Name = reader["Product Name"].ToString(),
                            IsVisibleInLegend = false,
                            IsXValueIndexed = true,
                            ChartType = SeriesChartType.Bar
                        };
                        if (prediction_chart.Series.IsUniqueName(reader["Product Name"].ToString()))
                            this.prediction_chart.Series.Add(series1);
                        this.prediction_chart.Series[reader["Product Name"].ToString()].Points.AddXY("Week 1", reader["Quantity Order"].ToString());
                     
                    }
                }

                command = new SqlCommand(weeks[1], conn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
                        {
                            Name = reader["Product Name"].ToString(),
                            IsVisibleInLegend = false,
                            IsXValueIndexed = true,
                            ChartType = SeriesChartType.Bar
                        };
                        if (prediction_chart.Series.IsUniqueName(reader["Product Name"].ToString()))
                            this.prediction_chart.Series.Add(series1);
                        this.prediction_chart.Series[reader["Product Name"].ToString()].Points.AddXY("Week 2", reader["Quantity Order"].ToString());

                    }
                }

                command = new SqlCommand(weeks[2], conn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
                        {
                            Name = reader["Product Name"].ToString(),
                            IsVisibleInLegend = false,
                            IsXValueIndexed = true,
                            ChartType = SeriesChartType.Bar
                        };
                        if (prediction_chart.Series.IsUniqueName(reader["Product Name"].ToString()))
                            this.prediction_chart.Series.Add(series1);
                        this.prediction_chart.Series[reader["Product Name"].ToString()].Points.AddXY("Week 3", reader["Quantity Order"].ToString()); 

                    }
                }

                command = new SqlCommand(weeks[3], conn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
                        {
                            Name = reader["Product Name"].ToString(),
                            IsVisibleInLegend = false,
                            IsXValueIndexed = true,
                            ChartType = SeriesChartType.Bar
                        };
                        if (prediction_chart.Series.IsUniqueName(reader["Product Name"].ToString()))
                            this.prediction_chart.Series.Add(series1);
                        this.prediction_chart.Series[reader["Product Name"].ToString()].Points.AddXY("Week 4", reader["Quantity Order"].ToString());

                    }
                }
                conn.Close();
            }

        }

        private void chart1_Click(object sender, EventArgs e)
        {
            /*PythonInstance py = new PythonInstance(@"
import pandas as pd
import matplotlib.pyplot as plt
import csv

class PyClass:
    def __init__(self):
        pass

    def somemethod(self):
        print 'in some method'

    def isodd(self, n):
        return 1 == n % 2

    def generateGraph(self):
        df = pd.read_csv('csvData.csv')
        fig, ax = plt.subplots()
        myScatterPlot = ax.scatter(
            df['Quantity Order'],	#X values
	        df['Product Name']	#Y values
        )
        ax.set_xlabel ('Products Sold')
        ax.set_ylabel('Date of Sale')
        ax.set_title('Sales Trend')
        
        # Get current size
        fig_size = plt.rcParams['figure.figsize']

        # Set figure width to 12 and height to 9
        fig_size[0] = 12
        fig_size[1] = 24
        plt.rcParams['figure.figsize'] = fig_size

        plt.savefig('C:/Users/Cruz Lee/.spyder-py3/csvTest.png',bbox_inches='tight',dpi=200)
");
            //URGENT DONT RUN THESE CODE
            //py.CallMethod("somemethod");
            //string msg = py.CallFunction("isodd", 6).ToString();
            //Console.WriteLine(msg);
            //MessageBox.Show(msg, "Message");*/
        }

        private void btnMakeCSV_Click(object sender, EventArgs e)
        {
            string userName = Environment.UserName;

            string[] weeks = generateQuery();
            //EXPORT CSV FILE BASED ON THE QUERY           
            SqlDataAdapter adapter = new SqlDataAdapter(weeks[1], connString.getConnString());
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            try
            {
                StreamWriter streamWriter = new StreamWriter(@"C:\Users\" + userName + @"\Documents\predictionData.csv", false);

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
                Process.Start(@"C:\Users\" + userName + @"\Documents\predictionData.csv");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
