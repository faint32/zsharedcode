﻿namespace zoyobar.shared.panzer.test.web.ib
{
	partial class FormIEBrowserDoc
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose ( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose ( );
			}
			base.Dispose ( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ( )
		{
			this.webBrowser = new System.Windows.Forms.WebBrowser ( );
			this.cmdNavigate = new System.Windows.Forms.Button ( );
			this.cmdExecuteJavscript = new System.Windows.Forms.Button ( );
			this.cmdInstallJavascript = new System.Windows.Forms.Button ( );
			this.cmdDataExchange = new System.Windows.Forms.Button ( );
			this.cmdInvokeJavascript = new System.Windows.Forms.Button ( );
			this.SuspendLayout ( );
			// 
			// webBrowser
			// 
			this.webBrowser.Location = new System.Drawing.Point ( 12, 12 );
			this.webBrowser.MinimumSize = new System.Drawing.Size ( 20, 20 );
			this.webBrowser.Name = "webBrowser";
			this.webBrowser.Size = new System.Drawing.Size ( 250, 250 );
			this.webBrowser.TabIndex = 0;
			this.webBrowser.Url = new System.Uri ( "about:blank", System.UriKind.Absolute );
			// 
			// cmdNavigate
			// 
			this.cmdNavigate.Location = new System.Drawing.Point ( 268, 12 );
			this.cmdNavigate.Name = "cmdNavigate";
			this.cmdNavigate.Size = new System.Drawing.Size ( 75, 23 );
			this.cmdNavigate.TabIndex = 1;
			this.cmdNavigate.Text = "页面跳转";
			this.cmdNavigate.UseVisualStyleBackColor = true;
			this.cmdNavigate.Click += new System.EventHandler ( this.cmdNavigate_Click );
			// 
			// cmdExecuteJavscript
			// 
			this.cmdExecuteJavscript.Location = new System.Drawing.Point ( 268, 41 );
			this.cmdExecuteJavscript.Name = "cmdExecuteJavscript";
			this.cmdExecuteJavscript.Size = new System.Drawing.Size ( 130, 23 );
			this.cmdExecuteJavscript.TabIndex = 1;
			this.cmdExecuteJavscript.Text = "执行 javascript";
			this.cmdExecuteJavscript.UseVisualStyleBackColor = true;
			this.cmdExecuteJavscript.Click += new System.EventHandler ( this.cmdExecuteJavscript_Click );
			// 
			// cmdInstallJavascript
			// 
			this.cmdInstallJavascript.Location = new System.Drawing.Point ( 268, 70 );
			this.cmdInstallJavascript.Name = "cmdInstallJavascript";
			this.cmdInstallJavascript.Size = new System.Drawing.Size ( 130, 23 );
			this.cmdInstallJavascript.TabIndex = 1;
			this.cmdInstallJavascript.Text = "安装 javascript";
			this.cmdInstallJavascript.UseVisualStyleBackColor = true;
			this.cmdInstallJavascript.Click += new System.EventHandler ( this.cmdInstallJavascript_Click );
			// 
			// cmdDataExchange
			// 
			this.cmdDataExchange.Location = new System.Drawing.Point ( 268, 128 );
			this.cmdDataExchange.Name = "cmdDataExchange";
			this.cmdDataExchange.Size = new System.Drawing.Size ( 75, 23 );
			this.cmdDataExchange.TabIndex = 1;
			this.cmdDataExchange.Text = "数据交互";
			this.cmdDataExchange.UseVisualStyleBackColor = true;
			this.cmdDataExchange.Click += new System.EventHandler ( this.cmdDataExchange_Click );
			// 
			// cmdInvokeJavascript
			// 
			this.cmdInvokeJavascript.Location = new System.Drawing.Point ( 268, 99 );
			this.cmdInvokeJavascript.Name = "cmdInvokeJavascript";
			this.cmdInvokeJavascript.Size = new System.Drawing.Size ( 130, 23 );
			this.cmdInvokeJavascript.TabIndex = 1;
			this.cmdInvokeJavascript.Text = "调用 javascript";
			this.cmdInvokeJavascript.UseVisualStyleBackColor = true;
			this.cmdInvokeJavascript.Click += new System.EventHandler ( this.cmdInvokeJavascript_Click );
			// 
			// FormIEBrowserDoc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF ( 6F, 12F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size ( 572, 324 );
			this.Controls.Add ( this.cmdInvokeJavascript );
			this.Controls.Add ( this.cmdDataExchange );
			this.Controls.Add ( this.cmdInstallJavascript );
			this.Controls.Add ( this.cmdExecuteJavscript );
			this.Controls.Add ( this.cmdNavigate );
			this.Controls.Add ( this.webBrowser );
			this.Name = "FormIEBrowserDoc";
			this.Text = "FormIEBrowserDoc";
			this.ResumeLayout ( false );

		}

		#endregion

		private System.Windows.Forms.WebBrowser webBrowser;
		private System.Windows.Forms.Button cmdNavigate;
		private System.Windows.Forms.Button cmdExecuteJavscript;
		private System.Windows.Forms.Button cmdInstallJavascript;
		private System.Windows.Forms.Button cmdDataExchange;
		private System.Windows.Forms.Button cmdInvokeJavascript;
	}
}