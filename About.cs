using System;
using System.Windows.Forms;


namespace FillFormWabBrowser
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {

        }
        
        private void likFeedback_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                //System.Diagnostics.Process.Start("mailto:wenzhixing100@163.com");
                Feedback feedback = new Feedback();
                feedback.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this,ex.ToString());
            }
        }
    }
}
