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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableSetting));
            this.gdv_Tables = new System.Windows.Forms.DataGridView();
            this.TableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableCommon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KeyFields = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_Tables)).BeginInit();
            this.SuspendLayout();
            // 
            // gdv_Tables
            // 
            this.gdv_Tables.BackgroundColor = System.Drawing.Color.White;
            this.gdv_Tables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdv_Tables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TableName,
            this.TableCommon,
            this.KeyFields,
            this.State});
            this.gdv_Tables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdv_Tables.GridColor = System.Drawing.Color.White;
            this.gdv_Tables.Location = new System.Drawing.Point(0, 0);
            this.gdv_Tables.Margin = new System.Windows.Forms.Padding(0);
            this.gdv_Tables.Name = "gdv_Tables";
            this.gdv_Tables.RowTemplate.Height = 23;
            this.gdv_Tables.Size = new System.Drawing.Size(466, 263);
            this.gdv_Tables.TabIndex = 0;
            // 
            // TableName
            // 
            this.TableName.DataPropertyName = "TableName";
            this.TableName.HeaderText = "表名称";
            this.TableName.Name = "TableName";
            // 
            // TableCommon
            // 
            this.TableCommon.DataPropertyName = "TableCommon";
            this.TableCommon.HeaderText = "表说明";
            this.TableCommon.Name = "TableCommon";
            // 
            // KeyFields
            // 
            this.KeyFields.DataPropertyName = "KeyFields";
            this.KeyFields.HeaderText = "关键列";
            this.KeyFields.Name = "KeyFields";
            // 
            // State
            // 
            this.State.DataPropertyName = "State";
            this.State.HeaderText = "是否更新";
            this.State.Name = "State";
            // 
            // TableSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(466, 263);
            this.Controls.Add(this.gdv_Tables);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TableSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "表设置";
            this.Load += new System.EventHandler(this.TableSetting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdv_Tables)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gdv_Tables;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableCommon;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeyFields;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
    }
}