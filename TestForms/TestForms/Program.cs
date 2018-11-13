using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Security.Cryptography;

namespace TestForms
{
    static class Program
    {
        private const DataProtectionScope scope = DataProtectionScope.CurrentUser;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            RegistryKey myKey;

            if (Environment.Is64BitOperatingSystem)
                myKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
            else
                myKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (myKey.OpenSubKey(@"SOFTWARE\SRPsystem") == null)
            {
                try
                {
                    RegistryKey srpKey = myKey.CreateSubKey(@"SOFTWARE\SRPsystem");

                    if (srpKey.GetValue("SRPvalue1") == null)
                    {
                        srpKey.SetValue("SRPvalue1", Encrypt("admin"), RegistryValueKind.String);
                    }
                    if (srpKey.GetValue("SRPvalue2") == null)
                    {
                        srpKey.SetValue("SRPvalue2", "admin", RegistryValueKind.String);
                    }
                }
                catch
                {
                    MessageBox.Show("Run program as administrator to generate manager password", "Administrator Permissions Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            Application.Run(new SRP_System());
        }

        public static string Encrypt(string text)
        {
            return Convert.ToBase64String(
                ProtectedData.Protect(Encoding.Unicode.GetBytes(text), null, DataProtectionScope.CurrentUser));
        }
    }
}
