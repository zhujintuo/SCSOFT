namespace LogQuery
{
    partial class frmLogQuery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogQuery));
            this.tb_Content = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Key = new System.Windows.Forms.TextBox();
            this.btn_Query = new System.Windows.Forms.Button();
            this.tb_LogPath = new System.Windows.Forms.TextBox();
            this.btn_LogLoad = new System.Windows.Forms.Button();
            this.tb_Exists = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_Content
            // 
            this.tb_Content.Location = new System.Drawing.Point(12, 65);
            this.tb_Content.Multiline = true;
            this.tb_Content.Name = "tb_Content";
            this.tb_Content.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_Content.Size = new System.Drawing.Size(662, 260);
            this.tb_Content.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "关键字";
            // 
            // tb_Key
            // 
            this.tb_Key.Location = new System.Drawing.Point(59, 12);
            this.tb_Key.Name = "tb_Key";
            this.tb_Key.Size = new System.Drawing.Size(505, 21);
            this.tb_Key.TabIndex = 1;
            // 
            // btn_Query
            // 
            this.btn_Query.Location = new System.Drawing.Point(570, 11);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(100, 23);
            this.btn_Query.TabIndex = 2;
            this.btn_Query.Text = "关键字查询";
            this.btn_Query.UseVisualStyleBackColor = true;
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // tb_LogPath
            // 
            this.tb_LogPath.Location = new System.Drawing.Point(59, 38);
            this.tb_LogPath.Name = "tb_LogPath";
            this.tb_LogPath.Size = new System.Drawing.Size(505, 21);
            this.tb_LogPath.TabIndex = 4;
            // 
            // btn_LogLoad
            // 
            this.btn_LogLoad.Location = new System.Drawing.Point(570, 36);
            this.btn_LogLoad.Name = "btn_LogLoad";
            this.btn_LogLoad.Size = new System.Drawing.Size(100, 23);
            this.btn_LogLoad.TabIndex = 5;
            this.btn_LogLoad.Text = "日志文件加载";
            this.btn_LogLoad.UseVisualStyleBackColor = true;
            this.btn_LogLoad.Click += new System.EventHandler(this.btn_LogLoad_Click);
            // 
            // tb_Exists
            // 
            this.tb_Exists.Location = new System.Drawing.Point(12, 332);
            this.tb_Exists.Multiline = true;
            this.tb_Exists.Name = "tb_Exists";
            this.tb_Exists.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_Exists.Size = new System.Drawing.Size(662, 123);
            this.tb_Exists.TabIndex = 7;
            // 
            // frmLogQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(686, 466);
            this.Controls.Add(this.tb_Exists);
            this.Controls.Add(this.btn_LogLoad);
            this.Controls.Add(this.tb_LogPath);
            this.Controls.Add(this.btn_Query);
            this.Controls.Add(this.tb_Key);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Content);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "日志查询";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Content;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Key;
        private System.Windows.Forms.Button btn_Query;
        private System.Windows.Forms.TextBox tb_LogPath;
        private System.Windows.Forms.Button btn_LogLoad;
        private System.Windows.Forms.TextBox tb_Exists;
    }
}

