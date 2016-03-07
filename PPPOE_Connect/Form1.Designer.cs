namespace PPPOE_Connect
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radio_StaticIP = new System.Windows.Forms.RadioButton();
            this.radio_LT_Line = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Public_IP = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_PrivateIP = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.断开连接ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radio_Download = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label_version = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // radio_StaticIP
            // 
            this.radio_StaticIP.AutoSize = true;
            this.radio_StaticIP.Checked = true;
            this.radio_StaticIP.Location = new System.Drawing.Point(22, 22);
            this.radio_StaticIP.Name = "radio_StaticIP";
            this.radio_StaticIP.Size = new System.Drawing.Size(71, 16);
            this.radio_StaticIP.TabIndex = 0;
            this.radio_StaticIP.TabStop = true;
            this.radio_StaticIP.Text = "后台专线";
            this.radio_StaticIP.UseVisualStyleBackColor = true;
            // 
            // radio_LT_Line
            // 
            this.radio_LT_Line.AutoSize = true;
            this.radio_LT_Line.Location = new System.Drawing.Point(22, 48);
            this.radio_LT_Line.Name = "radio_LT_Line";
            this.radio_LT_Line.Size = new System.Drawing.Size(71, 16);
            this.radio_LT_Line.TabIndex = 1;
            this.radio_LT_Line.Text = "联通线路";
            this.radio_LT_Line.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "公网 IP:";
            // 
            // label_Public_IP
            // 
            this.label_Public_IP.AutoSize = true;
            this.label_Public_IP.Location = new System.Drawing.Point(69, 136);
            this.label_Public_IP.Name = "label_Public_IP";
            this.label_Public_IP.Size = new System.Drawing.Size(29, 12);
            this.label_Public_IP.TabIndex = 3;
            this.label_Public_IP.Text = "Null";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "连接";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(104, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "刷新";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "PPPOE IP:";
            // 
            // label_PrivateIP
            // 
            this.label_PrivateIP.AutoSize = true;
            this.label_PrivateIP.Location = new System.Drawing.Point(77, 163);
            this.label_PrivateIP.Name = "label_PrivateIP";
            this.label_PrivateIP.Size = new System.Drawing.Size(29, 12);
            this.label_PrivateIP.TabIndex = 7;
            this.label_PrivateIP.Text = "Null";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "线路切换工具";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.断开连接ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 48);
            // 
            // 断开连接ToolStripMenuItem
            // 
            this.断开连接ToolStripMenuItem.Name = "断开连接ToolStripMenuItem";
            this.断开连接ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.断开连接ToolStripMenuItem.Text = "断开连接";
            this.断开连接ToolStripMenuItem.Click += new System.EventHandler(this.断开连接ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(208, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(142, 214);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "后台线路限登陆后台使用\r\n请勿下载\r\n\r\n联通线路仅供测试\r\n请勿下载大文件\r\n\r\n各个专线拨上后会无法连接打印机\r\n\r\n后台专线列表：\r\n222.76.112." +
    "57\r\n222.76.112.61\r\n222.76.112.89\r\n222.76.112.81\r\n222.76.112.85\r\n\r\n 运维部  ";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radio_Download
            // 
            this.radio_Download.AutoSize = true;
            this.radio_Download.Location = new System.Drawing.Point(22, 74);
            this.radio_Download.Name = "radio_Download";
            this.radio_Download.Size = new System.Drawing.Size(71, 16);
            this.radio_Download.TabIndex = 9;
            this.radio_Download.Text = "下载专线";
            this.radio_Download.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(118, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "link_ico.png");
            this.imageList1.Images.SetKeyName(1, "linking_ico.png");
            this.imageList1.Images.SetKeyName(2, "link_error_ico.png");
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "link_done_ico.png");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 12);
            this.label3.TabIndex = 11;
            // 
            // label_version
            // 
            this.label_version.AutoSize = true;
            this.label_version.Location = new System.Drawing.Point(309, 217);
            this.label_version.Name = "label_version";
            this.label_version.Size = new System.Drawing.Size(0, 12);
            this.label_version.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 238);
            this.Controls.Add(this.label_version);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radio_Download);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_PrivateIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_Public_IP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radio_LT_Line);
            this.Controls.Add(this.radio_StaticIP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "线路切换工具";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged_1);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radio_StaticIP;
        private System.Windows.Forms.RadioButton radio_LT_Line;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Public_IP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_PrivateIP;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radio_Download;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_version;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 断开连接ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

