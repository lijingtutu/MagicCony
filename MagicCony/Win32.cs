using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace MagicCony
{
    class Win32
    {
        /// <summary>
        /// 向Windows发送的消息类型
        /// </summary>
        public const int WM_SYSCOMMAND = 0x0112;
        /// <summary>
        /// 发送消息的附加消息
        /// </summary>
        public const int SC_MOVE = 0xF010;
        /// <summary>
        /// 发送消息的附加消息
        /// </summary>
        public const int HTCAPTION = 0x0002;

        /// <summary>
        /// 释放被当前线程中某个窗口中捕获的光标
        /// </summary>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        /// <summary>
        /// 向指定的窗体发送Windows消息
        /// </summary>
        /// <param name="hwdn"></param>
        /// <param name="wMsg"></param>
        /// <param name="mParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwdn, int wMsg, int mParam, int lParam);
    }
}
