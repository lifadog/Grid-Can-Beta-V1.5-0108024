using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Threading;
using System.Windows.Forms;

namespace test0515
{
    public partial class SetForm : Form
    {
        private Main main;
        private string[] lsbname;
        private ResourceManager resourceManager;
        private bool IsAdd
        {
            get { return _isadd; }
            set
            {
                _isadd = value;
                lsb_Xmlfilelist.Enabled = !(value);
            }
        }
        private bool _isadd = false;
        //..........move..........
        public bool beginMove = false;
        public int currentXPosition;
        public int currentYPosition;
        private bool test01 =false;

        public SetForm(Main main)
        {
            InitializeComponent();

            this.Opacity = 0;
            tbx_ID.Click += Tbx_ID_Click;
            lsb_Xmlfilelist.MouseDown += Lsb_Xmlfilelist_MouseDown;
            lbl_X.ForeColor = Color.FromArgb(100, 196, 154, 138);
            lsb_Xmlfilelist.SelectedIndexChanged += new EventHandler(this.lsb_Xmlfilelist_SelectedIndexChanged);
            this.main = main;
            // this.Icon = Properties.Resources.Logo1;
            main.Load_Xml_FileList(lsb_Xmlfilelist);
            main.SetDgv(dgv_Data);
            dgv_Data.Rows.Clear();
            dgv_Data.Columns.Clear();
            panel1.Paint += Bp_Paint;
            cbb_DataType.SelectedIndex = 1;
            cbb_end.SelectedIndex = 1;
            resourceManager = new ResourceManager("test0515.Resources.Strings", typeof(SetForm).Assembly);
            LoadLanguage(Thread.CurrentThread.CurrentUICulture.Name);
            Main.issetformshow = true;
            Main.LanguageChanged += Main_LanguageChanged;
            this.Paint += new PaintEventHandler(RoundedForm_Paint);
            tbx_portid.Text = "0";
            tbx_mode.Text = "0";
            tbx_dlc.Text = "8";
            rdb_hex.Select();
            tbx_ID.Visible = false;
            IsHex();
            main.DisplayValueHex(false);
            this.BackColor = ColorTranslator.FromHtml("#C49A8A");
            panel1.BackColor = Color.Beige;
            InitializeContextMenu();
            btn_new.Click += Btn_new_Click;
            main.SetButtonMouseEnterEvent(this.Controls);
            this.FormClosing += SetForm_FormClosing1;
            dgv_Data.DataBindingComplete += (s, e) =>
            {
                HideColumns(dgv_Data);
                dgv_Data.Columns["Value"].Width = 90;
            };
            //borderForm = new BorderForm();
            //borderForm.AttachToMainForm(this);
            //borderForm.Show();
            SetDataGridViewHeaderStyle();
            OpenTimer.Start();
        }
        private void SetDataGridViewHeaderStyle()
        {
            dgv_Data.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#C49A8A");
            dgv_Data.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black; // 设置标题文本颜色
          //  dgv_Data.GridColor= ColorTranslator.FromHtml("#C49A8A");
            dgv_Data.EnableHeadersVisualStyles = false; // 确保自定义样式生效
            dgv_Data.DefaultCellStyle.SelectionBackColor= ColorTranslator.FromHtml("#C49A8A");


        }
        private void SetForm_FormClosing1(object sender, FormClosingEventArgs e)
        {
            Main.issetformshow = false;
        }

        private void HideColumns(DataGridView dgv)
        {
            dgv.Columns["portid"].Visible = false;
            dgv.Columns["mode"].Visible = false;
        }
        private void Btn_new_Click(object sender, EventArgs e)
        {
            lsb_Xmlfilelist.SelectedIndex = -1;
            btn_new.Visible = false;
            lbl_xmlfilename.Visible = false;
            tbx_ID.Visible = true;
            tbx_ID.Clear();
            tbx_MessageID.Clear();
            tbx_portid.Clear();
            tbx_mode.Clear();
            tbx_extid.Clear();
            tbx_Data_lsb.Clear();
            tbx_Data_msb.Clear();
            tbx_Data_Name.Clear();
            tbx_Data_Size.Clear();
            tbx_dlc.Clear();
            main.datalist.Clear();
        }

        private void InitializeContextMenu()
        {
            ContextMenuStrip contextMenu = new ContextMenuStrip();
            ToolStripMenuItem copyItem = new ToolStripMenuItem("複製");
            ToolStripMenuItem Rename = new ToolStripMenuItem("重新命名");
            Rename.Click += Rename_Click;
            copyItem.Click += CopyItem_Click;
            contextMenu.Items.Add(Rename);
            contextMenu.Items.Add(copyItem);
            lsb_Xmlfilelist.ContextMenuStrip = contextMenu;
        }

        private void Rename_Click(object sender, EventArgs e)
        {
            main.lsbmousedown(sender, lsb_Xmlfilelist);
        }
        private void ExitTimer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity >= 0.098)
            {
                this.Opacity -= 0.196;
            }
            else
            {
                ExitTimer.Stop();
                this.Close();
            }
        }
        private void OpenTimer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 0.98)
            {
                this.Opacity += 0.196;
            }
            if (this.Opacity >= 0.98)
            {
                OpenTimer.Stop();
                OpenTimer.Enabled = false;
                this.Opacity = 0.98;
                return;
            }
            //  this.Opacity = 0.92;
        }
        private void CopyItem_Click(object sender, EventArgs e)
        {
            if (lsb_Xmlfilelist.SelectedItem != null)
            {
                string selectedFileName = lsb_Xmlfilelist.SelectedItem.ToString() + ".xml";
                string newFileName = Path.GetFileNameWithoutExtension(selectedFileName) + " - Copy.xml";
                string sourcePath = Path.Combine(main.xmlFolderPath, selectedFileName);
                string destinationPath = Path.Combine(main.xmlFolderPath, newFileName);
                try
                {
                    File.Copy(sourcePath, destinationPath);
                    main.Load_Xml_FileList(lsb_Xmlfilelist); // 重新加载列表
                    main.loadlist();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error copying file: {ex.Message}");
                }
            }
        }
        private static GraphicsPath CreateRoundRectPath(Rectangle rect, int cornerRadius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = cornerRadius * 2;

            // Top left arc
            path.AddArc(rect.Left, rect.Top, diameter, diameter, 180, 90);
            // Top right arc
            path.AddArc(rect.Right - diameter, rect.Top, diameter, diameter, 270, 90);
            // Bottom right arc
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            // Bottom left arc
            path.AddArc(rect.Left, rect.Bottom - diameter, diameter, diameter, 90, 90);

            path.CloseFigure();
            return path;
        }
        private void RoundedForm_Paint(object sender, PaintEventArgs e)
        {
            // 设置窗体的圆角半径
            int cornerRadius = 7;

            // 创建圆角矩形路径
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            using (GraphicsPath path = CreateRoundRectPath(rect, cornerRadius))
            {
                this.Region = new Region(path);
            }
            LogHelper.WriteLog("InitUI Finished");
        }
        private static GraphicsPath CbPath(Rectangle rect, int cornerRadius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = cornerRadius * 2;

            // Top left line
            path.AddLine(rect.Left, rect.Top, rect.Right, rect.Top);

            // Top right line
            path.AddLine(rect.Right, rect.Top, rect.Right, rect.Bottom - cornerRadius);

            // Bottom right arc
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);

            // Bottom line
            path.AddLine(rect.Right - cornerRadius, rect.Bottom, rect.Left + cornerRadius, rect.Bottom);

            // Bottom left arc
            path.AddArc(rect.Left, rect.Bottom - diameter, diameter, diameter, 90, 90);

            // Top left line
            path.AddLine(rect.Left, rect.Bottom - cornerRadius, rect.Left, rect.Top);

            path.CloseFigure();
            return path;
        }
        private void Bp_Paint(object sender, PaintEventArgs e)
        {
            Panel p = sender as Panel;
            // 设置窗体的圆角半径
            int cornerRadius = 7;

            // 创建圆角矩形路径
            Rectangle rect = new Rectangle(0, 0, p.Width, p.Height);
            using (GraphicsPath path = CbPath(rect, cornerRadius))
            {
                p.Region = new Region(path);
            }
            LogHelper.WriteLog("InitUI Finished");
        }
        private void Main_LanguageChanged()
        {
            LoadLanguage(Thread.CurrentThread.CurrentUICulture.Name);
        }
        public void LoadLanguage(string culture)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            groupBox3.Text = resourceManager.GetString("gbxxmlfile");
            btn_create.Text = resourceManager.GetString("btncreate");
            btn_Add.Text = resourceManager.GetString("btnadd");
            btn_delete_data.Text = resourceManager.GetString("btndelete");
            btn_Write.Text = resourceManager.GetString("btnvalue");
            groupBox2.Text = resourceManager.GetString("gbxid");
            groupBox1.Text = resourceManager.GetString("gbxdata");
            label1.Text = resourceManager.GetString("dName");
            label2.Text = resourceManager.GetString("dType");
            label3.Text = resourceManager.GetString("dSize");
            label4.Text = resourceManager.GetString("dlsb");
            label5.Text = resourceManager.GetString("dMsb");
            this.Text = resourceManager.GetString("xmltitle");
            lbl_Title.Text = resourceManager.GetString("xmltitle");
            rtb_file.Text = resourceManager.GetString("rtbxml");
            rtb_descripe.Text = resourceManager.GetString("rtbid");
            rtb_data.Text = resourceManager.GetString("rtbdata");
            rtb_write.Text = resourceManager.GetString("rtbvalue");
            btn_ReadCan.Text = resourceManager.GetString("rcan");
            btn_WriteCan.Text = resourceManager.GetString("wcan");
            gbx_com.Text = resourceManager.GetString("gcom");
            btn_exit.Text = resourceManager.GetString("Exit");
            lbl_xml.Text = resourceManager.GetString("lblxml");
            btn_new.Text = resourceManager.GetString("btnnew");
            btn_reset.Text = resourceManager.GetString("btnres");
            rdb_dec.Text = resourceManager.GetString("dec");
            rdb_hex.Text = resourceManager.GetString("hex");
        }
        private void Set_Items(ListBox lsb)
        {
            lsbname = new string[lsb_Xmlfilelist.Items.Count];
            for (int i = 0; i < lsb.Items.Count; i++)
            {
                lsbname[i] = lsb.Items[i].ToString();
            }
            for (int i = 0; i < lsb.Items.Count; i++)
            {
                if (lsbname[i] == tbx_ID.Text)
                {
                    lsb_Xmlfilelist.SelectedIndex = i;
                }
            }
        }
        private void lsb_Xmlfilelist_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbx_ID.Visible = false;
            lbl_xmlfilename.Visible = true;
            btn_new.Visible = true;
            main.lsbxmlfileselectindexchanged(sender, e, tbx_ID, dgv_Data, tbx_MessageID, tbx_portid, tbx_mode, lbl_xmlfilename, lsb_Xmlfilelist);
        }
        private void Lsb_Xmlfilelist_MouseDown(object sender, MouseEventArgs e)
        {
            // main.lsbmousedown(sender, e, lsb_Xmlfilelist);
        }
        private void Tbx_ID_Click(object sender, EventArgs e)
        {
            lsb_Xmlfilelist.SelectedIndex = -1;
        }
        //...........................................................
        public void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                beginMove = true;
                currentXPosition = MousePosition.X; //滑鼠的 X 座標為當前窗體左上角 X 座標參考
                currentYPosition = MousePosition.Y; //滑鼠的 Y 座標為當前窗體左上角 Y 座標參考
            }
        }
        public void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (beginMove)
            {
                this.Left += MousePosition.X - currentXPosition; //根據滑鼠的 X 座標確定窗體的 X 座標
                this.Top += MousePosition.Y - currentYPosition; //根據滑鼠的 Y 座標確定窗體的 Y 座標
                currentXPosition = MousePosition.X;
                currentYPosition = MousePosition.Y;
            }
        }
        public void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                currentXPosition = 0; //設定初始狀態
                currentYPosition = 0; //設定初始狀態
                beginMove = false;
            }
        }
        public void lbl_X_Click(object sender, EventArgs e)
        {
            ExitTimer.Start();
        }
        public void lbl_X_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_X.ForeColor = Color.White;
            lbl_X.Font = new("Corbel", 19, FontStyle.Bold);
            lbl_X.Location = new Point(814, 0);
        }
        public void lbl_X_MouseLeave(object sender, EventArgs e)
        {
            lbl_X.Font = new("Corbel", 17, FontStyle.Regular);
            lbl_X.ForeColor = Color.FromArgb(100, 196, 154, 138);
            lbl_X.Location = new Point(817, 2);
        }
        public void Main_Deactivate(object sender, EventArgs e)
        {
            //Panel_Title.BackColor = Color.LightSteelBlue;
            Panel_Title.BackgroundImage = Properties.Resources.title_2;
        }
        public void Main_Activated(object sender, EventArgs e)
        {
            //Panel_Title.BackColor = Color.DodgerBlue;
            Panel_Title.BackgroundImage = Properties.Resources.title_1;
        }
        //............................................................
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (tbx_ID != null && tbx_MessageID.Text != "")
            {
                main.datalist.Clear();
                main.Create_XmlFile(tbx_ID, tbx_MessageID, lsb_Xmlfilelist, tbx_portid, tbx_mode, lbl_xml, lbl_extid, lbl_port, lbl_mode);
                if (tbx_ID.Text != "")
                {
                    main.Set_Xml_Descripe(tbx_ID, tbx_MessageID, lsb_Xmlfilelist, tbx_portid, tbx_mode, lbl_xml, lbl_extid, lbl_port, lbl_mode);
                }
                lbl_xmlfilename.Visible = true;
                tbx_ID.Visible = false;
            }
        }
        private void IsHex()
        {
            if (rdb_hex.Checked) { main.ishex = true; }
            if (rdb_dec.Checked) { main.ishex = false; }
        }
        private void btn_Write_Click(object sender, EventArgs e)
        {
            main.Write_Xml(tbx_ID, dgv_Data, tbx_MessageID, tbx_portid, tbx_mode, lbl_xml, lbl_extid, lbl_port, lbl_mode, lsb_Xmlfilelist);
            Set_Items(lsb_Xmlfilelist);
            IsAdd = false;
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            main.Add_Data_Format(lsb_Xmlfilelist, tbx_Data_Name, cbb_DataType, tbx_Data_Size, tbx_Data_lsb, tbx_Data_msb,cbb_end);
            Set_Items(lsb_Xmlfilelist);
            IsAdd = true;
        }
        private void btn_delete_data_Click(object sender, EventArgs e)
        {
            main.Remove_Data_From_XmlFile(lsb_Xmlfilelist, dgv_Data);
        }
        private void SetForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.LanguageChanged -= Main_LanguageChanged;
            Main.issetformshow = false;
        }
        private void btn_WriteCan_Click(object sender, EventArgs e)
        {
            IsHex();
            main.Write_Xml(tbx_ID, dgv_Data, tbx_MessageID, tbx_portid, tbx_mode, lbl_xml, lbl_extid, lbl_port, lbl_mode, lsb_Xmlfilelist);
            Set_Items(lsb_Xmlfilelist);
            IsAdd = false;
            main.test4(tbx_portid.Text, tbx_mode.Text, tbx_dlc.Text, tbx_MessageID.Text, (main.test2(lsb_Xmlfilelist.SelectedItem.ToString()+".xml")));
        }
        private void btn_ReadCan_Click(object sender, EventArgs e)
        {
            IsHex();
            main.Write_Xml(tbx_ID, dgv_Data, tbx_MessageID, tbx_portid, tbx_mode, lbl_xml, lbl_extid, lbl_port, lbl_mode, lsb_Xmlfilelist);
            Set_Items(lsb_Xmlfilelist);
            tbx_dlc.Text = "4";
            IsAdd = false;
            main.test3(tbx_portid.Text, tbx_mode.Text, "4", tbx_MessageID.Text, (main.test2(lsb_Xmlfilelist.SelectedItem.ToString() + ".xml")));
        }
        private void btn_reset_Click(object sender, EventArgs e)
        {
            if (lsb_Xmlfilelist.SelectedItem != null)
            {

                main.Write_Xml(tbx_ID, dgv_Data, tbx_MessageID, tbx_portid, tbx_mode, lbl_xml, lbl_extid, lbl_port, lbl_mode, lsb_Xmlfilelist);
                Set_Items(lsb_Xmlfilelist);
                IsAdd = false;
            }
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            ExitTimer.Start();
        }
        private void rdb_hex_CheckedChanged(object sender, EventArgs e)
        {
            IsHex();
            main.DisplayValueHex(test01);
            test01 = true;
        }
    }
}
