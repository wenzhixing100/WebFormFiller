using System;
using System.Net;
using System.Windows.Forms;
using System.Xml;
using WebFormFiller.Core;
using WebFormFiller.Update;


namespace FillFormWabBrowser
{
    public partial class UpdateSoft : Form
    {
        public UpdateSoft()
        {
            InitializeComponent();
        }

        private void UpdateSoft_Load(object sender, EventArgs e)
        {
            SystemConfig systemConfig = SystemConfig.LoadConfig();
            chkAutoUpdate.Checked = systemConfig.AutoUpdate;
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            SystemConfig systemConfig = SystemConfig.LoadConfig();
            systemConfig.AutoUpdate = chkAutoUpdate.Checked;
            systemConfig.SaveConfig();
            this.Close();
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butUpdate_Click(object sender, EventArgs e)
        {
            AppUpdater appUpdater = new AppUpdater();
            string errorMsg = "";
            try
            {
               int downloadListCount = appUpdater.Update();
               if (downloadListCount < 1)
                   MessageBox.Show(this, "您的软件已为最新版！", "软件更新", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (WebException exp)
            {
                errorMsg = "您好，系统升级出错。无法找到指定升级资源。";
            }
            catch (XmlException exp)
            {
                errorMsg = string.Format("您好，系统升级出错。下载的升级文件有错误。{0}", exp.ToString());
            }
            catch (NotSupportedException exp)
            {
                errorMsg = string.Format("您好，系统升级出错。升级地址配置错误。{0}", exp.ToString());
            }
            catch (ArgumentException exp)
            {
                errorMsg = string.Format("您好，系统升级出错。下载的升级文件有错误。{0}", exp.ToString());
            }
            catch (Exception exp)
            {
                errorMsg = string.Format("您好，系统升级出错。升级过程中发生错误。{0}", exp.ToString());
            }

            if (!string.IsNullOrWhiteSpace(errorMsg))
            {
                MessageBox.Show(this, errorMsg, "错误消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AppUpdater.RestoreOldFile();
            }
        }
    }
}
