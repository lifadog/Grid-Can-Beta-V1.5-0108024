using System.Drawing;
using System.Windows.Forms;

namespace test0515
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.rtb_console = new System.Windows.Forms.RichTextBox();
            this.btn_Open = new System.Windows.Forms.Button();
            this.Panel_Title = new System.Windows.Forms.Panel();
            this.pnl_form = new System.Windows.Forms.Panel();
            this.lbl_mini = new System.Windows.Forms.Label();
            this.ptb_size = new System.Windows.Forms.PictureBox();
            this.lbl_X = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_SetXml = new System.Windows.Forms.Button();
            this.pnl_control = new System.Windows.Forms.Panel();
            this.pnl_lsb = new System.Windows.Forms.Panel();
            this.lbl_lsb = new System.Windows.Forms.Label();
            this.btn_fly = new System.Windows.Forms.Button();
            this.gbx_ctrl_xmlfile_data = new System.Windows.Forms.GroupBox();
            this.lsb_ctrl_xmlfile_data = new System.Windows.Forms.ListBox();
            this.btn_drop = new System.Windows.Forms.Button();
            this.gbx_ctrl_xmlfile = new System.Windows.Forms.GroupBox();
            this.lsb_ctrl_xmlfile = new System.Windows.Forms.ListBox();
            this.pnl_ctrl = new System.Windows.Forms.Panel();
            this.pnl_tempctrl = new System.Windows.Forms.Panel();
            this.pnl_update = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_updset = new System.Windows.Forms.Button();
            this.pnl_ccom = new System.Windows.Forms.Panel();
            this.btn_ccomsave = new System.Windows.Forms.Button();
            this.btn_ccomopen = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tbx_DLC = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tbx_Pid = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tbx_ID = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btn_writeccom = new System.Windows.Forms.Button();
            this.btn_readccom = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbl_g5 = new System.Windows.Forms.Label();
            this.lbl_g1 = new System.Windows.Forms.Label();
            this.lbl_g4 = new System.Windows.Forms.Label();
            this.lbl_g2 = new System.Windows.Forms.Label();
            this.lbl_g3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbx_g5_type = new System.Windows.Forms.TextBox();
            this.tbx_g4_type = new System.Windows.Forms.TextBox();
            this.tbx_g3_type = new System.Windows.Forms.TextBox();
            this.tbx_g2_type = new System.Windows.Forms.TextBox();
            this.tbx_g1_type = new System.Windows.Forms.TextBox();
            this.tbx_g5_v = new System.Windows.Forms.TextBox();
            this.tbx_g4_v = new System.Windows.Forms.TextBox();
            this.tbx_g3_v = new System.Windows.Forms.TextBox();
            this.tbx_g2_v = new System.Windows.Forms.TextBox();
            this.tbx_g1_v = new System.Windows.Forms.TextBox();
            this.tbx_g5_msb = new System.Windows.Forms.TextBox();
            this.tbx_g4_msb = new System.Windows.Forms.TextBox();
            this.tbx_g3_msb = new System.Windows.Forms.TextBox();
            this.tbx_g2_msb = new System.Windows.Forms.TextBox();
            this.tbx_g1_msb = new System.Windows.Forms.TextBox();
            this.tbx_g5_lsb = new System.Windows.Forms.TextBox();
            this.tbx_g4_lsb = new System.Windows.Forms.TextBox();
            this.tbx_g3_lsb = new System.Windows.Forms.TextBox();
            this.tbx_g2_lsb = new System.Windows.Forms.TextBox();
            this.tbx_g1_lsb = new System.Windows.Forms.TextBox();
            this.tbx_g5_size = new System.Windows.Forms.TextBox();
            this.tbx_g4_size = new System.Windows.Forms.TextBox();
            this.tbx_g3_size = new System.Windows.Forms.TextBox();
            this.tbx_g2_size = new System.Windows.Forms.TextBox();
            this.tbx_g1_size = new System.Windows.Forms.TextBox();
            this.btn_ccomset = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pnl_supersu = new System.Windows.Forms.Panel();
            this.btn_console = new System.Windows.Forms.Button();
            this.tb_console = new System.Windows.Forms.TextBox();
            this.rtb_suCon = new System.Windows.Forms.RichTextBox();
            this.btn_suset = new System.Windows.Forms.Button();
            this.rtb_su = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pnl_filepath = new System.Windows.Forms.Panel();
            this.pnl_baud = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_baudset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_getcandata = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_baud0 = new System.Windows.Forms.ComboBox();
            this.gbx_connect = new System.Windows.Forms.GroupBox();
            this.cbb_port = new System.Windows.Forms.ComboBox();
            this.rb_canpro = new System.Windows.Forms.RadioButton();
            this.cbb_baud1 = new System.Windows.Forms.ComboBox();
            this.pnl_lan = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_lan = new System.Windows.Forms.Label();
            this.btn_lanok = new System.Windows.Forms.Button();
            this.cbb_lan = new System.Windows.Forms.ComboBox();
            this.btn_lan = new System.Windows.Forms.Button();
            this.pnl_info = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.ptb_info = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_infook = new System.Windows.Forms.Button();
            this.btn_ctrlopen = new System.Windows.Forms.Button();
            this.btn_ctrlsave = new System.Windows.Forms.Button();
            this.btn_canopen = new System.Windows.Forms.Button();
            this.ptb_com = new System.Windows.Forms.PictureBox();
            this.gbx_can = new System.Windows.Forms.GroupBox();
            this.lbl_comsta = new System.Windows.Forms.Label();
            this.ptb_conn = new System.Windows.Forms.PictureBox();
            this.lbl_state = new System.Windows.Forms.Label();
            this.gbx_config = new System.Windows.Forms.GroupBox();
            this.cbx_autoconfig = new System.Windows.Forms.CheckBox();
            this.btn_ID = new System.Windows.Forms.Button();
            this.CanbusTimer = new System.Windows.Forms.Timer(this.components);
            this.btn_Exit = new System.Windows.Forms.Button();
            this.pnl_under = new System.Windows.Forms.Panel();
            this.pnl_st = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.ExitTimer = new System.Windows.Forms.Timer(this.components);
            this.OpenTimer = new System.Windows.Forms.Timer(this.components);
            this.ConnTimer = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnl_ctrlnum = new System.Windows.Forms.Panel();
            this.tbx_ctrlnum = new System.Windows.Forms.TextBox();
            this.btn_ctrlnumset = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.menu = new test0515.menubar();
            this.Panel_Title.SuspendLayout();
            this.pnl_form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_control.SuspendLayout();
            this.pnl_lsb.SuspendLayout();
            this.gbx_ctrl_xmlfile_data.SuspendLayout();
            this.gbx_ctrl_xmlfile.SuspendLayout();
            this.pnl_ctrl.SuspendLayout();
            this.pnl_tempctrl.SuspendLayout();
            this.pnl_update.SuspendLayout();
            this.pnl_ccom.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.pnl_supersu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.pnl_baud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gbx_connect.SuspendLayout();
            this.pnl_lan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnl_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_com)).BeginInit();
            this.gbx_can.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_conn)).BeginInit();
            this.gbx_config.SuspendLayout();
            this.pnl_under.SuspendLayout();
            this.pnl_st.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel3.SuspendLayout();
            this.pnl_ctrlnum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // rtb_console
            // 
            this.rtb_console.BackColor = System.Drawing.Color.LemonChiffon;
            this.rtb_console.CausesValidation = false;
            this.rtb_console.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_console.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rtb_console.Location = new System.Drawing.Point(563, 11);
            this.rtb_console.Margin = new System.Windows.Forms.Padding(4);
            this.rtb_console.Name = "rtb_console";
            this.rtb_console.ReadOnly = true;
            this.rtb_console.Size = new System.Drawing.Size(703, 80);
            this.rtb_console.TabIndex = 25;
            this.rtb_console.Text = "";
            // 
            // btn_Open
            // 
            this.btn_Open.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_Open.BackgroundImage = global::test0515.Properties.Resources.btn2;
            this.btn_Open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Open.ForeColor = System.Drawing.Color.Black;
            this.btn_Open.Location = new System.Drawing.Point(13, 23);
            this.btn_Open.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(102, 29);
            this.btn_Open.TabIndex = 29;
            this.btn_Open.Text = "FilePath";
            this.btn_Open.UseVisualStyleBackColor = false;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // Panel_Title
            // 
            this.Panel_Title.BackColor = System.Drawing.Color.White;
            this.Panel_Title.BackgroundImage = global::test0515.Properties.Resources.title_1;
            this.Panel_Title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel_Title.Controls.Add(this.pnl_form);
            this.Panel_Title.Controls.Add(this.pictureBox1);
            this.Panel_Title.Controls.Add(this.lbl_Title);
            this.Panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Title.Location = new System.Drawing.Point(0, 0);
            this.Panel_Title.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Panel_Title.Name = "Panel_Title";
            this.Panel_Title.Size = new System.Drawing.Size(1380, 29);
            this.Panel_Title.TabIndex = 32;
            this.Panel_Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.Panel_Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.Panel_Title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // pnl_form
            // 
            this.pnl_form.BackColor = System.Drawing.Color.Transparent;
            this.pnl_form.Controls.Add(this.lbl_mini);
            this.pnl_form.Controls.Add(this.ptb_size);
            this.pnl_form.Controls.Add(this.lbl_X);
            this.pnl_form.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_form.Location = new System.Drawing.Point(1230, 0);
            this.pnl_form.Name = "pnl_form";
            this.pnl_form.Size = new System.Drawing.Size(150, 29);
            this.pnl_form.TabIndex = 5;
            // 
            // lbl_mini
            // 
            this.lbl_mini.AutoSize = true;
            this.lbl_mini.BackColor = System.Drawing.Color.Transparent;
            this.lbl_mini.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_mini.ForeColor = System.Drawing.Color.White;
            this.lbl_mini.Location = new System.Drawing.Point(0, 6);
            this.lbl_mini.Name = "lbl_mini";
            this.lbl_mini.Size = new System.Drawing.Size(22, 19);
            this.lbl_mini.TabIndex = 4;
            this.lbl_mini.Text = "—";
            // 
            // ptb_size
            // 
            this.ptb_size.BackColor = System.Drawing.Color.Transparent;
            this.ptb_size.Image = ((System.Drawing.Image)(resources.GetObject("ptb_size.Image")));
            this.ptb_size.Location = new System.Drawing.Point(62, 7);
            this.ptb_size.Name = "ptb_size";
            this.ptb_size.Size = new System.Drawing.Size(18, 18);
            this.ptb_size.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_size.TabIndex = 3;
            this.ptb_size.TabStop = false;
            // 
            // lbl_X
            // 
            this.lbl_X.AutoSize = true;
            this.lbl_X.BackColor = System.Drawing.Color.Transparent;
            this.lbl_X.Font = new System.Drawing.Font("Corbel", 15F);
            this.lbl_X.ForeColor = System.Drawing.Color.White;
            this.lbl_X.Location = new System.Drawing.Point(121, 4);
            this.lbl_X.Name = "lbl_X";
            this.lbl_X.Size = new System.Drawing.Size(22, 24);
            this.lbl_X.TabIndex = 1;
            this.lbl_X.Text = "X";
            this.lbl_X.Click += new System.EventHandler(this.lbl_X_Click);
            this.lbl_X.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.lbl_X.MouseLeave += new System.EventHandler(this.lbl_X_MouseLeave);
            this.lbl_X.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_X_MouseMove);
            this.lbl_X.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::test0515.Properties.Resources.ll_removebg_preview1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Title.Location = new System.Drawing.Point(32, 5);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(75, 20);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Gird Can";
            this.lbl_Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.lbl_Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.lbl_Title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btn_SetXml
            // 
            this.btn_SetXml.BackgroundImage = global::test0515.Properties.Resources.btn2;
            this.btn_SetXml.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_SetXml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SetXml.Location = new System.Drawing.Point(123, 13);
            this.btn_SetXml.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SetXml.Name = "btn_SetXml";
            this.btn_SetXml.Size = new System.Drawing.Size(88, 80);
            this.btn_SetXml.TabIndex = 35;
            this.btn_SetXml.Text = "Edit Data";
            this.btn_SetXml.UseVisualStyleBackColor = true;
            this.btn_SetXml.Click += new System.EventHandler(this.btn_dgv_Click);
            // 
            // pnl_control
            // 
            this.pnl_control.AllowDrop = true;
            this.pnl_control.BackColor = System.Drawing.Color.Beige;
            this.pnl_control.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_control.Controls.Add(this.pnl_lsb);
            this.pnl_control.Controls.Add(this.pnl_ctrl);
            this.pnl_control.Location = new System.Drawing.Point(12, 31);
            this.pnl_control.Name = "pnl_control";
            this.pnl_control.Size = new System.Drawing.Size(1365, 604);
            this.pnl_control.TabIndex = 37;
            // 
            // pnl_lsb
            // 
            this.pnl_lsb.Controls.Add(this.lbl_lsb);
            this.pnl_lsb.Controls.Add(this.btn_fly);
            this.pnl_lsb.Controls.Add(this.gbx_ctrl_xmlfile_data);
            this.pnl_lsb.Controls.Add(this.btn_drop);
            this.pnl_lsb.Controls.Add(this.gbx_ctrl_xmlfile);
            this.pnl_lsb.Location = new System.Drawing.Point(1, 10);
            this.pnl_lsb.Name = "pnl_lsb";
            this.pnl_lsb.Size = new System.Drawing.Size(182, 594);
            this.pnl_lsb.TabIndex = 4;
            // 
            // lbl_lsb
            // 
            this.lbl_lsb.AutoSize = true;
            this.lbl_lsb.BackColor = System.Drawing.Color.Transparent;
            this.lbl_lsb.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_lsb.Location = new System.Drawing.Point(100, 551);
            this.lbl_lsb.Name = "lbl_lsb";
            this.lbl_lsb.Size = new System.Drawing.Size(74, 28);
            this.lbl_lsb.TabIndex = 59;
            this.lbl_lsb.Text = "Beta V 2.0.1 \r\n0241807-F1\r\n";
            // 
            // btn_fly
            // 
            this.btn_fly.BackColor = System.Drawing.Color.White;
            this.btn_fly.BackgroundImage = global::test0515.Properties.Resources.btn2;
            this.btn_fly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_fly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fly.Location = new System.Drawing.Point(11, 549);
            this.btn_fly.Margin = new System.Windows.Forms.Padding(4);
            this.btn_fly.Name = "btn_fly";
            this.btn_fly.Size = new System.Drawing.Size(83, 30);
            this.btn_fly.TabIndex = 38;
            this.btn_fly.Text = "Floating";
            this.btn_fly.UseVisualStyleBackColor = false;
            // 
            // gbx_ctrl_xmlfile_data
            // 
            this.gbx_ctrl_xmlfile_data.Controls.Add(this.lsb_ctrl_xmlfile_data);
            this.gbx_ctrl_xmlfile_data.Location = new System.Drawing.Point(5, 252);
            this.gbx_ctrl_xmlfile_data.Name = "gbx_ctrl_xmlfile_data";
            this.gbx_ctrl_xmlfile_data.Size = new System.Drawing.Size(169, 290);
            this.gbx_ctrl_xmlfile_data.TabIndex = 2;
            this.gbx_ctrl_xmlfile_data.TabStop = false;
            this.gbx_ctrl_xmlfile_data.Text = "Value";
            // 
            // lsb_ctrl_xmlfile_data
            // 
            this.lsb_ctrl_xmlfile_data.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lsb_ctrl_xmlfile_data.FormattingEnabled = true;
            this.lsb_ctrl_xmlfile_data.ItemHeight = 15;
            this.lsb_ctrl_xmlfile_data.Location = new System.Drawing.Point(6, 21);
            this.lsb_ctrl_xmlfile_data.Name = "lsb_ctrl_xmlfile_data";
            this.lsb_ctrl_xmlfile_data.Size = new System.Drawing.Size(157, 259);
            this.lsb_ctrl_xmlfile_data.TabIndex = 2;
            // 
            // btn_drop
            // 
            this.btn_drop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_drop.Location = new System.Drawing.Point(11, 549);
            this.btn_drop.Margin = new System.Windows.Forms.Padding(4);
            this.btn_drop.Name = "btn_drop";
            this.btn_drop.Size = new System.Drawing.Size(83, 30);
            this.btn_drop.TabIndex = 39;
            this.btn_drop.Text = "Drop";
            this.btn_drop.UseVisualStyleBackColor = true;
            this.btn_drop.Visible = false;
            // 
            // gbx_ctrl_xmlfile
            // 
            this.gbx_ctrl_xmlfile.Controls.Add(this.lsb_ctrl_xmlfile);
            this.gbx_ctrl_xmlfile.Location = new System.Drawing.Point(5, 3);
            this.gbx_ctrl_xmlfile.Name = "gbx_ctrl_xmlfile";
            this.gbx_ctrl_xmlfile.Size = new System.Drawing.Size(169, 244);
            this.gbx_ctrl_xmlfile.TabIndex = 1;
            this.gbx_ctrl_xmlfile.TabStop = false;
            this.gbx_ctrl_xmlfile.Text = "ID";
            // 
            // lsb_ctrl_xmlfile
            // 
            this.lsb_ctrl_xmlfile.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lsb_ctrl_xmlfile.FormattingEnabled = true;
            this.lsb_ctrl_xmlfile.ItemHeight = 15;
            this.lsb_ctrl_xmlfile.Location = new System.Drawing.Point(6, 21);
            this.lsb_ctrl_xmlfile.Name = "lsb_ctrl_xmlfile";
            this.lsb_ctrl_xmlfile.Size = new System.Drawing.Size(157, 214);
            this.lsb_ctrl_xmlfile.TabIndex = 1;
            this.lsb_ctrl_xmlfile.SelectedIndexChanged += new System.EventHandler(this.Lsb_Ctrl_XmlFile_SelectedIndexChanged);
            // 
            // pnl_ctrl
            // 
            this.pnl_ctrl.AllowDrop = true;
            this.pnl_ctrl.AutoScroll = true;
            this.pnl_ctrl.BackColor = System.Drawing.Color.Beige;
            this.pnl_ctrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_ctrl.Controls.Add(this.pnl_tempctrl);
            this.pnl_ctrl.Location = new System.Drawing.Point(189, 9);
            this.pnl_ctrl.Name = "pnl_ctrl";
            this.pnl_ctrl.Size = new System.Drawing.Size(1156, 594);
            this.pnl_ctrl.TabIndex = 3;
            // 
            // pnl_tempctrl
            // 
            this.pnl_tempctrl.Controls.Add(this.pnl_ctrlnum);
            this.pnl_tempctrl.Controls.Add(this.pnl_update);
            this.pnl_tempctrl.Controls.Add(this.pnl_ccom);
            this.pnl_tempctrl.Controls.Add(this.pnl_supersu);
            this.pnl_tempctrl.Controls.Add(this.pnl_filepath);
            this.pnl_tempctrl.Controls.Add(this.pnl_baud);
            this.pnl_tempctrl.Controls.Add(this.pnl_lan);
            this.pnl_tempctrl.Controls.Add(this.btn_Open);
            this.pnl_tempctrl.Controls.Add(this.pnl_info);
            this.pnl_tempctrl.Controls.Add(this.btn_SetXml);
            this.pnl_tempctrl.Location = new System.Drawing.Point(777, 24);
            this.pnl_tempctrl.Name = "pnl_tempctrl";
            this.pnl_tempctrl.Size = new System.Drawing.Size(302, 10);
            this.pnl_tempctrl.TabIndex = 60;
            this.pnl_tempctrl.Visible = false;
            // 
            // pnl_update
            // 
            this.pnl_update.BackgroundImage = global::test0515.Properties.Resources.Flow_3x2;
            this.pnl_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_update.Controls.Add(this.label12);
            this.pnl_update.Controls.Add(this.label11);
            this.pnl_update.Controls.Add(this.label10);
            this.pnl_update.Controls.Add(this.btn_updset);
            this.pnl_update.Location = new System.Drawing.Point(223, 103);
            this.pnl_update.Name = "pnl_update";
            this.pnl_update.Size = new System.Drawing.Size(411, 254);
            this.pnl_update.TabIndex = 61;
            this.pnl_update.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(79, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(260, 126);
            this.label12.TabIndex = 64;
            this.label12.Text = "．F5快捷鍵，連線或中斷CanPro連線。\r\n\r\n．F6快捷鍵，開啟界面設定檔案。\r\n\r\n．F7快捷鍵，開啟資料編輯視窗。\r\n\r\n．F8快捷鍵，開發人員測試工具。" +
    "\r\n\r\n．勾選自動載入，可以在程式啟動時自動載入設定檔\r\n";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(63, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 15);
            this.label11.TabIndex = 63;
            this.label11.Text = "新增功能:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(117, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(185, 17);
            this.label10.TabIndex = 62;
            this.label10.Text = "已更新至版本 - V2.1 0240008";
            // 
            // btn_updset
            // 
            this.btn_updset.BackColor = System.Drawing.Color.White;
            this.btn_updset.BackgroundImage = global::test0515.Properties.Resources.btn2;
            this.btn_updset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_updset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updset.Font = new System.Drawing.Font("微軟正黑體", 8F, System.Drawing.FontStyle.Bold);
            this.btn_updset.Location = new System.Drawing.Point(171, 225);
            this.btn_updset.Margin = new System.Windows.Forms.Padding(4);
            this.btn_updset.Name = "btn_updset";
            this.btn_updset.Size = new System.Drawing.Size(71, 22);
            this.btn_updset.TabIndex = 59;
            this.btn_updset.Text = "確認";
            this.btn_updset.UseVisualStyleBackColor = false;
            // 
            // pnl_ccom
            // 
            this.pnl_ccom.Controls.Add(this.btn_ccomsave);
            this.pnl_ccom.Controls.Add(this.btn_ccomopen);
            this.pnl_ccom.Controls.Add(this.panel8);
            this.pnl_ccom.Controls.Add(this.btn_writeccom);
            this.pnl_ccom.Controls.Add(this.btn_readccom);
            this.pnl_ccom.Controls.Add(this.panel7);
            this.pnl_ccom.Controls.Add(this.panel6);
            this.pnl_ccom.Controls.Add(this.panel5);
            this.pnl_ccom.Controls.Add(this.btn_ccomset);
            this.pnl_ccom.Controls.Add(this.label8);
            this.pnl_ccom.Controls.Add(this.pictureBox7);
            this.pnl_ccom.Location = new System.Drawing.Point(366, 39);
            this.pnl_ccom.Name = "pnl_ccom";
            this.pnl_ccom.Size = new System.Drawing.Size(608, 352);
            this.pnl_ccom.TabIndex = 62;
            this.pnl_ccom.Visible = false;
            // 
            // btn_ccomsave
            // 
            this.btn_ccomsave.BackColor = System.Drawing.Color.White;
            this.btn_ccomsave.BackgroundImage = global::test0515.Properties.Resources.btn2;
            this.btn_ccomsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ccomsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ccomsave.Font = new System.Drawing.Font("微軟正黑體", 8F, System.Drawing.FontStyle.Bold);
            this.btn_ccomsave.Location = new System.Drawing.Point(518, 105);
            this.btn_ccomsave.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ccomsave.Name = "btn_ccomsave";
            this.btn_ccomsave.Size = new System.Drawing.Size(71, 42);
            this.btn_ccomsave.TabIndex = 71;
            this.btn_ccomsave.Text = "儲存";
            this.btn_ccomsave.UseVisualStyleBackColor = false;
            this.btn_ccomsave.Click += new System.EventHandler(this.btn_ccomsave_Click);
            // 
            // btn_ccomopen
            // 
            this.btn_ccomopen.BackColor = System.Drawing.Color.White;
            this.btn_ccomopen.BackgroundImage = global::test0515.Properties.Resources.btn2;
            this.btn_ccomopen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ccomopen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ccomopen.Font = new System.Drawing.Font("微軟正黑體", 8F, System.Drawing.FontStyle.Bold);
            this.btn_ccomopen.Location = new System.Drawing.Point(518, 55);
            this.btn_ccomopen.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ccomopen.Name = "btn_ccomopen";
            this.btn_ccomopen.Size = new System.Drawing.Size(71, 42);
            this.btn_ccomopen.TabIndex = 70;
            this.btn_ccomopen.Text = "開啟";
            this.btn_ccomopen.UseVisualStyleBackColor = false;
            this.btn_ccomopen.Click += new System.EventHandler(this.btn_ccomopen_Click);
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.tbx_DLC);
            this.panel8.Controls.Add(this.label20);
            this.panel8.Controls.Add(this.tbx_Pid);
            this.panel8.Controls.Add(this.label19);
            this.panel8.Controls.Add(this.tbx_ID);
            this.panel8.Controls.Add(this.label18);
            this.panel8.Location = new System.Drawing.Point(17, 47);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(493, 46);
            this.panel8.TabIndex = 69;
            // 
            // tbx_DLC
            // 
            this.tbx_DLC.BackColor = System.Drawing.Color.LemonChiffon;
            this.tbx_DLC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_DLC.Location = new System.Drawing.Point(411, 11);
            this.tbx_DLC.Name = "tbx_DLC";
            this.tbx_DLC.Size = new System.Drawing.Size(54, 23);
            this.tbx_DLC.TabIndex = 89;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(372, 15);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 15);
            this.label20.TabIndex = 88;
            this.label20.Text = "DLC";
            // 
            // tbx_Pid
            // 
            this.tbx_Pid.BackColor = System.Drawing.Color.LemonChiffon;
            this.tbx_Pid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_Pid.Location = new System.Drawing.Point(299, 11);
            this.tbx_Pid.Name = "tbx_Pid";
            this.tbx_Pid.Size = new System.Drawing.Size(54, 23);
            this.tbx_Pid.TabIndex = 87;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(229, 15);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 15);
            this.label19.TabIndex = 86;
            this.label19.Text = "Port ID";
            // 
            // tbx_ID
            // 
            this.tbx_ID.BackColor = System.Drawing.Color.LemonChiffon;
            this.tbx_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_ID.Location = new System.Drawing.Point(91, 11);
            this.tbx_ID.Name = "tbx_ID";
            this.tbx_ID.Size = new System.Drawing.Size(131, 23);
            this.tbx_ID.TabIndex = 85;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(10, 15);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 15);
            this.label18.TabIndex = 5;
            this.label18.Text = "Message ID";
            // 
            // btn_writeccom
            // 
            this.btn_writeccom.BackColor = System.Drawing.Color.White;
            this.btn_writeccom.BackgroundImage = global::test0515.Properties.Resources.btn2;
            this.btn_writeccom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_writeccom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_writeccom.Font = new System.Drawing.Font("微軟正黑體", 8F, System.Drawing.FontStyle.Bold);
            this.btn_writeccom.Location = new System.Drawing.Point(518, 258);
            this.btn_writeccom.Margin = new System.Windows.Forms.Padding(4);
            this.btn_writeccom.Name = "btn_writeccom";
            this.btn_writeccom.Size = new System.Drawing.Size(71, 42);
            this.btn_writeccom.TabIndex = 68;
            this.btn_writeccom.Text = "寫入";
            this.btn_writeccom.UseVisualStyleBackColor = false;
            this.btn_writeccom.Click += new System.EventHandler(this.btn_writeccom_Click);
            // 
            // btn_readccom
            // 
            this.btn_readccom.BackColor = System.Drawing.Color.White;
            this.btn_readccom.BackgroundImage = global::test0515.Properties.Resources.btn2;
            this.btn_readccom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_readccom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_readccom.Font = new System.Drawing.Font("微軟正黑體", 8F, System.Drawing.FontStyle.Bold);
            this.btn_readccom.Location = new System.Drawing.Point(518, 208);
            this.btn_readccom.Margin = new System.Windows.Forms.Padding(4);
            this.btn_readccom.Name = "btn_readccom";
            this.btn_readccom.Size = new System.Drawing.Size(71, 42);
            this.btn_readccom.TabIndex = 67;
            this.btn_readccom.Text = "讀取";
            this.btn_readccom.UseVisualStyleBackColor = false;
            this.btn_readccom.Click += new System.EventHandler(this.btn_readccom_Click);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.label21);
            this.panel7.Controls.Add(this.label17);
            this.panel7.Controls.Add(this.label16);
            this.panel7.Controls.Add(this.label15);
            this.panel7.Controls.Add(this.label14);
            this.panel7.Location = new System.Drawing.Point(17, 100);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(49, 205);
            this.panel7.TabIndex = 66;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "Name";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(10, 117);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(31, 15);
            this.label21.TabIndex = 9;
            this.label21.Text = "Type";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 170);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 15);
            this.label17.TabIndex = 8;
            this.label17.Text = "Value";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 92);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 15);
            this.label16.TabIndex = 7;
            this.label16.Text = "Msb";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 67);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 15);
            this.label15.TabIndex = 6;
            this.label15.Text = "Lsb";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 15);
            this.label14.TabIndex = 5;
            this.label14.Text = "Size";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.lbl_g5);
            this.panel6.Controls.Add(this.lbl_g1);
            this.panel6.Controls.Add(this.lbl_g4);
            this.panel6.Controls.Add(this.lbl_g2);
            this.panel6.Controls.Add(this.lbl_g3);
            this.panel6.Location = new System.Drawing.Point(72, 100);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(438, 23);
            this.panel6.TabIndex = 65;
            // 
            // lbl_g5
            // 
            this.lbl_g5.AutoSize = true;
            this.lbl_g5.Location = new System.Drawing.Point(336, 3);
            this.lbl_g5.Name = "lbl_g5";
            this.lbl_g5.Size = new System.Drawing.Size(35, 15);
            this.lbl_g5.TabIndex = 4;
            this.lbl_g5.Text = "Value";
            // 
            // lbl_g1
            // 
            this.lbl_g1.AutoSize = true;
            this.lbl_g1.Location = new System.Drawing.Point(10, 3);
            this.lbl_g1.Name = "lbl_g1";
            this.lbl_g1.Size = new System.Drawing.Size(62, 15);
            this.lbl_g1.TabIndex = 0;
            this.lbl_g1.Text = "Header - 1";
            // 
            // lbl_g4
            // 
            this.lbl_g4.AutoSize = true;
            this.lbl_g4.Location = new System.Drawing.Point(255, 3);
            this.lbl_g4.Name = "lbl_g4";
            this.lbl_g4.Size = new System.Drawing.Size(35, 15);
            this.lbl_g4.TabIndex = 3;
            this.lbl_g4.Text = "Value";
            // 
            // lbl_g2
            // 
            this.lbl_g2.AutoSize = true;
            this.lbl_g2.Location = new System.Drawing.Point(92, 3);
            this.lbl_g2.Name = "lbl_g2";
            this.lbl_g2.Size = new System.Drawing.Size(62, 15);
            this.lbl_g2.TabIndex = 1;
            this.lbl_g2.Text = "Header - 2";
            // 
            // lbl_g3
            // 
            this.lbl_g3.AutoSize = true;
            this.lbl_g3.Location = new System.Drawing.Point(174, 3);
            this.lbl_g3.Name = "lbl_g3";
            this.lbl_g3.Size = new System.Drawing.Size(35, 15);
            this.lbl_g3.TabIndex = 2;
            this.lbl_g3.Text = "Value";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.tbx_g5_type);
            this.panel5.Controls.Add(this.tbx_g4_type);
            this.panel5.Controls.Add(this.tbx_g3_type);
            this.panel5.Controls.Add(this.tbx_g2_type);
            this.panel5.Controls.Add(this.tbx_g1_type);
            this.panel5.Controls.Add(this.tbx_g5_v);
            this.panel5.Controls.Add(this.tbx_g4_v);
            this.panel5.Controls.Add(this.tbx_g3_v);
            this.panel5.Controls.Add(this.tbx_g2_v);
            this.panel5.Controls.Add(this.tbx_g1_v);
            this.panel5.Controls.Add(this.tbx_g5_msb);
            this.panel5.Controls.Add(this.tbx_g4_msb);
            this.panel5.Controls.Add(this.tbx_g3_msb);
            this.panel5.Controls.Add(this.tbx_g2_msb);
            this.panel5.Controls.Add(this.tbx_g1_msb);
            this.panel5.Controls.Add(this.tbx_g5_lsb);
            this.panel5.Controls.Add(this.tbx_g4_lsb);
            this.panel5.Controls.Add(this.tbx_g3_lsb);
            this.panel5.Controls.Add(this.tbx_g2_lsb);
            this.panel5.Controls.Add(this.tbx_g1_lsb);
            this.panel5.Controls.Add(this.tbx_g5_size);
            this.panel5.Controls.Add(this.tbx_g4_size);
            this.panel5.Controls.Add(this.tbx_g3_size);
            this.panel5.Controls.Add(this.tbx_g2_size);
            this.panel5.Controls.Add(this.tbx_g1_size);
            this.panel5.Location = new System.Drawing.Point(72, 128);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(438, 177);
            this.panel5.TabIndex = 64;
            // 
            // tbx_g5_type
            // 
            this.tbx_g5_type.BackColor = System.Drawing.Color.LemonChiffon;
            this.tbx_g5_type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_g5_type.Location = new System.Drawing.Point(336, 86);
            this.tbx_g5_type.Name = "tbx_g5_type";
            this.tbx_g5_type.Size = new System.Drawing.Size(90, 23);
            this.tbx_g5_type.TabIndex = 89;
            // 
            // tbx_g4_type
            // 
            this.tbx_g4_type.BackColor = System.Drawing.Color.LemonChiffon;
            this.tbx_g4_type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_g4_type.Location = new System.Drawing.Point(255, 86);
            this.tbx_g4_type.Name = "tbx_g4_type";
            this.tbx_g4_type.Size = new System.Drawing.Size(75, 23);
            this.tbx_g4_type.TabIndex = 88;
            // 
            // tbx_g3_type
            // 
            this.tbx_g3_type.BackColor = System.Drawing.Color.LemonChiffon;
            this.tbx_g3_type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_g3_type.Location = new System.Drawing.Point(174, 86);
            this.tbx_g3_type.Name = "tbx_g3_type";
            this.tbx_g3_type.Size = new System.Drawing.Size(75, 23);
            this.tbx_g3_type.TabIndex = 87;
            // 
            // tbx_g2_type
            // 
            this.tbx_g2_type.BackColor = System.Drawing.Color.LemonChiffon;
            this.tbx_g2_type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_g2_type.Location = new System.Drawing.Point(92, 86);
            this.tbx_g2_type.Name = "tbx_g2_type";
            this.tbx_g2_type.Size = new System.Drawing.Size(75, 23);
            this.tbx_g2_type.TabIndex = 86;
            // 
            // tbx_g1_type
            // 
            this.tbx_g1_type.BackColor = System.Drawing.Color.LemonChiffon;
            this.tbx_g1_type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_g1_type.Location = new System.Drawing.Point(10, 86);
            this.tbx_g1_type.Name = "tbx_g1_type";
            this.tbx_g1_type.Size = new System.Drawing.Size(75, 23);
            this.tbx_g1_type.TabIndex = 85;
            // 
            // tbx_g5_v
            // 
            this.tbx_g5_v.BackColor = System.Drawing.Color.LemonChiffon;
            this.tbx_g5_v.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_g5_v.Location = new System.Drawing.Point(336, 138);
            this.tbx_g5_v.Name = "tbx_g5_v";
            this.tbx_g5_v.Size = new System.Drawing.Size(90, 23);
            this.tbx_g5_v.TabIndex = 84;
            // 
            // tbx_g4_v
            // 
            this.tbx_g4_v.BackColor = System.Drawing.Color.LemonChiffon;
            this.tbx_g4_v.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_g4_v.Location = new System.Drawing.Point(255, 138);
            this.tbx_g4_v.Name = "tbx_g4_v";
            this.tbx_g4_v.Size = new System.Drawing.Size(75, 23);
            this.tbx_g4_v.TabIndex = 83;
            // 
            // tbx_g3_v
            // 
            this.tbx_g3_v.BackColor = System.Drawing.Color.LemonChiffon;
            this.tbx_g3_v.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_g3_v.Location = new System.Drawing.Point(174, 138);
            this.tbx_g3_v.Name = "tbx_g3_v";
            this.tbx_g3_v.Size = new System.Drawing.Size(75, 23);
            this.tbx_g3_v.TabIndex = 82;
            // 
            // tbx_g2_v
            // 
            this.tbx_g2_v.BackColor = System.Drawing.Color.LemonChiffon;
            this.tbx_g2_v.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_g2_v.Location = new System.Drawing.Point(92, 138);
            this.tbx_g2_v.Name = "tbx_g2_v";
            this.tbx_g2_v.Size = new System.Drawing.Size(75, 23);
            this.tbx_g2_v.TabIndex = 81;
            // 
            // tbx_g1_v
            // 
            this.tbx_g1_v.BackColor = System.Drawing.Color.LemonChiffon;
            this.tbx_g1_v.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_g1_v.Location = new System.Drawing.Point(10, 138);
            this.tbx_g1_v.Name = "tbx_g1_v";
            this.tbx_g1_v.Size = new System.Drawing.Size(75, 23);
            this.tbx_g1_v.TabIndex = 80;
            // 
            // tbx_g5_msb
            // 
            this.tbx_g5_msb.BackColor = System.Drawing.Color.LemonChiffon;
            this.tbx_g5_msb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_g5_msb.Location = new System.Drawing.Point(336, 59);
            this.tbx_g5_msb.Name = "tbx_g5_msb";
            this.tbx_g5_msb.Size = new System.Drawing.Size(90, 23);
            this.tbx_g5_msb.TabIndex = 79;
            // 
            // tbx_g4_msb
            // 
            this.tbx_g4_msb.BackColor = System.Drawing.Color.LemonChiffon;
            this.tbx_g4_msb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_g4_msb.Location = new System.Drawing.Point(255, 59);
            this.tbx_g4_msb.Name = "tbx_g4_msb";
            this.tbx_g4_msb.Size = new System.Drawing.Size(75, 23);
            this.tbx_g4_msb.TabIndex = 78;
            // 
            // tbx_g3_msb
            // 
            this.tbx_g3_msb.BackColor = System.Drawing.Color.LemonChiffon;
            this.tbx_g3_msb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_g3_msb.Location = new System.Drawing.Point(174, 59);
            this.tbx_g3_msb.Name = "tbx_g3_msb";
            this.tbx_g3_msb.Size = new System.Drawing.Size(75, 23);
            this.tbx_g3_msb.TabIndex = 77;
            // 
            // tbx_g2_msb
            // 
            this.tbx_g2_msb.BackColor = System.Drawing.Color.LemonChiffon;
            this.tbx_g2_msb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_g2_msb.Location = new System.Drawing.Point(92, 59);
            this.tbx_g2_msb.Name = "tbx_g2_msb";
            this.tbx_g2_msb.Size = new System.Drawing.Size(75, 23);
            this.tbx_g2_msb.TabIndex = 76;
            // 
            // tbx_g1_msb
            // 
            this.tbx_g1_msb.BackColor = System.Drawing.Color.LemonChiffon;
            this.tbx_g1_msb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_g1_msb.Location = new System.Drawing.Point(10, 59);
            this.tbx_g1_msb.Name = "tbx_g1_msb";
            this.tbx_g1_msb.Size = new System.Drawing.Size(75, 23);
            this.tbx_g1_msb.TabIndex = 75;
            // 
            // tbx_g5_lsb
            // 
            this.tbx_g5_lsb.BackColor = System.Drawing.Color.LemonChiffon;
            this.tbx_g5_lsb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_g5_lsb.Location = new System.Drawing.Point(336, 33);
            this.tbx_g5_lsb.Name = "tbx_g5_lsb";
            this.tbx_g5_lsb.Size = new System.Drawing.Size(90, 23);
            this.tbx_g5_lsb.TabIndex = 74;
            // 
            // tbx_g4_lsb
            // 
            this.tbx_g4_lsb.BackColor = System.Drawing.Color.LemonChiffon;
            this.tbx_g4_lsb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_g4_lsb.Location = new System.Drawing.Point(255, 33);
            this.tbx_g4_lsb.Name = "tbx_g4_lsb";
            this.tbx_g4_lsb.Size = new System.Drawing.Size(75, 23);
            this.tbx_g4_lsb.TabIndex = 73;
            // 
            // tbx_g3_lsb
            // 
            this.tbx_g3_lsb.BackColor = System.Drawing.Color.LemonChiffon;
            this.tbx_g3_lsb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_g3_lsb.Location = new System.Drawing.Point(174, 33);
            this.tbx_g3_lsb.Name = "tbx_g3_lsb";
            this.tbx_g3_lsb.Size = new System.Drawing.Size(75, 23);
            this.tbx_g3_lsb.TabIndex = 72;
            // 
            // tbx_g2_lsb
            // 
            this.tbx_g2_lsb.BackColor = System.Drawing.Color.LemonChiffon;
            this.tbx_g2_lsb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_g2_lsb.Location = new System.Drawing.Point(92, 33);
            this.tbx_g2_lsb.Name = "tbx_g2_lsb";
            this.tbx_g2_lsb.Size = new System.Drawing.Size(75, 23);
            this.tbx_g2_lsb.TabIndex = 71;
            // 
            // tbx_g1_lsb
            // 
            this.tbx_g1_lsb.BackColor = System.Drawing.Color.LemonChiffon;
            this.tbx_g1_lsb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_g1_lsb.Location = new System.Drawing.Point(10, 33);
            this.tbx_g1_lsb.Name = "tbx_g1_lsb";
            this.tbx_g1_lsb.Size = new System.Drawing.Size(75, 23);
            this.tbx_g1_lsb.TabIndex = 70;
            // 
            // tbx_g5_size
            // 
            this.tbx_g5_size.BackColor = System.Drawing.Color.LemonChiffon;
            this.tbx_g5_size.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_g5_size.Location = new System.Drawing.Point(336, 6);
            this.tbx_g5_size.Name = "tbx_g5_size";
            this.tbx_g5_size.Size = new System.Drawing.Size(90, 23);
            this.tbx_g5_size.TabIndex = 69;
            // 
            // tbx_g4_size
            // 
            this.tbx_g4_size.BackColor = System.Drawing.Color.LemonChiffon;
            this.tbx_g4_size.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_g4_size.Location = new System.Drawing.Point(255, 6);
            this.tbx_g4_size.Name = "tbx_g4_size";
            this.tbx_g4_size.Size = new System.Drawing.Size(75, 23);
            this.tbx_g4_size.TabIndex = 68;
            // 
            // tbx_g3_size
            // 
            this.tbx_g3_size.BackColor = System.Drawing.Color.LemonChiffon;
            this.tbx_g3_size.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_g3_size.Location = new System.Drawing.Point(174, 6);
            this.tbx_g3_size.Name = "tbx_g3_size";
            this.tbx_g3_size.Size = new System.Drawing.Size(75, 23);
            this.tbx_g3_size.TabIndex = 67;
            // 
            // tbx_g2_size
            // 
            this.tbx_g2_size.BackColor = System.Drawing.Color.LemonChiffon;
            this.tbx_g2_size.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_g2_size.Location = new System.Drawing.Point(92, 6);
            this.tbx_g2_size.Name = "tbx_g2_size";
            this.tbx_g2_size.Size = new System.Drawing.Size(75, 23);
            this.tbx_g2_size.TabIndex = 66;
            // 
            // tbx_g1_size
            // 
            this.tbx_g1_size.BackColor = System.Drawing.Color.LemonChiffon;
            this.tbx_g1_size.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_g1_size.Location = new System.Drawing.Point(10, 6);
            this.tbx_g1_size.Name = "tbx_g1_size";
            this.tbx_g1_size.Size = new System.Drawing.Size(75, 23);
            this.tbx_g1_size.TabIndex = 65;
            // 
            // btn_ccomset
            // 
            this.btn_ccomset.BackColor = System.Drawing.Color.White;
            this.btn_ccomset.BackgroundImage = global::test0515.Properties.Resources.btn2;
            this.btn_ccomset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ccomset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ccomset.Font = new System.Drawing.Font("微軟正黑體", 8F, System.Drawing.FontStyle.Bold);
            this.btn_ccomset.Location = new System.Drawing.Point(254, 321);
            this.btn_ccomset.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ccomset.Name = "btn_ccomset";
            this.btn_ccomset.Size = new System.Drawing.Size(71, 22);
            this.btn_ccomset.TabIndex = 59;
            this.btn_ccomset.Text = "關閉";
            this.btn_ccomset.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(43, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 17);
            this.label8.TabIndex = 62;
            this.label8.Text = "Control:";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::test0515.Properties.Resources.set;
            this.pictureBox7.Location = new System.Drawing.Point(15, 12);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(22, 22);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 63;
            this.pictureBox7.TabStop = false;
            // 
            // pnl_supersu
            // 
            this.pnl_supersu.Controls.Add(this.btn_console);
            this.pnl_supersu.Controls.Add(this.tb_console);
            this.pnl_supersu.Controls.Add(this.rtb_suCon);
            this.pnl_supersu.Controls.Add(this.btn_suset);
            this.pnl_supersu.Controls.Add(this.rtb_su);
            this.pnl_supersu.Controls.Add(this.label7);
            this.pnl_supersu.Controls.Add(this.pictureBox6);
            this.pnl_supersu.Location = new System.Drawing.Point(183, 157);
            this.pnl_supersu.Name = "pnl_supersu";
            this.pnl_supersu.Size = new System.Drawing.Size(403, 248);
            this.pnl_supersu.TabIndex = 62;
            this.pnl_supersu.Visible = false;
            // 
            // btn_console
            // 
            this.btn_console.BackColor = System.Drawing.Color.White;
            this.btn_console.BackgroundImage = global::test0515.Properties.Resources.btn2;
            this.btn_console.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_console.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_console.Font = new System.Drawing.Font("微軟正黑體", 8F, System.Drawing.FontStyle.Bold);
            this.btn_console.Location = new System.Drawing.Point(66, 217);
            this.btn_console.Margin = new System.Windows.Forms.Padding(4);
            this.btn_console.Name = "btn_console";
            this.btn_console.Size = new System.Drawing.Size(71, 22);
            this.btn_console.TabIndex = 64;
            this.btn_console.Text = "輸入";
            this.btn_console.UseVisualStyleBackColor = false;
            // 
            // tb_console
            // 
            this.tb_console.BackColor = System.Drawing.Color.LemonChiffon;
            this.tb_console.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_console.Location = new System.Drawing.Point(145, 176);
            this.tb_console.Name = "tb_console";
            this.tb_console.Size = new System.Drawing.Size(238, 23);
            this.tb_console.TabIndex = 0;
            this.tb_console.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_console_KeyPress);
            // 
            // rtb_suCon
            // 
            this.rtb_suCon.BackColor = System.Drawing.Color.LemonChiffon;
            this.rtb_suCon.CausesValidation = false;
            this.rtb_suCon.Enabled = false;
            this.rtb_suCon.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rtb_suCon.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rtb_suCon.Location = new System.Drawing.Point(145, 45);
            this.rtb_suCon.Margin = new System.Windows.Forms.Padding(4);
            this.rtb_suCon.Name = "rtb_suCon";
            this.rtb_suCon.ReadOnly = true;
            this.rtb_suCon.Size = new System.Drawing.Size(238, 125);
            this.rtb_suCon.TabIndex = 62;
            this.rtb_suCon.Text = "";
            // 
            // btn_suset
            // 
            this.btn_suset.BackColor = System.Drawing.Color.White;
            this.btn_suset.BackgroundImage = global::test0515.Properties.Resources.btn2;
            this.btn_suset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_suset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_suset.Font = new System.Drawing.Font("微軟正黑體", 8F, System.Drawing.FontStyle.Bold);
            this.btn_suset.Location = new System.Drawing.Point(255, 217);
            this.btn_suset.Margin = new System.Windows.Forms.Padding(4);
            this.btn_suset.Name = "btn_suset";
            this.btn_suset.Size = new System.Drawing.Size(71, 22);
            this.btn_suset.TabIndex = 61;
            this.btn_suset.Text = "關閉";
            this.btn_suset.UseVisualStyleBackColor = false;
            // 
            // rtb_su
            // 
            this.rtb_su.BackColor = System.Drawing.Color.LemonChiffon;
            this.rtb_su.CausesValidation = false;
            this.rtb_su.Enabled = false;
            this.rtb_su.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rtb_su.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rtb_su.Location = new System.Drawing.Point(15, 45);
            this.rtb_su.Margin = new System.Windows.Forms.Padding(4);
            this.rtb_su.Name = "rtb_su";
            this.rtb_su.ReadOnly = true;
            this.rtb_su.Size = new System.Drawing.Size(122, 155);
            this.rtb_su.TabIndex = 51;
            this.rtb_su.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(43, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 60;
            this.label7.Text = "SuperSu:";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::test0515.Properties.Resources.set;
            this.pictureBox6.Location = new System.Drawing.Point(15, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(22, 22);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 61;
            this.pictureBox6.TabStop = false;
            // 
            // pnl_filepath
            // 
            this.pnl_filepath.Location = new System.Drawing.Point(39, 100);
            this.pnl_filepath.Name = "pnl_filepath";
            this.pnl_filepath.Size = new System.Drawing.Size(119, 82);
            this.pnl_filepath.TabIndex = 61;
            // 
            // pnl_baud
            // 
            this.pnl_baud.Controls.Add(this.label5);
            this.pnl_baud.Controls.Add(this.pictureBox2);
            this.pnl_baud.Controls.Add(this.btn_baudset);
            this.pnl_baud.Controls.Add(this.label1);
            this.pnl_baud.Controls.Add(this.btn_getcandata);
            this.pnl_baud.Controls.Add(this.label2);
            this.pnl_baud.Controls.Add(this.cbb_baud0);
            this.pnl_baud.Controls.Add(this.gbx_connect);
            this.pnl_baud.Controls.Add(this.cbb_baud1);
            this.pnl_baud.Location = new System.Drawing.Point(284, 386);
            this.pnl_baud.Name = "pnl_baud";
            this.pnl_baud.Size = new System.Drawing.Size(291, 136);
            this.pnl_baud.TabIndex = 55;
            this.pnl_baud.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(34, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 52;
            this.label5.Text = "Set Conncet:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::test0515.Properties.Resources.set;
            this.pictureBox2.Location = new System.Drawing.Point(6, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 59;
            this.pictureBox2.TabStop = false;
            // 
            // btn_baudset
            // 
            this.btn_baudset.BackColor = System.Drawing.Color.White;
            this.btn_baudset.BackgroundImage = global::test0515.Properties.Resources.btn2;
            this.btn_baudset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_baudset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_baudset.Font = new System.Drawing.Font("微軟正黑體", 8F, System.Drawing.FontStyle.Bold);
            this.btn_baudset.Location = new System.Drawing.Point(168, 105);
            this.btn_baudset.Margin = new System.Windows.Forms.Padding(4);
            this.btn_baudset.Name = "btn_baudset";
            this.btn_baudset.Size = new System.Drawing.Size(71, 22);
            this.btn_baudset.TabIndex = 55;
            this.btn_baudset.Text = "Set";
            this.btn_baudset.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 48;
            this.label1.Text = "Baud 0:";
            // 
            // btn_getcandata
            // 
            this.btn_getcandata.BackColor = System.Drawing.Color.White;
            this.btn_getcandata.BackgroundImage = global::test0515.Properties.Resources.btn2;
            this.btn_getcandata.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_getcandata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_getcandata.Font = new System.Drawing.Font("微軟正黑體", 8F, System.Drawing.FontStyle.Bold);
            this.btn_getcandata.Location = new System.Drawing.Point(46, 105);
            this.btn_getcandata.Margin = new System.Windows.Forms.Padding(4);
            this.btn_getcandata.Name = "btn_getcandata";
            this.btn_getcandata.Size = new System.Drawing.Size(71, 22);
            this.btn_getcandata.TabIndex = 45;
            this.btn_getcandata.Text = "Get Port";
            this.btn_getcandata.UseVisualStyleBackColor = false;
            this.btn_getcandata.Click += new System.EventHandler(this.btn_getcandata_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 49;
            this.label2.Text = "Baud 1:";
            // 
            // cbb_baud0
            // 
            this.cbb_baud0.BackColor = System.Drawing.Color.Beige;
            this.cbb_baud0.FormattingEnabled = true;
            this.cbb_baud0.Items.AddRange(new object[] {
            "100Kbps",
            "125Kbps",
            "250Kbps",
            "500Kbps"});
            this.cbb_baud0.Location = new System.Drawing.Point(185, 47);
            this.cbb_baud0.Name = "cbb_baud0";
            this.cbb_baud0.Size = new System.Drawing.Size(96, 23);
            this.cbb_baud0.TabIndex = 46;
            // 
            // gbx_connect
            // 
            this.gbx_connect.BackColor = System.Drawing.Color.Transparent;
            this.gbx_connect.Controls.Add(this.cbb_port);
            this.gbx_connect.Controls.Add(this.rb_canpro);
            this.gbx_connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbx_connect.Location = new System.Drawing.Point(14, 31);
            this.gbx_connect.Name = "gbx_connect";
            this.gbx_connect.Size = new System.Drawing.Size(110, 71);
            this.gbx_connect.TabIndex = 44;
            this.gbx_connect.TabStop = false;
            this.gbx_connect.Text = "Connect";
            // 
            // cbb_port
            // 
            this.cbb_port.BackColor = System.Drawing.Color.Beige;
            this.cbb_port.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbb_port.ForeColor = System.Drawing.Color.Black;
            this.cbb_port.FormattingEnabled = true;
            this.cbb_port.Location = new System.Drawing.Point(6, 42);
            this.cbb_port.Name = "cbb_port";
            this.cbb_port.Size = new System.Drawing.Size(97, 23);
            this.cbb_port.TabIndex = 44;
            // 
            // rb_canpro
            // 
            this.rb_canpro.AutoSize = true;
            this.rb_canpro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_canpro.Location = new System.Drawing.Point(6, 17);
            this.rb_canpro.Name = "rb_canpro";
            this.rb_canpro.Size = new System.Drawing.Size(72, 19);
            this.rb_canpro.TabIndex = 43;
            this.rb_canpro.TabStop = true;
            this.rb_canpro.Text = "CANPRO";
            this.rb_canpro.UseVisualStyleBackColor = true;
            // 
            // cbb_baud1
            // 
            this.cbb_baud1.BackColor = System.Drawing.Color.Beige;
            this.cbb_baud1.FormattingEnabled = true;
            this.cbb_baud1.Items.AddRange(new object[] {
            "100Kbps",
            "125Kbps",
            "250Kbps",
            "500Kbps"});
            this.cbb_baud1.Location = new System.Drawing.Point(185, 74);
            this.cbb_baud1.Name = "cbb_baud1";
            this.cbb_baud1.Size = new System.Drawing.Size(96, 23);
            this.cbb_baud1.TabIndex = 50;
            // 
            // pnl_lan
            // 
            this.pnl_lan.Controls.Add(this.pictureBox3);
            this.pnl_lan.Controls.Add(this.panel1);
            this.pnl_lan.Controls.Add(this.btn_lanok);
            this.pnl_lan.Controls.Add(this.cbb_lan);
            this.pnl_lan.Controls.Add(this.btn_lan);
            this.pnl_lan.Location = new System.Drawing.Point(346, 244);
            this.pnl_lan.Name = "pnl_lan";
            this.pnl_lan.Size = new System.Drawing.Size(291, 136);
            this.pnl_lan.TabIndex = 59;
            this.pnl_lan.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::test0515.Properties.Resources.set;
            this.pictureBox3.Location = new System.Drawing.Point(6, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 60;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lbl_lan);
            this.panel1.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.panel1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Location = new System.Drawing.Point(32, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(116, 25);
            this.panel1.TabIndex = 52;
            // 
            // lbl_lan
            // 
            this.lbl_lan.AutoSize = true;
            this.lbl_lan.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_lan.ForeColor = System.Drawing.Color.Black;
            this.lbl_lan.Location = new System.Drawing.Point(4, 0);
            this.lbl_lan.Name = "lbl_lan";
            this.lbl_lan.Size = new System.Drawing.Size(94, 17);
            this.lbl_lan.TabIndex = 51;
            this.lbl_lan.Text = "Set Language:";
            // 
            // btn_lanok
            // 
            this.btn_lanok.BackColor = System.Drawing.Color.White;
            this.btn_lanok.BackgroundImage = global::test0515.Properties.Resources.btn2;
            this.btn_lanok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_lanok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lanok.Font = new System.Drawing.Font("微軟正黑體", 8F, System.Drawing.FontStyle.Bold);
            this.btn_lanok.Location = new System.Drawing.Point(201, 105);
            this.btn_lanok.Margin = new System.Windows.Forms.Padding(4);
            this.btn_lanok.Name = "btn_lanok";
            this.btn_lanok.Size = new System.Drawing.Size(71, 22);
            this.btn_lanok.TabIndex = 55;
            this.btn_lanok.Text = "確認";
            this.btn_lanok.UseVisualStyleBackColor = false;
            // 
            // cbb_lan
            // 
            this.cbb_lan.BackColor = System.Drawing.Color.Beige;
            this.cbb_lan.FormattingEnabled = true;
            this.cbb_lan.Items.AddRange(new object[] {
            "中文",
            "English"});
            this.cbb_lan.Location = new System.Drawing.Point(55, 57);
            this.cbb_lan.Name = "cbb_lan";
            this.cbb_lan.Size = new System.Drawing.Size(185, 23);
            this.cbb_lan.TabIndex = 50;
            // 
            // btn_lan
            // 
            this.btn_lan.BackgroundImage = global::test0515.Properties.Resources.btn2;
            this.btn_lan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_lan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lan.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_lan.Location = new System.Drawing.Point(20, 105);
            this.btn_lan.Margin = new System.Windows.Forms.Padding(4);
            this.btn_lan.Name = "btn_lan";
            this.btn_lan.Size = new System.Drawing.Size(71, 22);
            this.btn_lan.TabIndex = 40;
            this.btn_lan.Text = "Set";
            this.btn_lan.UseVisualStyleBackColor = true;
            this.btn_lan.Click += new System.EventHandler(this.btn_lan_Click);
            // 
            // pnl_info
            // 
            this.pnl_info.Controls.Add(this.label4);
            this.pnl_info.Controls.Add(this.ptb_info);
            this.pnl_info.Controls.Add(this.label3);
            this.pnl_info.Controls.Add(this.btn_infook);
            this.pnl_info.Location = new System.Drawing.Point(39, 228);
            this.pnl_info.Name = "pnl_info";
            this.pnl_info.Size = new System.Drawing.Size(291, 136);
            this.pnl_info.TabIndex = 56;
            this.pnl_info.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(64, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 17);
            this.label4.TabIndex = 58;
            this.label4.Text = "Gird Can -Beta V2.0 0241807";
            // 
            // ptb_info
            // 
            this.ptb_info.Image = global::test0515.Properties.Resources.hy;
            this.ptb_info.Location = new System.Drawing.Point(19, 20);
            this.ptb_info.Name = "ptb_info";
            this.ptb_info.Size = new System.Drawing.Size(35, 43);
            this.ptb_info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_info.TabIndex = 57;
            this.ptb_info.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 56);
            this.label3.TabIndex = 56;
            this.label3.Text = "BYGNUSX DEV®\r\nbygnusxsr@outlook.com\r\n\r\n生活就像被強姦，不能抵抗那就享受。";
            // 
            // btn_infook
            // 
            this.btn_infook.BackColor = System.Drawing.Color.White;
            this.btn_infook.BackgroundImage = global::test0515.Properties.Resources.btn2;
            this.btn_infook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_infook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_infook.Font = new System.Drawing.Font("微軟正黑體", 8F, System.Drawing.FontStyle.Bold);
            this.btn_infook.Location = new System.Drawing.Point(110, 105);
            this.btn_infook.Margin = new System.Windows.Forms.Padding(4);
            this.btn_infook.Name = "btn_infook";
            this.btn_infook.Size = new System.Drawing.Size(71, 22);
            this.btn_infook.TabIndex = 55;
            this.btn_infook.Text = "享受";
            this.btn_infook.UseVisualStyleBackColor = false;
            // 
            // btn_ctrlopen
            // 
            this.btn_ctrlopen.BackColor = System.Drawing.Color.White;
            this.btn_ctrlopen.BackgroundImage = global::test0515.Properties.Resources.btn2;
            this.btn_ctrlopen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ctrlopen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ctrlopen.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ctrlopen.Location = new System.Drawing.Point(106, 18);
            this.btn_ctrlopen.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ctrlopen.Name = "btn_ctrlopen";
            this.btn_ctrlopen.Size = new System.Drawing.Size(91, 27);
            this.btn_ctrlopen.TabIndex = 38;
            this.btn_ctrlopen.Text = "Load Config";
            this.btn_ctrlopen.UseVisualStyleBackColor = false;
            this.btn_ctrlopen.Click += new System.EventHandler(this.Btn_ctrlopen_Click);
            // 
            // btn_ctrlsave
            // 
            this.btn_ctrlsave.BackColor = System.Drawing.Color.White;
            this.btn_ctrlsave.BackgroundImage = global::test0515.Properties.Resources.btn2;
            this.btn_ctrlsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ctrlsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ctrlsave.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ctrlsave.Location = new System.Drawing.Point(106, 54);
            this.btn_ctrlsave.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ctrlsave.Name = "btn_ctrlsave";
            this.btn_ctrlsave.Size = new System.Drawing.Size(91, 27);
            this.btn_ctrlsave.TabIndex = 39;
            this.btn_ctrlsave.Text = "Save Config";
            this.btn_ctrlsave.UseVisualStyleBackColor = false;
            this.btn_ctrlsave.Click += new System.EventHandler(this.Btn_ctrlsave_Click);
            // 
            // btn_canopen
            // 
            this.btn_canopen.BackColor = System.Drawing.Color.White;
            this.btn_canopen.BackgroundImage = global::test0515.Properties.Resources.btn2;
            this.btn_canopen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_canopen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_canopen.Font = new System.Drawing.Font("微軟正黑體", 8F, System.Drawing.FontStyle.Bold);
            this.btn_canopen.Location = new System.Drawing.Point(187, 18);
            this.btn_canopen.Margin = new System.Windows.Forms.Padding(4);
            this.btn_canopen.Name = "btn_canopen";
            this.btn_canopen.Size = new System.Drawing.Size(95, 64);
            this.btn_canopen.TabIndex = 40;
            this.btn_canopen.Text = "Open Can";
            this.btn_canopen.UseVisualStyleBackColor = false;
            this.btn_canopen.Click += new System.EventHandler(this.btn_canopen_Click);
            // 
            // ptb_com
            // 
            this.ptb_com.Location = new System.Drawing.Point(12, 20);
            this.ptb_com.Name = "ptb_com";
            this.ptb_com.Size = new System.Drawing.Size(20, 21);
            this.ptb_com.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_com.TabIndex = 52;
            this.ptb_com.TabStop = false;
            // 
            // gbx_can
            // 
            this.gbx_can.BackColor = System.Drawing.Color.Transparent;
            this.gbx_can.Controls.Add(this.lbl_comsta);
            this.gbx_can.Controls.Add(this.ptb_conn);
            this.gbx_can.Controls.Add(this.ptb_com);
            this.gbx_can.Controls.Add(this.lbl_state);
            this.gbx_can.Controls.Add(this.btn_canopen);
            this.gbx_can.ForeColor = System.Drawing.Color.Black;
            this.gbx_can.Location = new System.Drawing.Point(57, 5);
            this.gbx_can.Name = "gbx_can";
            this.gbx_can.Size = new System.Drawing.Size(289, 89);
            this.gbx_can.TabIndex = 47;
            this.gbx_can.TabStop = false;
            this.gbx_can.Text = "CanBus";
            // 
            // lbl_comsta
            // 
            this.lbl_comsta.AutoSize = true;
            this.lbl_comsta.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_comsta.Location = new System.Drawing.Point(38, 23);
            this.lbl_comsta.Name = "lbl_comsta";
            this.lbl_comsta.Size = new System.Drawing.Size(41, 15);
            this.lbl_comsta.TabIndex = 54;
            this.lbl_comsta.Text = "State ";
            // 
            // ptb_conn
            // 
            this.ptb_conn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_conn.Location = new System.Drawing.Point(12, 55);
            this.ptb_conn.Name = "ptb_conn";
            this.ptb_conn.Size = new System.Drawing.Size(20, 21);
            this.ptb_conn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_conn.TabIndex = 53;
            this.ptb_conn.TabStop = false;
            // 
            // lbl_state
            // 
            this.lbl_state.AutoSize = true;
            this.lbl_state.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_state.Location = new System.Drawing.Point(38, 57);
            this.lbl_state.Name = "lbl_state";
            this.lbl_state.Size = new System.Drawing.Size(41, 15);
            this.lbl_state.TabIndex = 51;
            this.lbl_state.Text = "State ";
            // 
            // gbx_config
            // 
            this.gbx_config.BackColor = System.Drawing.Color.Transparent;
            this.gbx_config.Controls.Add(this.cbx_autoconfig);
            this.gbx_config.Controls.Add(this.btn_ctrlsave);
            this.gbx_config.Controls.Add(this.btn_ctrlopen);
            this.gbx_config.Location = new System.Drawing.Point(352, 5);
            this.gbx_config.Name = "gbx_config";
            this.gbx_config.Size = new System.Drawing.Size(204, 89);
            this.gbx_config.TabIndex = 48;
            this.gbx_config.TabStop = false;
            this.gbx_config.Text = "Config";
            // 
            // cbx_autoconfig
            // 
            this.cbx_autoconfig.AutoSize = true;
            this.cbx_autoconfig.Location = new System.Drawing.Point(25, 26);
            this.cbx_autoconfig.Name = "cbx_autoconfig";
            this.cbx_autoconfig.Size = new System.Drawing.Size(78, 19);
            this.cbx_autoconfig.TabIndex = 41;
            this.cbx_autoconfig.Text = "自動載入";
            this.cbx_autoconfig.UseVisualStyleBackColor = true;
            // 
            // btn_ID
            // 
            this.btn_ID.BackColor = System.Drawing.Color.White;
            this.btn_ID.BackgroundImage = global::test0515.Properties.Resources.btnID;
            this.btn_ID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ID.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_ID.Location = new System.Drawing.Point(6, 6);
            this.btn_ID.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ID.Name = "btn_ID";
            this.btn_ID.Size = new System.Drawing.Size(35, 35);
            this.btn_ID.TabIndex = 49;
            this.btn_ID.UseVisualStyleBackColor = false;
            this.btn_ID.Click += new System.EventHandler(this.btn_ID_Click);
            this.btn_ID.MouseLeave += new System.EventHandler(this.btn_ID_MouseLeave);
            this.btn_ID.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_ID_MouseMove);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackgroundImage = global::test0515.Properties.Resources.btn2;
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Location = new System.Drawing.Point(1274, 11);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(93, 80);
            this.btn_Exit.TabIndex = 26;
            this.btn_Exit.Text = "關閉";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // pnl_under
            // 
            this.pnl_under.Controls.Add(this.pnl_st);
            this.pnl_under.Controls.Add(this.rtb_console);
            this.pnl_under.Controls.Add(this.btn_Exit);
            this.pnl_under.Controls.Add(this.gbx_config);
            this.pnl_under.Controls.Add(this.gbx_can);
            this.pnl_under.Location = new System.Drawing.Point(0, 639);
            this.pnl_under.Name = "pnl_under";
            this.pnl_under.Size = new System.Drawing.Size(1378, 97);
            this.pnl_under.TabIndex = 54;
            // 
            // pnl_st
            // 
            this.pnl_st.Controls.Add(this.pictureBox4);
            this.pnl_st.Controls.Add(this.btn_ID);
            this.pnl_st.Location = new System.Drawing.Point(6, 8);
            this.pnl_st.Name = "pnl_st";
            this.pnl_st.Size = new System.Drawing.Size(45, 89);
            this.pnl_st.TabIndex = 50;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Image = global::test0515.Properties.Resources.hy;
            this.pictureBox4.Location = new System.Drawing.Point(6, 48);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 35);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 59;
            this.pictureBox4.TabStop = false;
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
            // ConnTimer
            // 
            this.ConnTimer.Interval = 150;
            this.ConnTimer.Tick += new System.EventHandler(this.ConnTimer_Tick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.menu);
            this.panel3.Controls.Add(this.pnl_under);
            this.panel3.Controls.Add(this.pnl_control);
            this.panel3.Location = new System.Drawing.Point(1, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1378, 740);
            this.panel3.TabIndex = 56;
            // 
            // pnl_ctrlnum
            // 
            this.pnl_ctrlnum.Controls.Add(this.label13);
            this.pnl_ctrlnum.Controls.Add(this.tbx_ctrlnum);
            this.pnl_ctrlnum.Controls.Add(this.btn_ctrlnumset);
            this.pnl_ctrlnum.Controls.Add(this.label6);
            this.pnl_ctrlnum.Controls.Add(this.pictureBox5);
            this.pnl_ctrlnum.Location = new System.Drawing.Point(242, 38);
            this.pnl_ctrlnum.Name = "pnl_ctrlnum";
            this.pnl_ctrlnum.Size = new System.Drawing.Size(234, 123);
            this.pnl_ctrlnum.TabIndex = 65;
            this.pnl_ctrlnum.Visible = false;
            // 
            // tbx_ctrlnum
            // 
            this.tbx_ctrlnum.BackColor = System.Drawing.Color.LemonChiffon;
            this.tbx_ctrlnum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_ctrlnum.Location = new System.Drawing.Point(74, 51);
            this.tbx_ctrlnum.Name = "tbx_ctrlnum";
            this.tbx_ctrlnum.Size = new System.Drawing.Size(98, 23);
            this.tbx_ctrlnum.TabIndex = 0;
            // 
            // btn_ctrlnumset
            // 
            this.btn_ctrlnumset.BackColor = System.Drawing.Color.White;
            this.btn_ctrlnumset.BackgroundImage = global::test0515.Properties.Resources.btn2;
            this.btn_ctrlnumset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ctrlnumset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ctrlnumset.Font = new System.Drawing.Font("微軟正黑體", 8F, System.Drawing.FontStyle.Bold);
            this.btn_ctrlnumset.Location = new System.Drawing.Point(81, 94);
            this.btn_ctrlnumset.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ctrlnumset.Name = "btn_ctrlnumset";
            this.btn_ctrlnumset.Size = new System.Drawing.Size(71, 22);
            this.btn_ctrlnumset.TabIndex = 61;
            this.btn_ctrlnumset.Text = "關閉";
            this.btn_ctrlnumset.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(43, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 60;
            this.label6.Text = "設定控制件數量";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::test0515.Properties.Resources.set;
            this.pictureBox5.Location = new System.Drawing.Point(15, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(22, 22);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 61;
            this.pictureBox5.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(31, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 17);
            this.label13.TabIndex = 62;
            this.label13.Text = "數量:";
            // 
            // menu
            // 
            this.menu.Location = new System.Drawing.Point(1, 0);
            this.menu.main = null;
            this.menu.Margin = new System.Windows.Forms.Padding(4);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1022, 21);
            this.menu.TabIndex = 55;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1380, 770);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Panel_Title);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Panel_Title.ResumeLayout(false);
            this.Panel_Title.PerformLayout();
            this.pnl_form.ResumeLayout(false);
            this.pnl_form.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_control.ResumeLayout(false);
            this.pnl_lsb.ResumeLayout(false);
            this.pnl_lsb.PerformLayout();
            this.gbx_ctrl_xmlfile_data.ResumeLayout(false);
            this.gbx_ctrl_xmlfile.ResumeLayout(false);
            this.pnl_ctrl.ResumeLayout(false);
            this.pnl_tempctrl.ResumeLayout(false);
            this.pnl_update.ResumeLayout(false);
            this.pnl_update.PerformLayout();
            this.pnl_ccom.ResumeLayout(false);
            this.pnl_ccom.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.pnl_supersu.ResumeLayout(false);
            this.pnl_supersu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.pnl_baud.ResumeLayout(false);
            this.pnl_baud.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gbx_connect.ResumeLayout(false);
            this.gbx_connect.PerformLayout();
            this.pnl_lan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_info.ResumeLayout(false);
            this.pnl_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_com)).EndInit();
            this.gbx_can.ResumeLayout(false);
            this.gbx_can.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_conn)).EndInit();
            this.gbx_config.ResumeLayout(false);
            this.gbx_config.PerformLayout();
            this.pnl_under.ResumeLayout(false);
            this.pnl_st.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel3.ResumeLayout(false);
            this.pnl_ctrlnum.ResumeLayout(false);
            this.pnl_ctrlnum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtb_console;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.Panel Panel_Title;
        private System.Windows.Forms.Label lbl_X;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_SetXml;
        private System.Windows.Forms.Panel pnl_control;
        private System.Windows.Forms.GroupBox gbx_ctrl_xmlfile;
        private System.Windows.Forms.GroupBox gbx_ctrl_xmlfile_data;
        private System.Windows.Forms.Panel pnl_ctrl;
        private System.Windows.Forms.ListBox lsb_ctrl_xmlfile_data;
        private System.Windows.Forms.ListBox lsb_ctrl_xmlfile;
        private System.Windows.Forms.Panel pnl_lsb;
        private System.Windows.Forms.Button btn_fly;
        private System.Windows.Forms.Button btn_drop;
        private System.Windows.Forms.Button btn_ctrlopen;
        private System.Windows.Forms.Button btn_ctrlsave;
        private System.Windows.Forms.Button btn_canopen;
        private System.Windows.Forms.RadioButton rb_canpro;
        private System.Windows.Forms.GroupBox gbx_connect;
        private System.Windows.Forms.ComboBox cbb_port;
        private System.Windows.Forms.Button btn_getcandata;
        private System.Windows.Forms.GroupBox gbx_can;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbx_config;
        private System.Windows.Forms.Button btn_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_baud0;
        private System.Windows.Forms.ComboBox cbb_baud1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_lan;
        private System.Windows.Forms.Button btn_lan;
        private System.Windows.Forms.Label lbl_lan;
        private System.Windows.Forms.Timer CanbusTimer;
        private System.Windows.Forms.Label lbl_state;
        private System.Windows.Forms.PictureBox ptb_com;
        private System.Windows.Forms.Panel pnl_under;
        private System.Windows.Forms.Timer ExitTimer;
        private System.Windows.Forms.Timer OpenTimer;
        private System.Windows.Forms.PictureBox ptb_conn;
        private System.Windows.Forms.Timer ConnTimer;
        private System.Windows.Forms.Label lbl_comsta;
        private menubar menu;
        private Panel pnl_baud;
        private Button btn_baudset;
        private Panel pnl_info;
        private Label label3;
        private Button btn_infook;
        private PictureBox ptb_info;
        private Label label4;
        private Panel pnl_lan;
        private Panel panel1;
        private Button btn_lanok;
        private PictureBox ptb_size;
        private Label lbl_mini;
        private Panel pnl_form;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label5;
        private Panel pnl_filepath;
        private Panel pnl_tempctrl;
        private Panel panel3;
        private PictureBox pictureBox4;
        private Panel pnl_st;
        private Label lbl_lsb;
        private Panel pnl_update;
        private Panel pnl_supersu;
        private Button btn_suset;
        private RichTextBox rtb_su;
        private Label label7;
        private PictureBox pictureBox6;
        private RichTextBox rtb_suCon;
        private Button btn_console;
        private TextBox tb_console;
        private Panel pnl_ccom;
        private Button btn_ccomset;
        private Label label8;
        private PictureBox pictureBox7;
        private Panel panel7;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Panel panel6;
        private Label lbl_g5;
        private Label lbl_g1;
        private Label lbl_g4;
        private Label lbl_g2;
        private Label lbl_g3;
        private Panel panel5;
        private TextBox tbx_g5_lsb;
        private TextBox tbx_g4_lsb;
        private TextBox tbx_g3_lsb;
        private TextBox tbx_g2_lsb;
        private TextBox tbx_g1_lsb;
        private TextBox tbx_g5_size;
        private TextBox tbx_g4_size;
        private TextBox tbx_g3_size;
        private TextBox tbx_g2_size;
        private TextBox tbx_g1_size;
        private TextBox tbx_g5_v;
        private TextBox tbx_g4_v;
        private TextBox tbx_g3_v;
        private TextBox tbx_g2_v;
        private TextBox tbx_g1_v;
        private TextBox tbx_g5_msb;
        private TextBox tbx_g4_msb;
        private TextBox tbx_g3_msb;
        private TextBox tbx_g2_msb;
        private TextBox tbx_g1_msb;
        private Button btn_writeccom;
        private Button btn_readccom;
        private Panel panel8;
        private TextBox tbx_ID;
        private Label label18;
        private TextBox tbx_DLC;
        private Label label20;
        private TextBox tbx_Pid;
        private Label label19;
        private Button btn_ccomsave;
        private Button btn_ccomopen;
        private Label label21;
        private TextBox tbx_g5_type;
        private TextBox tbx_g4_type;
        private TextBox tbx_g3_type;
        private TextBox tbx_g2_type;
        private TextBox tbx_g1_type;
        private Label label9;
        private CheckBox cbx_autoconfig;
        private Label label10;
        private Button btn_updset;
        private Label label12;
        private Label label11;
        private Panel pnl_ctrlnum;
        private Label label13;
        private TextBox tbx_ctrlnum;
        private Button btn_ctrlnumset;
        private Label label6;
        private PictureBox pictureBox5;
    }
}