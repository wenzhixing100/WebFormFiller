using System;
using System.Windows.Forms;


namespace FillFormWabBrowser
{
    public partial class Feedback : Form
    {
        public Feedback()
        {
            InitializeComponent();
        }

        private void Feedback_Load(object sender, EventArgs e)
        {

        }


        private void likMailTo_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("mailto:wenzhixing100@163.com");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this,ex.ToString());
            }
        }

        protected string CheckInputData()
        {
            if (!string.IsNullOrWhiteSpace(tFeedbackText.Text))
                return "请您填写意见或建议";

            return "";
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            string errMsg = CheckInputData();
            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(this, errMsg);
                return;
            }

            try
            {
                WebFormFiller.Update.Feedback feedback = new WebFormFiller.Update.Feedback();
                feedback.SendText(tUserName.Text, tPhone.Text, tTel.Text, tEmail.Text, tFeedbackText.Text);
                MessageBox.Show(this, "发送成功！我们感谢你的反馈。");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.ToString());
                return;
            }

            this.Close();
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
