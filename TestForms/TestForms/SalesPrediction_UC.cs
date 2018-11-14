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
        private string prediction;
        

        public SalesPrediction_UC()
        {
            InitializeComponent();
            connString = new ConnectionString();
        }

        private string[] generateQuery()
        {
            string selectState, selectTop1, selectTop3;
            selectTop1 = @"SELECT TOP 1";
            selectTop3 = @"SELECT TOP 3";
            selectState = @" product_name AS 'Product Name', SUM(quantity_order) AS 'Quantity Order' FROM Product JOIN Sales_Record_Details ON Product.product_id = Sales_Record_Details.product_id JOIN Sales_Record ON Sales_Record.sales_record_id = Sales_Record_Details.sales_record_id WHERE Product.product_status = 1 AND Sales_Record.sales_status = 1";
            selectTop1 += selectState;
            selectTop3 += selectState;

            //CONDITION FOR CATEGORY
            if (cmbBoxCategory.SelectedIndex != 0)
            {
                string category = @" AND product_category = '" + cmbBoxCategory.SelectedItem + "'";
                selectTop1 += category;
                selectTop3 += category;
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
            string dateRangeMonth = " AND (Sales_Record.sales_record_date BETWEEN '" + dateFrom + "' AND '" + dateUntil + "')";
            string[] date = { selectTop3, selectTop3, selectTop3, selectTop3, selectTop1 };
            date[0] += dateRangeWeek1;
            date[1] += dateRangeWeek2;
            date[2] += dateRangeWeek3;
            date[3] += dateRangeWeek4;
            date[4] += dateRangeMonth;


            //GROUP BY PRODUCT NAME
            string groupBy = @" GROUP BY product_name";
            for(int i = 0; i <= 4; i++)
            {
                date[i] += groupBy;
            }
           

            //ORDER BY QUANTITY ORDER
            string orderBy = @" ORDER BY SUM(quantity_order) DESC";
            for (int i = 0; i <= 4; i++)
            {
                date[i] += orderBy;
            }

            return date;
        }

        private void InitDate(object sender, EventArgs e)
        {
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                Application.OpenForms[i].WindowState = FormWindowState.Maximized;
            }

            dateTimePicker_from.Value = DateTime.Today.AddMonths(-1);
            
            cmbBoxCategory.SelectedIndex = 0;

            generateGraph();
        }

        private void btnGenerateGraph_Click(object sender, EventArgs e)
        {
            generateGraph();
        }

        private void generateGraph()
        {
            //CLEAR SERIES IN CHART
            prediction_chart1.Series.Clear();
            prediction_chart2.Series.Clear();
            prediction_chart3.Series.Clear();
            prediction_chart4.Series.Clear();
            SqlCommand command;
            string[] date = generateQuery(); //generate select statement query
            using (SqlConnection conn = new SqlConnection(connString.getConnString()))
            {
                conn.Open();
                command = new SqlCommand(date[0], conn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
                        {
                            Name = reader["Product Name"].ToString(),
                            ChartType = SeriesChartType.Bar
                        };
                        if (prediction_chart1.Series.IsUniqueName(reader["Product Name"].ToString()))
                            this.prediction_chart1.Series.Add(series1);
                        this.prediction_chart1.Series[reader["Product Name"].ToString()].Points.AddXY("First Week", reader["Quantity Order"].ToString());
                    }
                }

                command = new SqlCommand(date[1], conn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
                        {
                            Name = reader["Product Name"].ToString(),
                            ChartType = SeriesChartType.Bar
                        };
                        if (prediction_chart2.Series.IsUniqueName(reader["Product Name"].ToString()))
                            this.prediction_chart2.Series.Add(series1);
                        this.prediction_chart2.Series[reader["Product Name"].ToString()].Points.AddXY("Second Week", reader["Quantity Order"].ToString());
                    }
                }

                command = new SqlCommand(date[2], conn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
                        {
                            Name = reader["Product Name"].ToString(),
                            ChartType = SeriesChartType.Bar
                        };
                        if (prediction_chart3.Series.IsUniqueName(reader["Product Name"].ToString()))
                            this.prediction_chart3.Series.Add(series1);
                        this.prediction_chart3.Series[reader["Product Name"].ToString()].Points.AddXY("Third Week", reader["Quantity Order"].ToString());
                    }
                }

                command = new SqlCommand(date[3], conn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
                        {
                            Name = reader["Product Name"].ToString(),
                            ChartType = SeriesChartType.Bar
                        };
                        if (prediction_chart4.Series.IsUniqueName(reader["Product Name"].ToString()))
                            this.prediction_chart4.Series.Add(series1);
                        this.prediction_chart4.Series[reader["Product Name"].ToString()].Points.AddXY("Fourth Week", reader["Quantity Order"].ToString());
                    }
                }

                command = new SqlCommand(date[4], conn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        prediction = reader["Product Name"].ToString();                      
                    }
                }

                conn.Close();
            }
        }

        private void dateTimePicker_from_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker_until.Value = dateTimePicker_from.Value.AddMonths(1);
        }

        private void dateTimePicker_until_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker_from.Value = dateTimePicker_until.Value.AddMonths(-1);
        }

        private void btnDisplayPrediction_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(prediction);
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
    }
}
