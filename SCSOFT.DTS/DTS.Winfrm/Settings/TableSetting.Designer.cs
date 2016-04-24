namespace DTS.Winfrm.Settings
{
    partial class TableSetting
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableSetting));
            this.gdv_Tables = new System.Windows.Forms.DataGridView();
            this.TableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableCommon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KeyFields = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmi_Refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Save = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_Tables)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gdv_Tables
            // 
            this.gdv_Tables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdv_Tables.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdv_Tables.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gdv_Tables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdv_Tables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TableName,
            this.TableCommon,
            this.KeyFields,
            this.State});
            this.gdv_Tables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdv_Tables.GridColor = System.Drawing.Color.White;
            this.gdv_Tables.Location = new System.Drawing.Point(0, 25);
            this.gdv_Tables.Margin = new System.Windows.Forms.Padding(0);
            this.gdv_Tables.Name = "gdv_Tables";
            this.gdv_Tables.RowTemplate.Height = 23;
            this.gdv_Tables.Size = new System.Drawing.Size(466, 238);
            this.gdv_Tables.TabIndex = 0;
            this.gdv_Tables.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdv_Tables_CellEndEdit);
            // 
            // TableName
            // 
            this.TableName.DataPropertyName = "TableName";
            this.TableName.FillWeight = 94.56266F;
            this.TableName.HeaderText = "表名称";
            this.TableName.Name = "TableName";
            // 
            // TableCommon
            // 
            this.TableCommon.DataPropertyName = "TableCommon";
            this.TableCommon.FillWeight = 129.206F;
            this.TableCommon.HeaderText = "表说明";
            this.TableCommon.Name = "TableCommon";
            // 
            // KeyFields
            // 
            this.KeyFields.DataPropertyName = "KeyFields";
            this.KeyFields.FillWeight = 77.6739F;
            this.KeyFields.HeaderText = "关键列";
            this.KeyFields.Name = "KeyFields";
            // 
            // State
            // 
            this.State.DataPropertyName = "State";
            this.State.FillWeight = 98.55743F;
            this.State.HeaderText = "是否更新";
            this.State.Name = "State";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Refresh,
            this.tsmi_Save});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(466, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmi_Refresh
            // 
            this.tsmi_Refresh.Name = "tsmi_Refresh";
            this.tsmi_Refresh.Size = new System.Drawing.Size(60, 21);
            this.tsmi_Refresh.Text = "刷新(&R)";
            this.tsmi_Refresh.Click += new System.EventHandler(this.tsmi_Refresh_Click);
            // 
            // tsmi_Save
            // 
            this.tsmi_Save.Name = "tsmi_Save";
            this.tsmi_Save.Size = new System.Drawing.Size(59, 21);
            this.tsmi_Save.Text = "保存(&S)";
            this.tsmi_Save.Click += new System.EventHandler(this.tsmi_Save_Click);
            // 
            // TableSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(466, 263);
            this.Controls.Add(this.gdv_Tables);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TableSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "表设置";
            this.Load += new System.EventHandler(this.TableSetting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdv_Tables)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gdv_Tables;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Refresh;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Save;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableCommon;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeyFields;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
    }
}