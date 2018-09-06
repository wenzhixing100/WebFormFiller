namespace FillFormWabBrowser
{
    partial class SoftRegist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoftRegist));
            this.tNoteText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butOK = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.labRegistCode = new System.Windows.Forms.Label();
            this.tRegistCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tMathineCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tNoteText
            // 
            this.tNoteText.BackColor = System.Drawing.SystemColors.Control;
            this.tNoteText.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tNoteText.ForeColor = System.Drawing.Color.Black;
            this.tNoteText.Location = new System.Drawing.Point(34, 265);
            this.tNoteText.MaxLength = 250;
            this.tNoteText.Multiline = true;
            this.tNoteText.Name = "tNoteText";
            this.tNoteText.ReadOnly = true;
            this.tNoteText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tNoteText.Size = new System.Drawing.Size(556, 26);
            this.tNoteText.TabIndex = 5;
            this.tNoteText.Text = resources.GetString("tNoteText.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "最终用户许可协议：";
            // 
            // butOK
            // 
            this.butOK.Location = new System.Drawing.Point(257, 109);
            this.butOK.Name = "butOK";
            this.butOK.Size = new System.Drawing.Size(75, 23);
            this.butOK.TabIndex = 2;
            this.butOK.Text = "确  定";
            this.butOK.UseVisualStyleBackColor = true;
            this.butOK.Click += new System.EventHandler(this.SubmitData);
            // 
            // butExit
            // 
            this.butExit.Location = new System.Drawing.Point(367, 109);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(75, 23);
            this.butExit.TabIndex = 3;
            this.butExit.Text = "关  闭";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butNo_Click);
            // 
            // labRegistCode
            // 
            this.labRegistCode.AutoSize = true;
            this.labRegistCode.Location = new System.Drawing.Point(37, 65);
            this.labRegistCode.Name = "labRegistCode";
            this.labRegistCode.Size = new System.Drawing.Size(53, 12);
            this.labRegistCode.TabIndex = 7;
            this.labRegistCode.Text = "注册码：";
            // 
            // tRegistCode
            // 
            this.tRegistCode.Location = new System.Drawing.Point(95, 61);
            this.tRegistCode.Name = "tRegistCode";
            this.tRegistCode.Size = new System.Drawing.Size(385, 21);
            this.tRegistCode.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "机器码：";
            // 
            // tMathineCode
            // 
            this.tMathineCode.BackColor = System.Drawing.SystemColors.Control;
            this.tMathineCode.Location = new System.Drawing.Point(95, 24);
            this.tMathineCode.Name = "tMathineCode";
            this.tMathineCode.ReadOnly = true;
            this.tMathineCode.Size = new System.Drawing.Size(385, 21);
            this.tMathineCode.TabIndex = 1;
            // 
            // SoftRegist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 144);
            this.Controls.Add(this.tMathineCode);
            this.Controls.Add(this.tRegistCode);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butOK);
            this.Controls.Add(this.labRegistCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tNoteText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SoftRegist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "软件注册";
            this.Load += new System.EventHandler(this.SoftRegist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tNoteText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butOK;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Label labRegistCode;
        private System.Windows.Forms.TextBox tRegistCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tMathineCode;
    }
}