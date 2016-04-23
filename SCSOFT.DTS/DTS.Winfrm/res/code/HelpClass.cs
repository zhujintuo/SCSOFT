using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DTS.Winfrm.res.code
{
    public class HelpClass
    {
        /// <summary>
        /// 打开窗体
        /// </summary>
        /// <param name="frm">窗体类</param>
        /// <param name="parent">父容器</param>
        public static void OpenForm(Form form, Control parent)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if ((frm.CompanyName + frm.Name) == (form.CompanyName + form.Name))
                {
                    frm.Dispose(); // 释放掉
                    break;
                }
            }

            form.TopLevel = false;
            form.Parent = parent;
            form.WindowState = FormWindowState.Maximized;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Show();

        }
    }
}
