using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace MagicCony
{
    public partial class Frm_Main : Office2007Form
    {
        public Frm_Main()
        {
            this.EnableGlass = false;
            InitializeComponent();
        }

        /// <summary>
        /// 切换最小化和关闭按钮的图片
        /// </summary>
        /// <param name="sender">最小化或关闭按钮</param>
        /// <param name="tag">Tag属性:0表示最小化，1表示关闭</param>
        /// <param name="flag">鼠标动作标识：0表示MouseEnter，1表示MouseLeave</param>
        private void ImageSwitch( object sender, int tag, int flag)
        {
            PictureBox temPbox = (PictureBox)sender;
            switch(tag)
            {
                case 0:
                    {
                        if (flag == 0)
                            temPbox.BackgroundImage = Properties.Resources.min2;
                        else if (flag == 1)
                            temPbox.BackgroundImage = Properties.Resources.min1;
                        break;
                    }
                case 1:
                    {
                        if (flag == 0)
                            temPbox.BackgroundImage = Properties.Resources.close2;
                        else if (flag == 1)
                            temPbox.BackgroundImage = Properties.Resources.close1;
                        break;
                    }
            }
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            ImageSwitch(sender, Convert.ToInt16(((PictureBox)sender).Tag), 0);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            ImageSwitch(sender, Convert.ToInt16(((PictureBox)sender).Tag), 1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(((PictureBox)sender).Tag) == 0)
                this.WindowState = FormWindowState.Minimized;
            else if (Convert.ToInt16(((PictureBox)sender).Tag) == 1)
                this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Win32.ReleaseCapture();
            Win32.SendMessage(this.Handle, Win32.WM_SYSCOMMAND, 
                Win32.SC_MOVE + Win32.HTCAPTION, 0);
        }

        private void pbox_System_Click(object sender, EventArgs e)
        {
            Frm_SysCheck systemCheck = new Frm_SysCheck();
            systemCheck.Show();
        }

        private void pbox_Clean_Click(object sender, EventArgs e)
        {
            Frm_SysTool frm = new Frm_SysTool();
            frm.ShowDialog();
        }

        private void pbox_Youhua_Click(object sender, EventArgs e)
        {
            Frm_Optimize optimize = new Frm_Optimize();
            optimize.Show();
        }

        private void pbox_STool_Click(object sender, EventArgs e)
        {
            Frm_SysTool frm = new Frm_SysTool();
            frm.ShowDialog();
        }
    }
}
