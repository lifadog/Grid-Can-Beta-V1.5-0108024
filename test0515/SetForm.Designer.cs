namespace test0515
{
    partial class SetForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetForm));
            this.Panel_Title = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_X = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lsb_Xmlfilelist = new System.Windows.Forms.ListBox();
            this.rtb_file = new System.Windows.Forms.RichTextBox();
            this.lbl_xml = new System.Windows.Forms.Label();
            this.btn_create = new System.Windows.Forms.Button();
            this.tbx_ID = new System.Windows.Forms.TextBox();
            this.rtb_write = new System.Windows.Forms.RichTextBox();
            this.btn_Write = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_xmlfilename = new System.Windows.Forms.Label();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.rtb_descripe = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_mode = new System.Windows.Forms.Label();
            this.lbl_port = new System.Windows.Forms.Label();
            this.tbx_mode = new System.Windows.Forms.TextBox();
            this.tbx_MessageID = new System.Windows.Forms.TextBox();
            this.tbx_portid = new System.Windows.Forms.TextBox();
            this.dgv_Data = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbb_end = new System.Windows.Forms.ComboBox();
            this.lbl_end = new System.Windows.Forms.Label();
            this.btn_delete_data = new System.Windows.Forms.Button();
            this.rtb_data = new System.Windows.Forms.RichTextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.tbx_Data_Size = new System.Windows.Forms.TextBox();
            this.tbx_Data_msb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_Data_lsb = new System.Windows.Forms.TextBox();
            this.tbx_Data_Name = new System.Windows.Forms.TextBox();
            this.cbb_DataType = new System.Windows.Forms.ComboBox();
            this.btn_ReadCan = new System.Windows.Forms.Button();
            this.btn_WriteCan = new System.Windows.Forms.Button();
            this.tbx_dlc = new System.Windows.Forms.TextBox();
            this.lbl_dlc = new System.Windows.Forms.Label();
            this.gbx_com = new System.Windows.Forms.GroupBox();
            this.rdb_dec = new System.Windows.Forms.RadioButton();
            this.rdb_hex = new System.Windows.Forms.RadioButton();
            this.lbl_extid = new System.Windows.Forms.Label();
            this.tbx_extid = new System.Windows.Forms.TextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.ExitTimer = new System.Windows.Forms.Timer(this.components);
            this.OpenTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Panel_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbx_com.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Title
            // 
            this.Panel_Title.BackColor = System.Drawing.Color.White;
            this.Panel_Title.BackgroundImage = global::test0515.Properties.Resources.title_1;
            this.Panel_Title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel_Title.Controls.Add(this.pictureBox1);
            this.Panel_Title.Controls.Add(this.lbl_X);
            this.Panel_Title.Controls.Add(this.lbl_Title);
            this.Panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Title.Location = new System.Drawing.Point(0, 0);
            this.Panel_Title.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel_Title.Name = "Panel_Title";
            this.Panel_Title.Size = new System.Drawing.Size(842, 29);
            this.Panel_Title.TabIndex = 33;
            this.Panel_Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.Panel_Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.Panel_Title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::test0515.Properties.Resources.ll_removebg_preview1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // lbl_X
            // 
            this.lbl_X.AutoSize = true;
            this.lbl_X.BackColor = System.Drawing.Color.Transparent;
            this.lbl_X.Font = new System.Drawing.Font("Corbel", 17F);
            this.lbl_X.Location = new System.Drawing.Point(817, 2);
            this.lbl_X.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_X.Name = "lbl_X";
            this.lbl_X.Size = new System.Drawing.Size(25, 28);
            this.lbl_X.TabIndex = 1;
            this.lbl_X.Text = "X";
            this.lbl_X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_X.Click += new System.EventHandler(this.lbl_X_Click);
            this.lbl_X.MouseLeave += new System.EventHandler(this.lbl_X_MouseLeave);
            this.lbl_X.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_X_MouseMove);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Title.Location = new System.Drawing.Point(32, 5);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(98, 20);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Data Editior";
            this.lbl_Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.lbl_Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.lbl_Title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.lsb_Xmlfilelist);
            this.groupBox3.Controls.Add(this.rtb_file);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(13, 243);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(256, 249);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Xml FIle";
            // 
            // lsb_Xmlfilelist
            // 
            this.lsb_Xmlfilelist.BackColor = System.Drawing.Color.Beige;
            this.lsb_Xmlfilelist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsb_Xmlfilelist.FormattingEnabled = true;
            this.lsb_Xmlfilelist.ItemHeight = 15;
            this.lsb_Xmlfilelist.Location = new System.Drawing.Point(9, 85);
            this.lsb_Xmlfilelist.Margin = new System.Windows.Forms.Padding(5);
            this.lsb_Xmlfilelist.Name = "lsb_Xmlfilelist";
            this.lsb_Xmlfilelist.Size = new System.Drawing.Size(228, 152);
            this.lsb_Xmlfilelist.TabIndex = 39;
            // 
            // rtb_file
            // 
            this.rtb_file.BackColor = System.Drawing.Color.Beige;
            this.rtb_file.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_file.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rtb_file.Location = new System.Drawing.Point(9, 25);
            this.rtb_file.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtb_file.Name = "rtb_file";
            this.rtb_file.ReadOnly = true;
            this.rtb_file.Size = new System.Drawing.Size(228, 52);
            this.rtb_file.TabIndex = 30;
            this.rtb_file.Text = "※輸入名稱，並建立Xml檔案。";
            // 
            // lbl_xml
            // 
            this.lbl_xml.AutoSize = true;
            this.lbl_xml.BackColor = System.Drawing.Color.Transparent;
            this.lbl_xml.Location = new System.Drawing.Point(10, 26);
            this.lbl_xml.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_xml.Name = "lbl_xml";
            this.lbl_xml.Size = new System.Drawing.Size(45, 15);
            this.lbl_xml.TabIndex = 0;
            this.lbl_xml.Text = "Name:";
            // 
            // btn_create
            // 
            this.btn_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_create.Location = new System.Drawing.Point(13, 174);
            this.btn_create.Margin = new System.Windows.Forms.Padding(5);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(97, 33);
            this.btn_create.TabIndex = 3;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // tbx_ID
            // 
            this.tbx_ID.BackColor = System.Drawing.Color.Beige;
            this.tbx_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_ID.Location = new System.Drawing.Point(56, 23);
            this.tbx_ID.Margin = new System.Windows.Forms.Padding(5);
            this.tbx_ID.Name = "tbx_ID";
            this.tbx_ID.Size = new System.Drawing.Size(172, 23);
            this.tbx_ID.TabIndex = 1;
            // 
            // rtb_write
            // 
            this.rtb_write.BackColor = System.Drawing.Color.Beige;
            this.rtb_write.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_write.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rtb_write.Location = new System.Drawing.Point(411, 173);
            this.rtb_write.Margin = new System.Windows.Forms.Padding(5);
            this.rtb_write.Name = "rtb_write";
            this.rtb_write.ReadOnly = true;
            this.rtb_write.Size = new System.Drawing.Size(414, 44);
            this.rtb_write.TabIndex = 44;
            this.rtb_write.Text = "※在編輯數值與新增資料格式後，請點擊寫入按鈕進行寫入。";
            // 
            // btn_Write
            // 
            this.btn_Write.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Write.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Write.Location = new System.Drawing.Point(279, 173);
            this.btn_Write.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Write.Name = "btn_Write";
            this.btn_Write.Size = new System.Drawing.Size(122, 45);
            this.btn_Write.TabIndex = 43;
            this.btn_Write.Text = "Write Value ";
            this.btn_Write.UseVisualStyleBackColor = true;
            this.btn_Write.Click += new System.EventHandler(this.btn_Write_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lbl_xmlfilename);
            this.groupBox2.Controls.Add(this.btn_new);
            this.groupBox2.Controls.Add(this.btn_reset);
            this.groupBox2.Controls.Add(this.rtb_descripe);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lbl_mode);
            this.groupBox2.Controls.Add(this.btn_create);
            this.groupBox2.Controls.Add(this.lbl_port);
            this.groupBox2.Controls.Add(this.lbl_xml);
            this.groupBox2.Controls.Add(this.tbx_mode);
            this.groupBox2.Controls.Add(this.tbx_ID);
            this.groupBox2.Controls.Add(this.tbx_MessageID);
            this.groupBox2.Controls.Add(this.tbx_portid);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(13, 5);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(256, 229);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Message ID";
            // 
            // lbl_xmlfilename
            // 
            this.lbl_xmlfilename.AutoSize = true;
            this.lbl_xmlfilename.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_xmlfilename.Location = new System.Drawing.Point(53, 24);
            this.lbl_xmlfilename.Name = "lbl_xmlfilename";
            this.lbl_xmlfilename.Size = new System.Drawing.Size(44, 17);
            this.lbl_xmlfilename.TabIndex = 54;
            this.lbl_xmlfilename.Text = "Name";
            // 
            // btn_new
            // 
            this.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new.Location = new System.Drawing.Point(12, 174);
            this.btn_new.Margin = new System.Windows.Forms.Padding(5);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(98, 33);
            this.btn_new.TabIndex = 53;
            this.btn_new.Text = "Create";
            this.btn_new.UseVisualStyleBackColor = true;
            // 
            // btn_reset
            // 
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Location = new System.Drawing.Point(140, 173);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(5);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(97, 33);
            this.btn_reset.TabIndex = 34;
            this.btn_reset.Text = "ReSet ID";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // rtb_descripe
            // 
            this.rtb_descripe.BackColor = System.Drawing.Color.Beige;
            this.rtb_descripe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_descripe.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rtb_descripe.Location = new System.Drawing.Point(12, 121);
            this.rtb_descripe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtb_descripe.Name = "rtb_descripe";
            this.rtb_descripe.ReadOnly = true;
            this.rtb_descripe.Size = new System.Drawing.Size(225, 44);
            this.rtb_descripe.TabIndex = 33;
            this.rtb_descripe.Text = "※設定該資料集合之ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 53);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 15);
            this.label6.TabIndex = 32;
            this.label6.Text = "ID:";
            // 
            // lbl_mode
            // 
            this.lbl_mode.AutoSize = true;
            this.lbl_mode.Location = new System.Drawing.Point(124, 84);
            this.lbl_mode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_mode.Name = "lbl_mode";
            this.lbl_mode.Size = new System.Drawing.Size(45, 15);
            this.lbl_mode.TabIndex = 52;
            this.lbl_mode.Text = "Mode:";
            // 
            // lbl_port
            // 
            this.lbl_port.AutoSize = true;
            this.lbl_port.Location = new System.Drawing.Point(12, 84);
            this.lbl_port.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_port.Name = "lbl_port";
            this.lbl_port.Size = new System.Drawing.Size(48, 15);
            this.lbl_port.TabIndex = 51;
            this.lbl_port.Text = "Port ID:";
            // 
            // tbx_mode
            // 
            this.tbx_mode.BackColor = System.Drawing.Color.Beige;
            this.tbx_mode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_mode.Location = new System.Drawing.Point(177, 82);
            this.tbx_mode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbx_mode.Name = "tbx_mode";
            this.tbx_mode.Size = new System.Drawing.Size(51, 23);
            this.tbx_mode.TabIndex = 50;
            // 
            // tbx_MessageID
            // 
            this.tbx_MessageID.BackColor = System.Drawing.Color.Beige;
            this.tbx_MessageID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_MessageID.Location = new System.Drawing.Point(56, 50);
            this.tbx_MessageID.Margin = new System.Windows.Forms.Padding(5);
            this.tbx_MessageID.Name = "tbx_MessageID";
            this.tbx_MessageID.Size = new System.Drawing.Size(172, 23);
            this.tbx_MessageID.TabIndex = 30;
            // 
            // tbx_portid
            // 
            this.tbx_portid.BackColor = System.Drawing.Color.Beige;
            this.tbx_portid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_portid.Location = new System.Drawing.Point(68, 82);
            this.tbx_portid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbx_portid.Name = "tbx_portid";
            this.tbx_portid.Size = new System.Drawing.Size(48, 23);
            this.tbx_portid.TabIndex = 48;
            // 
            // dgv_Data
            // 
            this.dgv_Data.BackgroundColor = System.Drawing.Color.Beige;
            this.dgv_Data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Data.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSalmon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Data.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Data.GridColor = System.Drawing.Color.Salmon;
            this.dgv_Data.Location = new System.Drawing.Point(279, 229);
            this.dgv_Data.Margin = new System.Windows.Forms.Padding(5);
            this.dgv_Data.Name = "dgv_Data";
            this.dgv_Data.RowTemplate.Height = 24;
            this.dgv_Data.Size = new System.Drawing.Size(546, 185);
            this.dgv_Data.TabIndex = 41;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbb_end);
            this.groupBox1.Controls.Add(this.lbl_end);
            this.groupBox1.Controls.Add(this.btn_delete_data);
            this.groupBox1.Controls.Add(this.rtb_data);
            this.groupBox1.Controls.Add(this.btn_Add);
            this.groupBox1.Controls.Add(this.tbx_Data_Size);
            this.groupBox1.Controls.Add(this.tbx_Data_msb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbx_Data_lsb);
            this.groupBox1.Controls.Add(this.tbx_Data_Name);
            this.groupBox1.Controls.Add(this.cbb_DataType);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(279, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(546, 158);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data";
            // 
            // cbb_end
            // 
            this.cbb_end.BackColor = System.Drawing.Color.Beige;
            this.cbb_end.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbb_end.FormattingEnabled = true;
            this.cbb_end.Items.AddRange(new object[] {
            "Little - End",
            "Big - End"});
            this.cbb_end.Location = new System.Drawing.Point(435, 50);
            this.cbb_end.Margin = new System.Windows.Forms.Padding(5);
            this.cbb_end.MaxDropDownItems = 3;
            this.cbb_end.Name = "cbb_end";
            this.cbb_end.Size = new System.Drawing.Size(87, 23);
            this.cbb_end.TabIndex = 25;
            // 
            // lbl_end
            // 
            this.lbl_end.AutoSize = true;
            this.lbl_end.Location = new System.Drawing.Point(432, 27);
            this.lbl_end.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_end.Name = "lbl_end";
            this.lbl_end.Size = new System.Drawing.Size(49, 15);
            this.lbl_end.TabIndex = 24;
            this.lbl_end.Text = "Endian:";
            // 
            // btn_delete_data
            // 
            this.btn_delete_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_data.Location = new System.Drawing.Point(460, 119);
            this.btn_delete_data.Margin = new System.Windows.Forms.Padding(5);
            this.btn_delete_data.Name = "btn_delete_data";
            this.btn_delete_data.Size = new System.Drawing.Size(61, 29);
            this.btn_delete_data.TabIndex = 23;
            this.btn_delete_data.Text = "Delete";
            this.btn_delete_data.UseVisualStyleBackColor = true;
            this.btn_delete_data.Click += new System.EventHandler(this.btn_delete_data_Click);
            // 
            // rtb_data
            // 
            this.rtb_data.BackColor = System.Drawing.Color.Beige;
            this.rtb_data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_data.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rtb_data.Location = new System.Drawing.Point(13, 86);
            this.rtb_data.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtb_data.Name = "rtb_data";
            this.rtb_data.ReadOnly = true;
            this.rtb_data.Size = new System.Drawing.Size(438, 59);
            this.rtb_data.TabIndex = 22;
            this.rtb_data.Text = "※在選取的Xml檔案中新增資料格式 : \n※名稱 : 資料名稱 ，類型 : 資料型別 ，資料大小(Bits)，起始Bit，結束Bit。";
            // 
            // btn_Add
            // 
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Location = new System.Drawing.Point(460, 86);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(61, 29);
            this.btn_Add.TabIndex = 21;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // tbx_Data_Size
            // 
            this.tbx_Data_Size.BackColor = System.Drawing.Color.Beige;
            this.tbx_Data_Size.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_Data_Size.Location = new System.Drawing.Point(227, 50);
            this.tbx_Data_Size.Margin = new System.Windows.Forms.Padding(5);
            this.tbx_Data_Size.Name = "tbx_Data_Size";
            this.tbx_Data_Size.Size = new System.Drawing.Size(61, 23);
            this.tbx_Data_Size.TabIndex = 13;
            // 
            // tbx_Data_msb
            // 
            this.tbx_Data_msb.BackColor = System.Drawing.Color.Beige;
            this.tbx_Data_msb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_Data_msb.Location = new System.Drawing.Point(371, 50);
            this.tbx_Data_msb.Margin = new System.Windows.Forms.Padding(5);
            this.tbx_Data_msb.Name = "tbx_Data_msb";
            this.tbx_Data_msb.Size = new System.Drawing.Size(56, 23);
            this.tbx_Data_msb.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(368, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "msb:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "lsb:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Size:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Name:";
            // 
            // tbx_Data_lsb
            // 
            this.tbx_Data_lsb.BackColor = System.Drawing.Color.Beige;
            this.tbx_Data_lsb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_Data_lsb.Location = new System.Drawing.Point(298, 50);
            this.tbx_Data_lsb.Margin = new System.Windows.Forms.Padding(5);
            this.tbx_Data_lsb.Name = "tbx_Data_lsb";
            this.tbx_Data_lsb.Size = new System.Drawing.Size(63, 23);
            this.tbx_Data_lsb.TabIndex = 14;
            // 
            // tbx_Data_Name
            // 
            this.tbx_Data_Name.BackColor = System.Drawing.Color.Beige;
            this.tbx_Data_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_Data_Name.Location = new System.Drawing.Point(13, 50);
            this.tbx_Data_Name.Margin = new System.Windows.Forms.Padding(5);
            this.tbx_Data_Name.Name = "tbx_Data_Name";
            this.tbx_Data_Name.Size = new System.Drawing.Size(109, 23);
            this.tbx_Data_Name.TabIndex = 12;
            // 
            // cbb_DataType
            // 
            this.cbb_DataType.BackColor = System.Drawing.Color.Beige;
            this.cbb_DataType.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbb_DataType.FormattingEnabled = true;
            this.cbb_DataType.Items.AddRange(new object[] {
            "Bit",
            "Byte",
            "Ushort",
            "Uint"});
            this.cbb_DataType.Location = new System.Drawing.Point(132, 50);
            this.cbb_DataType.Margin = new System.Windows.Forms.Padding(5);
            this.cbb_DataType.MaxDropDownItems = 3;
            this.cbb_DataType.Name = "cbb_DataType";
            this.cbb_DataType.Size = new System.Drawing.Size(87, 23);
            this.cbb_DataType.TabIndex = 11;
            // 
            // btn_ReadCan
            // 
            this.btn_ReadCan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ReadCan.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_ReadCan.Location = new System.Drawing.Point(152, 18);
            this.btn_ReadCan.Margin = new System.Windows.Forms.Padding(5);
            this.btn_ReadCan.Name = "btn_ReadCan";
            this.btn_ReadCan.Size = new System.Drawing.Size(105, 44);
            this.btn_ReadCan.TabIndex = 45;
            this.btn_ReadCan.Text = "Read From Canbus";
            this.btn_ReadCan.UseVisualStyleBackColor = true;
            this.btn_ReadCan.Click += new System.EventHandler(this.btn_ReadCan_Click);
            // 
            // btn_WriteCan
            // 
            this.btn_WriteCan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_WriteCan.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_WriteCan.Location = new System.Drawing.Point(267, 18);
            this.btn_WriteCan.Margin = new System.Windows.Forms.Padding(5);
            this.btn_WriteCan.Name = "btn_WriteCan";
            this.btn_WriteCan.Size = new System.Drawing.Size(105, 44);
            this.btn_WriteCan.TabIndex = 46;
            this.btn_WriteCan.Text = "Write  To CanBus";
            this.btn_WriteCan.UseVisualStyleBackColor = true;
            this.btn_WriteCan.Click += new System.EventHandler(this.btn_WriteCan_Click);
            // 
            // tbx_dlc
            // 
            this.tbx_dlc.BackColor = System.Drawing.Color.Beige;
            this.tbx_dlc.Location = new System.Drawing.Point(59, 28);
            this.tbx_dlc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbx_dlc.Name = "tbx_dlc";
            this.tbx_dlc.Size = new System.Drawing.Size(79, 23);
            this.tbx_dlc.TabIndex = 49;
            // 
            // lbl_dlc
            // 
            this.lbl_dlc.AutoSize = true;
            this.lbl_dlc.Location = new System.Drawing.Point(18, 31);
            this.lbl_dlc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dlc.Name = "lbl_dlc";
            this.lbl_dlc.Size = new System.Drawing.Size(33, 15);
            this.lbl_dlc.TabIndex = 53;
            this.lbl_dlc.Text = "DLC:";
            // 
            // gbx_com
            // 
            this.gbx_com.BackColor = System.Drawing.Color.Transparent;
            this.gbx_com.Controls.Add(this.rdb_dec);
            this.gbx_com.Controls.Add(this.rdb_hex);
            this.gbx_com.Controls.Add(this.lbl_extid);
            this.gbx_com.Controls.Add(this.btn_ReadCan);
            this.gbx_com.Controls.Add(this.lbl_dlc);
            this.gbx_com.Controls.Add(this.tbx_dlc);
            this.gbx_com.Controls.Add(this.btn_WriteCan);
            this.gbx_com.Controls.Add(this.tbx_extid);
            this.gbx_com.Location = new System.Drawing.Point(279, 421);
            this.gbx_com.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbx_com.Name = "gbx_com";
            this.gbx_com.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbx_com.Size = new System.Drawing.Size(473, 72);
            this.gbx_com.TabIndex = 55;
            this.gbx_com.TabStop = false;
            this.gbx_com.Text = "CanBus Operator";
            // 
            // rdb_dec
            // 
            this.rdb_dec.AutoSize = true;
            this.rdb_dec.Location = new System.Drawing.Point(380, 44);
            this.rdb_dec.Name = "rdb_dec";
            this.rdb_dec.Size = new System.Drawing.Size(47, 19);
            this.rdb_dec.TabIndex = 56;
            this.rdb_dec.TabStop = true;
            this.rdb_dec.Text = "Dec";
            this.rdb_dec.UseVisualStyleBackColor = true;
            // 
            // rdb_hex
            // 
            this.rdb_hex.AutoSize = true;
            this.rdb_hex.Location = new System.Drawing.Point(380, 18);
            this.rdb_hex.Name = "rdb_hex";
            this.rdb_hex.Size = new System.Drawing.Size(47, 19);
            this.rdb_hex.TabIndex = 55;
            this.rdb_hex.TabStop = true;
            this.rdb_hex.Text = "Hex";
            this.rdb_hex.UseVisualStyleBackColor = true;
            this.rdb_hex.CheckedChanged += new System.EventHandler(this.rdb_hex_CheckedChanged);
            // 
            // lbl_extid
            // 
            this.lbl_extid.AutoSize = true;
            this.lbl_extid.Enabled = false;
            this.lbl_extid.Location = new System.Drawing.Point(12, 46);
            this.lbl_extid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_extid.Name = "lbl_extid";
            this.lbl_extid.Size = new System.Drawing.Size(39, 15);
            this.lbl_extid.TabIndex = 54;
            this.lbl_extid.Text = "ExtID:";
            this.lbl_extid.Visible = false;
            // 
            // tbx_extid
            // 
            this.tbx_extid.BackColor = System.Drawing.Color.Beige;
            this.tbx_extid.Enabled = false;
            this.tbx_extid.Location = new System.Drawing.Point(59, 39);
            this.tbx_extid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbx_extid.Name = "tbx_extid";
            this.tbx_extid.Size = new System.Drawing.Size(79, 23);
            this.tbx_extid.TabIndex = 47;
            this.tbx_extid.Visible = false;
            // 
            // btn_exit
            // 
            this.btn_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Location = new System.Drawing.Point(760, 428);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(65, 64);
            this.btn_exit.TabIndex = 56;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // ExitTimer
            // 
            this.ExitTimer.Interval = 5;
            this.ExitTimer.Tick += new System.EventHandler(this.ExitTimer_Tick);
            // 
            // OpenTimer
            // 
            this.OpenTimer.Interval = 5;
            this.OpenTimer.Tick += new System.EventHandler(this.OpenTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.gbx_com);
            this.panel1.Controls.Add(this.rtb_write);
            this.panel1.Controls.Add(this.btn_Write);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.dgv_Data);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(1, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 504);
            this.panel1.TabIndex = 57;
            // 
            // SetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btn_exit;
            this.ClientSize = new System.Drawing.Size(842, 534);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Panel_Title);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SetForm";
            this.Activated += new System.EventHandler(this.Main_Activated);
            this.Deactivate += new System.EventHandler(this.Main_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SetForm_FormClosing);
            this.Panel_Title.ResumeLayout(false);
            this.Panel_Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbx_com.ResumeLayout(false);
            this.gbx_com.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_X;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox rtb_file;
        private System.Windows.Forms.Label lbl_xml;
        private System.Windows.Forms.TextBox tbx_ID;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.ListBox lsb_Xmlfilelist;
        private System.Windows.Forms.RichTextBox rtb_write;
        private System.Windows.Forms.Button btn_Write;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtb_descripe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbx_MessageID;
        private System.Windows.Forms.DataGridView dgv_Data;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_delete_data;
        private System.Windows.Forms.RichTextBox rtb_data;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox tbx_Data_Size;
        private System.Windows.Forms.TextBox tbx_Data_msb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_Data_lsb;
        private System.Windows.Forms.TextBox tbx_Data_Name;
        private System.Windows.Forms.ComboBox cbb_DataType;
        private System.Windows.Forms.Button btn_ReadCan;
        private System.Windows.Forms.Button btn_WriteCan;
        private System.Windows.Forms.TextBox tbx_portid;
        private System.Windows.Forms.TextBox tbx_dlc;
        private System.Windows.Forms.TextBox tbx_mode;
        private System.Windows.Forms.Label lbl_port;
        private System.Windows.Forms.Label lbl_mode;
        private System.Windows.Forms.Label lbl_dlc;
        private System.Windows.Forms.GroupBox gbx_com;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.RadioButton rdb_dec;
        private System.Windows.Forms.RadioButton rdb_hex;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Label lbl_xmlfilename;
        private System.Windows.Forms.Label lbl_extid;
        private System.Windows.Forms.TextBox tbx_extid;
        private System.Windows.Forms.ComboBox cbb_end;
        private System.Windows.Forms.Label lbl_end;
        private System.Windows.Forms.Timer ExitTimer;
        private System.Windows.Forms.Timer OpenTimer;
        private System.Windows.Forms.Panel panel1;
    }
}