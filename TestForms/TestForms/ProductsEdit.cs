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
    public partial class ProductsEdit : Form
    {
        private List<String> selectedRow = new List<String>();
        public ProductsEdit(List<String> sr)
        {
            InitializeComponent();
            selectedRow = sr;
            PutValueToForm();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PutValueToForm()
        {
            txtEditProductID.Text = selectedRow[0];
            txtEditProductName.Text = selectedRow[1];
            txtEditProductCategory.Text = selectedRow[3];
            txtEditProductUnitPrice.Value = Int32.Parse(selectedRow[6]);
            if (Int32.Parse(selectedRow[8]) == 1)
                sltEditPruductStatus.SelectedIndex = 0;
            else
                sltEditPruductStatus.SelectedIndex = 1;
        }
    }
}
