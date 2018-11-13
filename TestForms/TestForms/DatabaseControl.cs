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
    public partial class DatabaseControl : Form
    {
        private ConnectionString connString;
        string database = "SRP_SYSTEM.mdf";

        public DatabaseControl()
        {
            InitializeComponent();
            connString = new ConnectionString();
        }

        private void Btn_Restore_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog f = new OpenFileDialog();
                f.InitialDirectory = "C:\\SRPsystem\\";
                f.Title = "Select backup file";
                f.Filter = @"SQL Backup files (*.BAK) |*.BAK|All files(*.*) |*.*";
                if (f.ShowDialog() == DialogResult.OK)
                {
                    SqlConnection sqlconn = new SqlConnection("");
                    SqlCommand sqlcmd = new SqlCommand("ALTER DATABASE " + AppDomain.CurrentDomain.BaseDirectory + "\\" + database + " SET SINGLE_USER with ROLLBACK IMMEDIATE " + "use master; " + "RESTORE DATABASE [SRP_SYSTEM] FROM  DISK = @n WITH REPLACE ", sqlconn);
                    sqlcmd.Parameters.AddWithValue("@n", f.FileName);
                    sqlconn.Open();
                    sqlcmd.ExecuteNonQuery();
                    sqlconn.Close();
                    MessageBox.Show("Restore successful.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Btn_Backup_Click(object sender, EventArgs e)
        {
            SqlCommand command;

            string backupFolder = "C:\\SRPbackup\\";

            try
            {
                using (SqlConnection conn = new SqlConnection(connString.getConnString()))
                {
                    // Creates backup query with filename containing date
                    string backupQuery = "BACKUP DATABASE \"" + AppDomain.CurrentDomain.BaseDirectory + database + "\" TO DISK = '" + backupFolder + database + "-" + DateTime.Now.ToString("yyyy-MM-dd.HH-mm-ss") + ".bak'";

                    try
                    {
                        conn.Open();
                        command = new SqlCommand(backupQuery, conn);
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
