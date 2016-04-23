using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DTS.Winfrm
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
        } 
        /// <summary>
        /// 首页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmi_Home_Click(object sender, EventArgs e)
        {

        } 
        /// <summary>
        /// 表设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmi_Table_Click(object sender, EventArgs e)
        { 
            res.code.HelpClass.OpenForm(new Settings.TableSetting(), panel_Main);
        }
        /// <summary>
        /// 系统设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmi_System_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 重做日志
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmi_RedoLog_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 异常日志
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmi_ExceptionLog_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 系统日志
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmi_SystemLog_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 关于
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmi_About_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmi_Exit_Click(object sender, EventArgs e)
        {

        }
    }
}
