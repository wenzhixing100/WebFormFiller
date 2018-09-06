using System;
using System.IO;
using System.Windows.Forms;
using WebFormFiller.Core;
using WebFormFiller.Core.UI;

namespace FillFormWabBrowser
{
    public partial class MainForm : WebFormFiller.Core.UI.BaseForm
    {
        int _canUseCount = 15;//未注册用户使用次数
        string _registCanUseCountName = "canUseCount";

        public MainForm()
        {
            InitializeComponent();
            navBar1.WebBrowser = this.webBrowser;
            recordList1.FormElementList = this.formElementList;
            webBrowser.MouseoverStatusLabel = labNavStatu;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.recordList1.InitUI();
            this.formElementList.InitUI();
            this.webBrowser.DocumentTitleChanged += new EventHandler(webBrowser_DocumentTitleChanged);
            this.NavToUrl(webBrowser.GetHomePageUrl());
            this.webBrowser.StatusTextChanged += new EventHandler(webBrowser_StatusTextChanged);
            if (SystemConfig.IsRegisted == false)
            {
                RegistManager registManager = new RegistManager(SystemConfig.SoftName);
                bool isCanUserCount = registManager.IsExitData(_registCanUseCountName);
                if (isCanUserCount == false)
                {
                    registManager.SetData(_registCanUseCountName, _canUseCount.ToString());
                }

                Int32.TryParse(registManager.GetData(_registCanUseCountName), out _canUseCount);
            }
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            if (SystemConfig.IsRegisted == false)
            {
                RegistManager registManager = new RegistManager(SystemConfig.SoftName);
                registManager.SetData(_registCanUseCountName, _canUseCount.ToString());
            }

            base.OnClosing(e);
        }

        public override Record GetRecordData()
        {
            Record record = new Record();
            record.ReplaceRN = chkReplaceRN.Checked;
            record.ReplaceTab = chkReplaceTab.Checked;
            record.ClearBlankSpace = chkClearBlankSpace.Checked;
            record.NoDataNotFill = chkNoDataNotFill.Checked;
            record.Text = tFillData.Text;
            record.SplitKey = tSplitKey.Text;
            record.Url = webBrowser.Url.AbsoluteUri;
            return record;
        }

        public override void SetRecordData(Record record)
        {
            chkReplaceRN.Checked = record.ReplaceRN;
            chkNoDataNotFill.Checked = record.NoDataNotFill;
            chkReplaceTab.Checked = record.ReplaceTab;
            chkClearBlankSpace.Checked = record.ClearBlankSpace;
            tSplitKey.Text = record.SplitKey;

            if(!string.IsNullOrWhiteSpace(record.Url))
                webBrowser.NavToUrl(record.Url);

            _onTextChange = true;
            tFillData.Text = record.Text;
            _onTextChange = false;
        }

        void webBrowser_DocumentTitleChanged(object sender, EventArgs e)
        {
            this.Text = this.webBrowser.DocumentTitle;
        }


        private void NavToUrl(String url)
        {
            webBrowser.NavToUrl(url);
        }

        private void webBrowser_NewWindow(object sender, System.ComponentModel.CancelEventArgs e)
        {
            /*
            string newUrl = null;
            try
            {
                newUrl = webBrowser.Document.ActiveElement.GetAttribute("href");//截取url

            }
            catch
            {
                newUrl = webBrowser.Document.Url.AbsoluteUri;
            }
            

            NavToUrl(newUrl);//把url传给webbrowser
            e.Cancel = true; //取消ie操作
             * 
             */
        }

        private void webBrowser_StatusTextChanged(object sender, EventArgs e)
        {
            labLoadState.Text = webBrowser.StatusText;
        }

        private void webBrowser_BeforeNewWindow(object sender, WebBrowserExtendedNavigatingEventArgs e)
        {
            e.Cancel = true;
            NavToUrl(e.Url);
        }

        private void tsbFill_Click(object sender, EventArgs e)
        {
            if (_canUseCount <= 0)
            {
                MessageBox.Show(this, "您现在使用的是未注册软件，您的使用次数已到！", "提示消息",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string errMsg = FillDataToFormElementList();
            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(this, errMsg, "错误消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            butFillDataByList_Click(butFillDataByList, e);

            UpdateCanUseCount();
        }

        public override void SendMsg(MsgTypes msgType, object obj)
        {
            formElementList.GetMsg(msgType, obj);
            webBrowser.GetMsg(msgType, obj);
        }

        private void butPerView_Click(object sender, EventArgs e)
        {
            string errMsg = FillDataToFormElementList();
            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(this, errMsg);
            }
        }

        private string FillDataToFormElementList()
        {
            if (string.IsNullOrEmpty(tFillData.Text))
            {
                return "请在下面的文本框中输入填充数据！";
            }

            int rCount = formElementList.ElementCount;
            if (rCount < 1)
            {
                return "请加入要填充的表单元素！";
            }

            if (string.IsNullOrEmpty(tSplitKey.Text))
            {
                return "请输入分隔符！";
            }

            char[] separator = { Convert.ToChar(tSplitKey.Text) };
            string[] data = tFillData.Text.Split(separator);
            formElementList.FillData(data);

            return "";
        }

        private void UpdateCanUseCount()
        {
            if (SystemConfig.IsRegisted == false)
            {
                MessageBox.Show(this, string.Format("您现在使用的是未注册软件，您还可以使用{0}次！", --_canUseCount), "提示消息",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void butFillDataByList_Click(object sender, EventArgs e)
        {
            if (_canUseCount <= 0)
            {
                MessageBox.Show(this, "您现在使用的是未注册软件，您的使用次数已到！", "提示消息",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int rCount = formElementList.ElementCount;
            for (int i = 0; i < rCount; i++)
            {
                FormElement formElement = formElementList.GetFormElement(i);
                if (chkNoDataNotFill.Checked)
                {
                    if (!string.IsNullOrWhiteSpace(formElement.Value))
                        webBrowser.FillData(formElement);
                }
                else
                    webBrowser.FillData(formElement);
            }

            UpdateCanUseCount();
        }
        bool _onTextChange = false;
        private void tFillData_TextChanged(object sender, EventArgs e)
        {
            if (_onTextChange) return;
            if (tSplitKey.Text.Length < 1)
            {
                MessageBox.Show(this, "请输入分隔符！","错误消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _onTextChange = true;
            string text = tFillData.Text;
            if (chkClearBlankSpace.Checked == true)
                text = text.Replace(" ", "");

            if (chkReplaceTab.Checked == true)
                text = text.Replace("	", tSplitKey.Text);

            if (chkReplaceRN.Checked == true)
                text = text.Replace("\r\n", tSplitKey.Text);

            tFillData.Text = text;
            tFillData.Select(tFillData.Text.Length, 0);
            tFillData.ScrollToCaret();
            _onTextChange = false;
        }

        private void tsmHelp_Click(object sender, EventArgs e)
        {
            try
            {
                string helpFilePath = System.AppDomain.CurrentDomain.BaseDirectory + @"help.chm";
                if (File.Exists(helpFilePath))
                    Help.ShowHelp(this, helpFilePath);
                else
                    throw new Exception();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "打开本地帮助文档出错，将为你打在线机帮助。", "错误消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.Process.Start("http://www.glajijie.com/wfer/help/index.html"); 
            } 
        }

        private void tsmRegistProduct_Click(object sender, EventArgs e)
        {
            SoftRegist softRegist = new SoftRegist();
            softRegist.ShowDialog(this);
        }

        private void tsmFeedback_Click(object sender, EventArgs e)
        {
            Feedback feedback = new Feedback();
            feedback.ShowDialog(this);
        }

        private void tsmUpdate_Click(object sender, EventArgs e)
        {
            UpdateSoft updateSoft = new UpdateSoft();
            updateSoft.ShowDialog(this);
        }

        private void tsmAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog(this);
        }
    }
}