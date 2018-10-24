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
                RegistryKey srpKey = myKey.CreateSubKey(@"SOFTWARE\SRPsystem");
                
                //var data = Encoding.Unicode.GetBytes("admin");

                // Encrypt data
                //byte[] encrypted = ProtectedData.Protect(data, null, scope);

                if (srpKey.GetValue("SRPvalue1") == null)
                {
                    srpKey.SetValue("SRPvalue1", "admin", RegistryValueKind.String);
                    srpKey.SetValue("SRPvalue2", "admin", RegistryValueKind.String);
                }
            }

            Application.Run(new SalesRecords());
        }
    }
}
