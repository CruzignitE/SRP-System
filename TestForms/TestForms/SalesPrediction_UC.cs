using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForms
{
    public partial class SalesPrediction_UC : UserControl
    {
        public SalesPrediction_UC()
        {
            InitializeComponent();
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
    }
}
