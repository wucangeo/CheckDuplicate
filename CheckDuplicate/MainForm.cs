using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;

using DevExpress.XtraBars;
using DevExpress.XtraBars.Utils;

namespace CheckDuplicate
{
    public partial class MainForm : Form
    {
        public List<string> folderList = new List<string>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void biSetCheckFolders_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = fbd.SelectedPath;
                if (!Directory.Exists(path))
                {
                    MessageBox.Show("选择的目录不存在，请重新选择。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if(folderList.Contains(path))
                {
                    MessageBox.Show("已包含本目录", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                folderList.Add(path);

                SetRichTextFolderList();
            }            
        }

        private void SetRichTextFolderList()
        {
            this.richTextFolderList.BeginUpdate();
            this.richTextFolderList.EditValue = "";
            foreach(string value in folderList)
            {
                if(!Directory.Exists(value))
                {
                    MessageBox.Show("目录["+value+"]不存在，请重新选择。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                this.richTextFolderList.EditValue += value + "\n";
            }
            this.richTextFolderList.EndUpdate();
            this.richTextFolderList.Refresh();
        }

        private void biReset_ItemClick(object sender, ItemClickEventArgs e)
        {
            folderList.Clear();
            SetRichTextFolderList();
        }

        private void richTextFolderList_EditValueChanged(object sender, EventArgs e)
        {
            string richValue = (string)this.richTextFolderList.EditValue;
            if(richValue == "")
            {
                return;
            }
            folderList.Clear();

            string[] list = richValue.Split('\n');
            string dirDonotExist = "";
            foreach(string value in list)
            {
                if(!Directory.Exists(value))
                {
                    dirDonotExist += value + "\n";
                }
                folderList.Add(value);
            }
            MessageBox.Show("目录[" + dirDonotExist + "]不存在，请重新选择。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void biStart_ItemClick(object sender, ItemClickEventArgs e)
        {

        }


    }
}
