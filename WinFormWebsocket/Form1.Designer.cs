﻿namespace WinFormWebsocket
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.txtInputMsg = new System.Windows.Forms.RichTextBox();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnSendMsg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(778, 510);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(101, 29);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 266);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "输入消息";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "历史消息";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "服务器地址";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(59, 112);
            this.txtLog.Margin = new System.Windows.Forms.Padding(4);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(820, 119);
            this.txtLog.TabIndex = 19;
            this.txtLog.Text = "";
            // 
            // txtInputMsg
            // 
            this.txtInputMsg.Location = new System.Drawing.Point(59, 304);
            this.txtInputMsg.Margin = new System.Windows.Forms.Padding(4);
            this.txtInputMsg.Name = "txtInputMsg";
            this.txtInputMsg.Size = new System.Drawing.Size(820, 173);
            this.txtInputMsg.TabIndex = 20;
            this.txtInputMsg.Text = "";
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(182, 38);
            this.txtServerIP.Margin = new System.Windows.Forms.Padding(4);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(540, 25);
            this.txtServerIP.TabIndex = 18;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(746, 38);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(133, 29);
            this.btnConnect.TabIndex = 16;
            this.btnConnect.Text = "连接";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.Location = new System.Drawing.Point(614, 510);
            this.btnSendMsg.Margin = new System.Windows.Forms.Padding(4);
            this.btnSendMsg.Name = "btnSendMsg";
            this.btnSendMsg.Size = new System.Drawing.Size(157, 29);
            this.btnSendMsg.TabIndex = 17;
            this.btnSendMsg.Text = "发送消息";
            this.btnSendMsg.UseVisualStyleBackColor = true;
            this.btnSendMsg.Click += new System.EventHandler(this.btnSendMsg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 577);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.txtInputMsg);
            this.Controls.Add(this.txtServerIP);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnSendMsg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.RichTextBox txtInputMsg;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnSendMsg;
    }
}

