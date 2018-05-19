﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        class ConfigInfo
        {
            List<string> path;
            List<string> whitefile;
            List<string> filetype;
            string name;
            string fileurl;

        }

        class MoveEffect
        {
            Timer time;
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
                time = new Timer();
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
                   
                    for(int i=0;i< ControlList.Count;i++)
                    {
                        PointF p = MovePoint[i];
                        p.X += (float)(XInc * Count);
                        p.Y += (float)(YInc * Count);
                        MovePoint[i] = p;
                        ControlList[i].Location = new Point((int)(p.X+StartPoint[i].X+0.5), (int)(p.Y+StartPoint[i].Y+0.5));
                    }
                    Count--;
                    
                };
                MoveCount = 12;
            }

            public void AddControl(Control c)
            {
                ControlList.Add(c);
                StartPoint.Add(new Point(c.Location.X, c.Location.Y));
                MovePoint.Add(new PointF(0,0));
            }

            public void RemoveControl(Control c)
            {
                int index = ControlList.IndexOf(c);
                StartPoint.RemoveAt(index);
                MovePoint.RemoveAt(index);
                ControlList.RemoveAt(index);
            }

            public void Move(int x,int y)
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

        public Form1()
        {
            InitializeComponent();
            SetClassLong(this.Handle, GCL_STYLE, GetClassLong(this.Handle, GCL_STYLE) | CS_DropSHADOW);
            ConfigServerURL.Tag = false;
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

        private void exit_Click(object sender, EventArgs e)
        {
            if(isbusy)
            {
                if(MessageBox.Show("正在进行同步!\r\n确定退出?", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    System.Environment.Exit(0);
                }
            }
            else{
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
                    if (ConfigList.Items.Count == 0)
                    {
                        ConfigList.Text = "新配置1";
                    }
                    else
                    {
                        if (ConfigSelect.SelectedIndex != -1)
                            ConfigList.SelectedIndex = ConfigSelect.SelectedIndex;
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
            if (fbd.SelectedPath == "")
                fbd.SelectedPath = Directory.GetCurrentDirectory();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string path = fbd.SelectedPath;
                ConfigSyncDir.Items.Add(path);
                if (ConfigSyncDir.SelectedIndex == -1)
                    ConfigSyncDir.SelectedIndex = 0;
            }
        }

        private void ConfigDirDEL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ConfigSyncDir.SelectedIndex == -1) return;
            ConfigSyncDir.Items.RemoveAt(ConfigSyncDir.SelectedIndex);
            if(ConfigSyncDir.Items.Count!=0)
                ConfigSyncDir.SelectedIndex = 0;
        }

        private void ConfigWhiteFileCheck_CheckedChanged(object sender, EventArgs e)
        {
            ConfigWhiteFileEnable.Visible = ConfigWhiteFileCheck.Checked;
        }

        private void ConfigTestLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void ConfigSaveConfig_Click(object sender, EventArgs e)
        {

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
            foreach(string path in ConfigSyncDir.Items)
            {
                FileInfo[] files=new DirectoryInfo(path).GetFiles();
                foreach(var f in files)
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
            catch (Exception err){ MessageBox.Show(err.ToString()); }
            S2.Enabled = true;
        }
    }
}
