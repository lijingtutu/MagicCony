namespace MagicCony
{
    partial class Frm_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbox_STool = new System.Windows.Forms.PictureBox();
            this.pbox_Youhua = new System.Windows.Forms.PictureBox();
            this.pbox_Clean = new System.Windows.Forms.PictureBox();
            this.pbox_System = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.显示主界面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_STool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Youhua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Clean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_System)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::MagicCony.Properties.Resources.title;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 42);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::MagicCony.Properties.Resources.close1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(770, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "1";
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MagicCony.Properties.Resources.min1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(734, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "0";
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::MagicCony.Properties.Resources.back;
            this.panel2.Controls.Add(this.pbox_STool);
            this.panel2.Controls.Add(this.pbox_Youhua);
            this.panel2.Controls.Add(this.pbox_Clean);
            this.panel2.Controls.Add(this.pbox_System);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(812, 552);
            this.panel2.TabIndex = 5;
            // 
            // pbox_STool
            // 
            this.pbox_STool.BackColor = System.Drawing.Color.Transparent;
            this.pbox_STool.BackgroundImage = global::MagicCony.Properties.Resources.tool;
            this.pbox_STool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbox_STool.Location = new System.Drawing.Point(380, 415);
            this.pbox_STool.Name = "pbox_STool";
            this.pbox_STool.Size = new System.Drawing.Size(130, 125);
            this.pbox_STool.TabIndex = 3;
            this.pbox_STool.TabStop = false;
            this.pbox_STool.Click += new System.EventHandler(this.pbox_STool_Click);
            // 
            // pbox_Youhua
            // 
            this.pbox_Youhua.BackColor = System.Drawing.Color.Transparent;
            this.pbox_Youhua.BackgroundImage = global::MagicCony.Properties.Resources.youhua;
            this.pbox_Youhua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbox_Youhua.Location = new System.Drawing.Point(208, 415);
            this.pbox_Youhua.Name = "pbox_Youhua";
            this.pbox_Youhua.Size = new System.Drawing.Size(130, 125);
            this.pbox_Youhua.TabIndex = 2;
            this.pbox_Youhua.TabStop = false;
            this.pbox_Youhua.Click += new System.EventHandler(this.pbox_Youhua_Click);
            // 
            // pbox_Clean
            // 
            this.pbox_Clean.BackColor = System.Drawing.Color.Transparent;
            this.pbox_Clean.BackgroundImage = global::MagicCony.Properties.Resources.clean;
            this.pbox_Clean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbox_Clean.Location = new System.Drawing.Point(37, 415);
            this.pbox_Clean.Name = "pbox_Clean";
            this.pbox_Clean.Size = new System.Drawing.Size(130, 125);
            this.pbox_Clean.TabIndex = 1;
            this.pbox_Clean.TabStop = false;
            this.pbox_Clean.Click += new System.EventHandler(this.pbox_Clean_Click);
            // 
            // pbox_System
            // 
            this.pbox_System.BackColor = System.Drawing.Color.Transparent;
            this.pbox_System.BackgroundImage = global::MagicCony.Properties.Resources.system;
            this.pbox_System.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbox_System.Location = new System.Drawing.Point(313, 231);
            this.pbox_System.Name = "pbox_System";
            this.pbox_System.Size = new System.Drawing.Size(207, 77);
            this.pbox_System.TabIndex = 0;
            this.pbox_System.TabStop = false;
            this.pbox_System.Click += new System.EventHandler(this.pbox_System_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示主界面ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 48);
            // 
            // 显示主界面ToolStripMenuItem
            // 
            this.显示主界面ToolStripMenuItem.Name = "显示主界面ToolStripMenuItem";
            this.显示主界面ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.显示主界面ToolStripMenuItem.Text = "显示主界面";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "365系统加速器";
            this.notifyIcon1.Visible = true;
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 594);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "365系统加速器";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_STool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Youhua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Clean)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_System)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbox_STool;
        private System.Windows.Forms.PictureBox pbox_Youhua;
        private System.Windows.Forms.PictureBox pbox_Clean;
        private System.Windows.Forms.PictureBox pbox_System;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 显示主界面ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

