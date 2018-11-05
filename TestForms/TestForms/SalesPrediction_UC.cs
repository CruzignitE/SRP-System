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
    }
}
