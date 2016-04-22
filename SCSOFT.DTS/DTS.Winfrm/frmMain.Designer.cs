namespace DTS.Winfrm
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmi_Setting = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_LogQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_About = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Table = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_System = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_RedoLog = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_ExceptionLog = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_SystemLog = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Setting,
            this.tsmi_LogQuery,
            this.tsmi_About});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(608, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "菜单栏";
            // 
            // tsmi_Setting
            // 
            this.tsmi_Setting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Table,
            this.tsmi_System});
            this.tsmi_Setting.Name = "tsmi_Setting";
            this.tsmi_Setting.Size = new System.Drawing.Size(59, 21);
            this.tsmi_Setting.Text = "设置(&S)";
            // 
            // tsmi_LogQuery
            // 
            this.tsmi_LogQuery.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_RedoLog,
            this.tsmi_ExceptionLog,
            this.tsmi_SystemLog});
            this.tsmi_LogQuery.Name = "tsmi_LogQuery";
            this.tsmi_LogQuery.Size = new System.Drawing.Size(82, 21);
            this.tsmi_LogQuery.Text = "日志查询(&L)";
            // 
            // tsmi_About
            // 
            this.tsmi_About.Name = "tsmi_About";
            this.tsmi_About.Size = new System.Drawing.Size(60, 21);
            this.tsmi_About.Text = "关于(&A)";
            this.tsmi_About.Click += new System.EventHandler(this.tsmi_About_Click);
            // 
            // tsmi_Table
            // 
            this.tsmi_Table.Name = "tsmi_Table";
            this.tsmi_Table.Size = new System.Drawing.Size(152, 22);
            this.tsmi_Table.Text = "表设置(&T)";
            this.tsmi_Table.Click += new System.EventHandler(this.tsmi_Table_Click);
            // 
            // tsmi_System
            // 
            this.tsmi_System.Name = "tsmi_System";
            this.tsmi_System.Size = new System.Drawing.Size(152, 22);
            this.tsmi_System.Text = "系统设置";
            this.tsmi_System.Click += new System.EventHandler(this.tsmi_System_Click);
            // 
            // tsmi_RedoLog
            // 
            this.tsmi_RedoLog.Name = "tsmi_RedoLog";
            this.tsmi_RedoLog.Size = new System.Drawing.Size(152, 22);
            this.tsmi_RedoLog.Text = "重做日志(&R)";
            this.tsmi_RedoLog.Click += new System.EventHandler(this.tsmi_RedoLog_Click);
            // 
            // tsmi_ExceptionLog
            // 
            this.tsmi_ExceptionLog.Name = "tsmi_ExceptionLog";
            this.tsmi_ExceptionLog.Size = new System.Drawing.Size(152, 22);
            this.tsmi_ExceptionLog.Text = "异常日志(&E)";
            this.tsmi_ExceptionLog.Click += new System.EventHandler(this.tsmi_ExceptionLog_Click);
            // 
            // tsmi_SystemLog
            // 
            this.tsmi_SystemLog.Name = "tsmi_SystemLog";
            this.tsmi_SystemLog.Size = new System.Drawing.Size(152, 22);
            this.tsmi_SystemLog.Text = "系统日志(&O)";
            this.tsmi_SystemLog.Click += new System.EventHandler(this.tsmi_SystemLog_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(608, 336);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据交换服务-主页面";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Setting;
        private System.Windows.Forms.ToolStripMenuItem tsmi_LogQuery;
        private System.Windows.Forms.ToolStripMenuItem tsmi_About;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Table;
        private System.Windows.Forms.ToolStripMenuItem tsmi_System;
        private System.Windows.Forms.ToolStripMenuItem tsmi_RedoLog;
        private System.Windows.Forms.ToolStripMenuItem tsmi_ExceptionLog;
        private System.Windows.Forms.ToolStripMenuItem tsmi_SystemLog;
    }
}