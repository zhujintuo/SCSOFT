using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> headers = new List<string>();
            headers.Add("区县");
            headers.Add("企业名称");
            headers.Add("监控点名称");
            headers.Add("监测时间");

            string data = null;
            for (int i = 0; i < headers.Count; i++)
            {
                data += headers[i] + "\t";
            }
             

            SaveFileDialog sfd = new SaveFileDialog()
            {
                DefaultExt = "xls",
                Filter = "Microsoft Office Excel(*.xls)|*.xls",
                FilterIndex = 1
            };
            if (DialogResult.OK == sfd.ShowDialog())
            {
                using (Stream stream = sfd.OpenFile())
                {
                    using (StreamWriter writer = new StreamWriter(stream, System.Text.UnicodeEncoding.Unicode))
                    {
                       
                        writer.Write(data);
                        writer.Close();
                    }
                    stream.Close();
                }
            }
        }

        
    }
}
