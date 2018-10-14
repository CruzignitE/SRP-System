using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TestForms
{
    public partial class BrowseProductForm : Form
    {
        //DATABASE CONNECTION VARIABLES
        private string path = Path.GetDirectoryName(Application.StartupPath);
        private static string databasePath;
        String conString;
        SqlDataAdapter dataAdapter;
        DataTable table;

        public BrowseProductForm()
        {
            InitializeComponent();
            databasePath = path.Substring(0, path.Length - 3);
            conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + databasePath + @"database\SRP_SYSTEM.mdf;Integrated Security=True;Connect Timeout=30";
        }

        private void BrowseProductForm_Load(object sender, EventArgs e)
        {
            dataGVBrowseProduct.DataSource = bindingSource1;
            GetData("SELECT * FROM Product");
        }

        private void GetData(string cmd)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(cmd, conString);
                table = new DataTable();
                dataAdapter.Fill(table);

                bindingSource1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
