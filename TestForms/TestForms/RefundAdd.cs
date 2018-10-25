using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace TestForms
{
    public partial class RefundAdd : Form
    {
        RegistryKey myKey, srpKey;

        public RefundAdd()
        {
            InitializeComponent();

            // Get registry subkey for the software
            if (Environment.Is64BitOperatingSystem)
                myKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
            else
                myKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32);

            srpKey = myKey.OpenSubKey(@"SOFTWARE\SRPsystem");
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            // Validates manager password
            if (textBox_managerPass.Text == Decrypt((string)srpKey.GetValue("SRPvalue1")))
            {
                // Insert code

                this.Close();
            }
            else
                MessageBox.Show("Incorrect manager password.", "Wrong password", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static string Decrypt(string text)
        {
            return Encoding.Unicode.GetString(
                ProtectedData.Unprotect(Convert.FromBase64String(text), null, DataProtectionScope.CurrentUser));
        }
    }
}
