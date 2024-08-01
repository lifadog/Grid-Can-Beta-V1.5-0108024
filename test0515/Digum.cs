using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0515
{
    public partial class Dignum : UserControl
    {
        public Dignum()
        {
            InitializeComponent();
            this.Size = new Size(86, 22);
            this.BackColor = Color.Transparent;
        }

        private uint retushort(string n)
        {
            return uint.Parse(n);
        }

        private void shownum(uint n)
        {
            DisplayNumber(n.ToString(), 10);
        }

        private string Tempnum = "lily";
        PictureBox pictureBox;
        public bool ischange;

        public void DisplayNumber(string number, int maxDigits = 10)
        {
            if (Tempnum == number)
            {
                if (ischange != false)
                {
                    UpdateDigits(number, maxDigits, false); // 更新为黑色数字
                }
                ischange = false;
                return; // 退出方法，不再进一步更新
            }

            ischange = true; // 数字有变化，标记为更新状态
            UpdateDigits(number, maxDigits, true); // 更新为橘色数字

            Tempnum = number;
        }
        private void UpdateDigits(string number, int maxDigits, bool isUpdating)
        {
            this.Controls.Clear();
            int maxWidth = 86; // 控件的最大宽度
            int height = 16; // 固定高度

            int numDigits = number.Length;
            int widthPerDigit = maxWidth / maxDigits; // 每个数字图片的宽度

            this.Width = maxWidth;
            this.Height = height;

            for (int i = 0; i < numDigits; i++)
            {
                char digit = number[number.Length - 1 - i];
                pictureBox = new PictureBox
                {
                    Name = digit + "ptbnum",
                    Size = new Size(widthPerDigit, height),
                    Location = new Point(maxWidth - (i + 1) * widthPerDigit, 0),
                    Image = GetDigitImage(digit, isUpdating),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    BackColor = Color.Transparent,
                };
                this.Controls.Add(pictureBox);
            }
        }
        private Image GetDigitImage(char digit, bool isUpdating)
        {

            if (isUpdating)
            {
                switch (digit)
                {
                    case '0': return Properties.Resources._00_orange;
                    case '1': return Properties.Resources._11_orange;
                    case '2': return Properties.Resources._22_orange;
                    case '3': return Properties.Resources._33_orange;
                    case '4': return Properties.Resources._44_orange;
                    case '5': return Properties.Resources._55_orange;
                    case '6': return Properties.Resources._66_orange;
                    case '7': return Properties.Resources._77_orange;
                    case '8': return Properties.Resources._88_orange;
                    case '9': return Properties.Resources._99_orange;
                    default: throw new ArgumentException("Invalid digit");
                }
            }
            else
            {
                // 显示黑色图像
                switch (digit)
                {
                    case '0': return Properties.Resources._00;
                    case '1': return Properties.Resources._11;
                    case '2': return Properties.Resources._22;
                    case '3': return Properties.Resources._33;
                    case '4': return Properties.Resources._44;
                    case '5': return Properties.Resources._55;
                    case '6': return Properties.Resources._66;
                    case '7': return Properties.Resources._77;
                    case '8': return Properties.Resources._88;
                    case '9': return Properties.Resources._99;
                    default: throw new ArgumentException("Invalid digit");
                }
            }
        }
    }
}
