using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTS.Winfrm.res.code
{
    public class Log
    {
        /// <summary>
        /// 日志填写
        /// </summary>
        /// <param name="type"></param>
        /// <param name="msg"></param>
        public static void Write(logeType type, string msg)
        {
            try
            {
                if (type == logeType.重做日志)
                    msg = "【REDO】" + DateTime.Now.ToString("yyyy-MM-dd HH:mm") + "：" + msg;
                else if (type == logeType.异常日志)
                    msg = "【EXCEPTION】" + DateTime.Now.ToString("yyyy-MM-dd HH:mm") + "：" + msg;
                else if (type == logeType.系统日志)
                    msg = "【SYSTEM】" + DateTime.Now.ToString("yyyy-MM-dd HH:mm") + "：" + msg;
                
            }
            catch (Exception ex)
            {

            }
        }
    }

    public enum logeType
    {
        重做日志 = 1,
        异常日志 = 2,
        系统日志 = 3
    }
}
