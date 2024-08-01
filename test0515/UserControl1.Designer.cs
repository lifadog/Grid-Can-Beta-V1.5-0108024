namespace test0515
{
    partial class DigClock
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
            this.NowTimer = new System.Windows.Forms.Timer(this.components);
            this.lbl_now = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NowTimer
            // 
            this.NowTimer.Enabled = true;
            this.NowTimer.Interval = 1000;
            // 
            // lbl_now
            // 
            this.lbl_now.AutoSize = true;
            this.lbl_now.BackColor = System.Drawing.Color.Transparent;
            this.lbl_now.Location = new System.Drawing.Point(6, 6);
            this.lbl_now.Name = "lbl_now";
            this.lbl_now.Size = new System.Drawing.Size(33, 12);
            this.lbl_now.TabIndex = 0;
            this.lbl_now.Text = "label1";
            // 
            // DigClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::test0515.Properties.Resources.btn1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lbl_now);
            this.DoubleBuffered = true;
            this.Name = "DigClock";
            this.Size = new System.Drawing.Size(130, 70);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer NowTimer;
        private System.Windows.Forms.Label lbl_now;
    }
}
