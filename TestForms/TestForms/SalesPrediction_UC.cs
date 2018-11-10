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
    public partial class SalesPrediction_UC : UserControl
    {
        private ConnectionString connString;

        public SalesPrediction_UC()
        {
            InitializeComponent();
            connString = new ConnectionString();
        }

        private void InitDate(object sender, EventArgs e)
        {
            dateTimePicker_from.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dateTimePicker_until.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, 1);
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            PythonInstance py = new PythonInstance(@"
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
            //MessageBox.Show(msg, "Message");
        }

        private void btnMakeCSV_Click(object sender, EventArgs e)
        {
            string userName = Environment.UserName;
            string selectStateForCSV = @"SELECT product_name AS 'Product Name', SUM(quantity_order) AS 'Quantity Order' FROM Product JOIN Sales_Record_Details ON Product.product_id = Sales_Record_Details.product_id JOIN Sales_Record ON Sales_Record.sales_record_id = Sales_Record_Details.sales_record_id WHERE Product.product_status = 1 AND Sales_Record.sales_status = 1 GROUP BY product_name";

        SqlDataAdapter adapter = new SqlDataAdapter(selectStateForCSV, connString.getConnString());
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
