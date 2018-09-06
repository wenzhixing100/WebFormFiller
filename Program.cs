using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using Microsoft.Win32;
using WebFormFiller.Core;
using WebFormFiller.Update;

namespace FillFormWabBrowser
{
    static class Program
    {
        static Mutex _mutex = null;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool bCreatedNew;
            _mutex = new Mutex(true, SystemConfig.SoftName, out bCreatedNew);
            if (!bCreatedNew)
            {
                MessageBox.Show("您好，您的软件正在运行中！", "错误消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SystemConfig.IsRegisted = true;

            RegistManager registManager = new RegistManager(SystemConfig.SoftName);
            string registDate = "RegistDate";
            bool isRegisted = registManager.IsExitData(registDate);
            if (isRegisted == false)
            {
                registManager.SetData(registDate, DateTime.Now.ToString("yyyy-MM-dd"));
            }

            isRegisted = registManager.IsExitData(SystemConfig.RegistCodeName);
            if (isRegisted == false)//未注册
            {
                SoftRegist softRegist = new SoftRegist();
                if (softRegist.ShowDialog() != DialogResult.Yes)
                    SystemConfig.IsRegisted = false;

                UserMaxIEVertion();
            }
            else
            {
                //注册码对不对
                /*string processorID = ComputerDevices.GetProcessor();
                string processorCode = registManager.GetData(SystemConfig.RegistCodeName);
                PwdManager pwdManager = new PwdManager();
                if (pwdManager.Decode(processorCode) != processorID)
                {
                    MessageBox.Show("您好，您的软件注册码不正确！");
                    SystemConfig.IsRegisted = false;
                }*/

                /*else
                {
                    DateTime date = DateTime.Parse(registManager.GetData(registDate));
                    if ((date.AddYears(1) - DateTime.Now).Days < 0)
                    {
                        MessageBox.Show("您好，您的软件已经过期！");
                        SystemConfig.IsRegisted = false;
                    }
                }*/
            }

#if DEBUG
#else
            /**------------------自动升级---------s--------------**/
            SystemConfig systemConfig = SystemConfig.LoadConfig();
            if (systemConfig.AutoUpdate == true)
            {
                AppUpdater appUpdater = new AppUpdater();
                string errorMsg = "";
                try
                {
                    appUpdater.Update();
                }
                catch (WebException exp)
                {
                    //MsgBox.ErrorMessageBox(string.Format("您好，自动升级出错。无法找到指定升级资源。{0}", exp.ToString()));
                    //MsgBox.WarningBox("您好，系统升级出错。无法找到指定升级资源。");
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
                    MessageBox.Show(errorMsg, "错误消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    AppUpdater.RestoreOldFile();
                }
            }

            /**------------------自动升级---------e--------------**/
#endif
            Application.Run(new MainForm());
        }

        private static void UserMaxIEVertion()
        {
            try
            {
                string key = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Internet Explorer\MAIN\FeatureControl\FEATURE_BROWSER_EMULATION";
                string valueName = SystemConfig.SoftName + ".exe";
                string v = Registry.GetValue(key, valueName, "").ToString();
                if (string.IsNullOrEmpty(v))
                {
                    Registry.SetValue(key, valueName, 9999, RegistryValueKind.DWord);
                }
            }
            catch (Exception e) { }
        }
    }
}
