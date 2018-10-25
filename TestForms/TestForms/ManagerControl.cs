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
    public partial class ManagerControl : Form
    {
        private const DataProtectionScope scope = DataProtectionScope.CurrentUser;

        RegistryKey myKey, srpKey;

        public ManagerControl()
        {
            InitializeComponent();

            if (Environment.Is64BitOperatingSystem)
                myKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
            else
                myKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32);

            srpKey = myKey.OpenSubKey(@"SOFTWARE\SRPsystem", true);

            txtBox_hint.Text = (string)srpKey.GetValue("SRPvalue2");
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Confirm_Click(object sender, EventArgs e)
        {
            if (txtBox_currentPass.Text == txtBox_reenterPass.Text)
            {
                if (txtBox_currentPass.Text == (string)srpKey.GetValue("SRPvalue1"))
                {
                    // Writes new password and hint to registry
                    //srpKey.SetValue("SRPvalue1", Encrypt(txtBox_newPass.Text), RegistryValueKind.String);
                    srpKey.SetValue("SRPvalue1", txtBox_newPass.Text, RegistryValueKind.String);
                    srpKey.SetValue("SRPvalue2", txtBox_hint.Text, RegistryValueKind.String);

                    // Notifies user of successful password change
                    MessageBox.Show("Manager password changed.", "Password changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Current password " + txtBox_currentPass.Text + "does not match saved password " + (string)srpKey.GetValue("SRPvalue1"), "Wrong password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Current password does not match reentered password.", "Wrong password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string Encrypt(string str)
        {
            var data = Encoding.Unicode.GetBytes(str);

            // Encrypt data
            byte[] encrypted = ProtectedData.Protect(data, null, scope);

            return Convert.ToBase64String(encrypted);
        }

        private string Decrypt(string cipher)
        {
            // Parse base64 string
            byte[] data = Convert.FromBase64String(cipher);

            // Decrypt data
            byte[] decrypted = ProtectedData.Unprotect(data, null, scope);
            return Encoding.Unicode.GetString(decrypted);
        }
    }
}
