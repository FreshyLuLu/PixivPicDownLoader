using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApp1
{
    public partial class PixivPicDLer : Form
    {
        public PixivPicDLer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //获取下载链接和下载路径并传参
            String Link = Downloadlink.Text;
            String Path = Pathbox.Text;
            if (Link.Equals("") || Path.Equals(""))
            {
                MessageBox.Show("输入值无效");
                return;
            }
            status.Text = "璐璐正在一边摸鱼一边下载图片";
            pictureBox1.Image = Allresource._2;
            download(Link, Path);
            status.Text = "璐璐正在吃瓜等待命令";
            pictureBox1.Image = Allresource._3;
        }

        private void Pathchooser_Click(object sender, EventArgs e)
        {
            //路径选择器
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowDialog();
            Pathbox.Text = "" + folderDlg.SelectedPath;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Downloadlink_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Path_TextChanged(object sender, EventArgs e)
        {
            //储存新路径的位置
            String newpath = this.Pathbox.Text;

            Properties.Settings.Default.path = newpath;
            Properties.Settings.Default.Save();
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        public void download(String Link, String Path)
        {
            string[] Links = Link.Split(new String[] { "https" }, StringSplitOptions.RemoveEmptyEntries);
            //用于存放Path
            string pathbottle = Path;
            //总任务数量
            int total = Links.Length;
            DTotal.Text = total.ToString();
            //失败和成功的任务数量
            int falsein = 0;
            int truein = 0;
            //创建WebClient并开始下载
            WebClient myWebClient = new WebClient();
            myWebClient.Proxy = null;
            ServicePointManager.DefaultConnectionLimit = 500;
            //循环中需要用到的变量
            string link="";
            string pathadd;
            string referer;
            progressBar1.Value = 0;
            foreach (string l in Links)
            {
                Application.DoEvents();
                try
                {
                        link = "https" + l;
                        link = link.Trim();
                        pathadd = l.Replace("://i.pximg.net/img-original/img/", "").Replace('/', '.').Trim();
                        //设置referer
                        referer = l.Remove(0, 52);
                        referer = referer.Remove(referer.IndexOf("_"));
                        myWebClient.Headers.Add("Referer", "https://www.pixiv.net/member_illust.php?mode=medium&illust_id=" + referer);
                        Path = Path + "/" + pathadd;
                       //开始下载
                       myWebClient.DownloadFile(link, Path);
                       Application.DoEvents();
                }
                catch
                 {
                    falsein = falsein + 1;
                    Dfalse.Text = falsein.ToString();
                    //数据还原
                    Path = pathbottle;
                    myWebClient.Headers.Clear();
                    continue;
                }
                Path = pathbottle;
                myWebClient.Headers.Clear();
                truein = truein + 1;
                DTrue.Text = truein.ToString();
                this.progressBar1.Value = this.progressBar1.Value + (1/total) * 100;
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Pathbox.Text = Properties.Settings.Default.path;
            pictureBox1.Image = Allresource.fadai;




        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
             
        }
    }
}
