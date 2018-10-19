using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForms
{
    public partial class AddEditSalesRecord : Form
    {
        public AddEditSalesRecord()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBrowseProduct_Click(object sender, EventArgs e)
        {
            BrowseProductForm browseProduct = new BrowseProductForm();
            browseProduct.ShowDialog();
        }

        private void AddEditSalesRecord_Load(object sender, EventArgs e)
        {

        }
    }
}
