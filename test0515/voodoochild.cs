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
    public partial class voodoochild : Form
    {
        public voodoochild()
        {
            InitializeComponent();
            set_Btn();
        }

        private void set_Btn()
        {

            foreach (Control control in this.Controls)
            {
                if (control is Panel)
                {
                    foreach (Control ctrl in control.Controls)
                    {
                        if(ctrl is Button)
                        {
                            Button btn =ctrl as Button;
                            setbtnEvent(btn);
                        }
                    }
                }
            }
        }
        private void setbtnEvent(Button b)
        {
            string ret = Text;
            b.Click += B_Click;
        }

        private void B_Click(object sender, EventArgs e)
        {
            Button b=sender as Button;
            if (rtb_console.Text == "0000000000")
            {
                rtb_console.Clear();
                if (b.Text == "0")
                {
                    rtb_console.Text = "0";
                }
            }
            rtb_console.Text += b.Text;
            if (rtb_console.Text.Length > 10) 
            {
                rtb_console.Text = rtb_console.Text.Substring(0, 10); 
            }
                rtb_console.Text = rtb_console.Text;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            rtb_console.Clear();
            rtb_console.Text = "0000000000";
        }
    }
}
