namespace FillFormWabBrowser
{
    partial class Feedback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Feedback));
            this.labNote = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tUserName = new System.Windows.Forms.TextBox();
            this.tPhone = new System.Windows.Forms.TextBox();
            this.tTel = new System.Windows.Forms.TextBox();
            this.tEmail = new System.Windows.Forms.TextBox();
            this.tFeedbackText = new System.Windows.Forms.TextBox();
            this.butExit = new System.Windows.Forms.Button();
            this.butOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labNote
            // 
            this.labNote.Location = new System.Drawing.Point(37, 28);
            this.labNote.Name = "labNote";
            this.labNote.Size = new System.Drawing.Size(468, 30);
            this.labNote.TabIndex = 7;
            this.labNote.Text = "    您好，如果您在使用中有任何意见或建议请及时反馈给我们，以改进我们的软件和服务。您的意见和建议对我们来说很重要。";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "邮箱：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "电话：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "手机：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "您的姓名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "您的意见或建议（必填）：";
            // 
            // tUserName
            // 
            this.tUserName.Location = new System.Drawing.Point(108, 87);
            this.tUserName.Name = "tUserName";
            this.tUserName.Size = new System.Drawing.Size(212, 21);
            this.tUserName.TabIndex = 0;
            // 
            // tPhone
            // 
            this.tPhone.Location = new System.Drawing.Point(108, 114);
            this.tPhone.Name = "tPhone";
            this.tPhone.Size = new System.Drawing.Size(212, 21);
            this.tPhone.TabIndex = 1;
            // 
            // tTel
            // 
            this.tTel.Location = new System.Drawing.Point(108, 141);
            this.tTel.Name = "tTel";
            this.tTel.Size = new System.Drawing.Size(212, 21);
            this.tTel.TabIndex = 2;
            // 
            // tEmail
            // 
            this.tEmail.Location = new System.Drawing.Point(108, 167);
            this.tEmail.Name = "tEmail";
            this.tEmail.Size = new System.Drawing.Size(212, 21);
            this.tEmail.TabIndex = 3;
            // 
            // tFeedbackText
            // 
            this.tFeedbackText.Location = new System.Drawing.Point(108, 223);
            this.tFeedbackText.Multiline = true;
            this.tFeedbackText.Name = "tFeedbackText";
            this.tFeedbackText.Size = new System.Drawing.Size(344, 89);
            this.tFeedbackText.TabIndex = 4;
            // 
            // butExit
            // 
            this.butExit.Location = new System.Drawing.Point(430, 336);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(75, 23);
            this.butExit.TabIndex = 6;
            this.butExit.Text = "关  闭";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // butOK
            // 
            this.butOK.Location = new System.Drawing.Point(320, 336);
            this.butOK.Name = "butOK";
            this.butOK.Size = new System.Drawing.Size(75, 23);
            this.butOK.TabIndex = 5;
            this.butOK.Text = "确  定";
            this.butOK.UseVisualStyleBackColor = true;
            this.butOK.Click += new System.EventHandler(this.butOK_Click);
            // 
            // Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 384);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butOK);
            this.Controls.Add(this.tFeedbackText);
            this.Controls.Add(this.tEmail);
            this.Controls.Add(this.tTel);
            this.Controls.Add(this.tPhone);
            this.Controls.Add(this.tUserName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labNote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Feedback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "反馈建议";
            this.Load += new System.EventHandler(this.Feedback_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labNote;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tUserName;
        private System.Windows.Forms.TextBox tPhone;
        private System.Windows.Forms.TextBox tTel;
        private System.Windows.Forms.TextBox tEmail;
        private System.Windows.Forms.TextBox tFeedbackText;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Button butOK;

    }
}