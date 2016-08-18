namespace Zeje.ConfigEncrypt_
{
    partial class Main
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
            this.lblFile = new System.Windows.Forms.Label();
            this.ofdConfig = new System.Windows.Forms.OpenFileDialog();
            this.btnFile = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.rtbNote = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(31, 17);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(53, 12);
            this.lblFile.TabIndex = 0;
            this.lblFile.Text = "选择文件";
            // 
            // ofdConfig
            // 
            this.ofdConfig.FileName = "配置文件";
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(503, 12);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(75, 23);
            this.btnFile.TabIndex = 1;
            this.btnFile.Text = "选择文件";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(584, 12);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "执行加密处理";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // txtFile
            // 
            this.txtFile.Enabled = false;
            this.txtFile.Location = new System.Drawing.Point(90, 14);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(407, 21);
            this.txtFile.TabIndex = 3;
            // 
            // rtbNote
            // 
            this.rtbNote.Location = new System.Drawing.Point(12, 41);
            this.rtbNote.Name = "rtbNote";
            this.rtbNote.Size = new System.Drawing.Size(679, 246);
            this.rtbNote.TabIndex = 7;
            this.rtbNote.Text = "";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 299);
            this.Controls.Add(this.rtbNote);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.lblFile);
            this.Name = "Main";
            this.Text = "配置文件加密程序";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.OpenFileDialog ofdConfig;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.RichTextBox rtbNote;
    }
}

