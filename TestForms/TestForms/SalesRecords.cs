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
    public partial class SalesRecords : Form
    {
        public SalesRecords()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dropDownName n1 = new dropDownName("Sale ID");
            comboBox1.Items.Add(n1);
            dropDownName n2 = new dropDownName("Item ID");
            comboBox1.Items.Add(n2);
            dropDownName n3 = new dropDownName("Item");
            comboBox1.Items.Add(n3);
            dropDownName n4 = new dropDownName("Category");
            comboBox1.Items.Add(n4);
            dropDownName n5 = new dropDownName("Price");
            comboBox1.Items.Add(n5);
        }

            public class dropDownName
            {

                private string dataName;

                public dropDownName(string dataName)
                {
                    DataName = dataName;
                }

                public string DataName
                {
                    get { return dataName; }
                    set { dataName = value; }
                }

                public override string ToString()
                {
                    return dataName;
                }

            }

        private void addButton_Click(object sender, EventArgs e)
        {

        }

        private void editButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridTableStyle ts1 = new DataGridTableStyle();
            ts1.MappingName = "Customers";

            DataGridBoolColumn myDataCol = new DataGridBoolColumn();
            myDataCol.HeaderText = "My New Column";
            myDataCol.MappingName = "Current";

            ts1.GridColumnStyles.Add(myDataCol);

            dataGridView1.TableStyles.Add(ts1);
        }
    }
}

