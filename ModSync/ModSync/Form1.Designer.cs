namespace ModSync
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt0 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.S2 = new System.Windows.Forms.Panel();
            this.ConfigSyncDir = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ConfigDirADD = new System.Windows.Forms.LinkLabel();
            this.ConfigDirDEL = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.ConfigNameText = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.S1 = new System.Windows.Forms.Panel();
            this.loglist = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.syncbutton = new System.Windows.Forms.Button();
            this.configselect = new System.Windows.Forms.ComboBox();
            this.newconfig = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.downloadinfoprog = new System.Windows.Forms.ProgressBar();
            this.downloadinfo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.S2.SuspendLayout();
            this.S1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.bt1);
            this.panel1.Controls.Add(this.bt0);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 28);
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // bt0
            // 
            this.bt0.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt0.FlatAppearance.BorderSize = 0;
            this.bt0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt0.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt0.Location = new System.Drawing.Point(28, 0);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(75, 28);
            this.bt0.TabIndex = 6;
            this.bt0.Tag = "0";
            this.bt0.Text = "同步";
            this.bt0.UseVisualStyleBackColor = false;
            this.bt0.Click += new System.EventHandler(this.SelectSwitch);
            // 
            // bt1
            // 
            this.bt1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt1.FlatAppearance.BorderSize = 0;
            this.bt1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt1.Location = new System.Drawing.Point(103, 0);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(75, 28);
            this.bt1.TabIndex = 6;
            this.bt1.Tag = "1";
            this.bt1.Text = "配置";
            this.bt1.UseVisualStyleBackColor = false;
            this.bt1.Click += new System.EventHandler(this.SelectSwitch);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("宋体", 12F);
            this.exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exit.Location = new System.Drawing.Point(378, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(22, 28);
            this.exit.TabIndex = 6;
            this.exit.Text = "×";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(227, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mod 同步器";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // S2
            // 
            this.S2.BackgroundImage = global::ModSync.Properties.Resources.L2;
            this.S2.Controls.Add(this.label6);
            this.S2.Controls.Add(this.button1);
            this.S2.Controls.Add(this.comboBox2);
            this.S2.Controls.Add(this.ConfigNameText);
            this.S2.Controls.Add(this.linkLabel4);
            this.S2.Controls.Add(this.newconfig);
            this.S2.Controls.Add(this.label4);
            this.S2.Controls.Add(this.label5);
            this.S2.Controls.Add(this.label3);
            this.S2.Controls.Add(this.comboBox1);
            this.S2.Controls.Add(this.linkLabel2);
            this.S2.Controls.Add(this.ConfigSyncDir);
            this.S2.Controls.Add(this.linkLabel1);
            this.S2.Controls.Add(this.linkLabel3);
            this.S2.Controls.Add(this.ConfigDirDEL);
            this.S2.Controls.Add(this.ConfigDirADD);
            this.S2.Location = new System.Drawing.Point(400, 28);
            this.S2.Name = "S2";
            this.S2.Size = new System.Drawing.Size(400, 250);
            this.S2.TabIndex = 7;
            this.S2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.S2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // ConfigSyncDir
            // 
            this.ConfigSyncDir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ConfigSyncDir.FormattingEnabled = true;
            this.ConfigSyncDir.Location = new System.Drawing.Point(93, 62);
            this.ConfigSyncDir.Name = "ConfigSyncDir";
            this.ConfigSyncDir.Size = new System.Drawing.Size(221, 20);
            this.ConfigSyncDir.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(22, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "同步文件夹";
            // 
            // ConfigDirADD
            // 
            this.ConfigDirADD.AutoSize = true;
            this.ConfigDirADD.BackColor = System.Drawing.Color.Transparent;
            this.ConfigDirADD.Location = new System.Drawing.Point(320, 65);
            this.ConfigDirADD.Name = "ConfigDirADD";
            this.ConfigDirADD.Size = new System.Drawing.Size(29, 12);
            this.ConfigDirADD.TabIndex = 2;
            this.ConfigDirADD.TabStop = true;
            this.ConfigDirADD.Text = "添加";
            // 
            // ConfigDirDEL
            // 
            this.ConfigDirDEL.AutoSize = true;
            this.ConfigDirDEL.BackColor = System.Drawing.Color.Transparent;
            this.ConfigDirDEL.Location = new System.Drawing.Point(355, 65);
            this.ConfigDirDEL.Name = "ConfigDirDEL";
            this.ConfigDirDEL.Size = new System.Drawing.Size(29, 12);
            this.ConfigDirDEL.TabIndex = 2;
            this.ConfigDirDEL.TabStop = true;
            this.ConfigDirDEL.Text = "删除";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(22, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "文件服务器";
            // 
            // ConfigNameText
            // 
            this.ConfigNameText.Location = new System.Drawing.Point(93, 35);
            this.ConfigNameText.Name = "ConfigNameText";
            this.ConfigNameText.Size = new System.Drawing.Size(256, 21);
            this.ConfigNameText.TabIndex = 3;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Location = new System.Drawing.Point(320, 91);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(29, 12);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "添加";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.Location = new System.Drawing.Point(355, 91);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(29, 12);
            this.linkLabel2.TabIndex = 2;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "删除";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(93, 88);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(221, 20);
            this.comboBox1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(22, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "白名单文件";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(17, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "配置名称";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel3.Location = new System.Drawing.Point(355, 38);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(29, 12);
            this.linkLabel3.TabIndex = 2;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "测试";
            // 
            // S1
            // 
            this.S1.BackgroundImage = global::ModSync.Properties.Resources.L1;
            this.S1.Controls.Add(this.downloadinfoprog);
            this.S1.Controls.Add(this.loglist);
            this.S1.Controls.Add(this.downloadinfo);
            this.S1.Controls.Add(this.label1);
            this.S1.Controls.Add(this.syncbutton);
            this.S1.Controls.Add(this.configselect);
            this.S1.Location = new System.Drawing.Point(0, 28);
            this.S1.Name = "S1";
            this.S1.Size = new System.Drawing.Size(400, 250);
            this.S1.TabIndex = 6;
            this.S1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.S1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // loglist
            // 
            this.loglist.FormattingEnabled = true;
            this.loglist.ItemHeight = 12;
            this.loglist.Location = new System.Drawing.Point(272, 39);
            this.loglist.Name = "loglist";
            this.loglist.Size = new System.Drawing.Size(114, 148);
            this.loglist.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "配置";
            // 
            // syncbutton
            // 
            this.syncbutton.Location = new System.Drawing.Point(311, 217);
            this.syncbutton.Name = "syncbutton";
            this.syncbutton.Size = new System.Drawing.Size(75, 23);
            this.syncbutton.TabIndex = 4;
            this.syncbutton.Text = "同步";
            this.syncbutton.UseVisualStyleBackColor = true;
            // 
            // configselect
            // 
            this.configselect.FormattingEnabled = true;
            this.configselect.Location = new System.Drawing.Point(45, 13);
            this.configselect.Name = "configselect";
            this.configselect.Size = new System.Drawing.Size(341, 20);
            this.configselect.TabIndex = 1;
            // 
            // newconfig
            // 
            this.newconfig.AutoSize = true;
            this.newconfig.BackColor = System.Drawing.Color.Transparent;
            this.newconfig.Location = new System.Drawing.Point(305, 199);
            this.newconfig.Name = "newconfig";
            this.newconfig.Size = new System.Drawing.Size(29, 12);
            this.newconfig.TabIndex = 2;
            this.newconfig.TabStop = true;
            this.newconfig.Text = "克隆";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ModSync.Properties.Resources.Syncalt;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "保存配置";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel4.Location = new System.Drawing.Point(353, 199);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(29, 12);
            this.linkLabel4.TabIndex = 2;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "删除";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(76, 217);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(223, 20);
            this.comboBox2.TabIndex = 1;
            // 
            // downloadinfoprog
            // 
            this.downloadinfoprog.Location = new System.Drawing.Point(28, 199);
            this.downloadinfoprog.Name = "downloadinfoprog";
            this.downloadinfoprog.Size = new System.Drawing.Size(358, 12);
            this.downloadinfoprog.TabIndex = 5;
            // 
            // downloadinfo
            // 
            this.downloadinfo.AutoSize = true;
            this.downloadinfo.BackColor = System.Drawing.Color.Transparent;
            this.downloadinfo.ForeColor = System.Drawing.SystemColors.Control;
            this.downloadinfo.Location = new System.Drawing.Point(26, 184);
            this.downloadinfo.Name = "downloadinfo";
            this.downloadinfo.Size = new System.Drawing.Size(89, 12);
            this.downloadinfo.TabIndex = 0;
            this.downloadinfo.Text = "下载:xx.jar 0%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 278);
            this.Controls.Add(this.S2);
            this.Controls.Add(this.S1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Mod同步器";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.S2.ResumeLayout(false);
            this.S2.PerformLayout();
            this.S1.ResumeLayout(false);
            this.S1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox configselect;
        private System.Windows.Forms.LinkLabel newconfig;
        private System.Windows.Forms.ListBox loglist;
        private System.Windows.Forms.Button syncbutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel S1;
        private System.Windows.Forms.Panel S2;
        private System.Windows.Forms.TextBox ConfigNameText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ConfigSyncDir;
        private System.Windows.Forms.LinkLabel ConfigDirDEL;
        private System.Windows.Forms.LinkLabel ConfigDirADD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.ProgressBar downloadinfoprog;
        private System.Windows.Forms.Label downloadinfo;
    }
}

