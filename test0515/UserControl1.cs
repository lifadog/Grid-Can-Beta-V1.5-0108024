using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0515
{
    public partial class DigClock : UserControl
    {
        private PrivateFontCollection privateFonts = new PrivateFontCollection();
        DateTime nowtime;
        public DigClock()
        {
            InitializeComponent();
            LoadCustomFont();
            lbl_now.Text = "日期:00/00/00" + Environment.NewLine + "時間:00:00:00";
            NowTimer.Tick += NowTimer_Tick;
            
            //this.BackColor = Color.FromArgb(100, 196, 154, 138);
           // panel1.BackColor = Color.Beige;
            lbl_now.TextAlign = ContentAlignment.TopLeft;
            Start();
        }

        private void NowTimer_Tick(object sender, EventArgs e)
        {
            nowtime= DateTime.Now;
            lbl_now.Text ="日期:"+ nowtime.ToString("yy/MM/dd")+Environment.NewLine+ "時間:"+nowtime.ToString("HH:mm:ss");
        }

        private void Start()
        {
            NowTimer.Start();
        }
        private void LoadCustomFont()
        {
            // 从资源中获取字体数据
            byte[] fontData = Properties.Resources.CursedTimerUlil_Aznm;

            // 将字体数据载入到缓冲区
            IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
            Marshal.Copy(fontData, 0, fontPtr, fontData.Length);

            // 将字体添加到字体集合中
            privateFonts.AddMemoryFont(fontPtr, fontData.Length);

            // 注册字体资源
            IntPtr dummy = IntPtr.Zero;
            AddFontMemResourceEx(fontPtr, (uint)fontData.Length, IntPtr.Zero, ref dummy);

            // 释放字体数据的非托管副本
            Marshal.FreeCoTaskMem(fontPtr);

            // 设置控件的字体
            ApplyFontToLabel();
        }
        private void ApplyFontToLabel()
        {
            lbl_now.Font = new Font(/*privateFonts.Families[0]*/"Microsoft JhengHei UI", 10);
            lbl_now.Location = new Point(3, 3);
        }
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref IntPtr pcFonts);
    }
}
