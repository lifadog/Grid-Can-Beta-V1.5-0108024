namespace test0515
{
    partial class ByteCtrl
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comtimer = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_value = new System.Windows.Forms.Label();
            this.btn_set = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptb_Mode = new System.Windows.Forms.PictureBox();
            this.lbl_name1 = new System.Windows.Forms.Label();
            this.lbl_name2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Mode)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::test0515.Properties.Resources.pnlbtcl;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbl_name1);
            this.panel2.Controls.Add(this.btn_set);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(20, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(106, 68);
            this.panel2.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.lbl_value);
            this.panel4.Location = new System.Drawing.Point(9, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(86, 23);
            this.panel4.TabIndex = 7;
            // 
            // lbl_value
            // 
            this.lbl_value.AutoSize = true;
            this.lbl_value.BackColor = System.Drawing.Color.Transparent;
            this.lbl_value.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_value.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_value.Location = new System.Drawing.Point(28, 0);
            this.lbl_value.Name = "lbl_value";
            this.lbl_value.Size = new System.Drawing.Size(58, 22);
            this.lbl_value.TabIndex = 5;
            this.lbl_value.Text = "Value";
            // 
            // btn_set
            // 
            this.btn_set.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_set.Font = new System.Drawing.Font("微軟正黑體", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_set.Location = new System.Drawing.Point(64, 3);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(37, 23);
            this.btn_set.TabIndex = 4;
            this.btn_set.Text = "Set";
            this.btn_set.UseVisualStyleBackColor = true;
            this.btn_set.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::test0515.Properties.Resources.pnlbtcl;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_name2);
            this.panel1.Controls.Add(this.ptb_Mode);
            this.panel1.Location = new System.Drawing.Point(141, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(106, 68);
            this.panel1.TabIndex = 1;
            // 
            // ptb_Mode
            // 
            this.ptb_Mode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb_Mode.Image = global::test0515.Properties.Resources.ON;
            this.ptb_Mode.Location = new System.Drawing.Point(19, 22);
            this.ptb_Mode.Name = "ptb_Mode";
            this.ptb_Mode.Size = new System.Drawing.Size(68, 40);
            this.ptb_Mode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_Mode.TabIndex = 1;
            this.ptb_Mode.TabStop = false;
            this.ptb_Mode.Click += new System.EventHandler(this.ptb_Mode_Click);
            // 
            // lbl_name1
            // 
            this.lbl_name1.AutoSize = true;
            this.lbl_name1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_name1.Location = new System.Drawing.Point(3, 5);
            this.lbl_name1.Name = "lbl_name1";
            this.lbl_name1.Size = new System.Drawing.Size(38, 14);
            this.lbl_name1.TabIndex = 8;
            this.lbl_name1.Text = "Name";
            // 
            // lbl_name2
            // 
            this.lbl_name2.AutoSize = true;
            this.lbl_name2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_name2.Location = new System.Drawing.Point(3, 5);
            this.lbl_name2.Name = "lbl_name2";
            this.lbl_name2.Size = new System.Drawing.Size(38, 14);
            this.lbl_name2.TabIndex = 9;
            this.lbl_name2.Text = "Name";
            // 
            // ByteCtrl
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ByteCtrl";
            this.Size = new System.Drawing.Size(106, 68);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Mode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox ptb_Mode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_set;
        private System.Windows.Forms.Label lbl_value;
        private System.Windows.Forms.Timer comtimer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_name1;
        private System.Windows.Forms.Label lbl_name2;
    }
}
