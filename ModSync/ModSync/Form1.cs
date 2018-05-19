using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace ModSync
{
    public partial class Form1 : Form
    {

        Point downPoint;

        public bool isbusy { get; private set; }

        private const int CS_DropSHADOW = 0x20000;
        private const int GCL_STYLE = (-26);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SetClassLong(IntPtr hwnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetClassLong(IntPtr hwnd, int nIndex);

        System.Xml.XmlDocument xmlconfig;

        string configPath = Directory.GetCurrentDirectory() + "\\config.xml";

        List<ConfigInfo> ConfigList = new List<ConfigInfo>();

        Thread updateThread;
        //System.Runtime.Serialization.Json.DataContractJsonSerializer json = new System.Runtime.Serialization.Json.DataContractJsonSerializer(ConfigInfo);

        private static string GetMD5HashFromFile(string fileName)
        {
            try
            {
                FileStream file = new FileStream(fileName, FileMode.Open);
                System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
                byte[] retVal = md5.ComputeHash(file);
                file.Close();

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < retVal.Length; i++)
                {
                    sb.Append(retVal[i].ToString("x2"));
                }
                return sb.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("GetMD5HashFromFile() fail,error:" + ex.Message);
            }
        }

        [Serializable]
        public class ConfigInfo
        {
            public List<string> path;
            public List<string> whitefile;
            public List<string> filetype;
            public string name;
            public string fileurl;

            public ConfigInfo()
            {
                path = new List<string>();
                whitefile = new List<string>();
                filetype = new List<string>();
                name = "";
                fileurl = "";
            }

        }

        void loadconfig()
        {
            if (File.Exists(configPath))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<ConfigInfo>));
                ConfigList=(List<ConfigInfo>)ser.Deserialize(new FileStream(configPath, FileMode.Open));
                string curr = Directory.GetCurrentDirectory();
                foreach (var info in ConfigList)
                {
                    for (int i = 0; i < info.path.Count; i++)
                        if (info.path[i][0] == '~')
                            info.path[i] = curr + info.path[i].Substring(1);
                }
            }
        }

        void saveconfig()
        {
            XmlSerializer ser = new XmlSerializer(typeof(List<ConfigInfo>));
            string curr = Directory.GetCurrentDirectory();
            foreach(var info in ConfigList)
            {
                for (int i = 0; i < info.path.Count; i++)
                    info.path[i] = info.path[i].Replace(curr, "~");
            }
            File.Delete(configPath);
            ser.Serialize(new FileStream(configPath,FileMode.OpenOrCreate), ConfigList);
        }


        void AddLog(string str)
        {
            Label l = new Label();
            l.Location = new Point(6, 4+12*LogPanel.Controls.Count);
            l.AutoSize = true;
            l.Name = "L"+ LogPanel.Controls.Count;
            l.Size = new System.Drawing.Size(0, 12);
            l.TabIndex = 0;
            l.Text = str;
            LogPanel.Controls.Add(l);
            LogPanel.ScrollControlIntoView(l);
        }

        void SetLog(string str,int line)
        {
            LogPanel.Controls[line].Text = str;
        }

        void ClearLog()
        {
            LogPanel.Controls.Clear();
        }

        class MoveEffect
        {
            System.Windows.Forms.Timer time;
            List<Control> ControlList;
            List<Point> StartPoint;
            List<PointF> MovePoint;
            double XInc, YInc;
            int Count;
            public int MoveCount { get; set; }
            Point EndPoint;
            public MoveEffect()
            {

                ControlList = new List<Control>();
                StartPoint = new List<Point>();
                MovePoint = new List<PointF>();
                time = new System.Windows.Forms.Timer();
                time.Interval = 20;
                time.Tick += (object s, EventArgs e) => {
                    if (Count == 0)
                    {
                        time.Stop();
                        //for (int i = 0; i < ControlList.Count; i++)
                        //{
                        //    PointF p = MovePoint[i];
                        //    p.X = EndPoint.X;
                        //    p.Y = EndPoint.Y;
                        //    MovePoint[i] = p;
                        //    ControlList[i].Location = new Point((int)p.X + StartPoint[i].X, (int)p.Y + StartPoint[i].Y);
                        //}
                        return;
                    }

                    for (int i = 0; i < ControlList.Count; i++)
                    {
                        PointF p = MovePoint[i];
                        p.X += (float)(XInc * Count);
                        p.Y += (float)(YInc * Count);
                        MovePoint[i] = p;
                        ControlList[i].Location = new Point((int)(p.X + StartPoint[i].X + 0.5), (int)(p.Y + StartPoint[i].Y + 0.5));
                    }
                    Count--;

                };
                MoveCount = 12;
            }

            public void AddControl(Control c)
            {
                ControlList.Add(c);
                StartPoint.Add(new Point(c.Location.X, c.Location.Y));
                MovePoint.Add(new PointF(0, 0));
            }

            public void RemoveControl(Control c)
            {
                int index = ControlList.IndexOf(c);
                StartPoint.RemoveAt(index);
                MovePoint.RemoveAt(index);
                ControlList.RemoveAt(index);
            }

            public void Move(int x, int y)
            {
                int count = (MoveCount * (MoveCount + 1)) / 2;
                XInc = x;
                YInc = y;
                XInc /= count;
                YInc /= count;
                Count = MoveCount;
                time.Start();
                EndPoint = new Point(x, y);
                //for (int i = 0; i < ControlList.Count; i++)
                //{
                //    Point p = StartPoint[i];
                //    p.X = ControlList[i].Location.X;
                //    p.Y = ControlList[i].Location.Y;
                //    StartPoint[i] = p;
                //}
            }

            public bool isIdle()
            {
                return !time.Enabled;
            }
        }

        WebClient wc = new WebClient();
        volatile bool downloaddone = false;
        public Form1()
        {
            InitializeComponent();
            SetClassLong(this.Handle, GCL_STYLE, GetClassLong(this.Handle, GCL_STYLE) | CS_DropSHADOW);
            ConfigServerURL.Tag = false;
            wc.DownloadProgressChanged += Wc_DownloadProgressChanged;
            wc.DownloadFileCompleted += Wc_DownloadFileCompleted;
            loadconfig();
            this.FormClosing += Form1_FormClosing;
        }

        

        private void Wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            downloaddone = true;
            Invoke(new MethodInvoker(() => {
                downloadinfoprog.Value = 100;
                downloadinfo.Text = "下载完成!";
            }));
        }

        private void Wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            Invoke(new MethodInvoker(() => {
                downloadinfoprog.Value = e.ProgressPercentage;
                downloadinfo.Text = "下载中... " + e.ProgressPercentage + "%";
            }));
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            downPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - downPoint.X, this.Location.Y + e.Y - downPoint.Y);
            }
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveconfig();
            if (updateThread != null)
            {
                if (MessageBox.Show("正在进行同步!\r\n确定退出?", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    System.Environment.Exit(0);
                }
                else
                    e.Cancel = true;                    
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            saveconfig();
            if (updateThread!=null)
            {
                if (MessageBox.Show("正在进行同步!\r\n确定退出?", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    System.Environment.Exit(0);
                }
            }
            else {
                System.Environment.Exit(0);
            }
        }

        MoveEffect eff;
        int lastselectid = 0;
        private void SelectSwitch(object sender, EventArgs e)
        {
            if (eff == null)
            {
                eff = new MoveEffect();
                eff.AddControl(S1);
                eff.AddControl(S2);
            }
            if (!eff.isIdle()) return;
            int id = int.Parse((string)(((Control)sender).Tag));
            if (id != lastselectid)
            {
                lastselectid = id;
                if (id == 1)
                {
                    eff.Move(-400, 0);
                    if (ConfigListSelect.Items.Count == 0)
                    {
                        ConfigListSelect.Text = "新配置1";
                    }
                    else
                    {
                        if (ConfigSelect.SelectedIndex != -1)
                            ConfigListSelect.SelectedIndex = ConfigSelect.SelectedIndex;
                    }

                }
                else
                {
                    eff.Move(400, 0);
                }
                Color c = bt1.BackColor;
                bt1.BackColor = bt0.BackColor;
                bt0.BackColor = c;
            }
        }

        private void ConfigServerURL_Enter(object sender, EventArgs e)
        {
            if ((bool)ConfigServerURL.Tag == false)
                ConfigServerURL.Text = "";
            ConfigServerURL.ForeColor = Color.Black;
        }

        private void ConfigServerURL_Leave(object sender, EventArgs e)
        {
            if (ConfigServerURL.Text == "")
            {
                ConfigServerURL.Tag = false;
                ConfigServerURL.Text = "支持github、ftp服务器";
                ConfigServerURL.ForeColor = Color.LightGray;
            }
            else
                ConfigServerURL.Tag = true;
        }

        FolderBrowserDialog fbd = new FolderBrowserDialog();
        private void ConfigDirADD_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ConfigSyncDir.Items.Count != 0)
            {
                MessageBox.Show("当前版本只支持一个文件夹");
                return;
            }
            if (fbd.SelectedPath == "")
                fbd.SelectedPath = Directory.GetCurrentDirectory();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string path = fbd.SelectedPath;
                //if (path.Contains(Directory.GetCurrentDirectory()))
                //    path = path.Substring(Directory.GetCurrentDirectory().Length+1);
                ConfigSyncDir.Items.Add(path);
                if (ConfigSyncDir.SelectedIndex == -1)
                    ConfigSyncDir.SelectedIndex = 0;
            }
        }

        private void ConfigDirDEL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ConfigSyncDir.SelectedIndex == -1) return;
            ConfigSyncDir.Items.RemoveAt(ConfigSyncDir.SelectedIndex);
            if (ConfigSyncDir.Items.Count != 0)
                ConfigSyncDir.SelectedIndex = 0;
        }

        private void ConfigWhiteFileCheck_CheckedChanged(object sender, EventArgs e)
        {
            ConfigWhiteFileEnable.Visible = ConfigWhiteFileCheck.Checked;
        }

        //获取网页数据
        public static string HttpGetPage(string url, bool gzip = false)
        {
            try
            {
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                request.Timeout = 10000;

                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                Stream stream = response.GetResponseStream();
                string v = null;
                stream.ReadTimeout = 10000;
                if (response.ContentEncoding.Contains("gzip") || gzip)
                {
                    StreamReader reader = new StreamReader(new GZipStream(stream, CompressionMode.Decompress));
                    v = reader.ReadToEnd();
                    reader.Close();
                }
                else if (response.ContentEncoding.Contains("deflate"))
                {
                    StreamReader reader = new StreamReader(new DeflateStream(stream, CompressionMode.Decompress));
                    v = reader.ReadToEnd();
                    if (v == string.Empty || v == null)
                        v = reader.ReadToEnd();
                    reader.Close();

                }
                else
                {
                    StreamReader reader = new StreamReader(stream);
                    v = reader.ReadToEnd();
                    reader.Close();
                }
                stream.Close();
                return v;
            }
            catch
            {
                return null;
            }
        }

        Dictionary<string, string> getModList(string mod)
        {
            if (mod == "") return null;
            var fs = new string[] { mod };
            if (mod.Contains('\n'))
                fs = mod.Replace("\r\n", "\n").Split('\n');
            Dictionary<string, string> fileinfo = new Dictionary<string, string>();
            foreach (string s in fs)
            {
                var info = s.Split('=');
                if (info.Length == 2)
                    fileinfo.Add(info[0], info[1]);
            }
            return fileinfo;
        }

        private void ConfigTestLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //https://raw.githubusercontent.com/KeyMove/ModSync/master/ModSync/ModSync/Mods/modlist.txt
            //string s = Uri.EscapeUriString("【本地美化】JEI物品查询 4.9.1.168.jar ");
            string url = ConfigServerURL.Text;
            if (url.LastIndexOf("modlist.txt") != -1)
            {
                url = url.Substring(0, url.LastIndexOf("modlist.txt"));
            }
            string data = HttpGetPage(url + "modlist.txt");
            if (data == null) MessageBox.Show("获取失败");
            var modlist = getModList(data);
            MessageBox.Show("成功\r\n获取到" + modlist.Keys.Count + "个mod!");
        }

        private void ConfigSaveConfig_Click(object sender, EventArgs e)
        {

            ConfigInfo info;
            int index = ConfigListSelect.SelectedIndex;
            if (ConfigSyncDir.Items.Count == 0) return;
            string type = ConfigFileType.Text;
            if (type == "") return;
            if (ConfigListSelect.Text == "") return;
            if (ConfigServerURL.Text == "") return;
            if (ConfigListSelect.Items.Count == 0)
                info = new ConfigInfo();
            else
            {
                if (index == -1)
                    index = (int)ConfigName.Tag;
                info = ConfigList[index];
            }
            List<string> types;
            StringBuilder sb = new StringBuilder();
            if (type.IndexOf(';') != -1)
            {
                types = type.Split(';').ToList();
                if (types[types.Count - 1] == "")
                    types.RemoveAt(types.Count - 1);
            }
            else
            {
                types = new List<string>();
                types.Add(type);
            }
            info.filetype.Clear();
            info.filetype.AddRange(types);
            info.path.Clear();
            foreach (string v in ConfigSyncDir.Items)
                if (!info.path.Contains(v)) info.path.Add(v);
            if (ConfigWhiteFileCheck.Checked)
            {
                if (ConfigWhiteFlie.Items.Count > 0)
                {
                    info.whitefile.Clear();
                    foreach (string v in ConfigWhiteFlie.Items)
                        info.whitefile.Add(v);
                }
            }
            info.name = ConfigListSelect.Text;
            string url = ConfigServerURL.Text;
            if (url.LastIndexOf("modlist.txt") != -1)
            {
                url = url.Substring(0, url.LastIndexOf("modlist.txt"));
            }
            info.fileurl = url;
            if (ConfigListSelect.Items.Count == 0)
            {
                ConfigList.Add(info);
                ConfigListSelect.Items.Add(info.name);
                ConfigSelect.Items.Add(info.name);
                ConfigListSelect.SelectedIndex = ConfigSelect.SelectedIndex = 0;
            }
            else
            {
                ConfigListSelect.Items[index] = info.name;
                ConfigSelect.Items[index] = info.name;
            }

        }

        private void ConfigCreateInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ConfigSyncDir.Items.Count == 0) return;
            string type = ConfigFileType.Text;
            if (type == "") return;
            List<string> types;
            StringBuilder sb = new StringBuilder();
            if (type.IndexOf(';') != -1)
                types = type.Split(';').ToList();
            else
            {
                types = new List<string>();
                types.Add(type);
            }
            S2.Enabled = false;
            try {
                foreach (string path in ConfigSyncDir.Items)
                {
                    FileInfo[] files = new DirectoryInfo(path).GetFiles();
                    foreach (var f in files)
                    {
                        if (types.Contains(f.Extension.Substring(1)))
                        {
                            sb.Append(GetMD5HashFromFile(f.FullName));
                            sb.Append('=');
                            sb.AppendLine(f.Name);
                        }
                    }
                }
                StreamWriter sw = new StreamWriter(new FileStream(Directory.GetCurrentDirectory() + "\\modlist.txt", FileMode.OpenOrCreate));
                sw.Write(sb.ToString());
                sw.Flush();
                sw.Close();
            }
            catch (Exception err) { MessageBox.Show(err.ToString()); }
            S2.Enabled = true;
        }

        private void ConfigList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigName.Text = (string)ConfigListSelect.SelectedItem;
            ConfigName.Tag = ConfigListSelect.SelectedIndex;

            ConfigInfo info = ConfigList[ConfigListSelect.SelectedIndex];
            ConfigServerURL.Text = info.fileurl;
            ConfigSyncDir.Items.Clear();
            foreach (string s in info.path)
                ConfigSyncDir.Items.Add(s);
            ConfigSyncDir.SelectedIndex = 0;

            string types = "";
            foreach (var s in info.filetype)
            {
                types += s + ";";
            }
            ConfigFileType.Text = types;
            if (info.whitefile.Count != 0)
            {
                ConfigWhiteFileCheck.Checked = true;
                ConfigWhiteFlie.Items.Clear();
                foreach (string s in info.whitefile)
                    ConfigWhiteFlie.Items.Add(s);
                ConfigWhiteFlie.SelectedIndex = 0;
            }
        }

        private void ConfigCloneConfig_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ConfigListSelect.SelectedIndex == -1) return;
            ConfigInfo old = ConfigList[ConfigListSelect.SelectedIndex];
            ConfigInfo info = new ConfigInfo();

            info.filetype.AddRange(old.filetype);
            info.path.AddRange(old.path);
            info.whitefile.AddRange(old.whitefile);
            info.fileurl = old.fileurl;
            info.name = old.name + " 克隆";
            ConfigList.Add(info);
            ConfigListSelect.Items.Add(info.name);
            ConfigSelect.Items.Add(info.name);
            ConfigListSelect.SelectedIndex = ConfigListSelect.Items.Count - 1;
        }

        private void ConfigDelConfig_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ConfigListSelect.SelectedIndex == -1) return;
            if (MessageBox.Show("确定要删除配置 [" + ConfigListSelect.SelectedItem + "] 吗?", "提示", MessageBoxButtons.OKCancel) != DialogResult.OK) return;
            ConfigList.RemoveAt(ConfigListSelect.SelectedIndex);
            ConfigSelect.Items.RemoveAt(ConfigListSelect.SelectedIndex);
            ConfigListSelect.Items.RemoveAt(ConfigListSelect.SelectedIndex);
            ConfigListSelect.SelectedIndex = ConfigListSelect.Items.Count - 1;
            ConfigName.Text = "";
        }

        private void syncbutton_Click(object sender, EventArgs e)
        {
            if (updateThread != null)
            {
                if (MessageBox.Show("真的要停止更新吗？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    wc.CancelAsync();
                    try { updateThread.Abort(); } catch { };
                    downloadinfo.Text = "空闲";
                    downloadinfoprog.Value = 0;
                    AddLog("更新中断");
                    syncbutton.Text = "同步";
                    return;
                }
            }
            if (ConfigSelect.SelectedIndex == -1) return;
            ConfigInfo info = ConfigList[ConfigSelect.SelectedIndex];
            ClearLog();
            AddLog("获取mod信息");
            string data = HttpGetPage(info.fileurl + "modlist.txt");
            if (data == null)
            {
                SetLog("获取mod信息...失败",0);
                syncbutton.Text = "同步";
                return;
            }
            SetLog("获取mod信息...成功", 0);
            syncbutton.Text = "取消同步";
            var modlist = getModList(data);
            List<FileInfo> delfile = new List<FileInfo>();
            List<string> downloadfile = new List<string>();
            downloadfile.AddRange(modlist.Keys);
            
            updateThread = new Thread(() => {
                try
                {
                    foreach (string path in info.path)
                    {
                        FileInfo[] files = new DirectoryInfo(path).GetFiles();
                        Invoke(new MethodInvoker(() => {
                            AddLog("检查文件:0/" + files.Length);
                        }));
                        int fileindex = 0;
                        foreach (var f in files)
                        {
                            fileindex++;
                            Invoke(new MethodInvoker(() => {
                            SetLog("检查文件:" +fileindex+"/" + files.Length,1);
                            }));
                            if (info.filetype.Contains(f.Extension.Substring(1)))
                            {
                                string md5 = GetMD5HashFromFile(f.FullName);
                                int index = downloadfile.IndexOf(md5);
                                if (index == -1)
                                {
                                    delfile.Add(f);
                                }
                                else
                                {
                                    downloadfile.RemoveAt(index);
                                }
                            }
                        }
                        foreach(var f in delfile)
                        {
                            Invoke(new MethodInvoker(() => {
                                AddLog( "删除:"+f.Name);
                            }));
                            File.Delete(f.FullName);
                        }
                        foreach(var f in downloadfile)
                        {
                            Invoke(new MethodInvoker(() => {
                                AddLog( "下载:" + modlist[f]);
                            }));
                            downloaddone = false;
                            wc.DownloadFileAsync(new Uri(info.fileurl+ Uri.EscapeUriString(modlist[f])),path+"\\"+modlist[f]);
                            while (!downloaddone) Thread.Sleep(1);
                        }
                    }
                    Invoke(new MethodInvoker(() => {
                        AddLog("更新完成");
                        updateThread = null;
                        syncbutton.Text = "同步";
                    }));
                }
                catch (Exception err){
                    MessageBox.Show("同步失败\r\n"+err.ToString());
                };
            });
            updateThread.Start();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (ConfigList.Count == 0) return;
            foreach (var info in ConfigList)
            {
                ConfigSelect.Items.Add(info.name);
                ConfigListSelect.Items.Add(info.name);
            }
            ConfigSelect.SelectedIndex = ConfigListSelect.SelectedIndex = 0;
            ConfigServerURL.ForeColor = Color.Black;
            ConfigServerURL.Tag = true;
        }
    }
}
