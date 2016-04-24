using System;
using System.Data;
using System.Data.SQLite;
using System.Text;
using System.Windows.Forms;

namespace DTS.Winfrm.Settings
{
    public partial class TableSetting : Form
    {
        public TableSetting()
        {
            InitializeComponent();
        }

        private void TableSetting_Load(object sender, EventArgs e)
        {
            gdv_Tables.AutoGenerateColumns = false;
            BindData();
        }
        /// <summary>
        /// 数据绑定
        /// </summary>
        private void BindData()
        {
            try
            {
                DataSet ds = res.code.SQLiteHelper.ExecuteDataSet("select TableID,TableName,TableCommon,KeyFields,State from tablesetting order by TableID");
                if (ds != null && ds.Tables.Count > 0)
                    gdv_Tables.DataSource = ds.Tables[0];
                else
                    gdv_Tables.DataSource = null;
            }
            catch (Exception ex)
            {
                res.code.Log.Write(res.code.logeType.异常日志, ex.Message);
                MessageBox.Show("数据加载异常！异常信息为：" + ex.Message, "提示", MessageBoxButtons.OK);
            }
        }
        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmi_Refresh_Click(object sender, EventArgs e)
        {
            BindData();
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmi_Save_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in gdv_Tables.Rows)
            {
                row.Tag = 0;

                StringBuilder sb = new StringBuilder();
                sb.AppendLine(@"insert into tablesetting(TableName, TableCommon, KeyFields, State) ");
                sb.AppendLine(@"   values(@TableName, @TableCommon, @KeyFields, @State)");
                
                SQLiteParameter[] parameters = {
                    new SQLiteParameter("@TableName", DbType.String,200),
                    new SQLiteParameter("@TableCommon", DbType.String,500),
                    new SQLiteParameter("@KeyFields", DbType.String,100),
                    new SQLiteParameter("@State", DbType.Int32,4)};
                 
                parameters[0].Value = row.Cells["TableName"].Value;
                parameters[1].Value = row.Cells["TableCommon"].Value;
                parameters[2].Value = row.Cells["KeyFields"].Value;
                parameters[3].Value = row.Cells["State"].Value; 
                 
            }
        }
        /// <summary>
        /// 列编辑事件 标记以编辑过的行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gdv_Tables_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            gdv_Tables.Rows[e.RowIndex].Tag = 1;
        }
    }
}
