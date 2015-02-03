namespace CheckDuplicate
{
    partial class MainForm
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
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.biSetCheckFolders = new DevExpress.XtraBars.BarButtonItem();
            this.biReset = new DevExpress.XtraBars.BarButtonItem();
            this.richTextFolderList = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemRichTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.biStart = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemCheckedComboBoxEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            this.treeListResult = new DevExpress.XtraTreeList.TreeList();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemRadioGroup1 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.biSetCheckFolders,
            this.biReset,
            this.richTextFolderList,
            this.barButtonItem1,
            this.biStart,
            this.barCheckItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 14;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckedComboBoxEdit1,
            this.repositoryItemRichTextEdit1,
            this.repositoryItemRadioGroup1});
            this.ribbonControl1.Size = new System.Drawing.Size(872, 145);
            // 
            // biSetCheckFolders
            // 
            this.biSetCheckFolders.Caption = "设置目录";
            this.biSetCheckFolders.Glyph = global::CheckDuplicate.Properties.Resources.folder_add_icon;
            this.biSetCheckFolders.Id = 1;
            this.biSetCheckFolders.Name = "biSetCheckFolders";
            this.biSetCheckFolders.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.biSetCheckFolders.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biSetCheckFolders_ItemClick);
            // 
            // biReset
            // 
            this.biReset.Caption = "重新设置";
            this.biReset.Glyph = global::CheckDuplicate.Properties.Resources.reset_icon;
            this.biReset.Id = 3;
            this.biReset.Name = "biReset";
            this.biReset.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.biReset.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biReset_ItemClick);
            // 
            // richTextFolderList
            // 
            this.richTextFolderList.Caption = "目录列表:";
            this.richTextFolderList.Edit = this.repositoryItemRichTextEdit1;
            this.richTextFolderList.EditHeight = 70;
            this.richTextFolderList.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown;
            this.richTextFolderList.EditValue = "asfsdfdsfsd";
            this.richTextFolderList.Id = 4;
            this.richTextFolderList.Name = "richTextFolderList";
            this.richTextFolderList.Width = 150;
            this.richTextFolderList.EditValueChanged += new System.EventHandler(this.richTextFolderList_EditValueChanged);
            // 
            // repositoryItemRichTextEdit1
            // 
            this.repositoryItemRichTextEdit1.Name = "repositoryItemRichTextEdit1";
            this.repositoryItemRichTextEdit1.ShowCaretInReadOnly = false;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 7;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // biStart
            // 
            this.biStart.Caption = "开始扫描";
            this.biStart.Glyph = global::CheckDuplicate.Properties.Resources.start_icon;
            this.biStart.Id = 11;
            this.biStart.Name = "biStart";
            this.biStart.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.biStart.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biStart_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "工具";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.biSetCheckFolders);
            this.ribbonPageGroup1.ItemLinks.Add(this.richTextFolderList);
            this.ribbonPageGroup1.ItemLinks.Add(this.biReset);
            this.ribbonPageGroup1.ItemLinks.Add(this.biStart);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "设置";
            // 
            // repositoryItemCheckedComboBoxEdit1
            // 
            this.repositoryItemCheckedComboBoxEdit1.AutoHeight = false;
            this.repositoryItemCheckedComboBoxEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCheckedComboBoxEdit1.Name = "repositoryItemCheckedComboBoxEdit1";
            // 
            // treeListResult
            // 
            this.treeListResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListResult.Location = new System.Drawing.Point(0, 145);
            this.treeListResult.Name = "treeListResult";
            this.treeListResult.Size = new System.Drawing.Size(872, 394);
            this.treeListResult.TabIndex = 1;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barCheckItem1);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "过滤";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.biStart);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "开始";
            // 
            // repositoryItemRadioGroup1
            // 
            this.repositoryItemRadioGroup1.Name = "repositoryItemRadioGroup1";
            // 
            // barCheckItem1
            // 
            this.barCheckItem1.Caption = "pdf";
            this.barCheckItem1.Id = 13;
            this.barCheckItem1.Name = "barCheckItem1";
            this.barCheckItem1.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 539);
            this.Controls.Add(this.treeListResult);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "MainForm";
            this.Text = "重复文件夹检查工具";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem biSetCheckFolders;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit repositoryItemCheckedComboBoxEdit1;
        private DevExpress.XtraBars.BarButtonItem biReset;
        private DevExpress.XtraBars.BarEditItem richTextFolderList;
        private DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit repositoryItemRichTextEdit1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem biStart;
        private DevExpress.XtraTreeList.TreeList treeListResult;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup repositoryItemRadioGroup1;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
    }
}