namespace FillFormWabBrowser
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelTop = new System.Windows.Forms.Panel();
            this.navBar1 = new WebFormFiller.Core.UI.NavBar(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslHelp = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.formElementList = new WebFormFiller.Core.UI.FormElementList();
            this.panel3 = new System.Windows.Forms.Panel();
            this.recordList1 = new WebFormFiller.Core.UI.RecordList();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.labLoadState = new System.Windows.Forms.Label();
            this.webBrowser = new WebFormFiller.Core.UI.YsWebBrowser();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.tFillData = new System.Windows.Forms.TextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkNoDataNotFill = new System.Windows.Forms.CheckBox();
            this.butFillForm = new System.Windows.Forms.Button();
            this.butPerView = new System.Windows.Forms.Button();
            this.butFillDataByList = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkClearBlankSpace = new System.Windows.Forms.CheckBox();
            this.chkReplaceRN = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkReplaceTab = new System.Windows.Forms.CheckBox();
            this.tSplitKey = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labNavStatu = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelTop.SuspendLayout();
            this.navBar1.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel9.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.navBar1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(992, 25);
            this.panelTop.TabIndex = 0;
            // 
            // navBar1
            // 
            this.navBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBar1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.navBar1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.navBar1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.tslHelp});
            this.navBar1.Location = new System.Drawing.Point(0, 0);
            this.navBar1.Name = "navBar1";
            this.navBar1.Size = new System.Drawing.Size(992, 25);
            this.navBar1.TabIndex = 0;
            this.navBar1.Text = "navBar1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tslHelp
            // 
            this.tslHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmHelp,
            this.tsmAbout});
            this.tslHelp.Name = "tslHelp";
            this.tslHelp.Size = new System.Drawing.Size(42, 22);
            this.tslHelp.Text = "帮助";
            // 
            // tsmHelp
            // 
            this.tsmHelp.Name = "tsmHelp";
            this.tsmHelp.Size = new System.Drawing.Size(172, 22);
            this.tsmHelp.Text = "查看帮助";
            this.tsmHelp.Click += new System.EventHandler(this.tsmHelp_Click);
            // 
            // tsmAbout
            // 
            this.tsmAbout.Name = "tsmAbout";
            this.tsmAbout.Size = new System.Drawing.Size(172, 22);
            this.tsmAbout.Text = "关于 网页填单助手";
            this.tsmAbout.Click += new System.EventHandler(this.tsmAbout_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.panel2);
            this.panelRight.Controls.Add(this.panel3);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(682, 25);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(310, 648);
            this.panelRight.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.formElementList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 387);
            this.panel2.TabIndex = 2;
            // 
            // formElementList
            // 
            this.formElementList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formElementList.Location = new System.Drawing.Point(0, 0);
            this.formElementList.Name = "formElementList";
            this.formElementList.SelectedFormElement = null;
            this.formElementList.Size = new System.Drawing.Size(310, 387);
            this.formElementList.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.recordList1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 387);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(310, 261);
            this.panel3.TabIndex = 1;
            // 
            // recordList1
            // 
            this.recordList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recordList1.Location = new System.Drawing.Point(0, 0);
            this.recordList1.Name = "recordList1";
            this.recordList1.Size = new System.Drawing.Size(310, 261);
            this.recordList1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 648);
            this.panel1.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.labLoadState);
            this.panel8.Controls.Add(this.webBrowser);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(682, 521);
            this.panel8.TabIndex = 3;
            // 
            // labLoadState
            // 
            this.labLoadState.AutoSize = true;
            this.labLoadState.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labLoadState.Location = new System.Drawing.Point(0, 509);
            this.labLoadState.Name = "labLoadState";
            this.labLoadState.Size = new System.Drawing.Size(0, 12);
            this.labLoadState.TabIndex = 0;
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(682, 521);
            this.webBrowser.TabIndex = 1;
            this.webBrowser.BeforeNewWindow += new System.EventHandler<WebFormFiller.Core.UI.WebBrowserExtendedNavigatingEventArgs>(this.webBrowser_BeforeNewWindow);
            this.webBrowser.NewWindow += new System.ComponentModel.CancelEventHandler(this.webBrowser_NewWindow);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel10);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 521);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(682, 105);
            this.panel7.TabIndex = 2;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.tFillData);
            this.panel10.Controls.Add(this.panel12);
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(231, 105);
            this.panel10.TabIndex = 1;
            // 
            // tFillData
            // 
            this.tFillData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tFillData.Location = new System.Drawing.Point(35, 10);
            this.tFillData.Multiline = true;
            this.tFillData.Name = "tFillData";
            this.tFillData.Size = new System.Drawing.Size(196, 95);
            this.tFillData.TabIndex = 2;
            this.tFillData.TextChanged += new System.EventHandler(this.tFillData_TextChanged);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.label1);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel12.Location = new System.Drawing.Point(0, 10);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(35, 95);
            this.panel12.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "填\r\n充\r\n数\r\n据";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel11
            // 
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(231, 10);
            this.panel11.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.groupBox2);
            this.panel9.Controls.Add(this.groupBox1);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(231, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(451, 105);
            this.panel9.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkNoDataNotFill);
            this.groupBox2.Controls.Add(this.butFillForm);
            this.groupBox2.Controls.Add(this.butPerView);
            this.groupBox2.Controls.Add(this.butFillDataByList);
            this.groupBox2.Location = new System.Drawing.Point(223, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 88);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "填充";
            // 
            // chkNoDataNotFill
            // 
            this.chkNoDataNotFill.AutoSize = true;
            this.chkNoDataNotFill.Location = new System.Drawing.Point(16, 15);
            this.chkNoDataNotFill.Name = "chkNoDataNotFill";
            this.chkNoDataNotFill.Size = new System.Drawing.Size(84, 28);
            this.chkNoDataNotFill.TabIndex = 8;
            this.chkNoDataNotFill.Text = "列表数据为\r\n空则不填充";
            this.chkNoDataNotFill.UseVisualStyleBackColor = true;
            // 
            // butFillForm
            // 
            this.butFillForm.Location = new System.Drawing.Point(16, 51);
            this.butFillForm.Name = "butFillForm";
            this.butFillForm.Size = new System.Drawing.Size(63, 23);
            this.butFillForm.TabIndex = 5;
            this.butFillForm.Text = "直接填充";
            this.butFillForm.UseVisualStyleBackColor = true;
            this.butFillForm.Click += new System.EventHandler(this.tsbFill_Click);
            // 
            // butPerView
            // 
            this.butPerView.Location = new System.Drawing.Point(118, 16);
            this.butPerView.Name = "butPerView";
            this.butPerView.Size = new System.Drawing.Size(75, 23);
            this.butPerView.TabIndex = 6;
            this.butPerView.Text = "填充到列表";
            this.butPerView.UseVisualStyleBackColor = true;
            this.butPerView.Click += new System.EventHandler(this.butPerView_Click);
            // 
            // butFillDataByList
            // 
            this.butFillDataByList.Location = new System.Drawing.Point(118, 51);
            this.butFillDataByList.Name = "butFillDataByList";
            this.butFillDataByList.Size = new System.Drawing.Size(85, 23);
            this.butFillDataByList.TabIndex = 7;
            this.butFillDataByList.Text = "用列表值填充";
            this.butFillDataByList.UseVisualStyleBackColor = true;
            this.butFillDataByList.Click += new System.EventHandler(this.butFillDataByList_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkClearBlankSpace);
            this.groupBox1.Controls.Add(this.chkReplaceRN);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chkReplaceTab);
            this.groupBox1.Controls.Add(this.tSplitKey);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 88);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "粘贴";
            // 
            // chkClearBlankSpace
            // 
            this.chkClearBlankSpace.AutoSize = true;
            this.chkClearBlankSpace.Checked = true;
            this.chkClearBlankSpace.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkClearBlankSpace.Location = new System.Drawing.Point(17, 20);
            this.chkClearBlankSpace.Name = "chkClearBlankSpace";
            this.chkClearBlankSpace.Size = new System.Drawing.Size(72, 16);
            this.chkClearBlankSpace.TabIndex = 0;
            this.chkClearBlankSpace.Text = "去除空格";
            this.chkClearBlankSpace.UseVisualStyleBackColor = true;
            // 
            // chkReplaceRN
            // 
            this.chkReplaceRN.AutoSize = true;
            this.chkReplaceRN.Checked = true;
            this.chkReplaceRN.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkReplaceRN.Location = new System.Drawing.Point(17, 64);
            this.chkReplaceRN.Name = "chkReplaceRN";
            this.chkReplaceRN.Size = new System.Drawing.Size(144, 16);
            this.chkReplaceRN.TabIndex = 2;
            this.chkReplaceRN.Text = "将换行符替换为分隔符";
            this.chkReplaceRN.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "分隔符：";
            // 
            // chkReplaceTab
            // 
            this.chkReplaceTab.AutoSize = true;
            this.chkReplaceTab.Checked = true;
            this.chkReplaceTab.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkReplaceTab.Location = new System.Drawing.Point(17, 42);
            this.chkReplaceTab.Name = "chkReplaceTab";
            this.chkReplaceTab.Size = new System.Drawing.Size(90, 16);
            this.chkReplaceTab.TabIndex = 1;
            this.chkReplaceTab.Text = "从Excel粘贴";
            this.chkReplaceTab.UseVisualStyleBackColor = true;
            // 
            // tSplitKey
            // 
            this.tSplitKey.Location = new System.Drawing.Point(157, 18);
            this.tSplitKey.MaxLength = 1;
            this.tSplitKey.Name = "tSplitKey";
            this.tSplitKey.Size = new System.Drawing.Size(36, 21);
            this.tSplitKey.TabIndex = 4;
            this.tSplitKey.Text = "#";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labNavStatu});
            this.statusStrip1.Location = new System.Drawing.Point(0, 626);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(682, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labNavStatu
            // 
            this.labNavStatu.Name = "labNavStatu";
            this.labNavStatu.Size = new System.Drawing.Size(0, 17);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 673);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "网页填单助手";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.navBar1.ResumeLayout(false);
            this.navBar1.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panel1;
        private WebFormFiller.Core.UI.YsWebBrowser webBrowser;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labNavStatu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox tFillData;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tSplitKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butPerView;
        private System.Windows.Forms.Button butFillForm;
        private System.Windows.Forms.Label labLoadState;
        private System.Windows.Forms.Button butFillDataByList;
        private WebFormFiller.Core.UI.FormElementList formElementList;
        private WebFormFiller.Core.UI.NavBar navBar1;
        private WebFormFiller.Core.UI.RecordList recordList1;
        private System.Windows.Forms.CheckBox chkReplaceRN;
        private System.Windows.Forms.CheckBox chkReplaceTab;
        private System.Windows.Forms.CheckBox chkClearBlankSpace;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripDropDownButton tslHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkNoDataNotFill;
    }
}

