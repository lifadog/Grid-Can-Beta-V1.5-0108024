using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace test0515
{
    public partial class Form1 : Form
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct MARGINS
        {
            public int Left;
            public int Right;
            public int Top;
            public int Bottom;
        }

        [DllImport("dwmapi.dll", PreserveSig = false)]
        static extern void DwmExtendFrameIntoClientArea(IntPtr hwnd, ref MARGINS margins);

        [DllImport("dwmapi.dll", PreserveSig = false)]
        static extern bool DwmIsCompositionEnabled(); //Dll 导入 DwmApi
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //如果启用Aero
            if (DwmIsCompositionEnabled())
            {
                MARGINS m = new MARGINS();
                m.Right = -1; //设为负数,则全窗体透明
                DwmExtendFrameIntoClientArea(this.Handle, ref m); //开启全窗体透明效果
            }
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            if (DwmIsCompositionEnabled())
            {
                e.Graphics.Clear(Color.Black); //将窗体用黑色填充（Dwm 会把黑色视为透明区域）
            }
        }
        //public class CCommond
        //{
        //    [XmlElement("MessageID")]
        //    public string MessageID { get; set; }

        //    [XmlElement("PortID")]
        //    public string PortID { get; set; }

        //    [XmlElement("Mode")]
        //    public string Mode { get; set; }

        //    // H1 组
        //    [XmlElement("h1size")]
        //    public string h1size { get; set; }

        //    [XmlElement("h1type")]
        //    public string h1type { get; set; }

        //    [XmlElement("h1lsb")]
        //    public string h1lsb { get; set; }

        //    [XmlElement("h1msb")]
        //    public string h1msb { get; set; }

        //    [XmlElement("h1v")]
        //    public string h1v { get; set; }

        //    // H2 组
        //    [XmlElement("h2size")]
        //    public string h2size { get; set; }

        //    [XmlElement("h2type")]
        //    public string h2type { get; set; }

        //    [XmlElement("h2lsb")]
        //    public string h2lsb { get; set; }

        //    [XmlElement("h2msb")]
        //    public string h2msb { get; set; }

        //    [XmlElement("h2v")]
        //    public string h2v { get; set; }

        //    // V1 组
        //    [XmlElement("v1size")]
        //    public string v1size { get; set; }

        //    [XmlElement("v1type")]
        //    public string v1type { get; set; }

        //    [XmlElement("v1lsb")]
        //    public string v1lsb { get; set; }

        //    [XmlElement("v1msb")]
        //    public string v1msb { get; set; }

        //    [XmlElement("v1v")]
        //    public string v1v { get; set; }

        //    // V2 组
        //    [XmlElement("v2size")]
        //    public string v2size { get; set; }

        //    [XmlElement("v2type")]
        //    public string v2type { get; set; }

        //    [XmlElement("v2lsb")]
        //    public string v2lsb { get; set; }

        //    [XmlElement("v2msb")]
        //    public string v2msb { get; set; }

        //    [XmlElement("v2v")]
        //    public string v2v { get; set; }

        //    // V3 组
        //    [XmlElement("v3size")]
        //    public string v3size { get; set; }

        //    [XmlElement("v3type")]
        //    public string v3type { get; set; }

        //    [XmlElement("v3lsb")]
        //    public string v3lsb { get; set; }

        //    [XmlElement("v3msb")]
        //    public string v3msb { get; set; }

        //    [XmlElement("v3v")]
        //    public string v3v { get; set; }
        //}
        //public static string ccomxmlfilename = "";
        //public void initccom()
        //{
        //    if (ccomxmlfilename == "")
        //    {
        //        return;
        //    }
        //    else
        //    {
        //        Load_ccom(ccomxmlfilename);
        //    }
        //}
        //public void openccom()
        //{
        //    if (ccomxmlfilename == "")
        //    {
        //        using (OpenFileDialog openFileDialog = new OpenFileDialog())
        //        {
        //            openFileDialog.Filter = "控制指令Xml檔案 (*.xml)|*.xml|所有檔案 (*.*)|*.*";
        //            openFileDialog.Title = "載入控制指令Xml檔案";

        //            openFileDialog.InitialDirectory = xmlFolderPath;

        //            if (openFileDialog.ShowDialog() == DialogResult.OK)
        //            {
        //                if (!File.Exists(openFileDialog.FileName))
        //                {
        //                    return;
        //                }
        //                ccomxmlfilename = openFileDialog.FileName;
        //                Properties.Settings.Default.UserCcom = openFileDialog.FileName;
        //                Load_ccom(openFileDialog.FileName);
        //            }
        //        }
        //    }
        //    else
        //    {
        //        Load_ccom(ccomxmlfilename);
        //    }
        //}
        //public void saveccom()
        //{
        //    if (ccomxmlfilename == "")
        //    {
        //        using (SaveFileDialog saveFileDialog = new SaveFileDialog())
        //        {
        //            string userpath = Properties.Settings.Default.UserSelectedPath;
        //            if (!string.IsNullOrEmpty(userpath))
        //            {
        //                saveFileDialog.InitialDirectory = userpath;
        //            }
        //            saveFileDialog.Filter = "控制指令Xml檔案 (*.xml)|*.xml|所有檔案 (*.*)|*.*";
        //            saveFileDialog.DefaultExt = "xml";
        //            saveFileDialog.AddExtension = true;
        //            saveFileDialog.Title = "儲存控制指令Xml檔案";

        //            if (saveFileDialog.ShowDialog() == DialogResult.OK)
        //            {
        //                Save_ccom(saveFileDialog.FileName);
        //                ccomxmlfilename = saveFileDialog.FileName;
        //            }
        //        }
        //    }
        //    else
        //    {
        //        Save_ccom(ccomxmlfilename);
        //    }
        //    Properties.Settings.Default.UserCcom = ccomxmlfilename;
        //    Properties.Settings.Default.Save();
        //}
        //public void Load_ccom(string n)
        //{
        //    string filename = n;
        //    if (!File.Exists(filename))
        //    {
        //        LogHelper.WriteLog("Error : Load Xml Container failed : Can't Find the Data");
        //        rtb_console.AppendText("錯誤 : 找不到該資料或名稱錯誤。" + DateTime.Now.ToString("HH:mm:ss") + Environment.NewLine);
        //        RichtextboxScroll();
        //        return;
        //    }
        //    XmlSerializer serializer = new(typeof(CCommond));
        //    using (StreamReader reader = new(filename))
        //    {
        //        xmlfilename = filename;

        //    }
        //}
        //public void Save_ccom(string Filename)
        //{
        //    CCommond ccom = new CCommond();

        //    string filename = Path.Combine(xmlFolderPath, Filename);
        //    XmlSerializer serializer = new(typeof(CCommond));
        //    using (StreamWriter writer = new(filename))
        //    {
        //        serializer.Serialize(writer, ccom);
        //    }

        //    LogHelper.WriteLog("Info : Save Xml Container succeeded");
        //    rtb_console.AppendText("資訊 : 資料已成功保存。" + DateTime.Now.ToString("HH:mm:ss") + Environment.NewLine);
        //    RichtextboxScroll();
        //}
    }
}
