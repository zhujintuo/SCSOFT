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

        }
    }

    public enum logeType
    {
        重做日志 = 1,
        异常日志 = 2,
        系统日志 = 3
    }
}
