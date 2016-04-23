using System; 
using System.Data; 
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
            DataSet ds = res.code.SqliteHelper.ExecDataSet("select * from tablesetting");

            try
            {

            }
            catch (Exception ex) {
                MessageBox.Show("数据加载异常！异常信息为：" + ex.Message, "提示", MessageBoxButtons.OK);
            }
        }
    }
}
