using System;
using System.Windows.Forms;
using WebFormFiller.Core;

namespace FillFormWabBrowser
{
    public partial class SoftRegist : System.Windows.Forms.Form
    {
        public SoftRegist()
        {
            InitializeComponent();  
        }

        string _processorID = null;
        private void SoftRegist_Load(object sender, EventArgs e)
        {
            ShowInfo();
        }
        
        protected void ShowInfo()
        {
            //tRegistCode.Visible = false;
            tNoteText.Text = "技术支持：温智星 18016526665";
            RegistManager registManager = new RegistManager(SystemConfig.SoftName);
            bool isRegisted = registManager.IsExitData(SystemConfig.RegistCodeName);
            _processorID = ComputerDevices.GetProcessor();
            tMathineCode.Text = _processorID;

            if (isRegisted == true)//已注册
            {
                string processorCode = registManager.GetData(SystemConfig.RegistCodeName);
                PwdManager pwdManager = new PwdManager();
                if (pwdManager.Decode(processorCode) == _processorID)//注册码正确
                {
                    tRegistCode.Text = processorCode;
                    butOK.Visible = false;
                    return;
                }
            }
            else
            {
                PwdManager pwdManager = new PwdManager();
                tRegistCode.Text = pwdManager.Encode(_processorID);
                SubmitData(null, null);
            }

        }

        protected string CheckInputData()
        {
            if (string.IsNullOrEmpty(tRegistCode.Text.Trim()))
                return "请输入注册码";

            PwdManager pwdManager = new PwdManager();
            if (pwdManager.Encode(_processorID) != tRegistCode.Text)
                return "对不起，您请输入的注册码不正确！";
            
            return "";
        }

        public void SubmitData(object sender, EventArgs e)
        {
            tRegistCode.Focus();
            string errMsg = CheckInputData();
            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(this, errMsg, "错误消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RegistManager registManager = new RegistManager(SystemConfig.SoftName);
            registManager.SetData(SystemConfig.RegistCodeName, tRegistCode.Text);

            bool isExitData = registManager.IsExitData(SystemConfig.RegistCodeName);
            if (isExitData)
            {
                MessageBox.Show(this, "注册成功，祝你使用愉快！", "注册成功", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                this.Close();
            }
            else
            {
                MessageBox.Show(this, "对不起，注册失败，请与我们的客服人员联系！");
            }
        }

        private void butNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.No;
            this.Close();
        }
    }
}
