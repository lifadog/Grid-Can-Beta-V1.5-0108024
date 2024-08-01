using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace test0515
{
    public partial class ByteCtrl : UserControl
    {
        private bool _mode;
        //   private bool _isSigned = false;
        private bool _isFloat = false;
        private PrivateFontCollection privateFonts = new PrivateFontCollection();
        private Main main;
        public string valueName; // 從靜態變量改為實例變量
        public string XmlFileName { get; set; }
        public string MessageID { get; set; }
        public static event EventHandler<int> ModeChanged;
        public static event EventHandler<int> UshortChanged;
        public static event EventHandler<int> UintChanged;
        public int size, lsb, msb;
        public string portID;
        public string mode;
        public bool iscreate;
        public ushort _ushortValue;
        public uint _uintValue;
        private string type;
        private bool _signed;
        private bool _islitt;
        Dignum D;

        public DataItem DataItem { get; set; }
        public bool Islit
        {
            get { return _islitt; }
            set
            {
                _islitt = value;
                InitializeContextMenu(Signed, _islitt);
            }
        }
        public bool Signed
        {
            get { return _signed; }
            set
            {
                _signed = value;
                InitializeContextMenu(_signed, Islit);
            }
        }
        public string Type
        {
            get { return type; }
            set { Type = value; }
        }
        public ushort UshortValue
        {
            get { return _ushortValue; }
            set
            {
                _ushortValue = value;
                UshortChanged?.Invoke(this, ReturnValue());
            }
        }
        public uint UintValue
        {
            get { return _uintValue; }
            set
            {
                _uintValue = value;
                UintChanged?.Invoke(this, ReturnValue());
            }
        }
        private bool Mode
        {
            get { return _mode; }
            set
            {
                _mode = value;
                ptb_Mode.Image = _mode ? Properties.Resources.ON : Properties.Resources.OFF;
                ModeChanged?.Invoke(this, ReturnMode());
            }
        }
        private ContextMenuStrip contextMenuStrip;
        private void InitializeContextMenu(bool b = false, bool islit = false)
        {
            if (b == false && islit == false)
            {
                contextMenuStrip = new ContextMenuStrip();
                ToolStripMenuItem signedItem = new ToolStripMenuItem("Signed");
                signedItem.Click += SignedItem_Click;
                ToolStripMenuItem removeItem = new ToolStripMenuItem("Remove");
                removeItem.Click += RemoveItem_Click;
                ToolStripMenuItem islititem = new ToolStripMenuItem("Littel-End");
                islititem.Click += Islititem_Click;
                contextMenuStrip.Items.Add(signedItem);
                contextMenuStrip.Items.Add(islititem);
                contextMenuStrip.Items.Add(removeItem);

                this.ContextMenuStrip = contextMenuStrip;
            }
            if (b == true && islit == false)
            {
                contextMenuStrip = new ContextMenuStrip();
                ToolStripMenuItem signedItem = new ToolStripMenuItem("Signed ✓ ");
                signedItem.Click += SignedItem_Click;
                ToolStripMenuItem removeItem = new ToolStripMenuItem("Remove");
                removeItem.Click += RemoveItem_Click;
                ToolStripMenuItem islititem = new ToolStripMenuItem("Littel-End");
                islititem.Click += Islititem_Click;
                contextMenuStrip.Items.Add(signedItem);
                contextMenuStrip.Items.Add(islititem);
                contextMenuStrip.Items.Add(removeItem);

                this.ContextMenuStrip = contextMenuStrip;
            }
            if (b == false && islit == true)
            {
                contextMenuStrip = new ContextMenuStrip();
                ToolStripMenuItem signedItem = new ToolStripMenuItem("Signed");
                signedItem.Click += SignedItem_Click;
                ToolStripMenuItem removeItem = new ToolStripMenuItem("Remove");
                removeItem.Click += RemoveItem_Click;
                ToolStripMenuItem islititem = new ToolStripMenuItem("Littel-End ✓");
                islititem.Click += Islititem_Click;
                contextMenuStrip.Items.Add(signedItem);
                contextMenuStrip.Items.Add(islititem);
                contextMenuStrip.Items.Add(removeItem);

                this.ContextMenuStrip = contextMenuStrip;
            }
            if (b == true && islit == true)
            {
                contextMenuStrip = new ContextMenuStrip();
                ToolStripMenuItem signedItem = new ToolStripMenuItem("Signed ✓ ");
                signedItem.Click += SignedItem_Click;
                ToolStripMenuItem removeItem = new ToolStripMenuItem("Remove");
                removeItem.Click += RemoveItem_Click;
                ToolStripMenuItem islititem = new ToolStripMenuItem("Littel-End ✓");
                islititem.Click += Islititem_Click;
                contextMenuStrip.Items.Add(signedItem);
                contextMenuStrip.Items.Add(islititem);
                contextMenuStrip.Items.Add(removeItem);

                this.ContextMenuStrip = contextMenuStrip;
            }
        }
        private void updatebytectrlinformation(uint messageid, int id, int mode)
        {
            if (MessageID != messageid.ToString() || portID != id.ToString() || this.mode != mode.ToString())
            {
                MessageID = messageid.ToString();
                portID = id.ToString();
                this.mode = mode.ToString();
            }
        }
        private void Islititem_Click(object sender, EventArgs e)
        {
            Islit = !Islit;
        }
        private void SignedItem_Click(object sender, EventArgs e)
        {
            Signed = !Signed;
        }
        private void RemoveItem_Click(object sender, EventArgs e)
        {
            Main mainForm = this.FindForm() as Main;
            if (mainForm != null)
            {
                mainForm.Remove_ByteCtrl(this.removename);
            }
        }
        string removename;
        public ByteCtrl(DataItem item, string xmlFileName, string ID, string type, int size, int lsb, int msb, string portid, string mode, Main main, bool signed = false, bool islit = false)
        {
            InitializeComponent();
            InitializeContextMenu();
            LoadCustomFont();
            this.main = main;
            this.DataItem = item; // 確保 dataItem 不為 null
            this.type = type;
            this.Font = new Font("Microsoft JhengHei UI", 8, FontStyle.Bold);
            this.lsb = lsb;
            this.msb = msb;
            this.size = size;
            portID = portid;
            this.mode = mode;
            Islit = islit;
            Signed = signed;
            main.UpdateSuperSu("CreateCtrl: "+ParseID(ID).ToString()+"(dec)");
            EventManager.OnDataReceived += HandlerDataRecevied;
            comtimer.Interval = 100;
            comtimer.Tick += Comtimer_Tick;
            comtimer.Start();
            main.XmlDataChanged += Main_XmlDataChanged;
            //D = new();
            //D.Location = new Point(0, 0);
          //  panel3.Controls.Add(D);
            switch (this.type)
            {
                case "Bit":
                    valueName = item.Name;
                    MessageID = ID;
                    XmlFileName = xmlFileName;
                    panel2.Enabled = false;
                    panel2.Visible = false;
                    panel1.Enabled = true;
                    panel1.Visible = true;
                    panel1.Dock = DockStyle.Fill;
                   lbl_name2.Text = XmlFileName + "- " + valueName;
                    this.Name = $"{valueName}_{MessageID}";
                    removename = this.Name;
                    iscreate = true;
                    break;
                case "Byte":
                    valueName = item.Name;
                    MessageID = ID;
                    XmlFileName = xmlFileName;
                    panel2.Enabled = true;
                    panel2.Visible = true;
                    panel1.Enabled = false;
                    panel1.Visible = false;
                    panel2.Dock = DockStyle.Fill;
                    lbl_value.BackColor = Color.Transparent;
                   lbl_name1.Text = XmlFileName + "- " + valueName;
                    this.Name = $"{valueName}_{MessageID}";
                    removename = this.Name;
                    iscreate = true;
                    btn_set.Click += Btn_set_Click;
                    break;
                case "Ushort":
                    valueName = item.Name;
                    MessageID = ID;
                    XmlFileName = xmlFileName;
                    panel2.Enabled = true;
                    panel2.Visible = true;
                    panel1.Enabled = false;
                    panel1.Visible = false;
                    panel2.Dock = DockStyle.Fill;
                    lbl_value.BackColor = Color.Transparent;
                   lbl_name1.Text = XmlFileName + "- " + valueName;
                    this.Name = $"{valueName}_{MessageID}";
                    removename = this.Name;
                    iscreate = true;
                    btn_set.Click += Btn_set_Click;
                    break;
                case "Uint":
                    valueName = item.Name;
                    MessageID = ID;
                    XmlFileName = xmlFileName;
                    panel2.Enabled = true;
                    panel2.Visible = true;
                    panel1.Enabled = false;
                    panel1.Visible = false;
                    panel2.Dock = DockStyle.Fill;
                    lbl_value.BackColor = Color.Transparent;
                   lbl_name1.Text = XmlFileName + "- " + valueName;
                    this.Name = $"{valueName}_{MessageID}";
                    removename = this.Name;
                    iscreate = true;
                    btn_set.Click += Btn_set_Click;
                    break;
            }
            this.MouseDown += ByteCtrl_MouseDown;
            this.MouseMove += ByteCtrl_MouseMove;
            this.Disposed += ByteCtrl_Disposed;
            AddDragEventHandlers(this.Controls);
        }
        public void updatebytectrlconfig(DataItem item, string MessageID)
        {
            this.valueName = item.Name;
            this.MessageID = MessageID;
            this.size = int.Parse(item.Size);
            this.portID = item.portid;
            this.lsb = int.Parse(item.lsb);
            this.msb = int.Parse(item.msb);
            this.mode = item.mode;
            this.Name = $"{valueName}_{this.MessageID}";
            this.Islit = main.boolislit(item.Endian);
            removename = this.Name;
            switch (item.Type)
            {
                case "Bit":
                   lbl_name2.Text = XmlFileName + "- " + valueName;
                    break;
                case "Byte":
                   lbl_name1.Text = XmlFileName + "- " + valueName;
                    break;
                case "Ushort":
                   lbl_name1.Text = XmlFileName + "- " + valueName;
                    break;
                case "Uint":
                   lbl_name1.Text = XmlFileName + "- " + valueName;
                    break;
            }
            Console.WriteLine(valueName + " , " + this.MessageID + " , " + this.size + " , " + this.portID + " , " + this.lsb + " , " + this.msb + " , " + this.Name + " , " + this.Islit.ToString());
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
            lbl_value.Font = new Font(privateFonts.Families[0], 13);
        }
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref IntPtr pcFonts);
        private void Main_XmlDataChanged(object sender, XmlDataChangedEventArgs e)
        {
            updatebytectrlinformation( e.MessageID, e.portID, e.Mode);
        }
        private void Comtimer_Tick(object sender, EventArgs e)
        {
            TimeSpan timeSinceLastMessage = DateTime.Now - lasttime;
            if (timeSinceLastMessage.TotalMilliseconds > 2000)
            {
                lbl_value.ForeColor = Color.Black;
            }
            else
            {
                lbl_value.ForeColor = Color.OrangeRed;
            }
        }
        private void UpdateDisplayedValue()
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action(UpdateDisplayedValue));
            }
            else
            {
                if (Signed == true)
                {
                    string binaryString = Convert.ToString(UshortValue, 2).PadLeft(size, '0');

                    // 如果最高位是1，表示负数
                    if (binaryString[0] == '1')
                    {
                        // 转换成有号数值
                        int signedValue = ConvertBinaryStringToSigned(binaryString);

                        //  D.DisplayNumber(signedValue.ToString());
                        lbl_value.Text = signedValue.ToString();
                    }
                    else
                    {
                        // D.DisplayNumber(UshortValue.ToString());
                        // 转换成无号数值
                        lbl_value.Text = UshortValue.ToString();
                    }
                }
                else
                {
                    //  D.DisplayNumber(UshortValue.ToString());
                    lbl_value.Text = UshortValue.ToString();
                }
            }
        }
        private void UpdateuintDisplayedValue()
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action(UpdateuintDisplayedValue));
            }
            else
            {
                if (Signed == true)
                {
                    string binaryString = Convert.ToString(UintValue, 2).PadLeft(size, '0');

                    // 如果最高位是1，表示负数
                    if (binaryString[0] == '1')
                    {
                        // 转换成有号数值
                        int signedValue = ConvertBinaryStringToSigned(binaryString);
                        //  D.DisplayNumber(signedValue.ToString());
                        lbl_value.Text = signedValue.ToString();
                    }
                    else
                    {
                        //  D.DisplayNumber(UintValue.ToString());  
                        // 转换成无号数值
                        lbl_value.Text = UintValue.ToString();
                    }
                }
                else
                {
                    //  D.DisplayNumber(UintValue.ToString());
                    lbl_value.Text = UintValue.ToString();
                }
            }
        }
        private int ConvertBinaryStringToSigned(string binaryString)
        {
            // 如果最高位是1，表示负数
            if (binaryString[0] == '1')
            {
                // 使用补码表示法转换为有符号整数
                int signedValue = Convert.ToInt32(binaryString, 2) - (1 << size);
                return signedValue;
            }
            else
            {
                return Convert.ToInt32(binaryString, 2);
            }
        }
        private bool isDragging = false;
        private Point dragStartPoint;

        public void UpdateByteCtrl(byte[] d)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<byte[]>(UpdateByteCtrl), d);
            }
            else
            {
                lasttime = DateTime.Now; // 更新数据接收时间
                lbl_value.ForeColor = Color.OrangeRed; // 设置颜色为黑色
                this.Invoke((MethodInvoker)delegate
                {
                    if (type == "Bit")
                    {
                        test_setvalue(DoMath(d, size, lsb, msb, type, Islit));
                    }
                    if (type == "Byte")
                    {
                        UshortValue = ushort.Parse(DoMath(d, size, lsb, msb, type, Islit));
                        UpdateDisplayedValue();
                    }
                    if (type == "Ushort")
                    {
                        UshortValue = ushort.Parse(DoMath(d, size, lsb, msb, type, Islit));
                        UpdateDisplayedValue();
                    }
                    if (type == "Uint")
                    {
                        UintValue = uint.Parse(DoMath(d, size, lsb, msb, type, Islit));
                        UpdateuintDisplayedValue();
                    }
                });
            }
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
        public static bool CheckID = false;
        private HashSet<string> lsbsuID = new();
        private void test05(string id)
        {
            lsbsuID.Add(id); // HashSet.Add 方法会自动检查重复，如果 id 已存在，则不会再次添加
        }
        private string test07()
        {
            List<string>rulsb=lsbsuID.ToList<string>();
            string rus="";
            for(int i=0;i<rulsb.Count; i++)
            {
                if (rulsb[i] != null)
                {
                    rus += int.Parse(rulsb[i]).ToString("X2") + "(hex)";
                    if (i != rulsb.Count - 1)
                    {
                        rus += Environment.NewLine;
                    }
                }
            }
            return rus;
        }
        public void HandlerDataRecevied(int id, int portid, byte[] Data)
        {
            if (MessageID != null)
            {
                // Console.WriteLine("btclid: " + ParseID(MessageID).ToString("X2") + " , messageid: " + id.ToString("X2") + Environment.NewLine);
                // Thread.Sleep(50);
                test05(id.ToString());
                if (CheckID == true)
                {
                    main.UpdateSuperSu(test07());
                    CheckID= false;
                   // main.UpdateSuperSu("Control.ID= " + ParseID(MessageID).ToString("X2") + Environment.NewLine + "Recevied.ID= " + id.ToString("X2") + Environment.NewLine + "Control.PortID= " + this.portID + Environment.NewLine + "Recevied ID=" + portid.ToString() + Environment.NewLine);
                }
                if (ParseID(MessageID).ToString("X2") == id.ToString("X2") && this.portID == portid.ToString())
                {
                    UpdateByteCtrl(Data);
                }
            }
        }
        private void ByteCtrl_Disposed(object sender, EventArgs e)
        {
            EventManager.OnDataReceived -= HandlerDataRecevied;
        }
        private DateTime lasttime;
        public string DoMath(byte[] data, int size, int lsb, int msb, string type, bool islit = false)
        {

            if (data != null)
            {
                if (islit == false)
                {
                    switch (type)
                    {
                        case "Bit":
                            return PutBit(data, lsb, msb, size).ToString();
                        case "Byte":
                            return PutbigByte(data, lsb, msb, size).ToString();
                        case "Ushort":
                            return PutUshortByte(data, lsb, msb, size).ToString();
                        case "Uint":
                            return PutUintByte(data, lsb, msb, size).ToString();
                    }
                }
                if (islit == true)
                {
                    switch (type)
                    {
                        case "Bit":
                            return PutBit(data, lsb, msb, size).ToString();
                        case "Byte":
                            return PutByte(data, lsb, msb, size).ToString();
                        case "Ushort":
                            return PutlitUshortByte(data, lsb, msb, size).ToString();
                        case "Uint":
                            return PutlitUintByte(data, lsb, msb, size).ToString();
                    }
                }
                return "null";
            }
            else
            {
                return "null";
            }
        }
        public byte PutBit(byte[] data, int lsb, int msb, int size)
        {
            // 準備一個64位元的陣列來存儲所有的位元
            byte[] bitArray = new byte[64];
            string temp = "";
            // 將每個byte拆成bit並放到bitArray中
            for (int i = 0; i < 64; i++)
            {
                int byteIndex = i / 8;
                int bitOffset = i % 8;
                bitArray[i] = (byte)((data[byteIndex] >> bitOffset) & 1);
                temp += bitArray[i].ToString();
            }
            Console.WriteLine(temp);
            // 將選定的位元組合成一個ushort，按little-endian方式排列
            byte result = 0;
            if (size == msb - lsb + 1)
                for (int i = 0; i < size; i++)
                {
                    result |= (byte)(bitArray[lsb + i] << i);
                }
            //   MessageBox.Show(result.ToString());
            return result;
        }
        public ushort PutByte(byte[] data, int lsb, int msb, int size)
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
        public ushort PutbigByte(byte[] data, int lsb, int msb, int size)
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
        public ushort PutUshortByte(byte[] data, int lsb, int msb, int size)
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

            // 將選定的位元組合成一個ushort，按big-endian方式排列
            ushort result = 0;
            for (int i = 0; i < size; i++)
            {
                result |= (ushort)(bitArray[msb - i] << i);
            }
            return result;
        }
        public ushort PutlitUshortByte(byte[] data, int lsb, int msb, int size)
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
        public uint PutUintByte(byte[] data, int lsb, int msb, int size)
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
            string tmp = "";
            // 將每個byte拆成bit並放到bitArray中
            for (int i = 0; i < 64; i++)
            {
                int byteIndex = i / 8;
                int bitOffset = i % 8;
                bitArray[i] = (byte)((data[byteIndex] >> bitOffset) & 1);
                tmp += bitArray[i].ToString();
            }
            Console.WriteLine(tmp);
            // 將選定的位元組合成一個uint，按big-endian方式排列
            uint result = 0;
            int r = 0;
            string temp = "";
            for (int i = 0; i < size; i++)
            {
                result |= (uint)(bitArray[msb - i] << i);
                r |= (int)(bitArray[msb - i] << i);
                //  temp += bitArray[msb - i].ToString();
            }
            Console.WriteLine(temp);
            Console.WriteLine(r);
            return result;
        }
        public uint PutlitUintByte(byte[] data, int lsb, int msb, int size)
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
        private void ByteCtrl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragStartPoint = e.Location;
                isDragging = false; // 初始化为不在拖动状态
            }
        }
        private void ByteCtrl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!isDragging)
                {
                    // 计算鼠标移动的距离
                    int deltaX = Math.Abs(e.X - dragStartPoint.X);
                    int deltaY = Math.Abs(e.Y - dragStartPoint.Y);

                    // 当鼠标移动超过一定距离时，开始拖动
                    if (deltaX > SystemInformation.DragSize.Width || deltaY > SystemInformation.DragSize.Height)
                    {
                        isDragging = true; // 进入拖动状态
                        this.DoDragDrop(this, DragDropEffects.Move);
                    }
                }
            }
        }
        public void AddDragEventHandlers(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {

                    control.MouseDown += ByteCtrl_MouseDown;
                    control.MouseMove += ByteCtrl_MouseMove;
                    if (control.HasChildren)
                    {
                        AddDragEventHandlers(control.Controls);
                    }
                
            }
        }
        public int ReturnValue()
        {
            return int.Parse(lbl_value.Text);
        }
        private void Btn_set_Click(object sender, EventArgs e)
        {
            SetValue();
        }
        public void SetValue()
        {
            UshortValue = ushort.Parse(lbl_value.Text);
        }
        public void test_setvalue(string n)
        {
            {
                switch (n)
                {
                    case "0":
                        this.Invoke((MethodInvoker)delegate
                        {
                            Mode = false;
                        });
                        break;
                    case "1":
                        this.Invoke((MethodInvoker)delegate
                        {
                            Mode = true;
                        });
                        break;
                }
            }
        }
        public int ReturnMode()
        {
            if (Mode == true)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public void SelectMode()
        {
            Mode = !Mode;
        }
        private void ptb_Mode_Click(object sender, EventArgs e)
        {
            SelectMode();
        }
    }
}
