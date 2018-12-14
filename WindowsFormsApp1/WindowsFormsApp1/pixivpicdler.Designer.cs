namespace WindowsFormsApp1
{
    partial class PixivPicDLer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PixivPicDLer));
            this.button1 = new System.Windows.Forms.Button();
            this.Downloadlink = new System.Windows.Forms.TextBox();
            this.Pathchooser = new System.Windows.Forms.Button();
            this.Pathbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Dfalse = new System.Windows.Forms.Label();
            this.DTrue = new System.Windows.Forms.Label();
            this.DTotal = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(708, 224);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 89);
            this.button1.TabIndex = 0;
            this.button1.Text = "开始下载";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Downloadlink
            // 
            this.Downloadlink.Location = new System.Drawing.Point(141, 2);
            this.Downloadlink.Margin = new System.Windows.Forms.Padding(4);
            this.Downloadlink.MaximumSize = new System.Drawing.Size(637, 94);
            this.Downloadlink.MaxLength = 327672;
            this.Downloadlink.MinimumSize = new System.Drawing.Size(637, 94);
            this.Downloadlink.Multiline = true;
            this.Downloadlink.Name = "Downloadlink";
            this.Downloadlink.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Downloadlink.Size = new System.Drawing.Size(637, 94);
            this.Downloadlink.TabIndex = 1;
            this.Downloadlink.TextChanged += new System.EventHandler(this.Downloadlink_TextChanged);
            // 
            // Pathchooser
            // 
            this.Pathchooser.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Pathchooser.Location = new System.Drawing.Point(786, 97);
            this.Pathchooser.Margin = new System.Windows.Forms.Padding(4);
            this.Pathchooser.Name = "Pathchooser";
            this.Pathchooser.Size = new System.Drawing.Size(100, 35);
            this.Pathchooser.TabIndex = 2;
            this.Pathchooser.Text = "选择路径";
            this.Pathchooser.UseVisualStyleBackColor = true;
            this.Pathchooser.Click += new System.EventHandler(this.Pathchooser_Click);
            // 
            // Pathbox
            // 
            this.Pathbox.Location = new System.Drawing.Point(141, 104);
            this.Pathbox.Margin = new System.Windows.Forms.Padding(4);
            this.Pathbox.Name = "Pathbox";
            this.Pathbox.ReadOnly = true;
            this.Pathbox.Size = new System.Drawing.Size(637, 25);
            this.Pathbox.TabIndex = 3;
            this.Pathbox.TextChanged += new System.EventHandler(this.Path_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "抓取到的链接：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label2.Location = new System.Drawing.Point(43, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "下载路径：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(64, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "当前状态：";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("宋体", 9F);
            this.status.Location = new System.Drawing.Point(139, 161);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(77, 12);
            this.status.TabIndex = 7;
            this.status.Text = "璐璐正在发呆";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(64, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "总任务数：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(64, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "成功：";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(64, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "失败：";
            // 
            // Dfalse
            // 
            this.Dfalse.AutoSize = true;
            this.Dfalse.Font = new System.Drawing.Font("宋体", 9F);
            this.Dfalse.Location = new System.Drawing.Point(143, 252);
            this.Dfalse.Name = "Dfalse";
            this.Dfalse.Size = new System.Drawing.Size(11, 12);
            this.Dfalse.TabIndex = 11;
            this.Dfalse.Text = "0";
            // 
            // DTrue
            // 
            this.DTrue.AutoSize = true;
            this.DTrue.Font = new System.Drawing.Font("宋体", 9F);
            this.DTrue.Location = new System.Drawing.Point(143, 225);
            this.DTrue.Name = "DTrue";
            this.DTrue.Size = new System.Drawing.Size(11, 12);
            this.DTrue.TabIndex = 12;
            this.DTrue.Text = "0";
            // 
            // DTotal
            // 
            this.DTotal.AutoSize = true;
            this.DTotal.Font = new System.Drawing.Font("宋体", 9F);
            this.DTotal.Location = new System.Drawing.Point(143, 197);
            this.DTotal.Name = "DTotal";
            this.DTotal.Size = new System.Drawing.Size(11, 12);
            this.DTotal.TabIndex = 13;
            this.DTotal.Text = "0";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(-7, 321);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(963, 14);
            this.progressBar1.TabIndex = 14;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(387, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PixivPicDLer
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(214)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(932, 332);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.DTotal);
            this.Controls.Add(this.DTrue);
            this.Controls.Add(this.Dfalse);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pathbox);
            this.Controls.Add(this.Pathchooser);
            this.Controls.Add(this.Downloadlink);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(948, 371);
            this.MinimumSize = new System.Drawing.Size(948, 371);
            this.Name = "PixivPicDLer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pixiv图片下载器";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Downloadlink;
        private System.Windows.Forms.Button Pathchooser;
        private System.Windows.Forms.TextBox Pathbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label Dfalse;
        public System.Windows.Forms.Label DTrue;
        public System.Windows.Forms.Label DTotal;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

