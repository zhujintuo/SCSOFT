using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace LogQuery
{
    public partial class frmLogQuery : Form
    {
        public frmLogQuery()
        {
            InitializeComponent();
        }

        private void btn_Query_Click(object sender, EventArgs e)
        {
            try
            {
                //string key = tb_Key.Text;
                //if (string.IsNullOrEmpty(key))
                //{
                //    MessageBox.Show("关键字不能为空！", "提示", MessageBoxButtons.OK);
                //    return;
                //}

                StringBuilder sb = new StringBuilder();
                sb.AppendLine(@"select PsCode,DGICode,DGImn ");
                sb.AppendLine(@"   from T_INFO_DGIINFO y");
                sb.AppendLine(@"  where exists(select PsCode,DGICode ");
                sb.AppendLine(@"                 from (select PSCode,DGICode");
                sb.AppendLine(@"						 from T_INFO_DGIOUTPUTMAP x");
                sb.AppendLine(@"						where 1=1");
                sb.AppendLine(@"						  and exists(select 1 ");
                sb.AppendLine(@"									   from V_Output ");
                sb.AppendLine(@"									  where AttentiondegreeCode in (3,4,5)");
                sb.AppendLine(@"										and PsCode=x.PSCode");
                sb.AppendLine(@"										and outputcode=x.OutputCode");
                sb.AppendLine(@"									  )");
                sb.AppendLine(@"					   ) d");
                sb.AppendLine(@"			    where d.PSCode=y.PsCode ");
                sb.AppendLine(@"				  and d.DGICode=y.DGICode");
                sb.AppendLine(@"			   )");

                DataSet ds = res.code.DbHelperSQL.Query(sb.ToString());
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    sb = new StringBuilder();
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        if (tb_Content.Text.Contains(row["DGImn"].ToString()))
                        {
                            sb.AppendFormat("{0} {1} {2} \n", row["PsCode"].ToString(), row["DGICode"].ToString(), row["DGImn"].ToString());
                        }
                    }
                    tb_Exists.Text = sb.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("数据加载异常！异常信息为：" + ex.Message, "提示", MessageBoxButtons.OK);
            }
        }

        private void btn_LogLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "TXT文件(*.txt)|*.txt";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string file = fileDialog.FileName;
                tb_LogPath.Text = file;

                try
                {
                    StreamReader sr = new StreamReader(file, System.Text.Encoding.Default);
                    StringBuilder sb = new StringBuilder();
                    while (sr.ReadLine() != null)
                    {
                        sb.AppendLine(sr.ReadLine());
                    }
                    tb_Content.Text = sb.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("数据加载异常！异常信息为：" + ex.Message, "提示", MessageBoxButtons.OK);
                }
            }
        }
    }
}
