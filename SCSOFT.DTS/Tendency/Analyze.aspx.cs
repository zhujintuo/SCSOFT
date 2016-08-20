using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Tendency
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private string connectionString = ConfigurationSettings.AppSettings["SQLConnectionstr"].ToString();
        public string categories = string.Empty;
        public string series = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();
            }
        }

        private void BindData()
        {

            var sb = new System.Text.StringBuilder();
            sb.AppendLine(@"select x.sdi_showSectionName,y.fd_month,y.fd_value,x.sdi_sectionOrderby");
            sb.AppendLine(@"  from (select sdi_sectionID,sdi_showSectionName,sdi_sectionOrderby");
            sb.AppendLine(@"		  from T_SYS_SectionDetailInfo");
            sb.AppendLine(@"		 where sdi_year=2016");
            sb.AppendLine(@"		   and sdi_month=01");
            sb.AppendLine(@"		   and sdi_sectionType=31) x");
            sb.AppendLine(@"left join ");
            sb.AppendLine(@"		(select fd_month,fd_sectionID,dbo.T_fn_0_LimtValue("+DropDownList1.SelectedValue+",2) fd_value");
            sb.AppendLine(@"		  from T_DATA_BasicDataApply");
            sb.AppendLine(@"		 where fd_year=2016");
            sb.AppendLine(@"		   --and fd_month=01");
            sb.AppendLine(@"		   and fd_sectionType=31");
            sb.AppendLine(@"		     ) y");
            sb.AppendLine(@" on x.sdi_sectionID=y.fd_sectionID");
            sb.AppendLine(@" order by y.fd_month,x.sdi_sectionOrderby");

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                DataSet ds = new DataSet();
                try
                {
                    conn.Open();
                    SqlDataAdapter command = new SqlDataAdapter(sb.ToString(), conn);
                    command.Fill(ds, "ds");
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    throw new Exception(ex.Message);
                }

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    #region 1月
                    DataRow[] rows1 = ds.Tables[0].Select("fd_month=01");

                    string temp = "{name: '1月',data: [";
                    foreach (DataRow row in rows1)
                    {
                        categories += "'" + row["sdi_sectionOrderby"] + row["sdi_showSectionName"] + "',";
                        temp += row["fd_value"].ToString() + ",";
                    }
                    categories = categories.TrimEnd(',');
                    temp = temp.TrimEnd(',') + "]},";

                    series += temp;
                    #endregion

                    #region 2月
                    DataRow[] rows2 = ds.Tables[0].Select("fd_month=02");

                    temp = "{name: '2月',data: [";
                    foreach (DataRow row in rows2)
                    {
                        temp += row["fd_value"].ToString() + ",";
                    }
                    temp = temp.TrimEnd(',') + "]},";

                    series = series + temp;
                    #endregion

                    #region 3月
                    DataRow[] rows3 = ds.Tables[0].Select("fd_month=03");

                    temp = "{name: '3月',data: [";
                    foreach (DataRow row in rows3)
                    {
                        temp += row["fd_value"].ToString() + ",";
                    }

                    temp = temp.TrimEnd(',') + "]},";

                    series = series + temp;
                    #endregion

                    #region 4月
                    DataRow[] rows4 = ds.Tables[0].Select("fd_month=04");

                    temp = "{name: '4月',data: [";
                    foreach (DataRow row in rows4)
                    {
                        temp += row["fd_value"].ToString() + ",";
                    }

                    temp = temp.TrimEnd(',') + "]},";

                    series = series + temp;
                    #endregion

                    series = series.TrimEnd(',');
                }
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BindData();
            TextBox1.Text = DropDownList1.SelectedValue;
        }
    }
}