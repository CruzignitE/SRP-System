using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace TestForms
{
    class ConnectionString
    {
        private string path = Path.GetDirectoryName(Application.StartupPath);
        private static string databasePath;
        private readonly string conString;

        public ConnectionString()
        {
            databasePath = path.Substring(0, path.Length - 3);
            conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + databasePath + @"database\SRP_SYSTEM.mdf;Integrated Security=True;Connect Timeout=30";
        }

        public string getConnString()
        {
            return conString;
        }
    }
}
