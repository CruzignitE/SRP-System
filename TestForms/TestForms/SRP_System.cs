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
    public partial class SRP_System : Form
    {
        private List<Button> buttons_sidebar;
        private List<UserControl> tabs;

        public SRP_System()
        {
            InitializeComponent();

            buttons_sidebar = new List<Button>();
            buttons_sidebar.Add(button_side_salesRecords);
            buttons_sidebar.Add(button_side_products);
            buttons_sidebar.Add(button_side_inventory);
            buttons_sidebar.Add(button_side_salesPrediction);

            tabs = new List<UserControl>();
            tabs.Add(uc_salesRecords);
            tabs.Add(uc_products);
            tabs.Add(uc_inventory);
        }

        private void Btn_Sidebar_Click(object sender, EventArgs e)
        {
            foreach (UserControl uc in tabs)
                uc.Visible = false;

            foreach (Button b in buttons_sidebar)
            {

                if (sender == b)
                {
                    b.BackColor = Color.FromArgb(30, 35, 56);

                    if (b == button_side_salesRecords)
                        tabs[0].Visible = true;
                    else if (b == button_side_products)
                        tabs[1].Visible = true;
                    else if (b == button_side_inventory)
                        tabs[2].Visible = true;
                    else if (b == button_side_salesPrediction)
                        //not implemented yet
                        //tabs[3].Visible = true; 
                        break;
                        
                }
                else
                    b.BackColor = Color.Transparent;
            }
        }

        private void Btn_ManagerControl_Click(object sender, EventArgs e)
        {
            try
            {
                ManagerControl managerControl = new ManagerControl();
                managerControl.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please run program as administrator to access manager controls.", "Administrator Permissions Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
