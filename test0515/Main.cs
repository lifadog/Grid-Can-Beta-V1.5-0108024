using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Drawing;
using System.Linq;
using CANPro.SDK;
using System.IO.Ports;
using System.Threading.Tasks;
using System.Timers;
using System.Resources;
using System.Globalization;
using System.Threading;
using System.Drawing.Drawing2D;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.Xml;
using System.Windows.Forms.VisualStyles;
using System.Collections;
using System.Security.Cryptography;
using Microsoft.Win32;
using System.Reflection;
using static System.Collections.Specialized.BitVector32;

namespace test0515
{

    public partial class Main : Form
    {
        public BindingList<DataItem> datalist;
        public BindingSource bindingSource;
        public string xmlFolderPath;
        private ResourceManager resourceManager;
        private System.Timers.Timer _refreshTimer;
        public static event Action LanguageChanged;
        private DateTime LastMessageReceivedTime;
        private Label lbl_dev;
        private PictureBox ptb_hy;
        private Label r;
        public Point orgpnlctrlLocation;
        public Size orgpnlctrlsize;
        public float scaleFactor = 1.0f;
        //...........................................................
        public bool Isfly
        {
            get { return isfly; }
            set
            {
                isfly = value;
                btn_drop.Visible = value;
                btn_fly.Visible = !value;
                lbl_dev.Visible = value;
                ptb_hy.Visible = value;
                r.Visible = value;
            }
        }
        public bool isselect = false;
        public bool isctrl = false;
        public bool isnew = false;
        public bool isdelete = false;
        public bool isfly;
        public bool _isopencan;
        bool isselectitem = false;
        public bool IsOpenCan
        {
            get { return _isopencan; }
            set
            {
                _isopencan = value;
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(LAN);
                ptb_com.Image = _isopencan ? Properties.Resources.gg : Properties.Resources.rR;
                btn_canopen.Text = _isopencan ? resourceManager.GetString("CloseCan") : resourceManager.GetString("OpenCan");
                lbl_comsta.Text = _isopencan ? resourceManager.GetString("copen") : resourceManager.GetString("cclose");
            }
        }
        public bool _isvalue = true;
        public bool isupdatevalue = false;
        public bool _isloadconfig = false;
        private bool _ismax = false;
        public bool Isloadconfig
        {
            get { return _isloadconfig; }
            set
            {
                _isloadconfig = value;
                if (value == true)
                {
                }
            }
        }
        public bool IsValue
        {
            get { return _isvalue; }
            set
            {
                _isvalue = value;
            }
        }
        public bool _listselect = false;
        public bool ListSelect
        {
            get { return _listselect; }
            set
            {
                _listselect = value;
            }
        }
        public bool _isShowID;

        public bool IsShowID
        {
            get { return _isShowID; }
            set
            {
                _isShowID = value;
                if (value == true)
                {
                    if (IsMax == true)
                    {
                        pnl_ctrl.Size = new Size(pnl_ctrl.Width - 198, 833);
                        pnl_ctrl.Location = new Point(198, 0);
                        //     panel3.Size = new Size(this.Width - 2, this.Height - 1);
                    }
                    else
                    {
                        pnl_lsb.Location = originalPnlLsbLocation;
                        pnl_ctrl.Location = new Point(189, 0);
                        pnl_ctrl.Size = new Size(1165, 594);
                        //                   panel3.Size = new Size(1378, 740);

                    }
                    pnl_control.Controls.Add(pnl_lsb);
                    Adjust_ByteCtrl_GroupBoxPositions();
                    pnl_lsb.BorderStyle = BorderStyle.None;
                    btn_clear_pnl.Location = new Point(20, pnl_ctrl.Height - 50);
                    pnl_lsb.Visible = value;
                }
                if (value == false)
                {

                    if (IsMax == true)
                    {
                        pnl_ctrl.Location = originalPnlLsbLocation;
                        pnl_ctrl.Size = new Size(1893, 833);
                        //        panel3.Size = new Size(this.Width - 2, this.Height - 1);
                    }
                    else
                    {
                        pnl_ctrl.Location = originalPnlLsbLocation;
                        pnl_ctrl.Size = new Size(1354, 594);
                        //             panel3.Size = new Size(1378, 740);
                    }
                    Adjust_ByteCtrl_GroupBoxPositions();
                    btn_clear_pnl.Location = new Point(20, pnl_ctrl.Height - 50);
                    pnl_lsb.Visible = value;
                }
            }
        }
        private bool iseng;
        private bool IsEng
        {

            get { return iseng; }
            set
            {
                iseng = value;
                if (iseng == true) { cbb_lan.SelectedIndex = 0; }
                if (iseng != true) { cbb_lan.SelectedIndex = 1; }
            }

        }
        public static bool issetformshow = false;
        public bool iscom;
        private bool IsCom
        {
            get { return iscom; }
            set
            {
                iscom = value;
                if (iscom == false)
                {
                    ConnTimer.Stop();
                    ptb_conn.Image = Properties.Resources.stop;
                }
                if (iscom == true)
                {
                    ConnTimer.Start();
                }
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(LAN);
                lbl_state.Text = iscom ? resourceManager.GetString("coming") : resourceManager.GetString("stopcom");
            }
        }
        public bool IsMax
        {
            get { return _ismax; }
            set
            {
                _ismax = value;

                if (_ismax == true)
                {
                    ptb_size.Image = Properties.Resources.normal_m;

                    this.Refresh();
                    // this.WindowState = FormWindowState.Maximized;
                    test07();
                    setsize(pnl_under, pnl_control, pnl_ctrl);


                    this.Refresh();
                }
                if (_ismax == false)
                {
                    ptb_size.Image = Properties.Resources.max_m;

                    this.Refresh();
                    // this.WindowState = FormWindowState.Normal;
                    this.Size = new Size(1380, 770);
                    this.CenterToScreen();
                    setsize(pnl_under, pnl_control, pnl_ctrl);
                    panel3.Size = new Size(1378, 740);
                    this.Refresh();
                }
                Adjust_ByteCtrl_GroupBoxPositions();
                IsShowID = IsShowID;
                Isfly = Isfly;
            }
        }
        private bool isfirstopen = true;
        public bool ishex;
        private bool issu = false;
        private bool isautosave = false;
        private bool OpenConfig = false;
        private bool _isAskCan;
        //..........move..........
        public bool beginMove = false;
        public int currentXPosition;
        public int currentYPosition;
        //........................
        public Dictionary<string, bool> itemCreatedStatus = new Dictionary<string, bool>();
        public Point originalPnlLsbLocation; // 用于保存原始的 pnl_lsb 位置
        public Form floatingForm; // 新的窗口用于承载 pnl_lsb
        public string orgrtbstring;
        //........................
        Dictionary<string, bool> isselectdic = new Dictionary<string, bool>();
        public delegate void UpdateInfo(object sender, int infoId);
        public ushort uv, ov;
        public short ut, ot;
        //.......................
        private CanProDriver _canpro;
        public CanbusPacket _ctrl_packet;
        public CanbusPacket bal_packet;
        public CanbusPacket sim_packet;
        public CanbusPacket pmu_ctrl;
        public CanbusPacket cmu_ctrl;
        SerialPort _autoid_port = null;
        public CanBusDriver _canbus;

        CanPacket canp = new();
        public event EventHandler DataUpdated;
        private System.Timers.Timer _updateTimer;

        public event EventHandler<XmlDataChangedEventArgs> XmlDataChanged;
        private MenuStrip menuStrip;
        Location loc;

        private int initialWidth;
        List<int> initialPositions = new();

        ImageList imglst;
        int imagecount = 0;
        InputLanguage inputlan;
        //..............................Update.....................................
        private bool isupdate = Properties.Settings.Default.UpdateInformation;
        //................................Main.....................................
        public Main(string n = "")
        {
            InitializeComponent();
            xmlFolderPath = n;
            initclear();
            ptb_hy = new();
            r = new();
            lbl_dev = new();
            IsShowID = false;
            loc = new();
            loc.Pcontrol_Lo = pnl_control.Location;
            loc.Pctrl_Lo = pnl_ctrl.Location;
            loc.Punder_Lo = pnl_under.Location;
            loc.Pcontrol_Si = pnl_control.Size;
            loc.Pctrl_Si = pnl_ctrl.Size;
            loc.Punder_Si = pnl_under.Size;
            IsMax = false;
        }
        public void Main_Load(object sender, EventArgs e)
        {
            LogHelper.Initialize(xmlFolderPath);
            LogHelper.WriteLog("Application Start");
            datalist = new BindingList<DataItem>();
            bindingSource = new BindingSource();
            LogHelper.WriteLog("InitDatalist");
            //   initnotifyicon();
            lbl_X.ForeColor = Color.FromArgb(100, 196, 154, 138);
            this.BackColor = ColorTranslator.FromHtml("#C49A8A");
            panel3.BackColor = Color.Beige;
            bindingSource.DataSource = datalist;
            //........................................

            Init_Ptb_Size(ptb_size);
            initlblmini(lbl_mini);
            resourceManager = new ResourceManager("test0515.Resources.Strings", typeof(SetForm).Assembly);
            string userLanguage = Properties.Settings.Default.UserLan;
            LoadLanguage(userLanguage);
            IsEng = userLanguage == "en";
            this.FormClosed += Main_FormClosed;
            _updateTimer = new System.Timers.Timer(50); // 每10秒更新一次
            _updateTimer.Elapsed += UpdateTimer_Elapsed;
            _updateTimer.AutoReset = true;
            _updateTimer.Start();
            //.........................................
            lsb_ctrl_xmlfile_data.MouseDown += Lsb_ctrl_xmlfile_data_MouseDown;
            lsb_ctrl_xmlfile_data.DrawMode = DrawMode.OwnerDrawFixed;
            lsb_ctrl_xmlfile_data.DrawItem += Lsb_Ctrl_Xmlfile_Data_DrawItem;

            //.........................................
            btn_fly.Click += Btn_fly_Click;
            btn_drop.Click += Btn_drop_Click;
            this.Activated += Main_Activated;
            this.Deactivate += Main_Deactivate;
            //.........................................
            gbx_ctrl_xmlfile.MouseDown += panel1_MouseDown;
            gbx_ctrl_xmlfile.MouseMove += lsb_MouseMove;
            gbx_ctrl_xmlfile.MouseUp += panel1_MouseUp;
            gbx_ctrl_xmlfile_data.MouseDown += panel1_MouseDown;
            gbx_ctrl_xmlfile_data.MouseMove += lsb_MouseMove;
            gbx_ctrl_xmlfile_data.MouseUp += panel1_MouseUp;
            //.........................................
            pnl_lsb.MouseDown += panel1_MouseDown;
            pnl_lsb.MouseMove += lsb_MouseMove;
            pnl_lsb.MouseUp += panel1_MouseUp;
            lbl_lsb.MouseDown += panel1_MouseDown;
            lbl_lsb.MouseMove += lsb_MouseMove;
            lbl_lsb.MouseUp += panel1_MouseUp;
            pnl_ctrl.DragEnter += Pnl_Ctrl_DragEnter;
            pnl_ctrl.DragDrop += Pnl_Ctrl_DragDrop;
            //pnl_control.Location = new Point(13, 67);
            //pnl_control.Size = new Size(1365, 610);
            //.........................................
            CanbusTimer.Interval = 1000;
            CanbusTimer.Tick += CanbusTimer_Tick;
            CanbusTimer.Start();
            //.........................................
            cbb_baud0.SelectedIndex = 0;
            IsCom = false;
            this.Paint += new PaintEventHandler(RoundedForm_Paint);


            lbl_dev.Text = "BYU DEV";
            lbl_dev.Font = new Font("Forte", 10, FontStyle.Bold);
            lbl_dev.Width = 75;
            lbl_dev.Location = new Point(25, 4);
            lbl_dev.BackColor = Color.Transparent;


            ptb_hy.Image = Properties.Resources.hy;
            ptb_hy.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_hy.Size = new Size(14, 14);
            ptb_hy.Location = new Point(7, 4);

            ptb_size.Click += Ptb_size_Click;

            r.Text = "®";
            r.Font = new Font("Forte", 10, FontStyle.Regular);
            r.BackColor = Color.Transparent;
            r.Width = 30;
            r.Location = new Point(98, 4);

            //pnl_filepath.Controls.Add(lbl_dev);
            //pnl_filepath.Controls.Add(ptb_hy);
            //pnl_filepath.Controls.Add(r);
            btn_console.Click += Btn_console_Click;

            ListSelect = false;
            Isfly = false;

            //  MessageBox.Show(orgpnlctrlLocation.ToString() + orgpnlctrlsize.ToString());

            orgrtbstring = "※在編輯數值與新增" + Environment.NewLine + " 資料格式後，請點擊" + Environment.NewLine + "寫入按鈕進行寫入。";
            rb_canpro.Select();

            if (xmlFolderPath != null)
            {
                Load_Xml_FileList(lsb_ctrl_xmlfile);
            }
            Init_Cbb_Port(GetCanDeviceNum());
            if (Properties.Settings.Default.BaudRateIndex >= 0 && Properties.Settings.Default.BaudRateIndex < cbb_baud0.Items.Count)
            {
                cbb_baud0.SelectedIndex = Properties.Settings.Default.BaudRateIndex;
            }
            if (Properties.Settings.Default.BaudRateIndex1 >= 0 && Properties.Settings.Default.BaudRateIndex1 < cbb_baud0.Items.Count)
            {
                cbb_baud1.SelectedIndex = Properties.Settings.Default.BaudRateIndex;
            }
            SetButtonMouseEnterEvent(this.Controls);
            LogHelper.WriteLog("InitApplication Finished");
            this.Opacity = 0;
            OpenTimer.Start();

            imglst = new ImageList();
            imglst.Images.Add(Properties.Resources.b);
            imglst.Images.Add(Properties.Resources.y);
            imglst.Images.Add(Properties.Resources.x);
            imglst.Images.Add(Properties.Resources.z);
            imglst.Images.Add(Properties.Resources.a);
            imglst.Images.Add(Properties.Resources.h);
            imglst.Images.Add(Properties.Resources.i);
            imglst.Images.Add(Properties.Resources.j);
            imglst.Images.Add(Properties.Resources.k);
            imglst.Images.Add(Properties.Resources.l);
            //borderForm = new BorderForm();
            //borderForm.AttachToMainForm(this);
            //borderForm.Show();
            IsOpenCan = false;
            // initmenu();
            menu.Location = new Point(0, 0);
            menu.Size = new Size(panel3.Width, 24);
            menu.main = this;



            this.KeyPreview = true;
            this.KeyDown += Main_KeyDown;
            rtb_suCon.LostFocus += Rtb_suCon_LostFocus;
            Panel_Title.DoubleClick += Panel_Title_DoubleClick;
            ccomxmlfilename = Properties.Settings.Default.UserCcom;
            Console.WriteLine(loc.Pcontrol_Lo.ToString() + loc.Pctrl_Lo.ToString() + loc.Punder_Lo.ToString() + loc.Pcontrol_Si.ToString() + loc.Pctrl_Si.ToString() + loc.Punder_Si.ToString());
            inputlan = InputLanguage.CurrentInputLanguage;
            tb_console.Enter += Tb_console_Enter;
            tb_console.Leave += Tb_console_Leave;
            SavePathToRegedistry(Application.StartupPath);
            initccom();
            Main_Activated(sender, e);
            cbx_autoconfig.Checked = Properties.Settings.Default.AutoConfig;
            if (cbx_autoconfig.Checked == true)
            {
                configname = Properties.Settings.Default.UserConfig;
            }
            else
            {
                configname = "";
            }
           initautoconfig();
        }
        //......................Update Information........................
        private bool CheckUpdate(bool b)
        {
            if (b == false)
            {
                return false;
            }
            else
            {
                menuform updateform = new(pnl_update, "Gird Can UpdateTools", btn_updset);
                return false;
            }
        }
        //................................................................
        private void initautoconfig()
        {
            if (cbx_autoconfig.Checked)
            {
                if (configname != "")
                {
                    Open_Config(configname);
                }
                else
                {
                    return;
                }
            }
            else
            {
                return;
            }

        }
        private void Tb_console_Leave(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = inputlan;
        }
        private void Tb_console_Enter(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new System.Globalization.CultureInfo("en-US"));
        }
        private void Rtb_suCon_LostFocus(object sender, EventArgs e)
        {
            rtb_suCon.Enabled = false;
        }
        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F8)
            {
                DevClick();
            }
            if (e.KeyCode == Keys.F7)
            {
                setformshow();
            }
            if (e.KeyCode == Keys.F5)
            {
                CAN(IsOpenCan);
            }
            if (e.KeyCode == Keys.F6)
            {
                Open_Config();
            }
            if (e.KeyCode == Keys.Escape)
            {
                menu.test04();
            }
            if (e.KeyCode == Keys.F1)
            {
                menu.test05();
            }

        }
        //.............................Regedit32...................................
        private void SavePathToRegedistry(string directoryPath)
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\GridCan");
                key.SetValue("APPpath", directoryPath);
                key.Close();
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
        }
        //...............................SuperSu...................................
        private void Btn_console_Click(object sender, EventArgs e)
        {
            btn_consoleClick(tb_console);
        }
        private void cin(string input)
        {
            Match match = Regex.Match(input, @"name:\s*(?<name>[^,]+),\s*value:\s*(?<value>[^,]+)");
            string name = "", value = "";
            if (match.Success)
            {
                name = match.Groups["name"].Value.Trim();
                value = match.Groups["value"].Value.Trim();
                if (tempvalue == "")
                {
                    SetSettingDefault(name, returncinbool(value));
                }
                if (tempvalue != "")
                {
                    SetSettingDefault(name, false, tempvalue);
                }
            }
        }
        private void SetSettingDefault(string name, bool b = false, string v = "")
        {
            var property = Properties.Settings.Default.GetType().GetProperty(name);
            if (property != null)
            {
                if (property.PropertyType == typeof(bool))
                {
                    property.SetValue(Properties.Settings.Default, b);
                }
                else if (property.PropertyType == typeof(string))
                {
                    property.SetValue(Properties.Settings.Default, v);
                }
                else
                {
                    rtb_suCon.AppendText("錯誤 " + Environment.NewLine);
                    rtbScroll(rtb_suCon);
                }
                // 保存設定值
                Properties.Settings.Default.Save();
            }
            else
            {
                rtb_suCon.AppendText("未知參數: " + name + Environment.NewLine);
                rtbScroll(rtb_suCon);
            }
        }
        private string tempvalue;
        public bool returncinbool(string B)
        {
            string b = B.Trim().ToLower();
            if (b == "true")
            {
                return true;
            }
            if (b == "false")
            {
                return false;
            }
            else
            {
                tempvalue = B;
                rtb_suCon.AppendText("請再次輸入指令:" + Environment.NewLine);
                rtbScroll(rtb_suCon);
                return false;
            }
        }
        public void UpdateSuperSu(string ID)
        {
            Task.Run(() =>
            {
                string Rus = ID;
                // 更新UI需要在主线程中进行
                this.Invoke((MethodInvoker)delegate
                {
                    rtb_suCon.AppendText(Rus + Environment.NewLine);
                    rtbScroll(rtb_suCon);
                });
            });
        }
        private void switchconsole(TextBox tbx)
        {
            if (string.IsNullOrEmpty(tbx.Text))
            {
                tbx.Clear();
                return;
            }
            string command = tbx.Text.Trim().ToLower(); // 去除可能的空格，并转换为小写

            rtb_suCon.AppendText("執行命令: " + command + Environment.NewLine);
            rtbScroll(rtb_suCon);

            switch (command)
            {
                case "opencan":
                    CAN(false);
                    break;
                case "closecan":
                    CAN(true); // 假设 CloseCan 的逻辑是传递 true
                    break;
                case "getcanid":
                    issu = true;
                    break;
                case "stopid":
                    issu = false;
                    break;
                case "readbctrl":
                    ByteCtrl.CheckID = true;
                    rtb_suCon.Enabled = true;
                    break;
                case "stopreadbctrl":
                    ByteCtrl.CheckID = false;
                    break;
                case "loadconfig":
                    Open_Config();
                    break;
                case "path":
                    Select_FilePath();
                    break;
                case "edit":
                    SetForm s = new(this);
                    s.Show();
                    break;
                case "setlan":
                    itemlanClick();
                    break;
                case "setbaud":
                    itemBaudClick();
                    break;
                case "hy":
                    iteminfoClick();
                    break;
                case "saveconfig":
                    Save_Config();
                    break;
                case "unlock":
                    rtb_suCon.Enabled = true;
                    break;
                case "ccom":
                    CcomClick();
                    break;
                case "exit":
                    ExitTimer.Start();
                    break;
                case "editsetting":
                    rtb_suCon.AppendText("請依著以下格式輸入指令:" + Environment.NewLine);
                    rtb_suCon.AppendText("Suname: EX NAME,value: EX VALUE." + Environment.NewLine);
                    rtb_suCon.AppendText("輸入完畢後輸入指令:cin" + Environment.NewLine);
                    rtbScroll(rtb_suCon);
                    break;
                case "cin":
                    tb_console.Clear();
                    rtbScroll(rtb_suCon);
                    cin(SuString);
                    break;
                case "ccomtest":
                    //     ccomtest(ccomxmlfilename);
                    break;
                case "tagctrl":
                    rtb_suCon.AppendText("輸入控件名稱 " + Environment.NewLine);
                    rtb_suCon.AppendText("命令以Su為開頭 " + Environment.NewLine);
                    rtbScroll(rtb_suCon);
                    break;
                case "removectrl":
                    rtb_suCon.AppendText("移除控件 " + Environment.NewLine);
                    rtbScroll(rtb_suCon);
                    Remove_ByteCtrl(SuString);
                    break;
                default:
                    rtb_suCon.AppendText("未知命令: " + command + Environment.NewLine);
                    rtbScroll(rtb_suCon);
                    break;
            }
            tbx.Clear();
        }
        private static string SuString;
        private static int SuInt;
        private void btn_consoleClick(TextBox tbx, int Num = 0)
        {
            if (tbx.Text.StartsWith("Su"))
            {
                SuString = tbx.Text.Substring(2);
                SuInt = Num;
                rtb_suCon.AppendText("已儲存: " + SuString + Environment.NewLine);
                rtbScroll(rtb_suCon);
            }
            else
            {
                switchconsole(tbx);
            }
            tbx.Clear();
        }
        //.................................Size....................................
        Button btn_clear_pnl;
        private void Panel_Title_DoubleClick(object sender, EventArgs e)
        {
            IsMax = !IsMax;
        }
        public void Init_Ptb_Size(PictureBox p)
        {
            p.MouseMove += Ptb_size_MouseMove;
            p.MouseLeave += Ptb_size_MouseLeave;
        }
        private void Ptb_size_Click(object sender, EventArgs e)
        {
            IsMax = !IsMax;
            btn_clear_pnl.Location = new Point(20, pnl_ctrl.Height - 50);
        }
        private void initlblmini(Label l)
        {
            l.ForeColor = Color.FromArgb(100, 196, 154, 138);
            l.Click += L_Click;
            l.MouseMove += L_MouseMove;
            l.MouseLeave += L_MouseLeave;
        }
        private void L_MouseLeave(object sender, EventArgs e)
        {
            lbl_mini.ForeColor = Color.FromArgb(100, 196, 154, 138);
        }
        private void L_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_mini.ForeColor = Color.White;
        }
        private void L_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void test07()
        {
            Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;

            // 設定表單大小與工作區域相同
            this.Location = new Point(workingArea.Left, workingArea.Top);
            this.Size = new Size(workingArea.Width, workingArea.Height);
            panel3.Size = new Size(workingArea.Width - 2, workingArea.Height - 30);
        }
        private void setsize(Panel under, Panel Control, Panel ctrl)
        {
            if (IsMax == false)
            {
                Control.Location = loc.Pcontrol_Lo;
                ctrl.Location = loc.Pctrl_Lo;
                under.Location = loc.Punder_Lo;
                ctrl.Size = loc.Pctrl_Si;
                Control.Size = loc.Pcontrol_Si;
                under.Size = loc.Punder_Si;
                initialWidth = under.Width;
                initialPos(under, initialPositions);
                setnorpnlunder(under);
            }
            if (IsMax == true)
            {
                Control.Location = loc.Pcontrol_Lo;
                ctrl.Location = loc.Pctrl_Lo;
                under.Location = new Point(under.Location.X, panel3.Height - 97);
                Control.Size = new Size(this.Width - 12, under.Location.Y - 5 - Control.Location.Y);
                ctrl.Size = new Size(Control.Width - 15, Control.Height - 20);
                under.Size = new Size(this.Width, under.Size.Height);
                setpnlunder(under);
                //   Console.WriteLine(ctrl.Size.ToString());
            }
        }
        private void initialPos(Panel u, List<int> l)
        {
            if (isfirstopen == true)
            {
                var controls = new List<Control>
            {
                u.Controls["pnl_st"] as Panel,
          //      u.Controls["btn_ID"]as Button,
           //     u.Controls["btn_SetXml"] as Button,
                u.Controls["gbx_config"] as GroupBox,
                u.Controls["gbx_can"] as GroupBox,
                u.Controls["rtb_console"] as RichTextBox,
                u.Controls["btn_Exit"] as Button
            };

                if (controls.Any(c => c == null))
                {
                    throw new InvalidOperationException("One or more controls could not be found in the panel.");
                }
                initialPositions = controls.Select(c => c.Location.X).ToList();
            }
            isfirstopen = false;
        }
        private void setpnlunder(Panel u)
        {

            var controls = new List<Control>
            {
                u.Controls["pnl_st"] as Panel,
              //  u.Controls["btn_ID"]as Button,
            //    u.Controls["btn_SetXml"] as Button,
                u.Controls["gbx_config"] as GroupBox,
                u.Controls["gbx_can"] as GroupBox,
                u.Controls["rtb_console"] as RichTextBox,
                u.Controls["btn_Exit"] as Button
            };

            if (controls.Any(c => c == null))
            {
                throw new InvalidOperationException("One or more controls could not be found in the panel.");
            }

            // 记录初始时控件的位置
            initialPositions = controls.Select(c => c.Location.X).ToList();
            double scale = (double)u.Width / initialWidth;  // 放大比例

            // 计算新的控件位置
            for (int i = 0; i < controls.Count; i++)
            {
                var control = controls[i];
                int newX = (int)(initialPositions[i] * scale);  // 按比例调整位置
                control.Location = new Point(newX, control.Location.Y);
            }
        }
        private void setnorpnlunder(Panel u)
        {
            var controls = new List<Control>
            {
                u.Controls["pnl_st"] as Panel,
        //        u.Controls["btn_ID"]as Button,
         //       u.Controls["btn_SetXml"] as Button,
                u.Controls["gbx_config"] as GroupBox,
                u.Controls["gbx_can"] as GroupBox,
                u.Controls["rtb_console"] as RichTextBox,
                u.Controls["btn_Exit"] as Button
            };

            if (controls.Any(c => c == null))
            {
                throw new InvalidOperationException("One or more controls could not be found in the panel.");
            }
            //   initialPositions = controls.Select(c => c.Location.X).ToList();
            // 计算新的控件位置
            for (int i = 0; i < controls.Count; i++)
            {
                var control = controls[i];
                int newX = (int)(initialPositions[i]);  // 按比例调整位置
                control.Location = new Point(newX, control.Location.Y);
            }
        }
        private void Ptb_size_MouseLeave(object sender, EventArgs e)
        {
            if (IsMax == true)
            {
                ptb_size.Image = Properties.Resources.normal_m;
            }
            else
            {
                ptb_size.Image = Properties.Resources.max_m;
            }
        }
        private void Ptb_size_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMax == true)
            {
                ptb_size.Image = Properties.Resources.normal;
            }
            else
            {
                ptb_size.Image = Properties.Resources.max;
            }
        }
        //............................pnlCtrl.....................................
        private void initclear()
        {
            btn_clear_pnl = new();
            btn_clear_pnl.FlatStyle = FlatStyle.Flat;
            btn_clear_pnl.Size = new Size(80, 30);
            btn_clear_pnl.BackColor = Color.Beige;
            btn_clear_pnl.Location = new Point(20, pnl_ctrl.Height - 50);
            pnl_ctrl.Controls.Add(btn_clear_pnl);
            btn_clear_pnl.Text = "Clear";
            btn_clear_pnl.Click += Btn_clear_pnl_Click;

            tbx_ctrlnum.KeyDown += Tbx_ctrlnum_KeyDown;
            tbx_ctrlnum.KeyPress += Tbx_ctrlnum_KeyPress;
        }

        private void Tbx_ctrlnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Tbx_ctrlnum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // 检查文本框中的文本是否为数字
                int x;
                if (int.TryParse(tbx_ctrlnum.Text, out x) && tbx_ctrlnum.Text != "0")
                {
                    Panel parentPanel = (sender as TextBox).Parent as Panel;
                    GroupBox targetGroupBox = parentPanel.Tag as GroupBox;
                    setGroupboxSize(targetGroupBox, x);
                }
                else
                {
                    rtb_console.AppendText("錯誤 : 請輸入有效數字" + DateTime.Now.ToString("HH:mm:ss") + Environment.NewLine);
                    RichtextboxScroll();
                }
            }
        }
        private void setGroupboxSize(object sender, int x)
        {
            if (x != 0)
            {
                //foreach (Control ctrl in p.Controls)
                //{
                //    if (ctrl is GroupBox g)
                //    {
                Adjust_Ctrl_Positions(sender as GroupBox, x);
                //   }
            }
        }
        private void Btn_clear_pnl_Click(object sender, EventArgs e)
        {
            Reset_ByteCtrl();
            ReleaseConfigFile();
        }
        //...........................MainForm.....................................
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            LogHelper.iscreate = false;
        }
        public string LAN;
        private void LoadLanguage(string culture)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            LAN = culture;
            this.Text = resourceManager.GetString("title");
            btn_Exit.Text = resourceManager.GetString("Exit");
            btn_ctrlopen.Text = resourceManager.GetString("LoadConfig");
            btn_ctrlsave.Text = resourceManager.GetString("SaveConfig");
            btn_canopen.Text = resourceManager.GetString("OpenCan");
            gbx_connect.Text = resourceManager.GetString("Connect");
            label1.Text = resourceManager.GetString("Baud0");
            label2.Text = resourceManager.GetString("Baud1");
            btn_SetXml.Text = resourceManager.GetString("EditData");
            btn_Open.Text = resourceManager.GetString("FilePath");
            btn_fly.Text = resourceManager.GetString("Floating");
            btn_drop.Text = resourceManager.GetString("Drop");
            lbl_Title.Text = resourceManager.GetString("title");
            lbl_lan.Text = resourceManager.GetString("lan");
            //    btn_ID.Text = resourceManager.GetString("ShowIdList");
            btn_lan.Text = resourceManager.GetString("set");
            gbx_ctrl_xmlfile_data.Text = resourceManager.GetString("gbx_xmldata");
            ComboBox comboBox = this.Controls["cbb_lan"] as ComboBox;
            if (comboBox != null)
            {
                comboBox.Items.Clear();
                comboBox.Items.Add(resourceManager.GetString("tw"));
                comboBox.Items.Add(resourceManager.GetString("en"));
            }
            btn_getcandata.Text = resourceManager.GetString("getport");
            pnl_filepath.Text = resourceManager.GetString("gfile");
            LogHelper.WriteLog("SetLanguage:" + culture);
        }
        private void changelan(int n)
        {
            switch (n)
            {
                case 0:
                    LoadLanguage("zh-TW");
                    cbb_lan.SelectedIndex = 1;
                    LogHelper.WriteLog("ChangeLanguage to Zh-TW");
                    break;
                case 1:
                    LoadLanguage("en");
                    cbb_lan.SelectedIndex = 0;
                    LogHelper.WriteLog("ChangeLanguage to EN");
                    break;
            }
            LanguageChanged?.Invoke();
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
            Form form = sender as Form;
            if (IsMax == false)
            {
                int cornerRadius = 7;
                Rectangle rect = new Rectangle(0, 0, form.Width, form.Height);
                using (GraphicsPath path = CreateRoundRectPath(rect, cornerRadius))
                {
                    form.Region = new Region(path);
                }
            }
            if (IsMax == true)
            {
                int cornerRadius = 1;
                Rectangle rect = new Rectangle(0, 0, form.Width, form.Height);
                using (GraphicsPath path = CreateRoundRectPath(rect, cornerRadius))
                {
                    form.Region = new Region(path);
                }
            }
        }
        //.....................CanBus................................
        public int GetCanDeviceNum()
        {
            _canpro = new CanProDriver();
            uint t = _canpro.returncandevice();
            LogHelper.WriteLog("Get CanBus Device Number:" + t.ToString());
            return int.Parse(t.ToString());
        }
        public int CanCount = 0;
        public void Init_Cbb_Port(int port)
        {
            if (port == 0)
            {
                cbb_port.Items.Clear();
                cbb_port.Items.Add("NoPort");
                cbb_port.SelectedIndex = 0;
                LogHelper.WriteLog("Now NoPort");
            }
            for (int i = 0; i < port; i++)
            {
                cbb_port.Items.Clear();
                cbb_port.Items.Add("Device " + i.ToString());
                LogHelper.WriteLog("Port Count:" + i.ToString());
                cbb_port.SelectedIndex = 0;
            }
        }
        private void UpdateTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (_canpro != null && _canpro.CanDataInstance != null)
            {
                EventManager.RaiseDataReceived(_canpro.CanDataInstance.Id, _canpro.CanDataInstance.portId, _canpro.CanDataInstance.Data);
            }
        }
        private void CanbusTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan timeSinceLastMessage = DateTime.Now - LastMessageReceivedTime;
            bool temp = IsCom;
            if (timeSinceLastMessage.TotalMilliseconds > 600)
            {
                IsCom = false;
            }
            else
            {
                IsCom = true;
            }
            if (temp == !IsCom)
            {
                rtb_console.AppendText(iscom ? "訊息 : 資料傳輸中。" + DateTime.Now.ToString("HH:mm:ss") + Environment.NewLine : "訊息 : 資料停止傳輸。" + DateTime.Now.ToString("HH:mm:ss") + Environment.NewLine);
            }
        }
        private void ConnTimer_Tick(object sender, EventArgs e)
        {
            if (imagecount == 10)
            {
                imagecount = 0;
            }
            ptb_conn.Image = imglst.Images[imagecount];
            imagecount++;
        }
        public void _canbus_MessageNotify(object sender, int channel)
        {
            try
            {
                if (InvokeRequired)
                {
                    Invoke(new MessageNofify(_canbus_MessageNotify), sender, channel);
                }
                else
                {
                    Task.Run(() =>
                    {
                        object[] readobjs;
                        if (_canpro != null)
                        {
                            _canpro.ReadFrame(out readobjs);
                            List<CanbusPacket> packets = readobjs.OfType<CanbusPacket>().ToList();
                            uint[] ID = new uint[packets.Count];
                            int id_count = 0;
                            LastMessageReceivedTime = DateTime.Now;
                            foreach (CanbusPacket packet in packets)
                            {
                                SetPacket(packet);
                                ID[id_count] = packet.extID;
                                id_count++;
                            }
                        }
                        else
                        {
                            return;
                        }
                    });
                }
            }
            catch (Exception e)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    rtb_console.AppendText("訊息 : 讀取錯誤，訊息:" + e.Message + "。" + DateTime.Now.ToString("HH:mm:ss") + Environment.NewLine);
                    RichtextboxScroll();
                });
            }
        }
        public byte[] Getbaud0()
        {
            int n = cbb_baud0.SelectedIndex;
            byte[] rus = new byte[2];
            switch (n)
            {
                case 0:
                    rus[0] = 0x04;
                    rus[1] = 0x1C;
                    return rus;
                case 1:
                    rus[0] = 0x03;
                    rus[1] = 0x1C;
                    return rus;
                case 2:
                    rus[0] = 0x01;
                    rus[1] = 0x1C;
                    return rus;
                case 3:
                    rus[0] = 0x00;
                    rus[1] = 0x1C;
                    return rus;
            }
            LogHelper.WriteLog("Set Baud0:" + rus[0].ToString() + rus[1].ToString());
            return rus;
        }
        public byte[] Getbaud1()
        {
            int n = cbb_baud1.SelectedIndex;
            byte[] rus = new byte[2];
            switch (n)
            {
                case 0:
                    rus[0] = 0x04;
                    rus[1] = 0x1C;
                    return rus;
                case 1:
                    rus[0] = 0x03;
                    rus[1] = 0x1C;
                    return rus;
                case 2:
                    rus[0] = 0x01;
                    rus[1] = 0x1C;
                    return rus;
                case 3:
                    rus[0] = 0x00;
                    rus[1] = 0x1C;
                    return rus;
            }
            LogHelper.WriteLog("Set Baud1:" + rus[0].ToString() + rus[1].ToString());
            return rus;
        }
        public void CAN(bool isopen)
        {
            if (isopen == false)
            {
                if (cbb_port.SelectedItem != null || cbb_port.Items.ToString() != "NoPort")
                {
                    _canpro = new CanProDriver(CANPRO.DEV_USBCAN2, (uint)cbb_port.SelectedIndex);
                    _canpro.InitConfig();
                    if (_canpro.OpenDevice(Getbaud0()[0], Getbaud0()[1], Getbaud1()[0], Getbaud1()[1]))
                    {
                        IsOpenCan = true;
                        LogHelper.WriteLog("Connect CanBus Finished");
                        rtb_console.AppendText("訊息 : 成功開啟CanBus: " + cbb_port.SelectedItem.ToString() + " 。" + DateTime.Now.ToString("HH:mm:ss") + Environment.NewLine);

                        RichtextboxScroll();
                        SetCanbusDriver(_canpro);
                    }
                    else
                    {
                        LogHelper.WriteLog("Connect CanBus Failed : Start CanBus fail");
                        rtb_console.AppendText("錯誤 : 連接失敗。" + DateTime.Now.ToString("HH:mm:ss") + Environment.NewLine);
                        RichtextboxScroll();
                        IsOpenCan = false;
                    }
                }
                else
                {
                    LogHelper.WriteLog("Connect CanBus Failed : SelectPort is null or Error");
                    rtb_console.AppendText("錯誤 : 請選擇Port。" + DateTime.Now.ToString("HH:mm:ss") + Environment.NewLine);
                    RichtextboxScroll();
                    IsOpenCan = false;
                }
            }
            if (isopen == true)
            {
                _canpro?.CloseDevice();
                IsOpenCan = false;
                LogHelper.WriteLog("Close CanBus Failed");
                rtb_console.AppendText("訊息 : 成功關閉" + cbb_port.SelectedItem.ToString() + "。" + DateTime.Now.ToString("HH:mm:ss") + Environment.NewLine);
                RichtextboxScroll();
                _canpro = null;
            }
        }
        public void SetCanbusDriver(CanBusDriver driver)
        {
            _canbus = driver;
            if (_canbus != null)
            {
                _canbus.MessageNotify += _canbus_MessageNotify;
                LogHelper.WriteLog("SetCanBUs_MEssageNotify Finished");
            }
            LogHelper.WriteLog("SetCanBUs_MEssageNotify Failed : _canpro is NULL");
        }
        public string xmlfilename;
        public void SetPacket(CanbusPacket p)
        {
            // 从CanbusPacket获取必要的数据
            UInt32 msk_id = p.extID & 0x1FFFFF80;
            UInt32 devid = p.extID & 0x7F;
            canp.portID = p.portID;
            canp.DLC = p.DLC;
            canp.extID = p.extID;
            canp.Data = p.Data;
            canp.DeviceID = p.DeviceID;
            canp.mode = p.mode;
            canp.RTR = p.RTR;

            // 使用异步任务处理耗时操作
            Task.Run(() =>
            {
                string n = "";
                for (int i = 0; i < canp.Data.Length; i++)
                {
                    n += canp.Data[i].ToString() + ",";
                }

                byte[] d = new byte[8];
                for (int i = 0; i < 8; i++)
                {
                    d[i] = 0xCF;
                }

                EventManager.RaiseDataReceived(GetIDName(canp.extID), p.portID, canp.Data);

                // 更新UI需要在主线程中进行
                this.Invoke((MethodInvoker)delegate
                {
                    if (issu == true)
                    {
                        rtb_suCon.AppendText("封包ID: " + GetIDName(canp.extID).ToString() + Environment.NewLine);
                        rtbScroll(rtb_suCon);
                    }
                    if (_isAskCan == true)
                    {
                        UpdateDataItemValue(canp.extID.ToString(), canp.Data, xmlfilename, ishex);
                        rtb_suCon.AppendText("封包ID: " + GetIDName(canp.extID).ToString() + Environment.NewLine);
                        rtbScroll(rtb_suCon);
                    }
                });
            });
            //byte[] c = { 0xFF, 0x1C, 0xAB, 0x1C, 0x1C, 0x0A, 0x10, 0x24 };
            //EventManager.RaiseDataReceived(GetIDName(311448422), 0, c);
            //byte[] c = { 0xAB, 0xBA, 0x07, 0x28, 0x00, 0x00, 0x00, 0x24 };
        }
        public int GetIDName(uint id)
        {
            int rus = int.Parse(id.ToString());
            //  LogHelper.WriteLog("return ID:" + rus);
            return rus;
        }
        public void UpdateDataItemValue(string messageID, byte[] data, string xmlFileName, bool ishex)
        {
            try
            {
                if (string.IsNullOrEmpty(xmlFileName))
                {
                    LogHelper.WriteLog("xmlFile is NULL");
                    rtb_console.AppendText("錯誤 : 未選擇 XML 檔案。" + DateTime.Now.ToString("HH:mm:ss") + Environment.NewLine);
                    RichtextboxScroll();
                    return;
                }

                string selectedFile = Path.Combine(xmlFolderPath, xmlFileName);
                var container = Load_XmlContainer(selectedFile);

                if (container != null && container.MessageID.Substring(2) == (int.Parse(messageID)).ToString("X2"))
                {
                    string hexString = BitConverter.ToString(data).Replace("-", string.Empty);

                    foreach (var dataItem in container.DataItems)
                    {
                        int size = int.Parse(dataItem.Size);
                        int lsb = int.Parse(dataItem.lsb);
                        int msb = int.Parse(dataItem.msb);
                        string type = dataItem.Type;
                        bool end = boolislit(dataItem.Endian);
                        string value = DataMethod.DoMath(data, size, lsb, msb, type, end);
                        if (ishex)
                        {
                            // 檢查數據類型並適當地格式化十六進制輸出
                            switch (type)
                            {
                                case "Uint":
                                    // 確保以 "0x" 開頭且總長度為10字符（包括 "0x"）
                                    dataItem.Value = "0x" + uint.Parse(value).ToString("X8");
                                    break;
                                case "Ushort":
                                    // 確保以 "0x" 開頭且總長度為6字符（包括 "0x"）
                                    dataItem.Value = "0x" + ushort.Parse(value).ToString("X2");
                                    break;
                                case "Byte":
                                    // 確保以 "0x" 開頭且總長度為4字符（包括 "0x"）
                                    dataItem.Value = "0x" + byte.Parse(value).ToString("X2");
                                    break;
                                case "Float":
                                    // 確保以 "0x" 開頭且總長度為4字符（包括 "0x"）
                                    dataItem.Value = "0x" + byte.Parse(value).ToString("X2");
                                    break;
                                default:
                                    // 對於未知的或其他類型，默認為2位顯示
                                    dataItem.Value = "0x" + uint.Parse(value).ToString("X2");
                                    break;
                            }
                        }
                        else
                        {
                            dataItem.Value = value;
                        }
                        // 将更新后的数据写回到 XML 文件中
                        Save_XmlContainer(container, selectedFile);
                        Load_DataXml(selectedFile);
                        rtb_console.AppendText("訊息 : 成功接收CanBus回傳數據" + DateTime.Now.ToString("HH:mm:ss") + Environment.NewLine);
                        _isAskCan = false;
                        RichtextboxScroll();
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog("Error to UpdateXmlFileValue:" + ex.Message);
            }
        }
        public void DisplayValueHex(bool init = true)
        {
            if (init == true)
            {
                try
                {
                    if (string.IsNullOrEmpty(xmlfilename))
                    {
                        rtb_console.AppendText("錯誤 : 未選擇 XML 檔案。" + DateTime.Now.ToString("HH:mm:ss") + Environment.NewLine);
                        LogHelper.WriteLog("Xmlfile is NULL");
                        RichtextboxScroll();
                        return;
                    }

                    string selectedFile = Path.Combine(xmlFolderPath, xmlfilename);
                    var container = Load_XmlContainer(selectedFile);

                    foreach (var dataItem in container.DataItems)
                    {
                        if (ishex)
                        {
                            // 如果当前是十进制，转换为十六进制并加上 "0x"
                            if (!dataItem.Value.StartsWith("0x") && int.TryParse(dataItem.Value, out int intValue))
                            {
                                dataItem.Value = "0x" + intValue.ToString("X2");
                            }
                        }
                        else
                        {
                            // 如果当前是十六进制，去掉 "0x" 前缀并转换为十进制
                            if (dataItem.Value.StartsWith("0x") && int.TryParse(dataItem.Value.Substring(2), System.Globalization.NumberStyles.HexNumber, null, out int intValue))
                            {
                                dataItem.Value = intValue.ToString();
                            }
                        }
                    }

                    // 将更新后的数据写回到 XML 文件中
                    Save_XmlContainer(container, selectedFile);
                    Load_DataXml(selectedFile);
                    RichtextboxScroll();
                }
                catch (Exception ex)
                {
                    LogHelper.WriteLog("Error " + ex.Message);
                }
            }
        }
        public void checknull(TextBox XmlFileName, TextBox MessageID, TextBox PortID, TextBox Mode, Label xmlname, Label meid, Label portid, Label mode)
        {
            List<string> missingFields = new List<string>();
            missingFields.Clear();
            if (XmlFileName == null || string.IsNullOrWhiteSpace(XmlFileName.Text))
            {
                missingFields.Add("XmlFileName");
            }
            if (MessageID == null || string.IsNullOrWhiteSpace(MessageID.Text))
            {
                missingFields.Add("MessageID");
            }
            if (PortID == null || string.IsNullOrWhiteSpace(PortID.Text))
            {
                missingFields.Add("PortID");
            }
            if (Mode == null || string.IsNullOrWhiteSpace(Mode.Text))
            {
                missingFields.Add("Mode");
            }

            if (missingFields.Count > 0)
            {
                for (int i = 0; i < missingFields.Count; i++)
                {
                    if (missingFields[i] == "XmlFileName")
                    {
                        xmlname.ForeColor = Color.Red;
                    }
                    if (missingFields[i] == "MessageID")
                    {
                        meid.ForeColor = Color.Red;
                    }
                    if (missingFields[i] == "PortID")
                    {
                        portid.ForeColor = Color.Red;
                    }
                    if (missingFields[i] == "Mode")
                    {
                        mode.ForeColor = Color.Red;
                    }
                }
                return;
            }
            if (missingFields.Count == 0)
            {
                xmlname.ForeColor = Color.Black;
                meid.ForeColor = Color.Black;
                portid.ForeColor = Color.Black;
                mode.ForeColor = Color.Black;
            }
            return;
        }
        //......................Xml_Method.............................
        public void Create_XmlFile(TextBox XmlFileName, TextBox MessageID, ListBox lsb, TextBox PortID, TextBox Mode, Label xmlname, Label meid, Label portid, Label mode)
        {
            checknull(XmlFileName, MessageID, PortID, Mode, xmlname, meid, portid, mode);
            if (XmlFileName != null && MessageID != null && PortID != null && Mode != null && XmlFileName.Text != "" && MessageID.Text != "" && PortID.Text != "" && Mode.Text != "")
            {

                if (XmlFileName.Text.Length > 0 || XmlFileName.Text != "")
                {
                    string filename = Path.Combine(xmlFolderPath, XmlFileName.Text + ".xml");
                    DataItemsContainer container = new DataItemsContainer();
                    {
                        container.MessageID = MessageID.Text;
                        container.DataItems = new List<DataItem>(datalist);
                        container.PortID = PortID.Text;
                        container.Mode = Mode.Text;
                    }
                    XmlSerializer serializer = new XmlSerializer(typeof(DataItemsContainer));
                    using (StreamWriter writer = new StreamWriter(filename))
                    {
                        serializer.Serialize(writer, container);
                        checknull(XmlFileName, MessageID, PortID, Mode, xmlname, meid, portid, mode);
                        rtb_console.AppendText("訊息 : 成功建立Xml檔案。" + DateTime.Now.ToString("HH:mm:ss") + Environment.NewLine);
                        LogHelper.WriteLog("Create Xml File Success");
                        IsValue = true;
                        RichtextboxScroll();
                        Load_Xml_FileList(lsb);
                        Load_Xml_FileList(lsb_ctrl_xmlfile);
                    }
                    lsb.SelectedIndex = lsb.Items.Count - 1;
                    return;
                }
                else
                {
                    LogHelper.WriteLog("Error : Information is Null");
                    rtb_console.AppendText("訊息 : 請正確輸入所有欄位資料。" + DateTime.Now.ToString("HH:mm:ss") + Environment.NewLine);
                    RichtextboxScroll();
                }
            }
            else
            {
                LogHelper.WriteLog("Error : Information is Null");
                rtb_console.AppendText("訊息 : 請正確輸入所有欄位資料。" + DateTime.Now.ToString("HH:mm:ss") + Environment.NewLine);
                RichtextboxScroll();
            }
        }
        public void Write_Xml(TextBox XmlFileName, DataGridView dgv, TextBox MessageID, TextBox Portid, TextBox Mode, Label xmlname, Label meid, Label portid, Label mode, ListBox lsb = null)
        {
            if (isctrl == false)
            {
                Write_Data_To_XmlFile(XmlFileName, lsb, MessageID, Portid, Mode, xmlname, meid, portid, mode);
                XmlFile_DataChanged(XmlFileName.Text, MessageID.Text, int.Parse(Portid.Text), int.Parse(Mode.Text));
                Init_DataGridView(dgv, "false");
            }
            if (isctrl == true)
            {
                Reset_ByteCtrl();
            }
        }
        public void Set_Xml_Descripe(TextBox XmlFileName, TextBox MessageID, ListBox lsb, TextBox PortID, TextBox Mode, Label xmlname, Label meid, Label portid, Label mode)
        {
            checknull(XmlFileName, MessageID, PortID, Mode, xmlname, meid, portid, mode);
            if (XmlFileName != null && MessageID != null && PortID != null && Mode != null && XmlFileName.Text != "" && MessageID.Text != "" && PortID.Text != "" && Mode.Text != "")
            {

                if (XmlFileName.Text.Length > 0 || XmlFileName.Text != "")
                {
                    string filename = Path.Combine(xmlFolderPath, XmlFileName.Text + ".xml");
                    DataItemsContainer container = new DataItemsContainer();
                    {
                        container.MessageID = MessageID.Text;
                        container.DataItems = new List<DataItem>(datalist);
                        container.PortID = PortID.Text;
                        container.Mode = Mode.Text;
                    }
                    XmlSerializer serializer = new XmlSerializer(typeof(DataItemsContainer));
                    using (StreamWriter writer = new StreamWriter(filename))
                    {
                        serializer.Serialize(writer, container);
                        checknull(XmlFileName, MessageID, PortID, Mode, xmlname, meid, portid, mode);
                        rtb_console.AppendText("訊息 : 成功修改Xml檔案。" + DateTime.Now.ToString("HH:mm:ss") + Environment.NewLine);
                        LogHelper.WriteLog("Create Xml File Success");
                        IsValue = true;
                        RichtextboxScroll();
                        Load_Xml_FileList(lsb);
                        Load_Xml_FileList(lsb_ctrl_xmlfile);
                        XmlFile_DataChanged(XmlFileName.Text, MessageID.Text, int.Parse(PortID.Text), int.Parse(Mode.Text));
                    }
                    lsb.SelectedIndex = lsb.Items.Count - 1;
                    return;
                }
                else
                {
                    LogHelper.WriteLog("Error : Information is Null");
                    rtb_console.AppendText("訊息 : 請正確輸入所有欄位資料。" + DateTime.Now.ToString("HH:mm:ss") + Environment.NewLine);
                    RichtextboxScroll();
                }
            }
            else
            {
                LogHelper.WriteLog("Error : Information is Null");
                rtb_console.AppendText("訊息 : 請正確輸入所有欄位資料。" + DateTime.Now.ToString("HH:mm:ss") + Environment.NewLine);
                RichtextboxScroll();
            }
        }
        public void loadlist()
        {
            Load_Xml_FileList(lsb_ctrl_xmlfile);
        }
        public bool boolislit(string n)
        {
            if (n == "lit")
            {
                return true;
            }
            if (n == "big")
            {
                return false;
            }
            return false;
        }
        protected virtual void OnXmlDataChanged(XmlDataChangedEventArgs e)
        {
            XmlDataChanged?.Invoke(this, e);
        }
        private void XmlFile_DataChanged(string xn, string mid, int id, int mode)
        {
            uint Mid = Convert.ToUInt32(mid.Substring(2), 16);
            // 檢測到資料變動，觸發事件並傳遞參數
            OnXmlDataChanged(new XmlDataChangedEventArgs(xn, Mid, id, mode));
        }
        public string returnend(ComboBox cb)
        {
            if (cb.SelectedIndex == 0)
            {
                return "lit";
            }
            if (cb.SelectedIndex == 1)
            {
                return "big";
            }
            else
            {
                return "lit";
            }
        }
        public string returnend(bool b)
        {
            if (b == true)
            {
                return "lit";
            }
            if (b == false)
            {
                return "big";
            }
            return "error";
        }
        public void Add_Data_Format(ListBox lstb, TextBox Name, ComboBox Type, TextBox Size, TextBox Lsb, TextBox Msb, ComboBox End)
        {
            string name = Name.Text;
            string type = Type.SelectedItem?.ToString();
            string size = Size.Text;
            string lsb = Lsb.Text;
            string msb = Msb.Text;
            int index = Type.SelectedIndex;
            //    int endindex = End.SelectedIndex;
            string end = returnend(End);
            string value = "";
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(type) ||
             string.IsNullOrWhiteSpace(size) || string.IsNullOrWhiteSpace(lsb) || string.IsNullOrWhiteSpace(msb))
            {
                LogHelper.WriteLog("Error : Data in DataTextbox is Null");
                rtb_console.AppendText("錯誤 : 請輸入所有欄位的資料。" + DateTime.Now.ToString("HH:mm:ss") + Environment.NewLine);
                RichtextboxScroll();
                return;
            }
            if (lstb.SelectedIndex != -1)
            {
                // 創建新的 DataItem 並添加到資料列表
                DataItem newItem = new DataItem
                {
                    Name = name,
                    Type = type,
                    Size = size,
                    lsb = lsb,
                    msb = msb,
                    Value = value,
                    Endian = end
                };
                datalist.Add(newItem);

                IsValue = false;
                LogHelper.WriteLog("Write Data Format in XmlFile Success");
                rtb_console.AppendText("訊息 : 成功新增資料格式，請點擊寫入按鈕。" + DateTime.Now.ToString("HH:mm:ss") + Environment.NewLine);
                RichtextboxScroll();
                Clear_DataGridView(Name, Type, Size, Lsb, Msb, End);
                Type.SelectedIndex = index;
                //     End.SelectedIndex = endindex;
            }
            else
            {
                LogHelper.WriteLog("Error : Select XmlFile is Null");
                rtb_console.AppendText("訊息 : 請選擇Xml檔案以建立資料格式。" + DateTime.Now.ToString("HH:mm:ss") + Environment.NewLine);
                RichtextboxScroll();
            }
        }
        public void Write_Data_To_XmlFile(TextBox XmlFileName, ListBox lsb, TextBox MessageID, TextBox PortID, TextBox Mode, Label xmlname, Label meid, Label portid, Label mode)
        {
            checknull(XmlFileName, MessageID, PortID, Mode, xmlname, meid, portid, mode);
            if (MessageID != null && PortID != null && Mode != null && MessageID.Text != "" && PortID.Text != "" && Mode.Text != "")
            {

                if (lsb != null && lsb.SelectedItem != null)
                {
                    if (datalist.Count != 0)
                    {
                        {
                            string filename = Path.Combine(xmlFolderPath, lsb.SelectedItem.ToString() + ".xml");
                            DataItemsContainer container = new DataItemsContainer();
                            {
                                container.MessageID = MessageID.Text;
                                container.DataItems = new List<DataItem>(datalist);
                                container.PortID = PortID.Text;
                                container.Mode = Mode.Text;
                            }
                            XmlSerializer serializer = new XmlSerializer(typeof(DataItemsContainer));
                            using (StreamWriter writer = new StreamWriter(filename))
                            {
                                serializer.Serialize(writer, container);
                                if (isdelete != true)
                                {
                                    checknull(XmlFileName, MessageID, PortID, Mode, xmlname, meid, portid, mode);
                                    rtb_console.AppendText("訊息 : 成功寫入資料數據至本地資源檔。" + DateTime.Now.ToString("HH:mm:ss") + Environment.NewLine);
                                }
                                IsValue = true;
                                RichtextboxScroll();
                                lsb.Items.Clear();
                                Load_Xml_FileList(lsb);
                                Load_Xml_FileList(lsb_ctrl_xmlfile);
                                XmlFile_DataChanged(XmlFileName.Text, MessageID.Text, int.Parse(PortID.Text), int.Parse(Mode.Text));
                                LogHelper.WriteLog("Write Data in XmlFile Success");
                                return;
                            }
                        }
                    }
                }
                else
                {
                    {
                        LogHelper.WriteLog("Error : Select XmlFile is Null");
                        rtb_console.AppendText("訊息 : 請選擇Xml檔案以修改資料。" + DateTime.Now.ToString("HH:mm:ss") + Environment.NewLine);
                        RichtextboxScroll();
                    }
                }
            }
            else
            {
                LogHelper.WriteLog("Error : Information is Null");
                rtb_console.AppendText("訊息 : 請正確輸入所有欄位資料。" + DateTime.Now.ToString("HH:mm:ss") + Environment.NewLine);
                RichtextboxScroll();
            }
        }
        public DataItemsContainer Load_XmlContainer(string filePath)
        {
            if (!File.Exists(filePath))
            {
                LogHelper.WriteLog("Error : Load Xml Container failed : No FIle");
                return null;
            }

            XmlSerializer serializer = new XmlSerializer(typeof(DataItemsContainer));
            using (StreamReader reader = new StreamReader(filePath))
            {
                LogHelper.WriteLog("Load Xml Container success");
                return (DataItemsContainer)serializer.Deserialize(reader);

            }
        }
        public void Save_XmlContainer(DataItemsContainer container, string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(DataItemsContainer));
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, container);
                LogHelper.WriteLog("Save Xml Container success");
            }
        }
        public void Remove_Data_From_XmlFile(ListBox lsb, DataGridView dgv)
        {
            if (lsb.SelectedItem != null)
            {
                if (dgv.SelectedRows.Count > 0)
                {
                    isdelete = true;
                    // 獲取選中行的索引
                    int selectedIndex = dgv.SelectedRows[0].Index;

                    // 獲取選中行的 DataItem 對象
                    DataItem selectedItem = datalist[selectedIndex];

                    // 從 BindingList<DataItem> 中移除相應的 DataItem
                    datalist.Remove(selectedItem);
                    //Write_Data_To_XmlFile();
                    Remove_ByteCtrl(selectedItem.Name);

                    // 更新 DataGridView
                    dgv.DataSource = null;
                    dgv.DataSource = bindingSource;
                    dgv.Refresh();
                    // Clear_ByteCtrl_In_Panel();
                    // 輸出刪除成功消息到 richTextBox
                    LogHelper.WriteLog("Delete Data in Xmlfile Success");
                    rtb_console.AppendText("訊息 : 成功刪除資料數據。" + DateTime.Now.ToString("HH:mm:ss") + Environment.NewLine);
                    RichtextboxScroll();
                    isdelete = false;
                }
                else
                {
                    // 沒有選中的行，輸出錯誤消息
                    LogHelper.WriteLog("Error : DATAlist selected is Null");
                    rtb_console.AppendText("錯誤 : 沒有選中任何行。" + DateTime.Now.ToString("HH:mm:ss") + Environment.NewLine);
                    RichtextboxScroll();
                }
            }
            else
            {
                LogHelper.WriteLog("Error : Select XmlFIle is Null");
                rtb_console.AppendText("訊息 : 請選擇Xml檔案以刪除資料。" + DateTime.Now.ToString("HH:mm:ss") + Environment.NewLine);
                RichtextboxScroll();
            }
        }
        public void Load_Data_From_XmlFile(string n, TextBox PortID = null, TextBox Mode = null, TextBox tbx = null, string groupboxname = "", string ValueName = "", string value = "")
        {
            string filename = n;
            if (!File.Exists(filename))
            {
                LogHelper.WriteLog("Error : Load Xml Container failed : Can't Find the Data");
                rtb_console.AppendText("錯誤 : 找不到該資料或名稱錯誤。" + DateTime.Now.ToString("HH:mm:ss") + Environment.NewLine);
                RichtextboxScroll();
                return;
            }
            XmlSerializer serializer = new(typeof(DataItemsContainer));
            using (StreamReader reader = new(filename))
            {
                xmlfilename = filename;
                DataItemsContainer container = (DataItemsContainer)serializer.Deserialize(reader);
                if (tbx != null)
                {
                    tbx.Text = container.MessageID;
                    PortID.Text = container.PortID;
                    Mode.Text = container.Mode;
                }
                datalist.Clear();
                foreach (var item in container.DataItems)
                {
                    if (item.ToString() == "portid" || item.ToString() == "mode")
                    {
                        continue; // 跳过 "portid" 和 "mode" 项
                    }

                    datalist.Add(item);
                }
                if (isupdatevalue != true && isselectitem != true)
                {
                    LogHelper.WriteLog("Load Xml Data success");
                    rtb_console.AppendText("訊息 : 成功載入Xml資料。" + DateTime.Now.ToString("HH:mm:ss") + Environment.NewLine);
                }
                else
                {
                    if (isselectitem != true)
                    {
                        LogHelper.WriteLog("Set Parameter in XmlfILE success");
                        rtb_console.AppendText("訊息 : 成功修改「" + groupboxname + "」: " + ValueName + "參數，數值為: " + value + " 。" + tbx.Text + "。" + DateTime.Now.ToString("HH:mm:ss") + Environment.NewLine);
                    }
                }
                isupdatevalue = false;
                RichtextboxScroll();
            }
            // 初始化 lsb_ctrl_xmlfile_data
            lsb_ctrl_xmlfile_data.Items.Clear();
            foreach (var item in datalist)
            {
                lsb_ctrl_xmlfile_data.Items.Add(item);
            }
        }
        public void XmltoCtrl(ByteCtrl byteCtrl)
        {
            if (string.IsNullOrEmpty(xmlFolderPath))
            {
                LogHelper.WriteLog("Error : Load XmlFile failed : NoXMLfile");
                rtb_console.AppendText("訊息 : 部分ByteCtrl遺失Xml資訊。" + DateTime.Now.ToString("HH:mm:ss") + Environment.NewLine);
                RichtextboxScroll();
                return;
            }


            var xmlFiles = Directory.GetFiles(xmlFolderPath, "*.xml");
            foreach (var file in xmlFiles)
            {
                XmlSerializer serializer = new(typeof(DataItemsContainer));
                using (StreamReader reader = new(file))
                {
                    DataItemsContainer container = (DataItemsContainer)serializer.Deserialize(reader);
                    string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(file);
                    foreach (var item in container.DataItems)
                    {
                        checkctrlupdate(byteCtrl, fileNameWithoutExtension, item, container.MessageID);
                    }
                }
            }
        }
        public void checkctrlupdate(ByteCtrl byteCtrl, string Xmlfilename, DataItem item, string MessageID)
        {
            DataItem tempItemp = item;
            string tempname = Xmlfilename;
            string ID = ParseID(byteCtrl.MessageID).ToString("X2");

            if (byteCtrl.XmlFileName == Xmlfilename && byteCtrl.valueName == item.Name)
            {
                if (item.portid == null || item.mode == null)
                {
                    item.portid = "0";
                    item.mode = "1";
                }
                if (ID != MessageID.Substring(2) || byteCtrl.size != int.Parse(item.Size) || byteCtrl.portID != item.portid || byteCtrl.lsb != int.Parse(item.lsb) || byteCtrl.msb != int.Parse(item.msb) || byteCtrl.mode != item.mode || byteCtrl.Islit != boolislit(item.Endian))
                {
                    Console.WriteLine(ID + " , " + MessageID.Substring(2));
                    isautosave = true;
                    byteCtrl.updatebytectrlconfig(item, MessageID);

                    XmlFile_DataChanged(xmlfilename, MessageID, int.Parse(tempItemp.portid), int.Parse(tempItemp.mode));
                    Console.WriteLine("update" + item.Name);
                }
            }
            else
            {
                Console.WriteLine("noupdate");
            }
        }
        public void Load_Xml_FileList(ListBox lsb = null)
        {
            if (string.IsNullOrEmpty(xmlFolderPath))
            {
                LogHelper.WriteLog("Error : Load XmlFile failed : NoXMLfile");
                rtb_console.AppendText("訊息 : 載入Xml檔案失敗，請檢察路徑或路徑是否有Xml檔案。" + DateTime.Now.ToString("HH:mm:ss") + Environment.NewLine);
                RichtextboxScroll();
                return;
            }
            lsb.Items.Clear();
            var xmlFiles = Directory.GetFiles(xmlFolderPath, "*.xml");
            foreach (var file in xmlFiles)
            {
                if (lsb != null)
                {
                    lsb.Items.Add(Path.GetFileNameWithoutExtension(file));
                }
            }
        }
        public void lsbmousedown(object sender, ListBox lsb = null)
        {
            string selectedItem = lsb.SelectedItem.ToString();
            int index = lsb.SelectedIndex;
            string newName = Prompt.ShowDialog("Enter new name:", "Rename Item", selectedItem);
            string newPath = Path.Combine(xmlFolderPath, newName + ".xml");
            string oldPath = Path.Combine(xmlFolderPath, selectedItem + ".xml");
            if (!string.IsNullOrWhiteSpace(newName))
            {
                lsb.Items[index] = newName;
                LogHelper.WriteLog("ReName Xmlfile success");
                File.Move(oldPath, newPath); // 重命名文件
                Load_Xml_FileList(lsb);
                Load_Xml_FileList(lsb_ctrl_xmlfile);
            }
        }
        public void lsbxmlfileselectindexchanged(object sender, EventArgs e, TextBox ID, DataGridView dgv, TextBox Name, TextBox portiD, TextBox mode, Label XMLNAME, ListBox lsb = null)
        {
            bool check = Check_Xml_File_Save();
            if (lsb.SelectedItem != null)
            {
                if (check)
                {
                    rtb_console.AppendText("訊息 : 請點擊「Write Value」按鈕以寫入數據。" + DateTime.Now.ToString("HH:mm:ss") + Environment.NewLine);
                    RichtextboxScroll();
                    return;
                }
                if (isnew == true)
                {
                    isnew = false;
                }
                else
                {
                    isselectitem = true;
                    string selectedFile = Path.Combine(xmlFolderPath, lsb.SelectedItem.ToString() + ".xml");
                    ID.Text = lsb.SelectedItem.ToString();
                    XMLNAME.Text = lsb.SelectedItem.ToString();
                    Load_Data_From_XmlFile(selectedFile, portiD, mode, Name);
                    Init_DataGridView(dgv, "false");
                    isselect = true;
                    ListSelect = true;

                    // 同步選擇 lsb_ctrl_xmlfile 中的項目
                    string selectedItem = lsb.SelectedItem.ToString();
                    int index = lsb_ctrl_xmlfile.Items.IndexOf(selectedItem);
                    if (index != -1)
                    {
                        lsb_ctrl_xmlfile.SelectedIndex = index;
                    }
                    isselectitem = false;
                }
            }
        }
        public bool Check_Xml_File_Save()
        {
            if (isselect == true && IsValue == false)
            {
                LogHelper.WriteLog("Save XmlFIle success");
                return true;
            }
            else
            {
                LogHelper.WriteLog("error : Save XmlFIle failed");
                return false;
            }
        }
        public void Load_DataXml(string n)
        {
            string filename = n;
            if (!File.Exists(filename))
            {
                LogHelper.WriteLog("Error : Load Xml Container failed : Can't Find the Data");
                rtb_console.AppendText("錯誤 : 找不到該資料或名稱錯誤。" + DateTime.Now.ToString("HH:mm:ss") + Environment.NewLine);
                RichtextboxScroll();
                return;
            }
            XmlSerializer serializer = new(typeof(DataItemsContainer));
            using (StreamReader reader = new(filename))
            {
                DataItemsContainer container = (DataItemsContainer)serializer.Deserialize(reader);
                datalist.Clear();
                foreach (var item in container.DataItems)
                {
                    datalist.Add(item);
                }
            }
        }
        public void SetDgv(DataGridView dgv)
        {
            dgv.DataSource = bindingSource;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.CellValueChanged += Dgv_Data_CellValueChanged;
            // 确保列存在后设置其可见性
            dgv.AllowUserToAddRows = false;
            Init_DataGridView(dgv);
        }
        //.......................pnl_ccom..............................
        public static string ccomxmlfilename = "";
        public void initccom()
        {
            if (ccomxmlfilename == "")
            {
                return;
            }
            else
            {
                Load_ccom(ccomxmlfilename);
            }
        }
        public void openccom()
        {
            //if (ccomxmlfilename == "")
            //{
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "控制指令Xml檔案 (*.xml)|*.xml|所有檔案 (*.*)|*.*";
                openFileDialog.Title = "載入控制指令Xml檔案";

                openFileDialog.InitialDirectory = xmlFolderPath;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (!File.Exists(openFileDialog.FileName))
                    {
                        return;
                    }
                    ccomxmlfilename = openFileDialog.FileName;
                    Properties.Settings.Default.UserCcom = openFileDialog.FileName;
                    Load_ccom(openFileDialog.FileName);
                }
            }
            //}
            //else
            //{
            //    Load_ccom(ccomxmlfilename);
            //}
        }
        public void saveccom()
        {
            if (ccomxmlfilename == "")
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    string userpath = Properties.Settings.Default.UserSelectedPath;
                    if (!string.IsNullOrEmpty(userpath))
                    {
                        saveFileDialog.InitialDirectory = userpath;
                    }
                    saveFileDialog.Filter = "控制指令Xml檔案 (*.xml)|*.xml|所有檔案 (*.*)|*.*";
                    saveFileDialog.DefaultExt = "xml";
                    saveFileDialog.AddExtension = true;
                    saveFileDialog.Title = "儲存控制指令Xml檔案";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Save_ccom(saveFileDialog.FileName);
                        ccomxmlfilename = saveFileDialog.FileName;
                    }
                }
            }
            else
            {
                Save_ccom(ccomxmlfilename);
            }
            Properties.Settings.Default.UserCcom = ccomxmlfilename;
            Properties.Settings.Default.Save();
        }
        private List<DataItem> LoadDataItemsFromXml(string xmlFilePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(DataItemsContainer));
            using (StreamReader reader = new StreamReader(xmlFilePath))
            {
                DataItemsContainer container = (DataItemsContainer)serializer.Deserialize(reader);
                tbx_ID.Text = container.MessageID;
                tbx_Pid.Text = container.PortID;
                return container.DataItems;
            }
        }
        public void FillTextBoxesFromDataItems(List<DataItem> dataItems)
        {
            // 確保 dataItems 列表有五個項目
            if (dataItems == null || dataItems.Count < 5) return;

            // 填充第一組 TextBox
            lbl_g1.Text = dataItems[0].Name;
            tbx_g1_size.Text = dataItems[0].Size;
            tbx_g1_lsb.Text = dataItems[0].lsb;
            tbx_g1_msb.Text = dataItems[0].msb;
            tbx_g1_type.Text = dataItems[0].Type;
            tbx_g1_v.Text = dataItems[0].Value;

            // 填充第二組 TextBox
            lbl_g2.Text = dataItems[1].Name;
            tbx_g2_size.Text = dataItems[1].Size;
            tbx_g2_lsb.Text = dataItems[1].lsb;
            tbx_g2_msb.Text = dataItems[1].msb;
            tbx_g2_type.Text = dataItems[1].Type;
            tbx_g2_v.Text = dataItems[1].Value;

            // 填充第三組 TextBox
            lbl_g3.Text = dataItems[2].Name;
            tbx_g3_size.Text = dataItems[2].Size;
            tbx_g3_lsb.Text = dataItems[2].lsb;
            tbx_g3_msb.Text = dataItems[2].msb;
            tbx_g3_type.Text = dataItems[2].Type;
            tbx_g3_v.Text = dataItems[2].Value;

            // 填充第四組 TextBox
            lbl_g4.Text = dataItems[3].Name;
            tbx_g4_size.Text = dataItems[3].Size;
            tbx_g4_lsb.Text = dataItems[3].lsb;
            tbx_g4_msb.Text = dataItems[3].msb;
            tbx_g4_type.Text = dataItems[3].Type;
            tbx_g4_v.Text = dataItems[3].Value;

            // 填充第五組 TextBox
            lbl_g5.Text = dataItems[4].Name;
            tbx_g5_size.Text = dataItems[4].Size;
            tbx_g5_lsb.Text = dataItems[4].lsb;
            tbx_g5_msb.Text = dataItems[4].msb;
            tbx_g5_type.Text = dataItems[4].Type;
            tbx_g5_v.Text = dataItems[4].Value;
        }
        public void Load_ccom(string n)
        {
            string selectedFile = Path.Combine(xmlFolderPath, n);
            List<DataItem> dataItems = LoadDataItemsFromXml(selectedFile);
            FillTextBoxesFromDataItems(dataItems);
        }
        public void Save_ccom(string comm)
        {

            string filename = Path.Combine(xmlFolderPath, comm);
            DataItemsContainer container = new DataItemsContainer();
            {
                container.MessageID = tbx_ID.Text;
                container.DataItems = new List<DataItem>(datalist);
                container.PortID = tbx_Pid.Text;
                container.Mode = "1";
            }
            XmlSerializer serializer = new XmlSerializer(typeof(DataItemsContainer));
            using (StreamWriter writer = new StreamWriter(filename))
            {
                serializer.Serialize(writer, container);
                return;
            }
        }
        //......................DataGirdView...........................
        public void Select_FilePath()
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.ShowNewFolderButton = true;
                folderDialog.Description = "請選擇工作區資料夾";
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    xmlFolderPath = folderDialog.SelectedPath;
                    LogHelper.Initialize(xmlFolderPath);
                    Properties.Settings.Default.UserSelectedPath = xmlFolderPath;
                    Properties.Settings.Default.Save();
                    btn_ctrlopen.Enabled = true;
                    btn_ctrlsave.Enabled = true;
                    rtb_console.AppendText("訊息 : 成功選擇檔案路徑。" + DateTime.Now.ToString("HH:mm:ss") + Environment.NewLine);
                    LogHelper.WriteLog("Select Path Success:" + xmlFolderPath);
                    RichtextboxScroll();
                    Load_Xml_FileList(lsb_ctrl_xmlfile);

                }
            }
        }
        public void Clear_DataGridView(TextBox Name, ComboBox Type, TextBox Size, TextBox Lsb, TextBox Msb, ComboBox End)
        {
            Name.Clear();
            //  Type.SelectedIndex = -1;
            Size.Clear();
            Msb.Clear();
            Lsb.Clear();
            End.Items.Clear();
        }
        public void Init_DataGridView(DataGridView dgv, string n = "true")
        {
            switch (n)
            {
                case "false":
                    dgv.Columns["portid"].Visible = false;
                    dgv.Columns["mode"].Visible = false;

                    break;
                case "true":
                    //            dgv.Columns["Value"].ReadOnly = true;
                    dgv.Columns["portid"].Visible = false;
                    dgv.Columns["mode"].Visible = false;
                    break;
            }
        }
        public void Dgv_Data_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            IsValue = false;
            rtb_console.AppendText("訊息 : 成功修改資料數值。" + DateTime.Now.ToString("HH:mm:ss") + Environment.NewLine);
            RichtextboxScroll();
        }
        //.......................FormByteCtrl.........................
        public void Create_ByteCtrl(string type, DataItem item, GroupBox groupBox, string xmlFileName, string ID = "", string portid = "", string mode = "", bool end = false)
        {
            Control control = null;
            string ctrlname = $"{item.Name}_{ID}"; // 使用 item.Name 和 ID 組合生成唯一的 ctrlname
            ByteCtrl bytectrl = new ByteCtrl(item, xmlFileName, ID, type, int.Parse(item.Size), int.Parse(item.lsb), int.Parse(item.msb), portid, mode, this, false, end);
            if (ID != null)
            {
                LogHelper.WriteLog("Create ByteCtrl : Name: " + xmlFileName + " , MessageID : " + ID.ToString() + " , portid :" + portid + " , mode :" + mode + ",lit :" + item.Endian);
            }
            else
            {
                LogHelper.WriteLog("Error : ByteCtrl have No ID");
            }
            control = bytectrl;
            //   bytectrl.ctrlname = ctrlname; // 設置 bytectrl 的 ctrlname

            if (control != null)
            {
                int left = 15;
                int top = groupBox.Controls.OfType<Control>().Count(c => c is ByteCtrl) * (control.Height + 5) + 45; // 計算控件應該放置的位置
                control.Location = new Point(left, top);
                groupBox.Controls.Add(control);
                Adjust_Ctrl_Positions(groupBox);

                if (!isselectdic.ContainsKey(ctrlname))
                {
                    isselectdic.Add(ctrlname, true);
                }
                else
                {
                    isselectdic[ctrlname] = true;
                }
                lsb_ctrl_xmlfile_data.Invalidate();
            }
            Adjust_Btn_Lbl_Positions(groupBox);
        }
        public void Lsb_Ctrl_XmlFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                if (lsb_ctrl_xmlfile.SelectedIndex >= 0)
                {
                    string filename = lsb_ctrl_xmlfile.SelectedItem.ToString();
                    string filepath = Path.Combine(xmlFolderPath, filename + ".xml");
                    Load_Data_From_XmlFile(filepath);
                    lsb_ctrl_xmlfile_data.Items.Clear();
                    foreach (var item in datalist)
                    {
                        lsb_ctrl_xmlfile_data.Items.Add(item);
                    }
                }
            });
        }
        public void Lsb_ctrl_xmlfile_data_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                foreach (Control control in pnl_ctrl.Controls)
                {
                    if (control is GroupBox groupBox)
                    {
                        foreach (ByteCtrl byteCtrl in groupBox.Controls.OfType<ByteCtrl>())
                        {
                            string ctrlnameWithID = $"{byteCtrl.valueName}_{byteCtrl.MessageID}";
                            if (!isselectdic.ContainsKey(ctrlnameWithID))
                            {
                                isselectdic.Add(ctrlnameWithID, byteCtrl.iscreate);
                            }
                            else
                            {
                                isselectdic[ctrlnameWithID] = byteCtrl.iscreate;
                            }
                        }
                    }
                }
                if (lsb_ctrl_xmlfile_data.SelectedItem != null)
                {
                    DataItem selectedItem = (DataItem)lsb_ctrl_xmlfile_data.SelectedItem;
                    string selectedXmlFile = lsb_ctrl_xmlfile.SelectedItem?.ToString();
                    if (selectedXmlFile != null)
                    {
                        string filepath = Path.Combine(xmlFolderPath, selectedXmlFile + ".xml");
                        DataItemsContainer container = Load_XmlContainer(filepath);
                        if (container != null)
                        {
                            string ID = ParseID(container.MessageID).ToString();
                            string ctrlnameWithID = $"{selectedItem.Name}_{ID}";
                            bool isCreated = isselectdic.ContainsKey(ctrlnameWithID) && isselectdic[ctrlnameWithID];
                            Cursor.Current = Cursors.Hand;
                            if (!isCreated)
                            {
                                lsb_ctrl_xmlfile_data.DoDragDrop(lsb_ctrl_xmlfile_data.SelectedItem, DragDropEffects.Copy);
                            }
                        }
                    }
                }
                lsb_ctrl_xmlfile_data.Invalidate(); // 強制重繪 ListBox
            }
            catch (Exception ex)
            {
                return;
            }
        }
        public void IsDropItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            ListBox listBox = (ListBox)sender;
            DataItem item = listBox.Items[e.Index] as DataItem;

            if (item == null) return;

            // 获取当前选中的 XML 文件并加载 MessageID
            string selectedXmlFile = lsb_ctrl_xmlfile.SelectedItem?.ToString();
            if (selectedXmlFile != null)
            {
                string filepath = Path.Combine(xmlFolderPath, selectedXmlFile + ".xml");
                DataItemsContainer container = Load_XmlContainer(filepath);
                if (container != null)
                {
                    string ID = ParseID(container.MessageID).ToString();
                    string ctrlnameWithID = $"{item.Name}_{ID}";

                    // 从字典中获取创建状态
                    bool isCreated = isselectdic.ContainsKey(ctrlnameWithID) && isselectdic[ctrlnameWithID];

                    // 设置背景颜色
                    if (isCreated)
                    {
                        Cursor.Current = Cursors.No;
                        e.Graphics.FillRectangle(Brushes.DarkRed, e.Bounds);
                    }
                    else
                    {
                        Cursor.Current = Cursors.Default;
                        e.Graphics.FillRectangle(SystemBrushes.ControlDark, e.Bounds);
                    }

                    // 设置文字颜色
                    e.Graphics.DrawString(item.Name, e.Font, SystemBrushes.ControlText, e.Bounds);

                    // 绘制焦点矩形
                    e.DrawFocusRectangle();
                }
            }
        }
        public void Lsb_Ctrl_Xmlfile_Data_DrawItem(object sender, DrawItemEventArgs e)
        {
            IsDropItem(sender, e);
        }
        public void Pnl_Ctrl_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(DataItem)))
            {
                DataItem dataItem = (DataItem)e.Data.GetData(typeof(DataItem));
                string groupName = lsb_ctrl_xmlfile.SelectedItem?.ToString();
                if (groupName != null)
                {
                    // 確保選中的 XML 文件對應的 MessageID 被傳遞
                    string selectedFile = Path.Combine(xmlFolderPath, groupName + ".xml");
                    DataItemsContainer container = Load_XmlContainer(selectedFile);
                    if (container != null)
                    {
                        string messageID = container.MessageID;
                        uint ID = ParseID(messageID);
                        string portid = container.PortID;
                        string mode = container.Mode;
                        Point dropPoint = pnl_ctrl.PointToClient(new Point(e.X, e.Y));
                        GroupBox targetGroupBox = null;
                        // 檢查是否拖曳到已有的 GroupBox 內
                        foreach (var groupBox in pnl_ctrl.Controls.OfType<GroupBox>())
                        {
                            if (groupBox.Bounds.Contains(dropPoint))
                            {
                                targetGroupBox = groupBox;
                                break;
                            }
                        }
                        if (targetGroupBox == null)
                        {
                            // 沒有拖曳到已有的 GroupBox 內，創建新的 GroupBox
                            targetGroupBox = new GroupBox
                            {
                                Text = "New Group",
                                AutoSize = true,
                                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                                Padding = new Padding(10),
                                Margin = new Padding(5),
                                Name = groupName,
                                FlatStyle = FlatStyle.Flat,
                                Location = dropPoint // 設置 GroupBox 的位置為拖曳點
                            };
                            pnl_ctrl.Controls.Add(targetGroupBox);
                            Adjust_ByteCtrl_GroupBoxPositions();
                            targetGroupBox.MouseDown += TargetGroupBox_MouseDown;
                            setgbx(targetGroupBox);
                        }
                        // 創建 ByteCtrl 並添加到目標 GroupBox 中
                        Create_ByteCtrl(dataItem.Type, dataItem, targetGroupBox, groupName, ID.ToString(), portid, mode, boolislit(dataItem.Endian));
                        // 標記已拖曳過的項目
                        string ctrlnameWithID = $"{dataItem.Name}_{ID}";
                        if (!isselectdic.ContainsKey(ctrlnameWithID))
                        {
                            isselectdic.Add(ctrlnameWithID, true);
                        }

                        // 確保描述標籤只添加一次
                        if (targetGroupBox.Controls.OfType<Label>().Count() == 0)
                        {
                            Label descriptionLabel = new Label
                            {
                                Text = "Description",
                                Font = new Font("微軟正黑體", 17, FontStyle.Bold),
                                AutoSize = true
                            };
                            targetGroupBox.Controls.Add(descriptionLabel);
                            Adjust_Btn_Lbl_Positions(targetGroupBox);
                            Adjust_Ctrl_Positions(targetGroupBox);
                            descriptionLabel.DoubleClick += DescriptionLabel_DoubleClick;
                        }
                        Adjust_ByteCtrl_GroupBoxPositions();
                    }
                }
            }
            else if (e.Data.GetDataPresent(typeof(ByteCtrl)))
            {
                ByteCtrl byteCtrl = (ByteCtrl)e.Data.GetData(typeof(ByteCtrl));
                Point dropPoint = pnl_ctrl.PointToClient(new Point(e.X, e.Y));
                GroupBox targetGroupBox = null;
                // 檢查是否拖放到已有的 GroupBox 內
                foreach (var groupBox in pnl_ctrl.Controls.OfType<GroupBox>())
                {
                    if (groupBox.Bounds.Contains(dropPoint))
                    {
                        targetGroupBox = groupBox;
                        break;
                    }
                }
                GroupBox oldGroupBox = byteCtrl.Parent as GroupBox;
                oldGroupBox.MouseDown += TargetGroupBox_MouseDown;
                if (targetGroupBox != null)
                {
                    // 移動到目標 GroupBox 中
                    byteCtrl.Parent.Controls.Remove(byteCtrl);
                    targetGroupBox.Controls.Add(byteCtrl);
                    Adjust_Btn_Lbl_Positions(targetGroupBox);
                    Adjust_Ctrl_Positions(targetGroupBox);
                    Adjust_Btn_Lbl_Positions(oldGroupBox);
                    Adjust_Ctrl_Positions(oldGroupBox);
                    Adjust_ByteCtrl_GroupBoxPositions();
                }
                else
                {
                    // 如果沒有拖放到 GroupBox 內，則創建一個新的 GroupBox 並添加 ByteCtrl
                    string newGroupName = "New Group";

                    GroupBox newGroupBox = new GroupBox
                    {
                        Text = newGroupName,
                        AutoSize = true,
                        AutoSizeMode = AutoSizeMode.GrowAndShrink,
                        Padding = new Padding(10),
                        Margin = new Padding(5),

                        Name = newGroupName,
                        Location = dropPoint // 設置 GroupBox 的位置為拖放點
                    };
                    newGroupBox.MouseDown += TargetGroupBox_MouseDown;
                    setgbx(newGroupBox);
                    // 確保描述標籤只添加一次
                    if (newGroupBox.Controls.OfType<Label>().Count() == 0)
                    {
                        Label descriptionLabel = new Label
                        {
                            Text = "Description",
                            Font = new Font("微軟正黑體", 17, FontStyle.Bold),
                            AutoSize = true
                        };
                        newGroupBox.Controls.Add(descriptionLabel);
                        descriptionLabel.DoubleClick += DescriptionLabel_DoubleClick;
                    }
                    pnl_ctrl.Controls.Add(newGroupBox);
                    byteCtrl.Parent.Controls.Remove(byteCtrl);
                    newGroupBox.Controls.Add(byteCtrl);
                    Adjust_Ctrl_Positions(newGroupBox);
                    Adjust_Btn_Lbl_Positions(newGroupBox);
                    Adjust_ByteCtrl_GroupBoxPositions();
                }
                // 檢查舊的 GroupBox 是否空了
                if (oldGroupBox != null && !oldGroupBox.Controls.OfType<ByteCtrl>().Any())
                {
                    pnl_ctrl.Controls.Remove(oldGroupBox);
                    oldGroupBox.Dispose();
                }
                else if (oldGroupBox != null)
                {
                    Adjust_Ctrl_Positions(oldGroupBox);
                    Adjust_Btn_Lbl_Positions(oldGroupBox);
                    Adjust_ByteCtrl_GroupBoxPositions();
                }
                Adjust_ByteCtrl_GroupBoxPositions();
                initclear();
                pnl_ctrl.Refresh();
            }
        }
        private void setgbx(GroupBox g)
        {
            g.BackColor = Color.Transparent;
            g.BackgroundImage = Properties.Resources.gbxaero;
            g.BackgroundImageLayout = ImageLayout.Stretch;
            g.Paint += groupBox_Paint;
        }
        private void groupBox_Paint(object sender, PaintEventArgs e)
        {
            GroupBox groupBox = sender as GroupBox;
            if (groupBox != null)
            {
                // 清除边框线
                //    e.Graphics.Clear(groupBox.BackColor);

                // 绘制背景图片
                if (groupBox.BackgroundImage != null)
                {
                    e.Graphics.DrawImage(groupBox.BackgroundImage, groupBox.ClientRectangle);
                }
            }
        }
        public void Pnl_Ctrl_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(DataItem)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else if (e.Data.GetDataPresent(typeof(ByteCtrl)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        menuform ctrlnumform;
        private void TargetGroupBox_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    // 设置 Panel 的 Tag 属性为当前的 GroupBox
                    pnl_ctrlnum.Tag = sender as GroupBox;
                    // 创建 menuform 实例并传入 Panel
                    ctrlnumform = new(pnl_ctrlnum, "使用者控件數量", btn_ctrlnumset, null, false, null, sender);
                }
            }
            catch (Exception ex) { return; }
        }
        private void DescriptionLabel_DoubleClick(object sender, EventArgs e)
        {
            Label label = sender as Label;
            if (label != null)
            {
                TextBox textBox = new TextBox
                {
                    Text = label.Text,
                    Location = label.Location,
                    Size = new(150, 40),
                    Font = label.Font,
                    BackColor = Color.Beige,
                };
                textBox.LostFocus += (s, evt) => UpdateLabel(textBox, label);
                textBox.KeyDown += (s, evt) =>
                {
                    if (evt.KeyCode == Keys.Enter)
                    {
                        UpdateLabel(textBox, label);
                    }
                };
                label.Parent.Controls.Add(textBox);
                textBox.BringToFront();
                textBox.Focus();
                Control parent = label.Parent;
                while (parent != null && !(parent is GroupBox))
                {
                    parent = parent.Parent;
                }

                // 如果找到了GroupBox
                if (parent is GroupBox groupBox)
                {
                    // 调用adjust_lbl_btn_postion方法
                    Adjust_Btn_Lbl_Positions(groupBox);
                }
                label.Visible = false;
            }
        }
        private void UpdateLabel(TextBox textBox, Label label)
        {
            if (textBox.Text != "")
            {
                label.Text = textBox.Text;
            }
            else
            {
                label.Text = label.Text;
            }
            label.Visible = true;
            textBox.Parent.Controls.Remove(textBox);
        }
        public void Remove_ByteCtrl(string n)
        {
            GroupBox emptyGroupBox = null;

            // 遍历 Panel 控件中的所有子控件
            foreach (Control control in pnl_ctrl.Controls.OfType<GroupBox>())
            {
                foreach (Control subControl in control.Controls.OfType<Control>().ToList())
                {
                    // 检查控件名称是否与指定名称匹配
                    if (subControl.Name == n)
                    {
                        // 从父控件中移除匹配的子控件
                        control.Controls.Remove(subControl);
                        subControl.Dispose();
                    }
                }
                // 如果 GroupBox 没有其他控件，标记为 emptyGroupBox
                if (control.Controls.Count == 1)
                {
                    emptyGroupBox = (GroupBox)control;
                }
                else
                {
                    if (control is GroupBox groupBox)
                    {
                        groupBox.AutoSize = true;
                        //  Adjust_ByteCtrl_inGroupBox_Positions(groupBox);          
                        Adjust_Ctrl_Positions(groupBox);
                        Adjust_Btn_Lbl_Positions(groupBox);
                        if (groupBox.Controls.Count == 2)
                        {
                            Adjust_Btn_Lbl_Positions(groupBox, 1);
                        }

                    }
                }
            }
            // 删除空的 GroupBox
            if (emptyGroupBox != null)
            {
                pnl_ctrl.Controls.Remove(emptyGroupBox);
                emptyGroupBox.Dispose();
            }
            if (isselectdic.ContainsKey(n))
            {
                isselectdic[n] = false;
            }
            Adjust_ByteCtrl_GroupBoxPositions();
            lsb_ctrl_xmlfile_data.Invalidate();

            //    Adjust_ByteCtrl_GroupBoxPositions();
            // 更新界面
            initclear();
            pnl_ctrl.Refresh();
        }
        public void Adjust_Ctrl_Positions(GroupBox g, int n = 5)
        {
            int left = 15;
            int top = 85;
            int spacing = 5; // 控件之间的间隔
            int maxWidth = g.Width; // 父容器的宽度
            int controlsPerRow = n; // 每行最多控件數
            int currentRow = 0;
            int currentColumn = 0;
            int initialHeight = g.Height; // 初始高度

            foreach (Control ctrl in g.Controls)
            {
                if (ctrl is ByteCtrl)
                {
                    if (currentColumn >= controlsPerRow)
                    {
                        currentColumn = 0; // 重置列計數器
                        currentRow++; // 移動到下一行
                    }

                    left = 15 + (currentColumn * (ctrl.Width + spacing)); // 計算左邊位置
                    top = 85 + (currentRow * (ctrl.Height + spacing)); // 計算頂部位置

                    ctrl.Location = new Point(left, top);
                    currentColumn++;
                }
            }

            // 計算新的高度，根據行數調整高度
            int newHeight = 60 + (currentRow + 1) * (60 + spacing); // +1 因為 currentRow 是從 0 開始計算的
            g.Height = Math.Max(initialHeight, newHeight); // 更新 GroupBox 高度，保證不小於初始高度

            //Adjust_Btn_Lbl_Positions(g);
        }
        public void Adjust_Btn_Lbl_Positions(GroupBox groupBox, int n = 0)
        {
            int btnheight = 50;
            int groupBoxWidth = groupBox.Width;
            Label descriptionLabel = groupBox.Controls.OfType<Label>().FirstOrDefault();
            if (descriptionLabel != null)
            {
                descriptionLabel.Location = new Point(groupBoxWidth / 2 - 65, 20);
                if (n == 1)
                {
                    descriptionLabel.Location = new Point(15, 20);
                }
                Console.WriteLine($"Description Label Position: {descriptionLabel.Location}");
            }
            groupBox.Refresh(); // 强制重绘GroupBox
        }
        public void Adjust_ByteCtrl_GroupBoxPositions()
        {
            int left = 15;
            int top = 15;
            int spacing = 10; // GroupBox 之间的间隔
            int maxWidth = pnl_ctrl.Width; // 父容器的宽度
            int currentRowHeight = 0;

            int count = 0;

            foreach (Control ctrl in pnl_ctrl.Controls)
            {
                if (ctrl is GroupBox groupBox)
                {
                    // 判断是否需要换行
                    if (left + groupBox.Width > maxWidth)
                    {
                        left = 15; // 重置到左边界
                        top += currentRowHeight + spacing; // 移动到下一行
                        currentRowHeight = 0; // 重置当前行的高度
                    }

                    groupBox.Location = new Point(left, top);
                    left += groupBox.Width + spacing; // 更新左边界位置
                    currentRowHeight = Math.Max(currentRowHeight, groupBox.Height); // 更新当前行的高度
                    Adjust_Btn_Lbl_Positions(groupBox);
                    count++;
                }
            }
        }
        //public void Rename_ByteCtrl_GroupBox(GroupBox groupBox)
        //{
        //    string newName = Prompt.ShowDialog("NewName: ", "Rename GroupBox", groupBox.Text);
        //    if (!string.IsNullOrWhiteSpace(newName))
        //    {
        //        LogHelper.WriteLog("ReName Gruupbox :" + newName + " sccuess");
        //        groupBox.Text = newName;
        //    }
        //}
        public void Reset_ByteCtrl()
        {
            // 重置選取狀態字典
            isselectdic.Clear();
            itemCreatedStatus.Clear();

            // 還原 lsb_ctrl_xmlfile_data 的初始狀態
            lsb_ctrl_xmlfile_data.Items.Clear();
            foreach (var item in datalist)
            {
                lsb_ctrl_xmlfile_data.Items.Add(item);
            }

            // 重置選取狀態
            lsb_ctrl_xmlfile_data.SelectedIndex = -1;
            lsb_ctrl_xmlfile_data.Invalidate(); // 強制重繪ListBox

            // 清空 pnl_ctrl 上的所有 GroupBox 和 ByteCtrl 控件
            foreach (Control ctrl in pnl_ctrl.Controls)
            {
                if (ctrl is GroupBox groupBox)
                {
                    groupBox.Controls.Clear();
                }

            }
            pnl_ctrl.Controls.Clear();
            initclear();
            // 輸出還原成功訊息
            rtb_console.AppendText("訊息 : 成功清除使用者控制元件。" + DateTime.Now.ToString("HH:mm:ss") + Environment.NewLine);
            RichtextboxScroll();
        }
        //........................config.............................
        public static string configname;
        private FileStream configFileStream;
        private void ReleaseConfigFile()
        {
            if (configFileStream != null)
            {
                configFileStream.Close();
                configFileStream.Dispose();
                configFileStream = null;
                configname = "";
                Console.WriteLine("Config file released.");
            }
            else
            {
                Console.WriteLine("No config file is currently open.");
            }
        }
        public void Open_Config(string file = null)
        {
            OpenConfig = true;
            isselectdic.Clear();
            if (file == null)
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "設定檔 (*.config)|*.config|所有檔案 (*.*)|*.*";
                    openFileDialog.Title = "載入介面設定檔";

                    openFileDialog.InitialDirectory = xmlFolderPath;

                    LogHelper.WriteLog("OpenConfig Start");
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        if (!File.Exists(openFileDialog.FileName))
                        {
                            LogHelper.WriteLog("Error : .config is Null");
                            MessageBox.Show("找不到設定檔。");
                            return;
                        }
                        string directoryPath = "";
                        directoryPath = Path.GetDirectoryName(openFileDialog.FileName);
                        configname = openFileDialog.FileName;

                        xmlFolderPath = directoryPath;
                        Properties.Settings.Default.UserSelectedPath = xmlFolderPath;
                        Properties.Settings.Default.Save();

                        ControlConfig config;

                        using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open))
                        {
                            configFileStream = fs;
                            XmlSerializer serializer = new XmlSerializer(typeof(ControlConfig));
                            config = (ControlConfig)serializer.Deserialize(fs);
                        }

                        pnl_ctrl.Controls.Clear();
                        foreach (var groupBoxConfig in config.GroupBoxes)
                        {
                            GroupBox groupBox = new GroupBox
                            {
                                Text = groupBoxConfig.GroupBoxName,
                                Location = groupBoxConfig.Location,
                                AutoSize = true,
                                //  FlatStyle = FlatStyle.Standard,
                                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                                Padding = new Padding(10),
                                Margin = new Padding(5)
                            };
                            setgbx(groupBox);
                            groupBox.MouseDown += TargetGroupBox_MouseDown; ;
                            if (!string.IsNullOrEmpty(groupBoxConfig.Description))
                            {
                                Label descriptionLabel = new Label
                                {
                                    Text = groupBoxConfig.Description,
                                    Font = new Font("微軟正黑體", 17, FontStyle.Bold),
                                    AutoSize = true
                                };
                                groupBox.Controls.Add(descriptionLabel);
                                descriptionLabel.DoubleClick += DescriptionLabel_DoubleClick;
                            }
                            foreach (var byteCtrlConfig in groupBoxConfig.ByteCtrls)
                            {
                                DataItem dataItem = datalist.FirstOrDefault(item => item.Name == byteCtrlConfig.Name);
                                if (dataItem == null)
                                {
                                    dataItem = new DataItem { Name = byteCtrlConfig.Name, Type = byteCtrlConfig.Type, Size = (byteCtrlConfig.Size).ToString(), lsb = (byteCtrlConfig.Lsb).ToString(), msb = (byteCtrlConfig.Msb).ToString(), Endian = returnend(byteCtrlConfig.lit) };
                                    datalist.Add(dataItem);
                                }
                                rtb_su.AppendText("載入控件ID: " + int.Parse(byteCtrlConfig.MessageID).ToString("X2") + Environment.NewLine);
                                rtbScroll(rtb_su);
                                ByteCtrl byteCtrl = new ByteCtrl(dataItem, byteCtrlConfig.XmlFileName, byteCtrlConfig.MessageID, byteCtrlConfig.Type, byteCtrlConfig.Size, byteCtrlConfig.Lsb, byteCtrlConfig.Msb, byteCtrlConfig.portID, byteCtrlConfig.mode, this, byteCtrlConfig.Signed, byteCtrlConfig.lit)
                                {
                                    Location = byteCtrlConfig.Location
                                };
                                byteCtrl.AddDragEventHandlers(byteCtrl.Controls);
                                groupBox.Controls.Add(byteCtrl);
                                XmltoCtrl(byteCtrl);

                                string ctrlnameWithID = $"{dataItem.Name}_{byteCtrlConfig.MessageID}";

                                if (!isselectdic.ContainsKey(ctrlnameWithID))
                                {
                                    isselectdic.Add(ctrlnameWithID, true);
                                }
                                else
                                {
                                    isselectdic[ctrlnameWithID] = true;
                                }

                            }

                            initclear();
                            pnl_ctrl.Controls.Add(groupBox);
                            Adjust_Ctrl_Positions(groupBox);
                            Adjust_Btn_Lbl_Positions(groupBox);
                        }
                        Adjust_ByteCtrl_GroupBoxPositions();
                        Isloadconfig = true;
                        Load_Xml_FileList(lsb_ctrl_xmlfile);
                        //Get_Ctrl_Value();
                        if (isautosave == true)
                        {
                            autosave();
                        }
                        isautosave = false;
                        LogHelper.WriteLog("Load Config Sccuess");
                        rtb_console.AppendText("訊息 : 成功載入介面設定檔。" + DateTime.Now.ToString("HH:mm:ss") + Environment.NewLine);
                        RichtextboxScroll();
                    }
                }
            }
            else
            {
                OpenConfig = true;
                ControlConfig config;
                using (FileStream fs = new FileStream(file, FileMode.Open))
                {
                    configFileStream = fs;
                    XmlSerializer serializer = new XmlSerializer(typeof(ControlConfig));
                    config = (ControlConfig)serializer.Deserialize(fs);
                }
                pnl_ctrl.Controls.Clear();
                foreach (var groupBoxConfig in config.GroupBoxes)
                {
                    GroupBox groupBox = new GroupBox
                    {
                        Text = groupBoxConfig.GroupBoxName,
                        Location = groupBoxConfig.Location,
                        AutoSize = true,
                        //  FlatStyle = FlatStyle.Standard,
                        AutoSizeMode = AutoSizeMode.GrowAndShrink,
                        Padding = new Padding(10),
                        Margin = new Padding(5)
                    };
                    setgbx(groupBox);
                    groupBox.MouseDown += TargetGroupBox_MouseDown; ;
                    if (!string.IsNullOrEmpty(groupBoxConfig.Description))
                    {
                        Label descriptionLabel = new Label
                        {
                            Text = groupBoxConfig.Description,
                            Font = new Font("微軟正黑體", 17, FontStyle.Bold),
                            AutoSize = true
                        };
                        groupBox.Controls.Add(descriptionLabel);
                        descriptionLabel.DoubleClick += DescriptionLabel_DoubleClick;
                    }
                    foreach (var byteCtrlConfig in groupBoxConfig.ByteCtrls)
                    {
                        DataItem dataItem = datalist.FirstOrDefault(item => item.Name == byteCtrlConfig.Name);
                        if (dataItem == null)
                        {
                            dataItem = new DataItem { Name = byteCtrlConfig.Name, Type = byteCtrlConfig.Type, Size = (byteCtrlConfig.Size).ToString(), lsb = (byteCtrlConfig.Lsb).ToString(), msb = (byteCtrlConfig.Msb).ToString(), Endian = returnend(byteCtrlConfig.lit) };
                            datalist.Add(dataItem);
                        }
                        rtb_su.AppendText("載入控件ID: " + int.Parse(byteCtrlConfig.MessageID).ToString("X2") + Environment.NewLine);
                        rtbScroll(rtb_su);
                        ByteCtrl byteCtrl = new ByteCtrl(dataItem, byteCtrlConfig.XmlFileName, byteCtrlConfig.MessageID, byteCtrlConfig.Type, byteCtrlConfig.Size, byteCtrlConfig.Lsb, byteCtrlConfig.Msb, byteCtrlConfig.portID, byteCtrlConfig.mode, this, byteCtrlConfig.Signed, byteCtrlConfig.lit)
                        {
                            Location = byteCtrlConfig.Location
                        };
                        byteCtrl.AddDragEventHandlers(byteCtrl.Controls);
                        groupBox.Controls.Add(byteCtrl);
                        XmltoCtrl(byteCtrl);

                        string ctrlnameWithID = $"{dataItem.Name}_{byteCtrlConfig.MessageID}";

                        if (!isselectdic.ContainsKey(ctrlnameWithID))
                        {
                            isselectdic.Add(ctrlnameWithID, true);
                        }
                        else
                        {
                            isselectdic[ctrlnameWithID] = true;
                        }

                    }
                    initclear();
                    pnl_ctrl.Controls.Add(groupBox);
                    Adjust_Ctrl_Positions(groupBox);
                    Adjust_Btn_Lbl_Positions(groupBox);
                }
                Adjust_ByteCtrl_GroupBoxPositions();
                Isloadconfig = true;
                Load_Xml_FileList(lsb_ctrl_xmlfile);
                //Get_Ctrl_Value();
                if (isautosave == true)
                {
                    autosave();
                }
                isautosave = false;
                LogHelper.WriteLog("Load Config Sccuess");
                rtb_console.AppendText("訊息 : 成功載入介面設定檔。" + DateTime.Now.ToString("HH:mm:ss") + Environment.NewLine);
                RichtextboxScroll();
            }
        }
        public void autosave()
        {
            int gbx = 0;
            foreach (Control ctrl in pnl_ctrl.Controls)
            {
                if (ctrl is GroupBox g)
                {
                    gbx++;
                }
            }

            if (!OpenConfig && gbx == 0)
            {
                return;
            }

            ControlConfig config = new ControlConfig();
            foreach (GroupBox groupBox in pnl_ctrl.Controls.OfType<GroupBox>())
            {
                GroupBoxConfig groupBoxConfig = new GroupBoxConfig
                {
                    GroupBoxName = groupBox.Text,
                    Location = groupBox.Location
                };

                Label descriptionLabel = groupBox.Controls.OfType<Label>().FirstOrDefault();
                if (descriptionLabel != null)
                {
                    groupBoxConfig.Description = descriptionLabel.Text;
                }

                foreach (ByteCtrl byteCtrl in groupBox.Controls.OfType<ByteCtrl>())
                {
                    ByteCtrlConfig byteCtrlConfig = new ByteCtrlConfig
                    {
                        Name = byteCtrl.valueName,
                        XmlFileName = byteCtrl.XmlFileName,
                        MessageID = byteCtrl.MessageID,
                        Type = byteCtrl.Type,
                        Location = byteCtrl.Location,
                        Size = byteCtrl.size,
                        Lsb = byteCtrl.lsb,
                        Msb = byteCtrl.msb,
                        Signed = byteCtrl.Signed,
                        portID = byteCtrl.portID,
                        mode = byteCtrl.mode,
                        lit = byteCtrl.Islit
                    };
                    groupBoxConfig.ByteCtrls.Add(byteCtrlConfig);
                }
                config.GroupBoxes.Add(groupBoxConfig);
            }
            using (FileStream fs = new FileStream(configname, FileMode.Create)) // 使用 configname 保存文件
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ControlConfig));
                serializer.Serialize(fs, config);
            }

            LogHelper.WriteLog("Save Config Sccuess");
            rtb_console.AppendText("訊息 : 成功載入儲存設定檔。" + DateTime.Now.ToString("HH:mm:ss") + Environment.NewLine);
            RichtextboxScroll();
        }
        public void copyxml(string path)
        {
            try
            {
                string sourcePath = xmlFolderPath; 

                string[] files = Directory.GetFiles(sourcePath, "*.xml*", SearchOption.AllDirectories);
                foreach (string file in files)
                {
                    // 获取文件名
                    string fileName = Path.GetFileName(file);
                    // 目标文件路径（直接放到目标目录下）
                    string destinationFile = Path.Combine(path, fileName);

                    // 复制文件并覆盖
                    File.Copy(file, destinationFile, true);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("錯誤: " + ex.Message);
            }
        }
        public void Save_Config()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                string userpath = Properties.Settings.Default.UserSelectedPath;
                if (!string.IsNullOrEmpty(userpath))
                {
                    saveFileDialog.InitialDirectory = userpath;
                }
                saveFileDialog.Filter = "設定檔 (*.config)|*.config|所有檔案 (*.*)|*.*";
                saveFileDialog.DefaultExt = "config";
                saveFileDialog.AddExtension = true;
                saveFileDialog.Title = "儲存介面設定檔";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ControlConfig config = new ControlConfig();

                    foreach (GroupBox groupBox in pnl_ctrl.Controls.OfType<GroupBox>())
                    {
                        GroupBoxConfig groupBoxConfig = new GroupBoxConfig
                        {
                            GroupBoxName = groupBox.Text,
                            Location = groupBox.Location
                        };

                        Label descriptionLabel = groupBox.Controls.OfType<Label>().FirstOrDefault();
                        if (descriptionLabel != null)
                        {
                            groupBoxConfig.Description = descriptionLabel.Text;
                        }

                        foreach (ByteCtrl byteCtrl in groupBox.Controls.OfType<ByteCtrl>())
                        {
                            ByteCtrlConfig byteCtrlConfig = new ByteCtrlConfig
                            {
                                Name = byteCtrl.valueName,
                                XmlFileName = byteCtrl.XmlFileName,
                                MessageID = byteCtrl.MessageID,
                                Type = byteCtrl.Type,
                                Location = byteCtrl.Location,
                                Size = byteCtrl.size,
                                Lsb = byteCtrl.lsb,
                                Msb = byteCtrl.msb,
                                Signed = byteCtrl.Signed,
                                portID = byteCtrl.portID,
                                mode = byteCtrl.mode,
                                lit = byteCtrl.Islit
                            };
                            groupBoxConfig.ByteCtrls.Add(byteCtrlConfig);
                        }
                        config.GroupBoxes.Add(groupBoxConfig);
                    }

                    using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(ControlConfig));
                        serializer.Serialize(fs, config);
                    }

                    string directoryPath = Path.GetDirectoryName(saveFileDialog.FileName);
                    Properties.Settings.Default.UserSelectedPath = directoryPath;
                    copyxml(directoryPath);
                    Load_Xml_FileList(lsb_ctrl_xmlfile);
                    xmlFolderPath = directoryPath;
                    Properties.Settings.Default.Save();
                    configname = saveFileDialog.FileName;
                    LogHelper.WriteLog("Save Config Sccuess");
                    rtb_console.AppendText("訊息 : 成功載入儲存設定檔。" + DateTime.Now.ToString("HH:mm:ss") + Environment.NewLine);
                    RichtextboxScroll();
                }
            }
        }
        //............................test...........................
        public byte[] test2(string ccom)
        {
            // 获取选择的XML文件路径
            string selectedFile = Path.Combine(xmlFolderPath, ccom);

            // 读取XML文件内容
            XmlSerializer serializer = new XmlSerializer(typeof(DataItemsContainer));
            DataItemsContainer container;

            using (StreamReader reader = new StreamReader(selectedFile))
            {
                container = (DataItemsContainer)serializer.Deserialize(reader);
            }

            // 初始化一个8字节的数组
            byte[] result = new byte[8];
            string binaryString = "";
            bool isLitEndian = false;
            // 遍历数据项并计算其位位置和大小
            foreach (var item in container.DataItems)
            {
                uint size = uint.Parse(item.Size);
                uint lsb = uint.Parse(item.lsb);
                uint msb = uint.Parse(item.msb);
                string type = item.Type;
                isLitEndian = item.Endian == "lit"; // 假设 Endian 属性值为 "lit" 或 "big"

                LogHelper.WriteLog("DataWork: ID:" + container.MessageID + " Size:" + size + " lsb: " + lsb + " msb: " + msb + " type: " + type);

                if (string.IsNullOrEmpty(item.Value))
                {
                    binaryString += new string('0', (int)size);
                }
                else
                {
                    uint value;
                    try
                    {
                        if (item.Value.StartsWith("0x"))
                        {
                            value = Convert.ToUInt32(item.Value.Substring(2), 16);
                        }
                        else
                        {
                            value = uint.Parse(item.Value);
                        }

                        // 检查 value 是否在 size 位能表示的范围内
                        ulong maxValue;
                        if (size < 32)
                        {
                            maxValue = (1UL << (int)size) - 1; // size 位能表示的最大值
                        }
                        else
                        {
                            maxValue = uint.MaxValue; // 當 size 是 32 時，最大值應該是 2^32 - 1
                        }

                        ulong uValue = Convert.ToUInt64(value);

                        if (uValue > maxValue)
                        {
                            LogHelper.WriteLog($"Value '{item.Value}' out of range for {size}-bit field.");
                            throw new ArgumentOutOfRangeException($"Value '{item.Value}' out of range for {size}-bit field.");
                        }

                        binaryString += Convert.ToString((long)uValue, 2).PadLeft((int)size, '0');
                    }
                    catch (Exception ex)
                    {
                        LogHelper.WriteLog($"Error : Out of range for {size}-bit field.");
                        rtb_console.AppendText("錯誤 : 請確認輸入之數值範圍。" + DateTime.Now.ToString("HH:mm:ss") + Environment.NewLine);
                        RichtextboxScroll();
                        return null; // 退出方法，表示处理失败
                    }
                }
            }

            // 确保二进制字符串长度是8的倍数
            while (binaryString.Length % 8 != 0)
            {
                binaryString = "0" + binaryString;
            }

            // 将二进制字符串转换为字节数组
            for (int i = 0; i < 8; i++)
            {
                string byteString = binaryString.Substring(i * 8, 8);
                result[i] = Convert.ToByte(byteString, 2);
            }

            // 如果需要小端字节序进行调整
            if (isLitEndian)
            {
                Array.Reverse(result);
            }

            // 格式化输出为十六进制字符串
            string rus = string.Join("-", result.Select(b => b.ToString("X2")));
            LogHelper.WriteLog(rus);
            return result;
        }
        public void test3(string portID, string Mode, string DLC, string extID, byte[] data)
        {
            try
            {
                CanbusPacket w = new CanbusPacket();
                uint eID = Convert.ToUInt32(ParseID(extID).ToString());
                w.portID = Byte.Parse(portID);
                w.DLC = Byte.Parse(DLC);
                w.extID = uint.Parse(eID.ToString());
                w.mode = Byte.Parse(Mode);
                byte[] d = new byte[int.Parse(DLC.ToString())];
                for (int i = 0; i < int.Parse(DLC.ToString()); i++)
                {
                    if (data != null)
                        d[i] = data[i];
                    else
                    {
                        return;
                    }
                }
                string n = "";
                for (int i = 0; i < int.Parse(DLC.ToString()); i++)
                {
                    n += d[i].ToString("X2") + ",";
                }
                LogHelper.WriteLog("訊息 : extID:" + eID.ToString() + ", Port ID:" + Byte.Parse(portID).ToString() + ", Mode:" + Byte.Parse(Mode).ToString() + "," + Byte.Parse(DLC).ToString() + " ,ExtID:" + eID.ToString() + "。 ");
                rtb_console.AppendText("訊息 : extID:" + eID.ToString() + ", Port ID:" + Byte.Parse(portID).ToString() + ", Mode:" + Byte.Parse(Mode).ToString() + "," + Byte.Parse(DLC).ToString() + " ,ExtID:" + eID.ToString() + "。 " + DateTime.Now.ToString("HH:mm:ss") + Environment.NewLine);
                LogHelper.WriteLog("訊息 : 傳送Data: {" + n + "}。");
                rtb_console.AppendText("訊息 : 傳送Data: {" + n + "}。" + DateTime.Now.ToString("HH:mm:ss") + Environment.NewLine);
                _isAskCan = true;
                RichtextboxScroll();
                SetCanRusID = eID.ToString();
                w.Data = d;
                _canpro?.WriteFrame(new object[] { w });
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog("Error :" + ex.Message);
            }
        }
        public void test4(string portID, string Mode, string DLC, string extID, byte[] data)
        {
            try
            {
                CanbusPacket w = new CanbusPacket();
                uint eID = Convert.ToUInt32(ParseID(extID).ToString());
                w.portID = Byte.Parse(portID);
                w.DLC = Byte.Parse(DLC);
                w.extID = uint.Parse(eID.ToString());
                w.mode = Byte.Parse(Mode);
                byte[] d = new byte[int.Parse(DLC.ToString())];
                for (int i = 0; i < int.Parse(DLC.ToString()); i++)
                {
                    if (data != null)
                        d[i] = data[i];
                    else
                    {
                        return;
                    }
                }
                string n = "";
                for (int i = 0; i < int.Parse(DLC.ToString()); i++)
                {
                    n += d[i].ToString("X2") + ",";
                }
                LogHelper.WriteLog("訊息 : extID:" + eID.ToString() + ", Port ID:" + Byte.Parse(portID).ToString() + ", Mode:" + Byte.Parse(Mode).ToString() + "," + Byte.Parse(DLC).ToString() + " ,ExtID:" + eID.ToString() + "。 ");
                rtb_console.AppendText("訊息 : extID:" + eID.ToString() + ", Port ID:" + Byte.Parse(portID).ToString() + ", Mode:" + Byte.Parse(Mode).ToString() + "," + Byte.Parse(DLC).ToString() + " ,ExtID:" + eID.ToString() + "。 " + DateTime.Now.ToString("HH:mm:ss") + Environment.NewLine);
                LogHelper.WriteLog("訊息 : 傳送Data: {" + n + "}。");
                rtb_console.AppendText("訊息 : 傳送Data: {" + n + "}。" + DateTime.Now.ToString("HH:mm:ss") + Environment.NewLine);
                RichtextboxScroll();
                SetCanRusID = eID.ToString();
                w.Data = d;
                _canpro?.WriteFrame(new object[] { w });
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog("Error : " + ex.Message);
            }
        }
        public string SetCanRusID
        {
            get; set;
        }
        private uint ParseID(string ID)
        {
            uint rus;
            if (ID.StartsWith("0x"))
            {
                rus = Convert.ToUInt32(ID.Substring(2), 16);
                return rus;
            }
            else
            {
                rus = Convert.ToUInt32(ID);
                return rus;
            }
        }
        private void ExitTimer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity >= 0.098)
            {
                this.Opacity -= 0.196;
            }
            else
            {
                Properties.Settings.Default.AutoConfig = cbx_autoconfig.Checked;
                if (configname != null)
                {
                    Properties.Settings.Default.UserConfig = configname;
                }
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
                this.Show();
                this.Activate();
                //   Properties.Settings.Default.UpdateInformation = true;
                Properties.Settings.Default.UpdateInformation = CheckUpdate(Properties.Settings.Default.UpdateInformation);

                return;
            }
            //  this.Opacity = 0.92;
        }
        //.......................RichtextboxScroll...................
        public void RichtextboxScroll()
        {
            rtb_console.Select();
            rtb_console.Select(rtb_console.TextLength, 0);
            rtb_console.ScrollToCaret();
        }
        public void rtbScroll(RichTextBox rtb)
        {
            rtb.Select();
            rtb.Select(rtb.TextLength, 0);
            rtb.ScrollToCaret();
        }
        //.....................APP_style_n'_event....................
        public void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (beginMove && IsMax != true)
                {
                    this.Left += MousePosition.X - currentXPosition; //根據滑鼠的 X 座標確定窗體的 X 座標
                    this.Top += MousePosition.Y - currentYPosition; //根據滑鼠的 Y 座標確定窗體的 Y 座標
                    currentXPosition = MousePosition.X;
                    currentYPosition = MousePosition.Y;
                }
            }
            catch (Exception ex) { return; }
        }
        public void lsb_MouseMove(object sender, MouseEventArgs e)
        {
            if (beginMove)
            {
                try
                {
                    floatingForm.Left += MousePosition.X - currentXPosition; //根據滑鼠的 X 座標確定窗體的 X 座標
                    floatingForm.Top += MousePosition.Y - currentYPosition; //根據滑鼠的 Y 座標確定窗體的 Y 座標
                    currentXPosition = MousePosition.X;
                    currentYPosition = MousePosition.Y;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }
        }
        public void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    beginMove = true;
                    currentXPosition = MousePosition.X; //滑鼠的 X 座標為當前窗體左上角 X 座標參考
                    currentYPosition = MousePosition.Y; //滑鼠的 Y 座標為當前窗體左上角 Y 座標參考
                }
            }
            catch (Exception ex) { return; }

        }
        public void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    currentXPosition = 0; //設定初始狀態
                    currentYPosition = 0; //設定初始狀態
                    beginMove = false;
                }
            }
            catch (Exception ex) { return; }
        }
        public void lbl_X_Click(object sender, EventArgs e)
        {
            ExitTimer.Start();
        }
        public void lbl_X_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_X.ForeColor = Color.White;
            lbl_X.Font = new("Corbel", 16, FontStyle.Bold);
        }
        public void lbl_X_MouseLeave(object sender, EventArgs e)
        {
            lbl_X.Font = new("Corbel", 15, FontStyle.Regular);
            lbl_X.ForeColor = Color.FromArgb(100, 196, 154, 138);
        }
        public void Main_Deactivate(object sender, EventArgs e)
        {
            Panel_Title.BackgroundImage = Properties.Resources.title_2;
        }
        public void Main_Activated(object sender, EventArgs e)
        {
            //Panel_Title.BackColor = Color.DodgerBlue;
            Panel_Title.BackgroundImage = Properties.Resources.title_1;
        }
        //.......................Float_BytectrlList....................
        public void Btn_drop_Click(object sender, EventArgs e)
        {
            if (floatingForm != null)
            {
                floatingForm.Controls.Remove(pnl_lsb);

                pnl_control.Controls.Add(pnl_lsb);
                if (IsMax == true)
                {
                    pnl_ctrl.Size = new Size(pnl_ctrl.Width - 198, 833);
                    pnl_ctrl.Location = new Point(198, 0);
                }
                else
                {
                    pnl_lsb.Location = originalPnlLsbLocation;
                    pnl_ctrl.Location = new Point(189, 0);
                    pnl_ctrl.Size = new Size(1165, 594);
                }
                pnl_lsb.BorderStyle = BorderStyle.None;
                btn_ID.Visible = true;
                btn_clear_pnl.Location = new Point(20, pnl_ctrl.Height - 50);
                floatingForm.Close();
                floatingForm = null;
            }
        }
        public void FloatingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (floatingForm != null && !pnl_control.Controls.Contains(pnl_lsb))
            {

                if (IsMax == true)
                {

                }
                else
                {
                    pnl_lsb.Location = originalPnlLsbLocation;
                    pnl_ctrl.Location = loc.Pctrl_Lo;
                    pnl_ctrl.Size = loc.Pctrl_Si;
                }
                pnl_control.Controls.Add(pnl_lsb);
                floatingForm = null;

            }
            Isfly = false;
        }
        menuform MForm;
        public void itemBaudClick()
        {
            MForm = new(pnl_baud, "Connect Setting", btn_baudset);
        }
        public void iteminfoClick()
        {
            MForm = new(pnl_info, "關於Grid Can", btn_infook, Properties.Resources.back);
        }
        public void itemlanClick()
        {
            MForm = new(pnl_lan, "語言", btn_lanok);
        }
        public void DevClick()
        {
            MForm = new(pnl_supersu, "開發者功能測試", btn_suset, null, true, tb_console);
        }
        public void CcomClick()
        {
            MForm = new(pnl_ccom, "控制指令(Beta)", btn_ccomset);
        }
        public void NewClick()
        {
            Reset_ByteCtrl();
            ReleaseConfigFile();
        }
        public void Btn_fly_Click(object sender, EventArgs e)
        {
            originalPnlLsbLocation = pnl_lsb.Location;

            floatingForm = new Form
            {
                StartPosition = FormStartPosition.CenterParent,
                //     BackgroundImage = Properties.Resources.S__6471682,
                Size = new Size(182, 594),
                FormBorderStyle = FormBorderStyle.None,
                BackColor = Color.Beige,
                ShowInTaskbar = false,
                Font = new Font("Microsoft JhengHei UI", 9, FontStyle.Bold),
                //   BackColor = Color.AliceBlue,
                Opacity = 0.98,
                TopMost = true,
            };
            Isfly = true;

            if (IsMax == true)
            {
                pnl_ctrl.Location = originalPnlLsbLocation;
                pnl_ctrl.Size = new Size(1893, 833);
            }
            else
            {
                pnl_ctrl.Location = originalPnlLsbLocation;
                pnl_ctrl.Size = new Size(1354, 594);
            }

            pnl_lsb.Location = new Point(0, 0); // 将 pnl_lsb 移动到浮动窗口的起始位置
            pnl_lsb.BackColor = Color.Transparent;
            pnl_lsb.BorderStyle = BorderStyle.FixedSingle;
            floatingForm.Controls.Add(pnl_lsb);
            btn_clear_pnl.Location = new Point(20, pnl_ctrl.Height - 50);
            btn_ID.Visible = false;

            floatingForm.FormClosing += FloatingForm_FormClosing;
            floatingForm.Show();
        }
        //.............................................................
        public void SetButtonMouseEnterEvent(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is Button button)
                {
                    if (control != btn_clear_pnl && control != btn_ID)
                    {
                        button.BackgroundImage = Properties.Resources.btn2;
                        button.BackgroundImageLayout = ImageLayout.Stretch;
                        button.MouseEnter += Button_MouseEnter;
                        button.MouseLeave += Button_MouseLeave;
                    }
                }
                // 遞歸處理容器控件
                if (control.HasChildren)
                {
                    SetButtonMouseEnterEvent(control.Controls);
                }
            }
        }
        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                button.BackgroundImage = Properties.Resources.btn2;
                button.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                button.BackgroundImage = Properties.Resources.btn1;
                button.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }
        SetForm set;
        public void setformshow()
        {
            if (issetformshow != true)
            {
                set = new(this);
                set.Show();
            }
            else
            {
                set.Activate();
                return;
            }
        }
        public void btn_dgv_Click(object sender, EventArgs e)
        {
            setformshow();
        }
        public void btn_Exit_Click(object sender, EventArgs e)
        {
            ExitTimer.Start();
        }
        public void btn_Open_Click(object sender, EventArgs e)
        {
            Select_FilePath();
        }
        public void btn_canopen_Click(object sender, EventArgs e)
        {
            CAN(IsOpenCan);
        }
        public void btn_getcandata_Click(object sender, EventArgs e)
        {
            Init_Cbb_Port(GetCanDeviceNum());
        }
        private void btn_ID_Click(object sender, EventArgs e)
        {
            if (IsShowID == false)
            {
                IsShowID = true;
                return;
            }
            if (IsShowID == true)
            {
                IsShowID = false;
                return;
            }
        }
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (OpenConfig == true)
            //{
            //    autosave();
            //}
            if (configname == "")
            {
                cbx_autoconfig.Checked = false;
            }
            Properties.Settings.Default.BaudRateIndex = cbb_baud0.SelectedIndex;
            Properties.Settings.Default.Save();
        }
        private void btn_lan_Click(object sender, EventArgs e)
        {
            int selectedIndex = cbb_lan.SelectedIndex;
            changelan(selectedIndex);

            // 保存用户选择的语言
            string selectedLanguage = selectedIndex == 0 ? "zh-TW" : "en";
            IsOpenCan = IsOpenCan;
            Properties.Settings.Default.UserLan = selectedLanguage;
            Properties.Settings.Default.Save();
        }
        private void btn_ID_MouseMove(object sender, MouseEventArgs e)
        {
            btn_ID.BackgroundImage = Properties.Resources.btnID1;
        }
        private void btn_ID_MouseLeave(object sender, EventArgs e)
        {
            btn_ID.BackgroundImage = Properties.Resources.btnID;
        }
        private void tb_console_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_consoleClick(tb_console);
            }
        }
        private void btn_ccomopen_Click(object sender, EventArgs e)
        {
            openccom();
        }
        private void btn_ccomsave_Click(object sender, EventArgs e)
        {
            saveccom();
        }
        private void btn_readccom_Click(object sender, EventArgs e)
        {
            test3(tbx_Pid.Text, "1", "4", tbx_ID.Text, test2(ccomxmlfilename));
        }
        private void btn_writeccom_Click(object sender, EventArgs e)
        {
            test4(tbx_Pid.Text, "1", "8", tbx_ID.Text, test2(ccomxmlfilename));
        }
        public void Btn_ctrlsave_Click(object sender, EventArgs e)
        {
            if (configname != "")
            {
                autosave();
            }
            else
            {
                Save_Config();
            }
        }
        public void Btn_ctrlopen_Click(object sender, EventArgs e)
        {
            Open_Config();
        }
    }
    [XmlRoot("DataItems")]
    public class DataItemsContainer
    {
        [XmlElement("MessageID")]
        public string MessageID { get; set; }
        [XmlElement("PortID")]
        public string PortID { get; set; }
        [XmlElement("Mode")]
        public string Mode { get; set; }
        [XmlElement("DataItem")]
        public List<DataItem> DataItems { get; set; }
    }
    [XmlRoot("CCom")]

    public static class EventManager
    {
        public delegate void DataReceivedHandler(int id, int portid, byte[] data);
        public static event DataReceivedHandler OnDataReceived;
        public static void RaiseDataReceived(int id, int portid, byte[] data)
        {
            OnDataReceived?.Invoke(id, portid, data);
        }
    }
    public static class Prompt
    {
        public static bool beginMove = false;
        public static int currentXPosition;
        public static int currentYPosition;
        public static string ShowDialog(string text, string caption, string defaultValue = "")
        {
            Form prompt = new Form()
            {
                Width = 300,
                Height = 100,
                Opacity = 0.93,
                MinimizeBox = false,
                MaximizeBox = false,
                FormBorderStyle = FormBorderStyle.None,
                Text = caption,
                Icon = Properties.Resources.icco,
                StartPosition = FormStartPosition.CenterScreen,
                Font = new Font("微軟正黑體", 9, FontStyle.Regular),
                BackColor = Color.Beige,
            };
            prompt.Paint += (sender, e) => RoundedForm_Paint(prompt, e);
            Panel p = new Panel() { Left = 0, Top = 0, Height = 31, Width = 300, BackgroundImage = Properties.Resources.title_1, BackgroundImageLayout = ImageLayout.Stretch };
            Label lbl_title = new Label() { Left = 29, Width = 150, Top = 2, Font = new Font("微軟正黑體", 11, FontStyle.Bold), BackColor = Color.Transparent, ForeColor = Color.White };
            Label lbl_X = new Label() { Left = 275, Height = 28, Top = 2, Font = new Font("Corbel", 17, FontStyle.Regular), BackColor = Color.Transparent, ForeColor = Color.FromArgb(100, 196, 154, 138) };
            lbl_title.Text = "RENAME";
            lbl_X.Text = "X";
            lbl_title.Font = new Font("微軟正黑體", 17, FontStyle.Bold);
            PictureBox ptb = new PictureBox();
            ptb.Size = new Size(25, 25);
            ptb.Location = new Point(3, 3);
            ptb.Image = Properties.Resources.ll_removebg_preview1;
            ptb.SizeMode = PictureBoxSizeMode.Zoom;
            ptb.BackColor = Color.Transparent;
            p.Controls.Add(ptb);

            lbl_X.MouseMove += (sender, e) =>
            {
                lbl_X.ForeColor = Color.White;
                lbl_X.Location = new Point(273, 0);
                lbl_X.Font = new("Corbel", 19, FontStyle.Bold);
            };
            lbl_X.MouseLeave += (sender, e) =>
            {
                lbl_X.Location = new Point(275, 2);
                lbl_X.Font = new("Corbel", 17, FontStyle.Regular);
                lbl_X.ForeColor = Color.FromArgb(100, 196, 154, 138);
            };

            Label textLabel = new Label() { Left = 15, Top = 55, Width = 73, Text = text };
            TextBox textBox = new TextBox() { Left = 90, Top = 50, Width = 100 };
            Button confirmation = new Button() { Text = "Save", Left = 200, Width = 70, Top = 50, DialogResult = DialogResult.OK, FlatStyle = FlatStyle.Flat, BackgroundImage = Properties.Resources.btn2, BackgroundImageLayout = ImageLayout.Stretch };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            confirmation.MouseLeave += Button_MouseLeave;
            confirmation.MouseEnter += Button_MouseEnter;
            lbl_X.Click += (sender, e) => { prompt.Close(); };
            p.Controls.Add(lbl_title);
            p.Controls.Add(lbl_X);
            prompt.AcceptButton = confirmation;
            textBox.Enter += TextBox_Enter;
            textBox.Leave += TextBox_Leave;
            p.MouseDown += new MouseEventHandler(panel1_MouseDown);
            p.MouseMove += new MouseEventHandler(panel1_MouseMove);
            p.MouseUp += new MouseEventHandler(panel1_MouseUp);
            lbl_title.MouseDown += new MouseEventHandler(panel1_MouseDown);
            lbl_title.MouseMove += new MouseEventHandler(panel1_MouseMove);
            lbl_title.MouseUp += new MouseEventHandler(panel1_MouseUp);
            lbl_X.MouseDown += new MouseEventHandler(panel1_MouseDown);
            lbl_X.MouseMove += new MouseEventHandler(panel1_MouseMove);
            lbl_X.MouseUp += new MouseEventHandler(panel1_MouseUp);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(p);
            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
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
        private static void RoundedForm_Paint(Form form, PaintEventArgs e)
        {
            // 设置窗体的圆角半径
            int cornerRadius = 12;

            // 创建 GraphicsPath 对象，并添加一个圆角矩形
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, cornerRadius, cornerRadius), 180, 90);
            path.AddArc(new Rectangle(form.Width - cornerRadius, 0, cornerRadius, cornerRadius), -90, 90);
            path.AddArc(new Rectangle(form.Width - cornerRadius, form.Height - cornerRadius, cornerRadius, cornerRadius), 0, 90);
            path.AddArc(new Rectangle(0, form.Height - cornerRadius, cornerRadius, cornerRadius), 90, 90);
            path.CloseFigure();

            // 设置窗体的区域
            form.Region = new Region(path);
        }
        private static void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "輸入新名稱";
                textBox.ForeColor = Color.Gray;
            }
        }
        private static void TextBox_Enter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text.Trim() == "輸入新名稱")
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }
        private static void Button_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                button.BackgroundImage = Properties.Resources.btn2;
                button.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }
        private static void Button_MouseEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                button.BackgroundImage = Properties.Resources.btn1;
                button.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }
        public static void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    beginMove = true;
                    currentXPosition = e.X; // 滑鼠的 X 座標為當前窗體左上角 X 座標參考
                    currentYPosition = e.Y; // 滑鼠的 Y 座標為當前窗體左上角 Y 座標參考
                }
            }
            catch (Exception ex) { return; }
        }
        public static void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (beginMove)
                {
                    Form prompt = (sender as Control).FindForm();
                    prompt.Left += e.X - currentXPosition; // 根據滑鼠的 X 座標確定窗體的 X 座標
                    prompt.Top += e.Y - currentYPosition; // 根據滑鼠的 Y 座標確定窗體的 Y 座標
                }
            }
            catch (Exception ex) { return; }

        }
        public static void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    beginMove = false;
                }
            }
            catch (Exception ex) { return; }
        }
    }
    public class menuform
    {
        Form Menuform;
        public bool beginMove = false;
        public int currentXPosition;
        public int currentYPosition;
        Panel SettingPanel;
        private Action<Panel, int> _setGroupboxSize;
        public menuform(Panel SetPanel, string TitleText, Button BtnSet, Image bimage = null, bool su = false, TextBox tbxsu = null, object sender = null)
        {
            Menuform = new Form
            {
                StartPosition = FormStartPosition.CenterScreen,
                //     BackgroundImage = Properties.Resources.S__6471682,
                Size = new Size(SetPanel.Width + 2, SetPanel.Height + 30),
                FormBorderStyle = FormBorderStyle.None,
                BackColor = ColorTranslator.FromHtml("#C49A8A"),
                ShowInTaskbar = false,
                Font = new Font("Microsoft JhengHei UI", 9, FontStyle.Regular),
                //   BackColor = Color.AliceBlue,
                TopMost = true,
                KeyPreview = true,
            };
            SettingPanel = SetPanel;
            Panel p = new Panel() { Left = 0, Top = 0, Height = 29, Width = Menuform.Width, BackgroundImage = Properties.Resources.title_1, BackgroundImageLayout = ImageLayout.Stretch };
            Label lbl_title = new Label() { Left = 29, Width = 200, Top = 2, Font = new Font("Microsoft JhengHei UI", 12, FontStyle.Regular), BackColor = Color.Transparent, ForeColor = Color.White };
            lbl_title.Text = TitleText;
            lbl_title.Location = new Point(33, 6);
            p.Location = new Point(0, 0);
            p.MouseDown += new MouseEventHandler(panel1_MouseDown);
            p.MouseMove += new MouseEventHandler(panelsb_MouseMove);
            p.MouseUp += new MouseEventHandler(panel1_MouseUp);
            lbl_title.MouseDown += new MouseEventHandler(panel1_MouseDown);
            lbl_title.MouseMove += new MouseEventHandler(panelsb_MouseMove);
            lbl_title.MouseUp += new MouseEventHandler(panel1_MouseUp);
            PictureBox ptb = new PictureBox();
            ptb.Size = new Size(25, 25);
            ptb.Location = new Point(4, 3);
            ptb.Image = Properties.Resources.ll_removebg_preview1;
            ptb.SizeMode = PictureBoxSizeMode.Zoom;
            ptb.BackColor = Color.Transparent;
            ptb.MouseDown += new MouseEventHandler(panel1_MouseDown);
            ptb.MouseMove += new MouseEventHandler(panelsb_MouseMove);
            ptb.MouseUp += new MouseEventHandler(panel1_MouseUp);
            p.Controls.Add(ptb);
            SettingPanel.Location = new Point(1, 29);
            SettingPanel.BackColor = Color.Beige;
            SettingPanel.Visible = true;
            p.Controls.Add(lbl_title);
            Menuform.Controls.Add(p);
            Menuform.Controls.Add(SettingPanel);
            BtnSet.Click += Btn_baudset_Click;
            Menuform.Paint += BForm_Paint;
            SettingPanel.Paint += Bp_Paint;
            Menuform.KeyDown += Menuform_KeyDown;
            if (bimage != null)
            {
                SettingPanel.BackgroundImage = bimage;
                SettingPanel.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (su == true)
            {
                tbxsu.Focus();
            }
            Menuform.Show();
        }


        private void Menuform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (Menuform != null)
                {
                    // 在關閉表單之前移除 pnl_baud
                    SettingPanel.Visible = false;
                    Menuform.Controls.Remove(SettingPanel);
                    Menuform.Paint -= BForm_Paint;
                    SettingPanel.Paint -= Bp_Paint;
                    Menuform.Refresh();
                    Menuform.Close();
                    Menuform = null;
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

        private void BForm_Paint(object sender, PaintEventArgs e)
        {
            Form Form = sender as Form;
            // 设置窗体的圆角半径
            int cornerRadius = 7;

            // 创建圆角矩形路径
            Rectangle rect = new Rectangle(0, 0, Form.Width, Form.Height);
            using (GraphicsPath path = CreateRoundRectPath(rect, cornerRadius))
            {
                Form.Region = new Region(path);
            }
            LogHelper.WriteLog("InitUI Finished");
        }
        public void panelsb_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (beginMove)
                {
                    Menuform.Left += e.X - currentXPosition; //根據滑鼠的 X 座標確定窗體的 X 座標
                    Menuform.Top += e.Y - currentYPosition; //根據滑鼠的 Y 座標確定窗體的 Y 座標
                }
            }
            catch (Exception ex) { return; }
        }
        public void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    beginMove = true;
                    currentXPosition = e.X; //滑鼠的 X 座標為當前窗體左上角 X 座標參考
                    currentYPosition = e.Y; //滑鼠的 Y 座標為當前窗體左上角 Y 座標參考
                }
            }
            catch (Exception ex) { return; }

        }
        public void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    currentXPosition = 0; //設定初始狀態
                    currentYPosition = 0; //設定初始狀態
                    beginMove = false;
                }
            }
            catch (Exception ex) { return; }
        }
        private void Btn_baudset_Click(object sender, EventArgs e)
        {
            if (Menuform != null)
            {
                // 在關閉表單之前移除 pnl_baud

                SettingPanel.Visible = false;
                Menuform.Controls.Remove(SettingPanel);
                Menuform.Paint -= BForm_Paint;
                SettingPanel.Paint -= Bp_Paint;
                Menuform.Refresh();
                Menuform.Close();
                Menuform = null;
            }
        }
    }
    public class Location
    {
        public Point Pctrl_Lo { get; set; }
        public Point Punder_Lo { get; set; }
        public Point Pcontrol_Lo { get; set; }
        public Size Pctrl_Si { get; set; }
        public Size Punder_Si { get; set; }
        public Size Pcontrol_Si { get; set; }

    }
    public static class DataMethod
    {
        public static string DoMath(byte[] data, int size, int lsb, int msb, string type, bool islit)
        {
            if (data != null)
            {
                if (islit == false)
                {
                    switch (type)
                    {

                        case "Byte":
                            return PutByte(data, lsb, msb, size).ToString();
                        case "Ushort":
                            return PutUshortByte(data, lsb, msb, size).ToString();
                        case "Uint":
                            return PutUintByte(data, lsb, msb, size).ToString();
                        case "Float":
                            return PutFloatByte(data, lsb, msb, size).ToString();
                    }
                }
                if (islit == true)
                {
                    switch (type)
                    {

                        case "Byte":
                            return PutByte(data, lsb, msb, size).ToString();
                        case "Ushort":
                            return PutlitUshortByte(data, lsb, msb, size).ToString();
                        case "Uint":
                            return PutlitUintByte(data, lsb, msb, size).ToString();
                        case "Float":
                            return PutlitFloatByte(data, lsb, msb, size).ToString();
                    }
                }
                return "null";
            }
            else
            {
                return "null";
            }
        }
        public static float PutFloatByte(byte[] data, int lsb, int msb, int size)
        {
            if (size != 32) // Float is 32 bits
            {
                throw new ArgumentException("Size does not match 32 bits for float.");
            }
            if (msb >= 64 || lsb < 0 || lsb > msb)
            {
                throw new ArgumentOutOfRangeException("Invalid lsb or msb value.");
            }
            byte[] bitArray = new byte[64];
            for (int i = 0; i < 64; i++)
            {
                int byteIndex = i / 8;
                int bitOffset = i % 8;
                bitArray[i] = (byte)((data[byteIndex] >> bitOffset) & 1);
            }
            uint result = 0;
            for (int i = 0; i < size; i++)
            {
                result |= (uint)(bitArray[msb - i] << i);
            }
            byte[] floatBytes = BitConverter.GetBytes(result);
            return BitConverter.ToSingle(floatBytes, 0);
        }

        public static float PutlitFloatByte(byte[] data, int lsb, int msb, int size)
        {
            if (size != 32) // Float is 32 bits
            {
                throw new ArgumentException("Size does not match 32 bits for float.");
            }
            if (msb >= 64 || lsb < 0 || lsb > msb)
            {
                throw new ArgumentOutOfRangeException("Invalid lsb or msb value.");
            }
            byte[] bitArray = new byte[64];
            for (int i = 0; i < 64; i++)
            {
                int byteIndex = i / 8;
                int bitOffset = i % 8;
                bitArray[i] = (byte)((data[byteIndex] >> bitOffset) & 1);
            }
            uint result = 0;
            for (int i = 0; i < size; i++)
            {
                result |= (uint)(bitArray[lsb + i] << i);
            }
            byte[] floatBytes = BitConverter.GetBytes(result);
            return BitConverter.ToSingle(floatBytes, 0);
        }
        public static ushort PutByte(byte[] data, int lsb, int msb, int size)
        {
            // 準備一個64位元的陣列來存儲所有的位元
            byte[] bitArray = new byte[64];

            // 將每個byte拆成bit並放到bitArray中
            for (int i = 0; i < 64; i++)
            {
                int byteIndex = i / 8;
                int bitOffset = i % 8;
                bitArray[i] = (byte)((data[byteIndex] >> bitOffset) & 1);
            }

            // 將選定的位元組合成一個ushort，按little-endian方式排列
            ushort result = 0;
            if (size == msb - lsb + 1)
                for (int i = 0; i < size; i++)
                {
                    result |= (ushort)(bitArray[lsb + i] << i);
                }

            return result;
        }
        public static ushort PutbigByte(byte[] data, int lsb, int msb, int size)
        {
            // 準備一個64位元的陣列來存儲所有的位元
            byte[] bitArray = new byte[64];

            // 將每個byte拆成bit並放到bitArray中
            for (int i = 0; i < 64; i++)
            {
                int byteIndex = i / 8;
                int bitOffset = i % 8;
                bitArray[i] = (byte)((data[byteIndex] >> bitOffset) & 1);
            }

            // 將選定的位元組合成一個ushort，按big-endian方式排列
            ushort result = 0;
            if (size == msb - lsb + 1)
            {
                for (int i = 0; i < size; i++)
                {
                    result |= (ushort)(bitArray[msb - i] << i);
                }
            }

            return result;
        }
        public static ushort PutUshortByte(byte[] data, int lsb, int msb, int size)
        {
            // 檢查size是否符合要求
            if (size != msb - lsb + 1)
            {
                throw new ArgumentException("Size does not match msb - lsb + 1.");
            }

            // 檢查輸入參數是否有效
            if (msb >= 64 || lsb < 0 || lsb > msb)
            {
                throw new ArgumentOutOfRangeException("Invalid lsb or msb value.");
            }

            // 準備一個64位元的陣列來存儲所有的位元
            byte[] bitArray = new byte[64];

            // 將每個byte拆成bit並放到bitArray中
            for (int i = 0; i < 64; i++)
            {
                int byteIndex = i / 8;
                int bitOffset = i % 8;
                bitArray[i] = (byte)((data[byteIndex] >> (7 - bitOffset)) & 1);
            }

            // 將選定的位元組合成一個ushort，按big-endian方式排列
            ushort result = 0;
            for (int i = 0; i < size; i++)
            {
                result |= (ushort)(bitArray[msb - i] << i);
            }
            return result;
        }
        public static ushort PutlitUshortByte(byte[] data, int lsb, int msb, int size)
        {
            // 檢查size是否符合要求
            if (size != msb - lsb + 1)
            {
                throw new ArgumentException("Size does not match msb - lsb + 1.");
            }

            // 檢查輸入參數是否有效
            if (msb >= 64 || lsb < 0 || lsb > msb)
            {
                throw new ArgumentOutOfRangeException("Invalid lsb or msb value.");
            }

            // 準備一個64位元的陣列來存儲所有的位元
            byte[] bitArray = new byte[64];

            // 將每個byte拆成bit並放到bitArray中
            for (int i = 0; i < 64; i++)
            {
                int byteIndex = i / 8;
                int bitOffset = i % 8;
                bitArray[i] = (byte)((data[byteIndex] >> bitOffset) & 1);
            }

            // 將選定的位元組合成一個ushort，按little-endian方式排列
            ushort result = 0;
            for (int i = 0; i < size; i++)
            {
                result |= (ushort)(bitArray[lsb + i] << i);
            }

            return result;
        }
        public static uint PutUintByte(byte[] data, int lsb, int msb, int size)
        {
            // 檢查size是否符合要求
            if (size != msb - lsb + 1)
            {
                throw new ArgumentException("Size does not match msb - lsb + 1.");
            }

            // 檢查輸入參數是否有效
            if (msb >= 64 || lsb < 0 || lsb > msb)
            {
                throw new ArgumentOutOfRangeException("Invalid lsb or msb value.");
            }

            // 準備一個64位元的陣列來存儲所有的位元
            byte[] bitArray = new byte[64];

            // 將每個byte拆成bit並放到bitArray中
            for (int i = 0; i < 64; i++)
            {
                int byteIndex = i / 8;
                int bitOffset = i % 8;
                bitArray[i] = (byte)((data[byteIndex] >> (7 - bitOffset)) & 1);
            }

            // 將選定的位元組合成一個uint，按big-endian方式排列
            uint result = 0;
            for (int i = 0; i < size; i++)
            {
                result |= (uint)(bitArray[msb - i] << i);
            }

            return result;
        }
        public static uint PutlitUintByte(byte[] data, int lsb, int msb, int size)
        {
            // 檢查size是否符合要求
            if (size != msb - lsb + 1)
            {
                throw new ArgumentException("Size does not match msb - lsb + 1.");
            }

            // 檢查輸入參數是否有效
            if (msb >= 64 || lsb < 0 || lsb > msb)
            {
                throw new ArgumentOutOfRangeException("Invalid lsb or msb value.");
            }

            // 準備一個64位元的陣列來存儲所有的位元
            byte[] bitArray = new byte[64];

            // 將每個byte拆成bit並放到bitArray中
            for (int i = 0; i < 64; i++)
            {
                int byteIndex = i / 8;
                int bitOffset = i % 8;
                bitArray[i] = (byte)((data[byteIndex] >> bitOffset) & 1);
            }

            // 將選定的位元組合成一個uint，按little-endian方式排列
            uint result = 0;
            for (int i = 0; i < size; i++)
            {
                result |= (uint)(bitArray[lsb + i] << i);
            }

            return result;
        }
    }
    public class DataItem
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Size { get; set; }
        public string lsb { get; set; }
        public string msb { get; set; }
        public string Endian { get; set; }
        public string Value { get; set; }
        public string portid { get; set; }
        public string mode { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
    public class CanPacket
    {
        public int DeviceID;
        public byte portID;
        public uint extID;
        public byte mode;
        public byte RTR;
        public byte DLC;
        public byte[] Data = new byte[8];
        public CanPacket() { }
    }
    [Serializable]
    public class ControlConfig
    {
        public List<GroupBoxConfig> GroupBoxes { get; set; } = new List<GroupBoxConfig>();
    }
    [Serializable]
    public class GroupBoxConfig
    {
        public string GroupBoxName { get; set; }
        public string Description { get; set; }
        public Point Location { get; set; }
        public List<ByteCtrlConfig> ByteCtrls { get; set; } = new List<ByteCtrlConfig>();
    }
    [Serializable]
    public class ByteCtrlConfig
    {
        public string Name { get; set; }
        public string XmlFileName { get; set; }
        public string MessageID { get; set; }
        public string Type { get; set; }
        public int Size { get; set; }
        public int Lsb { get; set; }
        public int Msb { get; set; }
        public bool Signed { get; set; }
        public string portID { get; set; }
        public string mode { get; set; }
        public bool lit { get; set; }
        public Point Location { get; set; }
    }
    public class CanData
    {
        public int Id { get; set; }
        public int portId { get; set; }
        public byte[] Data { get; set; }
    }
    public static class LogHelper
    {
        private static string logDirectory;
        public static bool iscreate = false;
        public static bool first = true;
        public static void Initialize(string xmlFilePath)
        {
            if (first == true)
            {
                logDirectory = Path.Combine(xmlFilePath, "log");
                Directory.CreateDirectory(logDirectory); // 確保目錄存在  
                first = false;
            }
        }
        private static string temp = "";
        private static string GetLogFilePath()
        {
            string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");

            if (iscreate == true)
            {
                return temp;
            }
            if (iscreate == false)
            {
                temp = Path.Combine(logDirectory, $"{timestamp}_GridCan.log");
                iscreate = true;
                return temp;
            }
            else
            {
                return "";
            }
        }
        public static void WriteLog(string message)
        {
            try
            {
                if (string.IsNullOrEmpty(logDirectory))
                {
                    throw new InvalidOperationException("Log directory is not initialized.");
                }

                string logFilePath = GetLogFilePath();

                using (StreamWriter writer = new StreamWriter(logFilePath, true))
                {
                    writer.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff} - {message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to write log: {ex.Message}");
            }
        }
    }
    public class XmlDataChangedEventArgs : EventArgs
    {
        public string Xmlfilename { get; }
        public uint MessageID { get; }
        public int portID { get; }
        public int Mode { get; }
        public XmlDataChangedEventArgs(string XmlN, uint MessID, int id, int mode)
        {
            Xmlfilename = XmlN;
            MessageID = MessID;
            portID = id;
            Mode = mode;
        }
    }
}
