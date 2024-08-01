using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test0515
{
    internal class Class1
    {
        //public void Adjust_ByteCtrl_inGroupBox_Positions(GroupBox g)
        //{
        //    int left = 15;
        //    int top = 85;
        //    int spacing = 5; // 控件之間的間隔
        //    int maxWidth = g.Width; // 父容器的寬度
        //    int controlsPerRow = 5; // 每行最多控件數
        //    int currentRow = 0;
        //    int currentColumn = 0;
        //    int initialHeight = g.Height; // 初始高度
        //    g.AutoSize = false;
        //    foreach (Control ctrl in g.Controls)
        //    {
        //        if (ctrl is ByteCtrl)
        //        {
        //            if (currentColumn >= controlsPerRow)
        //            {
        //                currentColumn = 0; // 重置列計數器
        //                currentRow++; // 移動到下一行
        //            }

        //            left = 15 + (currentColumn * (ctrl.Width + spacing)); // 計算左邊位置
        //            top = 85 + (currentRow * (ctrl.Height + spacing)); // 計算頂部位置

        //            ctrl.Location = new Point(left, top);
        //            currentColumn++;
        //        }
        //    }

        //    // 計算新的高度，根據行數調整高度
        //    int newHeight = top + 60 + spacing; // 加上一个控件高度和间隔
        //    int newWidth = g.Controls.OfType<Control>()
        //                              .Where(c => c is ByteCtrl)
        //                              .Max(c => c.Right) + spacing; // 仅找到 ByteCtrl 和 ValueCtrl 最右边的控件并加上间隔

        //    g.Height = newHeight; // 更新 GroupBox 高度，保证不小于初始高度
        //    g.Width = newWidth;  // 更新 GroupBox 宽度，保证不小于初始宽度
        //    g.SetBounds(g.Left, g.Top, newWidth, newHeight); // 更新 GroupBox 的大小
        //    g.AutoSize = true;
        //    Adjust_Btn_Lbl_Positions(g);
        //    g.Refresh();
        //    pnl_ctrl.Refresh();
        //}
        //public void Adjust_Lbl_Positions(GroupBox groupBox)
        //{
        //    int groupBoxWidth = groupBox.Width;

        //    Label descriptionLabel = groupBox.Controls.OfType<Label>().FirstOrDefault();
        //    if (descriptionLabel != null)
        //    {
        //        descriptionLabel.Location = new Point(groupBoxWidth / 2 - 65, 20);
        //        Console.WriteLine($"Description Label Position: {descriptionLabel.Location}");
        //    }
        //    groupBox.Refresh(); // 强制重绘GroupBox
        //}
        //public void Add_Description(GroupBox groupBox)
        //{
        //    Label descriptionLabel = groupBox.Controls.OfType<Label>().FirstOrDefault();
        //    if (descriptionLabel != null)
        //    {
        //        string newDescription = Prompt.ShowDialog("Enter description:", "Add Description", descriptionLabel.Text);
        //        if (!string.IsNullOrWhiteSpace(newDescription))
        //        {
        //            descriptionLabel.Text = newDescription;
        //        }
        //    }
        //}
        //public void ByteCtrl_ModeChanged(object sender, int e)
        //{
        //    test1(sender, e);
        //}
        //public void ByteCtrl_UshortChanged(object sender, int e)
        //{
        //    test1(sender, e);
        //}
        //public void Clear_ByteCtrl_In_Panel()
        //{
        //    foreach (Control ctrl in pnl_ctrl.Controls)
        //    {
        //        ctrl.Dispose();
        //    }
        //    pnl_ctrl.Controls.Clear();
        //}        //public void Update_XmlFile_Value(string xmlFilename, string ctrlName, int value)
        //{
        //    string selectedFile = Path.Combine(xmlFolderPath, xmlFilename + ".xml");

        //    if (File.Exists(selectedFile))
        //    {
        //        XmlSerializer serializer = new XmlSerializer(typeof(DataItemsContainer));
        //        DataItemsContainer container;

        //        using (StreamReader reader = new StreamReader(selectedFile))
        //        {
        //            container = (DataItemsContainer)serializer.Deserialize(reader);
        //        }

        //        var dataItem = container.DataItems.Find(di => di.Name == ctrlName);
        //        if (dataItem != null)
        //        {
        //            dataItem.Value = value.ToString();

        //            using (StreamWriter writer = new StreamWriter(selectedFile))
        //            {
        //                serializer.Serialize(writer, container);
        //            }
        //            isupdatevalue = true;
        //            LogHelper.WriteLog("Update Data in Xml success");
        //            //Load_Data_From_XmlFile(selectedFile, tbx_Name, xmlFilename, ctrlName, value.ToString());
        //        }
        //    }
        //}        //public void test1(object sender, int value)
        //{
        //    ByteCtrl ctrl = sender as ByteCtrl;
        //    if (ctrl != null)
        //    {
        //        // Update_XmlFile_Value(ctrl.XmlFileName, ctrl.ctrlname, value);
        //    }
        //}
        //public string ReturnValue(DataItem item, byte[] data)
        //{
        //    string type = item.Type;
        //    int size = int.Parse(item.Size);
        //    int lsb = int.Parse(item.lsb);
        //    int msb = int.Parse(item.msb);
        //    Console.WriteLine((DataMethod.DoMath(data, size, lsb, msb, type)).ToString());
        //    return (DataMethod.DoMath(data, size, lsb, msb, type)).ToString();
        //}        //public void SetCV(CanbusPacket packet)
        //{
        //    UInt32 id = packet.Data[0];
        //    if (id > 20) return;
        //    CMU_FEII bmu = _bmus.Find(x => x.id == id);
        //    if (bmu == null)
        //    {
        //        bmu = new CMU_FEII(id);
        //        bmu.id = id;
        //        bmu.SetAlarmParam(uv, ov, ut, ot);
        //        _bmus.Add(bmu);
        //        _bmus.OrderBy(x => x.id);
        //        //GetBMUCellQueue(bmu);
        //        //GetNtcParam(bmu);
        //        //OnBMUChanged?.Invoke(this, _bmus.Count);
        //    //    bmu.ConfigUpdate += Bmu_ConfigUpdate;
        //    }
        //    bmu.ParsePacket(packet);
        //}
        //public void Bmu_ConfigUpdate(object sender, int info)
        //{
        //    OnBmuUpdated?.Invoke(this, (BMU_V01)sender, info);
        //}
    }
}
