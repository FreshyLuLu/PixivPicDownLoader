namespace WindowsFormsApp1
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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(846, 201);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "开始下载";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Downloadlink
            // 
            this.Downloadlink.Location = new System.Drawing.Point(161, 13);
            this.Downloadlink.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Downloadlink.MaxLength = 327672;
            this.Downloadlink.Multiline = true;
            this.Downloadlink.Name = "Downloadlink";
            this.Downloadlink.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Downloadlink.Size = new System.Drawing.Size(637, 94);
            this.Downloadlink.TabIndex = 1;
            this.Downloadlink.TextChanged += new System.EventHandler(this.Downloadlink_TextChanged);
            // 
            // Pathchooser
            // 
            this.Pathchooser.Location = new System.Drawing.Point(806, 115);
            this.Pathchooser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Pathchooser.Name = "Pathchooser";
            this.Pathchooser.Size = new System.Drawing.Size(91, 25);
            this.Pathchooser.TabIndex = 2;
            this.Pathchooser.Text = "选择路径";
            this.Pathchooser.UseVisualStyleBackColor = true;
            this.Pathchooser.Click += new System.EventHandler(this.Pathchooser_Click);
            // 
            // Pathbox
            // 
            this.Pathbox.Location = new System.Drawing.Point(161, 115);
            this.Pathbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Pathbox.Name = "Pathbox";
            this.Pathbox.ReadOnly = true;
            this.Pathbox.Size = new System.Drawing.Size(637, 25);
            this.Pathbox.TabIndex = 3;
            this.Pathbox.Text = "F:\\\\Temp";
            this.Pathbox.TextChanged += new System.EventHandler(this.Path_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(19, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "抓取到的链接：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(51, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "下载路径：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 173);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "当前状态：";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(158, 173);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(104, 17);
            this.status.TabIndex = 7;
            this.status.Text = "璐璐正在发呆";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "总任务数：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "成功：";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "失败：";
            // 
            // Dfalse
            // 
            this.Dfalse.AutoSize = true;
            this.Dfalse.Location = new System.Drawing.Point(158, 264);
            this.Dfalse.Name = "Dfalse";
            this.Dfalse.Size = new System.Drawing.Size(17, 17);
            this.Dfalse.TabIndex = 11;
            this.Dfalse.Text = "0";
            // 
            // DTrue
            // 
            this.DTrue.AutoSize = true;
            this.DTrue.Location = new System.Drawing.Point(158, 237);
            this.DTrue.Name = "DTrue";
            this.DTrue.Size = new System.Drawing.Size(17, 17);
            this.DTrue.TabIndex = 12;
            this.DTrue.Text = "0";
            // 
            // DTotal
            // 
            this.DTotal.AutoSize = true;
            this.DTotal.Location = new System.Drawing.Point(158, 209);
            this.DTotal.Name = "DTotal";
            this.DTotal.Size = new System.Drawing.Size(17, 17);
            this.DTotal.TabIndex = 13;
            this.DTotal.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 290);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

