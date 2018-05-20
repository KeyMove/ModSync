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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Headpanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.S2 = new System.Windows.Forms.Panel();
            this.ConfigWhiteFileCheck = new System.Windows.Forms.CheckBox();
            this.ConfigWhiteFileEnable = new System.Windows.Forms.Panel();
            this.ConfigDelWhiteFile = new System.Windows.Forms.LinkLabel();
            this.ConfigAddWhiteFile = new System.Windows.Forms.LinkLabel();
            this.ConfigWhiteFlie = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ConfigSaveConfig = new System.Windows.Forms.Button();
            this.ConfigListSelect = new System.Windows.Forms.ComboBox();
            this.ConfigFileType = new System.Windows.Forms.TextBox();
            this.ConfigServerURL = new System.Windows.Forms.TextBox();
            this.ConfigDelConfig = new System.Windows.Forms.LinkLabel();
            this.ConfigCreateInfo = new System.Windows.Forms.LinkLabel();
            this.ConfigCloneConfig = new System.Windows.Forms.LinkLabel();
            this.ConfigName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ConfigSyncDir = new System.Windows.Forms.ComboBox();
            this.ConfigTestLink = new System.Windows.Forms.LinkLabel();
            this.ConfigDirDEL = new System.Windows.Forms.LinkLabel();
            this.ConfigDirADD = new System.Windows.Forms.LinkLabel();
            this.S1 = new System.Windows.Forms.Panel();
            this.LAB = new System.Windows.Forms.Label();
            this.LogPanel = new System.Windows.Forms.Panel();
            this.downloadinfoprog = new System.Windows.Forms.ProgressBar();
            this.loglist = new System.Windows.Forms.ListBox();
            this.downloadinfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.syncbutton = new System.Windows.Forms.Button();
            this.ConfigSelect = new System.Windows.Forms.ComboBox();
            this.GithubInfo = new System.Windows.Forms.LinkLabel();
            this.Headpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.S2.SuspendLayout();
            this.ConfigWhiteFileEnable.SuspendLayout();
            this.S1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Headpanel
            // 
            this.Headpanel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Headpanel.Controls.Add(this.label2);
            this.Headpanel.Controls.Add(this.pictureBox1);
            this.Headpanel.Controls.Add(this.exit);
            this.Headpanel.Controls.Add(this.bt1);
            this.Headpanel.Controls.Add(this.bt0);
            this.Headpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Headpanel.Location = new System.Drawing.Point(0, 0);
            this.Headpanel.Name = "Headpanel";
            this.Headpanel.Size = new System.Drawing.Size(400, 28);
            this.Headpanel.TabIndex = 5;
            this.Headpanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.Headpanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ModSync.Properties.Resources.x28;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
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
            // S2
            // 
            this.S2.BackgroundImage = global::ModSync.Properties.Resources.L2;
            this.S2.Controls.Add(this.ConfigWhiteFileCheck);
            this.S2.Controls.Add(this.ConfigWhiteFileEnable);
            this.S2.Controls.Add(this.label5);
            this.S2.Controls.Add(this.label6);
            this.S2.Controls.Add(this.ConfigSaveConfig);
            this.S2.Controls.Add(this.ConfigListSelect);
            this.S2.Controls.Add(this.ConfigFileType);
            this.S2.Controls.Add(this.ConfigServerURL);
            this.S2.Controls.Add(this.ConfigDelConfig);
            this.S2.Controls.Add(this.ConfigCreateInfo);
            this.S2.Controls.Add(this.ConfigCloneConfig);
            this.S2.Controls.Add(this.ConfigName);
            this.S2.Controls.Add(this.label4);
            this.S2.Controls.Add(this.label3);
            this.S2.Controls.Add(this.ConfigSyncDir);
            this.S2.Controls.Add(this.ConfigTestLink);
            this.S2.Controls.Add(this.ConfigDirDEL);
            this.S2.Controls.Add(this.ConfigDirADD);
            this.S2.Location = new System.Drawing.Point(400, 28);
            this.S2.Name = "S2";
            this.S2.Size = new System.Drawing.Size(400, 250);
            this.S2.TabIndex = 7;
            this.S2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.S2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // ConfigWhiteFileCheck
            // 
            this.ConfigWhiteFileCheck.AutoSize = true;
            this.ConfigWhiteFileCheck.BackColor = System.Drawing.Color.Transparent;
            this.ConfigWhiteFileCheck.ForeColor = System.Drawing.SystemColors.Menu;
            this.ConfigWhiteFileCheck.Location = new System.Drawing.Point(24, 115);
            this.ConfigWhiteFileCheck.Name = "ConfigWhiteFileCheck";
            this.ConfigWhiteFileCheck.Size = new System.Drawing.Size(84, 16);
            this.ConfigWhiteFileCheck.TabIndex = 6;
            this.ConfigWhiteFileCheck.Text = "白名单文件";
            this.ConfigWhiteFileCheck.UseVisualStyleBackColor = false;
            this.ConfigWhiteFileCheck.CheckedChanged += new System.EventHandler(this.ConfigWhiteFileCheck_CheckedChanged);
            // 
            // ConfigWhiteFileEnable
            // 
            this.ConfigWhiteFileEnable.BackColor = System.Drawing.Color.Transparent;
            this.ConfigWhiteFileEnable.Controls.Add(this.ConfigDelWhiteFile);
            this.ConfigWhiteFileEnable.Controls.Add(this.ConfigAddWhiteFile);
            this.ConfigWhiteFileEnable.Controls.Add(this.ConfigWhiteFlie);
            this.ConfigWhiteFileEnable.Location = new System.Drawing.Point(94, 128);
            this.ConfigWhiteFileEnable.Name = "ConfigWhiteFileEnable";
            this.ConfigWhiteFileEnable.Size = new System.Drawing.Size(294, 33);
            this.ConfigWhiteFileEnable.TabIndex = 5;
            this.ConfigWhiteFileEnable.Visible = false;
            // 
            // ConfigDelWhiteFile
            // 
            this.ConfigDelWhiteFile.AutoSize = true;
            this.ConfigDelWhiteFile.BackColor = System.Drawing.Color.Transparent;
            this.ConfigDelWhiteFile.Location = new System.Drawing.Point(261, 10);
            this.ConfigDelWhiteFile.Name = "ConfigDelWhiteFile";
            this.ConfigDelWhiteFile.Size = new System.Drawing.Size(29, 12);
            this.ConfigDelWhiteFile.TabIndex = 2;
            this.ConfigDelWhiteFile.TabStop = true;
            this.ConfigDelWhiteFile.Text = "删除";
            // 
            // ConfigAddWhiteFile
            // 
            this.ConfigAddWhiteFile.AutoSize = true;
            this.ConfigAddWhiteFile.BackColor = System.Drawing.Color.Transparent;
            this.ConfigAddWhiteFile.Location = new System.Drawing.Point(226, 10);
            this.ConfigAddWhiteFile.Name = "ConfigAddWhiteFile";
            this.ConfigAddWhiteFile.Size = new System.Drawing.Size(29, 12);
            this.ConfigAddWhiteFile.TabIndex = 2;
            this.ConfigAddWhiteFile.TabStop = true;
            this.ConfigAddWhiteFile.Text = "添加";
            // 
            // ConfigWhiteFlie
            // 
            this.ConfigWhiteFlie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ConfigWhiteFlie.FormattingEnabled = true;
            this.ConfigWhiteFlie.Location = new System.Drawing.Point(-1, 7);
            this.ConfigWhiteFlie.Name = "ConfigWhiteFlie";
            this.ConfigWhiteFlie.Size = new System.Drawing.Size(221, 20);
            this.ConfigWhiteFlie.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(34, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "文件类型";
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
            // ConfigSaveConfig
            // 
            this.ConfigSaveConfig.Location = new System.Drawing.Point(307, 216);
            this.ConfigSaveConfig.Name = "ConfigSaveConfig";
            this.ConfigSaveConfig.Size = new System.Drawing.Size(77, 23);
            this.ConfigSaveConfig.TabIndex = 4;
            this.ConfigSaveConfig.Text = "保存配置";
            this.ConfigSaveConfig.UseVisualStyleBackColor = true;
            this.ConfigSaveConfig.Click += new System.EventHandler(this.ConfigSaveConfig_Click);
            // 
            // ConfigListSelect
            // 
            this.ConfigListSelect.FormattingEnabled = true;
            this.ConfigListSelect.Location = new System.Drawing.Point(76, 217);
            this.ConfigListSelect.Name = "ConfigListSelect";
            this.ConfigListSelect.Size = new System.Drawing.Size(223, 20);
            this.ConfigListSelect.TabIndex = 1;
            this.ConfigListSelect.SelectedIndexChanged += new System.EventHandler(this.ConfigList_SelectedIndexChanged);
            // 
            // ConfigFileType
            // 
            this.ConfigFileType.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ConfigFileType.Location = new System.Drawing.Point(93, 88);
            this.ConfigFileType.Name = "ConfigFileType";
            this.ConfigFileType.Size = new System.Drawing.Size(221, 21);
            this.ConfigFileType.TabIndex = 3;
            this.ConfigFileType.Text = "jar;";
            // 
            // ConfigServerURL
            // 
            this.ConfigServerURL.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.ConfigServerURL.Location = new System.Drawing.Point(93, 35);
            this.ConfigServerURL.Name = "ConfigServerURL";
            this.ConfigServerURL.Size = new System.Drawing.Size(256, 21);
            this.ConfigServerURL.TabIndex = 3;
            this.ConfigServerURL.Text = "支持github、ftp服务器";
            this.ConfigServerURL.Enter += new System.EventHandler(this.ConfigServerURL_Enter);
            this.ConfigServerURL.Leave += new System.EventHandler(this.ConfigServerURL_Leave);
            // 
            // ConfigDelConfig
            // 
            this.ConfigDelConfig.AutoSize = true;
            this.ConfigDelConfig.BackColor = System.Drawing.Color.Transparent;
            this.ConfigDelConfig.Location = new System.Drawing.Point(355, 199);
            this.ConfigDelConfig.Name = "ConfigDelConfig";
            this.ConfigDelConfig.Size = new System.Drawing.Size(29, 12);
            this.ConfigDelConfig.TabIndex = 2;
            this.ConfigDelConfig.TabStop = true;
            this.ConfigDelConfig.Text = "删除";
            this.ConfigDelConfig.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ConfigDelConfig_LinkClicked);
            // 
            // ConfigCreateInfo
            // 
            this.ConfigCreateInfo.AutoSize = true;
            this.ConfigCreateInfo.BackColor = System.Drawing.Color.Transparent;
            this.ConfigCreateInfo.Location = new System.Drawing.Point(222, 199);
            this.ConfigCreateInfo.Name = "ConfigCreateInfo";
            this.ConfigCreateInfo.Size = new System.Drawing.Size(77, 12);
            this.ConfigCreateInfo.TabIndex = 2;
            this.ConfigCreateInfo.TabStop = true;
            this.ConfigCreateInfo.Text = "创建同步文件";
            this.ConfigCreateInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ConfigCreateInfo_LinkClicked);
            // 
            // ConfigCloneConfig
            // 
            this.ConfigCloneConfig.AutoSize = true;
            this.ConfigCloneConfig.BackColor = System.Drawing.Color.Transparent;
            this.ConfigCloneConfig.Location = new System.Drawing.Point(305, 199);
            this.ConfigCloneConfig.Name = "ConfigCloneConfig";
            this.ConfigCloneConfig.Size = new System.Drawing.Size(29, 12);
            this.ConfigCloneConfig.TabIndex = 2;
            this.ConfigCloneConfig.TabStop = true;
            this.ConfigCloneConfig.Text = "克隆";
            this.ConfigCloneConfig.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ConfigCloneConfig_LinkClicked);
            // 
            // ConfigName
            // 
            this.ConfigName.AutoSize = true;
            this.ConfigName.BackColor = System.Drawing.Color.Transparent;
            this.ConfigName.ForeColor = System.Drawing.SystemColors.Window;
            this.ConfigName.Location = new System.Drawing.Point(74, 199);
            this.ConfigName.Name = "ConfigName";
            this.ConfigName.Size = new System.Drawing.Size(0, 12);
            this.ConfigName.TabIndex = 1;
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
            // ConfigSyncDir
            // 
            this.ConfigSyncDir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ConfigSyncDir.FormattingEnabled = true;
            this.ConfigSyncDir.Location = new System.Drawing.Point(93, 62);
            this.ConfigSyncDir.Name = "ConfigSyncDir";
            this.ConfigSyncDir.Size = new System.Drawing.Size(221, 20);
            this.ConfigSyncDir.TabIndex = 0;
            // 
            // ConfigTestLink
            // 
            this.ConfigTestLink.AutoSize = true;
            this.ConfigTestLink.BackColor = System.Drawing.Color.Transparent;
            this.ConfigTestLink.Location = new System.Drawing.Point(355, 38);
            this.ConfigTestLink.Name = "ConfigTestLink";
            this.ConfigTestLink.Size = new System.Drawing.Size(29, 12);
            this.ConfigTestLink.TabIndex = 2;
            this.ConfigTestLink.TabStop = true;
            this.ConfigTestLink.Text = "测试";
            this.ConfigTestLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ConfigTestLink_LinkClicked);
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
            this.ConfigDirDEL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ConfigDirDEL_LinkClicked);
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
            this.ConfigDirADD.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ConfigDirADD_LinkClicked);
            // 
            // S1
            // 
            this.S1.BackgroundImage = global::ModSync.Properties.Resources.L1;
            this.S1.Controls.Add(this.GithubInfo);
            this.S1.Controls.Add(this.LAB);
            this.S1.Controls.Add(this.LogPanel);
            this.S1.Controls.Add(this.downloadinfoprog);
            this.S1.Controls.Add(this.loglist);
            this.S1.Controls.Add(this.downloadinfo);
            this.S1.Controls.Add(this.label1);
            this.S1.Controls.Add(this.syncbutton);
            this.S1.Controls.Add(this.ConfigSelect);
            this.S1.Location = new System.Drawing.Point(0, 28);
            this.S1.Name = "S1";
            this.S1.Size = new System.Drawing.Size(400, 250);
            this.S1.TabIndex = 6;
            this.S1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.S1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // LAB
            // 
            this.LAB.AutoSize = true;
            this.LAB.Location = new System.Drawing.Point(12, 222);
            this.LAB.Name = "LAB";
            this.LAB.Size = new System.Drawing.Size(0, 12);
            this.LAB.TabIndex = 0;
            // 
            // LogPanel
            // 
            this.LogPanel.AutoScroll = true;
            this.LogPanel.BackColor = System.Drawing.Color.Transparent;
            this.LogPanel.Location = new System.Drawing.Point(12, 39);
            this.LogPanel.Name = "LogPanel";
            this.LogPanel.Size = new System.Drawing.Size(374, 142);
            this.LogPanel.TabIndex = 6;
            this.LogPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.LogPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // downloadinfoprog
            // 
            this.downloadinfoprog.Location = new System.Drawing.Point(28, 199);
            this.downloadinfoprog.Name = "downloadinfoprog";
            this.downloadinfoprog.Size = new System.Drawing.Size(358, 12);
            this.downloadinfoprog.TabIndex = 5;
            // 
            // loglist
            // 
            this.loglist.FormattingEnabled = true;
            this.loglist.ItemHeight = 12;
            this.loglist.Location = new System.Drawing.Point(272, 39);
            this.loglist.Name = "loglist";
            this.loglist.Size = new System.Drawing.Size(114, 136);
            this.loglist.TabIndex = 3;
            // 
            // downloadinfo
            // 
            this.downloadinfo.AutoSize = true;
            this.downloadinfo.BackColor = System.Drawing.Color.Transparent;
            this.downloadinfo.ForeColor = System.Drawing.SystemColors.Control;
            this.downloadinfo.Location = new System.Drawing.Point(10, 184);
            this.downloadinfo.Name = "downloadinfo";
            this.downloadinfo.Size = new System.Drawing.Size(29, 12);
            this.downloadinfo.TabIndex = 0;
            this.downloadinfo.Text = "空闲";
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
            this.syncbutton.Click += new System.EventHandler(this.syncbutton_Click);
            // 
            // ConfigSelect
            // 
            this.ConfigSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ConfigSelect.FormattingEnabled = true;
            this.ConfigSelect.Location = new System.Drawing.Point(45, 13);
            this.ConfigSelect.Name = "ConfigSelect";
            this.ConfigSelect.Size = new System.Drawing.Size(341, 20);
            this.ConfigSelect.TabIndex = 1;
            // 
            // GithubInfo
            // 
            this.GithubInfo.AutoSize = true;
            this.GithubInfo.BackColor = System.Drawing.Color.Transparent;
            this.GithubInfo.Location = new System.Drawing.Point(1, 236);
            this.GithubInfo.Name = "GithubInfo";
            this.GithubInfo.Size = new System.Drawing.Size(41, 12);
            this.GithubInfo.TabIndex = 7;
            this.GithubInfo.TabStop = true;
            this.GithubInfo.Text = "Github";
            this.GithubInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GithubInfo_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 278);
            this.Controls.Add(this.S2);
            this.Controls.Add(this.S1);
            this.Controls.Add(this.Headpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Mod同步器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.Headpanel.ResumeLayout(false);
            this.Headpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.S2.ResumeLayout(false);
            this.S2.PerformLayout();
            this.ConfigWhiteFileEnable.ResumeLayout(false);
            this.ConfigWhiteFileEnable.PerformLayout();
            this.S1.ResumeLayout(false);
            this.S1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ConfigSelect;
        private System.Windows.Forms.LinkLabel ConfigCloneConfig;
        private System.Windows.Forms.ListBox loglist;
        private System.Windows.Forms.Button syncbutton;
        private System.Windows.Forms.Panel Headpanel;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel S1;
        private System.Windows.Forms.Panel S2;
        private System.Windows.Forms.TextBox ConfigServerURL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ConfigSyncDir;
        private System.Windows.Forms.LinkLabel ConfigDirDEL;
        private System.Windows.Forms.LinkLabel ConfigDirADD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ConfigWhiteFlie;
        private System.Windows.Forms.LinkLabel ConfigDelWhiteFile;
        private System.Windows.Forms.LinkLabel ConfigAddWhiteFile;
        private System.Windows.Forms.LinkLabel ConfigTestLink;
        private System.Windows.Forms.Button ConfigSaveConfig;
        private System.Windows.Forms.ComboBox ConfigListSelect;
        private System.Windows.Forms.LinkLabel ConfigDelConfig;
        private System.Windows.Forms.ProgressBar downloadinfoprog;
        private System.Windows.Forms.Label downloadinfo;
        private System.Windows.Forms.Panel ConfigWhiteFileEnable;
        private System.Windows.Forms.CheckBox ConfigWhiteFileCheck;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ConfigFileType;
        private System.Windows.Forms.LinkLabel ConfigCreateInfo;
        private System.Windows.Forms.Label ConfigName;
        private System.Windows.Forms.Panel LogPanel;
        private System.Windows.Forms.Label LAB;
        private System.Windows.Forms.LinkLabel GithubInfo;
    }
}

