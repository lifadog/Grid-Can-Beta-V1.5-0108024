using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;


namespace test0515
{

    internal static class Program
    {
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string setpath = Properties.Settings.Default.UserSelectedPath;
            // 组合目标路径
            string targetPath = Path.Combine(appDataPath, "CanPro", "XmlFile");
            if (setpath != null)
            {
                Application.Run(new Main(setpath));
            }
            else
            {
                if (!Directory.Exists(targetPath))
                {
                    Directory.CreateDirectory(targetPath);
                }
                Application.Run(new Main(targetPath));
            }
            // Application.Run(new voodoochild());
        }
    }
}   
