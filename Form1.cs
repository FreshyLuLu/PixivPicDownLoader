using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
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
            status.Text = "正在下载图片";
            download(Link, Path);
            status.Text = "璐璐干完活又去摸鱼了";
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
            //循环中需要用到的变量
            string link;
            string pathadd;
            string referer;
            foreach (string l in Links)
            {
                try
                {
                    link = "https" + l;
                    pathadd = l.Replace("://i.pximg.net/img-original/img/", "").Replace('/', '.').Trim();
                    //设置referer
                    referer = l.Remove(0, 52);
                    referer = referer.Remove(referer.IndexOf("_"));
                    myWebClient.Headers.Add("Referer", "https://www.pixiv.net/member_illust.php?mode=medium&illust_id="+referer);
                    Path = Path + "/" + pathadd;
                    //开始下载
                    myWebClient.DownloadFile(link.Trim(), Path);
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
            }
        }
    }
}
