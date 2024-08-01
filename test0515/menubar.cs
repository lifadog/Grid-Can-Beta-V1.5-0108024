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
    public partial class menubar : UserControl
    {
        private Main _main;
        public Main main
        {
            get { return _main; }
            set { _main = value; }
        }
        ToolStripMenuItem fileMenuItem;
        public menubar()
        {
            InitializeComponent();
            menu.BackColor = Color.Beige;
            menu.Width = this.Width;
            menu.Renderer = new CustomToolStripRenderer();
            initmenubar();
        }
        ToolStripMenuItem aboutMenuItem;
        private void initmenubar()
        {
            
            // 创建菜单项
            fileMenuItem = new ToolStripMenuItem("檔案(F)");
            ToolStripMenuItem newFileMenuItem = new ToolStripMenuItem("新增工作區(N)", null, new EventHandler(NewFileMenuItem_Click));
            ToolStripMenuItem selectWorkspaceMenuItem = new ToolStripMenuItem("選擇工作區資料夾(P)", null, new EventHandler(SelectWorkspaceMenuItem_Click));
            ToolStripMenuItem openconfigMenuItem = new ToolStripMenuItem("開啟設定檔(O)", null, new EventHandler(opencMenuItem_Click));
            ToolStripMenuItem saveasconfigMenuItem = new ToolStripMenuItem("另存設定檔(S)", null, new EventHandler(saveascMenuItem_Click));
            ToolStripMenuItem saveconfigMenuItem = new ToolStripMenuItem("儲存設定檔(S)", null, new EventHandler(savecMenuItem_Click));
            ToolStripMenuItem closeProgramMenuItem = new ToolStripMenuItem("結束(X)", null, new EventHandler(CloseProgramMenuItem_Click));

            ToolStripMenuItem setMenuItem = new("設定(S)");
            ToolStripMenuItem baudItem = new("設定波特率(B)", null, new EventHandler(setbaud_Click));
            ToolStripMenuItem LanItem = new("設定語言(L)", null, new EventHandler(setLan_Click));
            ToolStripMenuItem SetFItem = new("設定資料格式(E)", null, new EventHandler(SetF_Click));
            ToolStripMenuItem CcomItem = new("控制指令(C)", null, new EventHandler(Ccom_Click));
            ToolStripMenuItem DevFItem = new("開發者功能(D)", null, new EventHandler(Dev_Click));

            aboutMenuItem = new("說明(H)");
            ToolStripMenuItem informationItem = new("關於Grid Can(A)",null,new EventHandler(informationItem_Click));

            ToolStripSeparator t;
           

            // 添加子菜单项到檔案菜单项
            fileMenuItem.DropDownItems.Add(newFileMenuItem);
            fileMenuItem.DropDownItems.Add(selectWorkspaceMenuItem);
            fileMenuItem.DropDownItems.Add(openconfigMenuItem);
            fileMenuItem.DropDownItems.Add(saveconfigMenuItem);
            fileMenuItem.DropDownItems.Add(saveasconfigMenuItem);
            fileMenuItem.DropDownItems.Add(closeProgramMenuItem);

            // 添加檔案菜单项到菜单条
            setMenuItem.DropDownItems.Add(baudItem);
            setMenuItem.DropDownItems.Add(LanItem);
            setMenuItem.DropDownItems.Add(SetFItem);
            setMenuItem.DropDownItems.Add(CcomItem);
            setMenuItem.DropDownItems.Add(DevFItem);
            setMenuItem.DropDownItems[3].Enabled = false;

            aboutMenuItem.DropDownItems.Add(informationItem);
            menu.Items.Add(fileMenuItem);
            menu.Items.Add(setMenuItem);
            menu.Items.Add(aboutMenuItem);

            foreach (ToolStripMenuItem item in menu.Items)
            {
                item.DropDownOpening += Item_DropDownOpening;
            }
        }
        public void test04()
        {
            fileMenuItem.ShowDropDown();  
        }
        public void test05()
        {
            aboutMenuItem.ShowDropDown();
        }
        private void Item_DropDownOpening(object sender, EventArgs e)
        {
            ToolStripDropDownItem item = sender as ToolStripDropDownItem;
            if (item != null)
            {
                foreach (ToolStripItem dropDownItem in item.DropDownItems)
                {
                    dropDownItem.BackColor = Color.Beige;
                }
            }
        }
        private void Ccom_Click(object sender, EventArgs e)
        {
            main.CcomClick();
        }

        private void Dev_Click(object sender, EventArgs e)
        {
            main.DevClick();
        }
        private void SetF_Click(object sender, EventArgs e)
        {
            main.setformshow();
        }
        private void informationItem_Click(object sender, EventArgs e)
        {
            main.iteminfoClick();
        }
        private void setbaud_Click(object sender, EventArgs e)
        {
            main.itemBaudClick();
        }
        private void setLan_Click(object sender, EventArgs e)
        {
            main.itemlanClick();
        }
        private void opencMenuItem_Click(object sender, EventArgs e)
        {
            main.Open_Config();
        }
        private void savecMenuItem_Click(object sender, EventArgs e)
        {
            main.autosave();
        }
        private void saveascMenuItem_Click(object sender, EventArgs e)
        {
            main.Save_Config();
        }
        private void NewFileMenuItem_Click(object sender, EventArgs e)
        {
            main.NewClick();
        }
        // 選擇工作區資料夾点击事件处理程序
        private void SelectWorkspaceMenuItem_Click(object sender, EventArgs e)
        {
            main.Select_FilePath();
        }

        // 關閉程式点击事件处理程序
        private void CloseProgramMenuItem_Click(object sender, EventArgs e)
        {
            main.Close();
        }
    }
    public class CustomToolStripRenderer : ToolStripProfessionalRenderer
    {
        private readonly Color selectedColor = Color.FromArgb(100, 196, 154, 138);
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            if (e.Item.Selected || e.Item.Pressed)
            {
                e.Graphics.FillRectangle(new SolidBrush(selectedColor), e.Item.ContentRectangle); // 設置選中時的背景顏色
            }
            else
            {
                base.OnRenderMenuItemBackground(e);
            }
        }
    }
}
