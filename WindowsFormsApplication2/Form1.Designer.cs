namespace WindowsFormsApplication2
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.打开文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.另存为ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemun = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemre = new System.Windows.Forms.ToolStripMenuItem();
            this.统计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全部ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文字字母ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数字ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.空格ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.单词ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.其他字符ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.s_target = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button_cx = new System.Windows.Forms.Button();
            this.button_hf = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.A_textBox = new System.Windows.Forms.TextBox();
            this.N_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.S_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.W_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.s_num = new System.Windows.Forms.TextBox();
            this.O_textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.清空ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开文件ToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.toolStripMenuItemun,
            this.toolStripMenuItemre,
            this.统计ToolStripMenuItem,
            this.清空ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(666, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 打开文件ToolStripMenuItem
            // 
            this.打开文件ToolStripMenuItem.Name = "打开文件ToolStripMenuItem";
            this.打开文件ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.打开文件ToolStripMenuItem.Text = "打开文件";
            this.打开文件ToolStripMenuItem.Click += new System.EventHandler(this.打开文件ToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存ToolStripMenuItem1,
            this.另存为ToolStripMenuItem});
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.保存ToolStripMenuItem.Text = "保存文件";
            // 
            // 保存ToolStripMenuItem1
            // 
            this.保存ToolStripMenuItem1.Name = "保存ToolStripMenuItem1";
            this.保存ToolStripMenuItem1.Size = new System.Drawing.Size(110, 22);
            this.保存ToolStripMenuItem1.Text = "保存";
            this.保存ToolStripMenuItem1.Click += new System.EventHandler(this.保存ToolStripMenuItem1_Click);
            // 
            // 另存为ToolStripMenuItem
            // 
            this.另存为ToolStripMenuItem.Name = "另存为ToolStripMenuItem";
            this.另存为ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.另存为ToolStripMenuItem.Text = "另存为";
            this.另存为ToolStripMenuItem.Click += new System.EventHandler(this.另存为ToolStripMenuItem_Click);
            // 
            // toolStripMenuItemun
            // 
            this.toolStripMenuItemun.Name = "toolStripMenuItemun";
            this.toolStripMenuItemun.Size = new System.Drawing.Size(43, 20);
            this.toolStripMenuItemun.Text = "撤销";
            this.toolStripMenuItemun.Click += new System.EventHandler(this.toolStripMenuItemun_Click);
            // 
            // toolStripMenuItemre
            // 
            this.toolStripMenuItemre.Name = "toolStripMenuItemre";
            this.toolStripMenuItemre.Size = new System.Drawing.Size(43, 20);
            this.toolStripMenuItemre.Text = "恢复";
            this.toolStripMenuItemre.Click += new System.EventHandler(this.toolStripMenuItemre_Click);
            // 
            // 统计ToolStripMenuItem
            // 
            this.统计ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.全部ToolStripMenuItem,
            this.文字字母ToolStripMenuItem,
            this.数字ToolStripMenuItem,
            this.空格ToolStripMenuItem,
            this.单词ToolStripMenuItem,
            this.其他字符ToolStripMenuItem});
            this.统计ToolStripMenuItem.Name = "统计ToolStripMenuItem";
            this.统计ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.统计ToolStripMenuItem.Text = "统计";
            // 
            // 全部ToolStripMenuItem
            // 
            this.全部ToolStripMenuItem.Name = "全部ToolStripMenuItem";
            this.全部ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.全部ToolStripMenuItem.Text = "全部";
            this.全部ToolStripMenuItem.Click += new System.EventHandler(this.全部ToolStripMenuItem_Click);
            // 
            // 文字字母ToolStripMenuItem
            // 
            this.文字字母ToolStripMenuItem.Name = "文字字母ToolStripMenuItem";
            this.文字字母ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.文字字母ToolStripMenuItem.Text = "字母";
            this.文字字母ToolStripMenuItem.Click += new System.EventHandler(this.文字字母ToolStripMenuItem_Click);
            // 
            // 数字ToolStripMenuItem
            // 
            this.数字ToolStripMenuItem.Name = "数字ToolStripMenuItem";
            this.数字ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.数字ToolStripMenuItem.Text = "数字";
            this.数字ToolStripMenuItem.Click += new System.EventHandler(this.数字ToolStripMenuItem_Click);
            // 
            // 空格ToolStripMenuItem
            // 
            this.空格ToolStripMenuItem.Name = "空格ToolStripMenuItem";
            this.空格ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.空格ToolStripMenuItem.Text = "空格";
            this.空格ToolStripMenuItem.Click += new System.EventHandler(this.空格ToolStripMenuItem_Click);
            // 
            // 单词ToolStripMenuItem
            // 
            this.单词ToolStripMenuItem.Name = "单词ToolStripMenuItem";
            this.单词ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.单词ToolStripMenuItem.Text = "单词";
            this.单词ToolStripMenuItem.Click += new System.EventHandler(this.单词ToolStripMenuItem_Click);
            // 
            // 其他字符ToolStripMenuItem
            // 
            this.其他字符ToolStripMenuItem.Name = "其他字符ToolStripMenuItem";
            this.其他字符ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.其他字符ToolStripMenuItem.Text = "其他字符";
            this.其他字符ToolStripMenuItem.Click += new System.EventHandler(this.其他字符ToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 156);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(414, 170);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "统计字符串在文中个数";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // s_target
            // 
            this.s_target.Location = new System.Drawing.Point(95, 51);
            this.s_target.Name = "s_target";
            this.s_target.Size = new System.Drawing.Size(100, 21);
            this.s_target.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "请输入字符串";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(225, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "删除该子串";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_cx
            // 
            this.button_cx.Location = new System.Drawing.Point(14, 23);
            this.button_cx.Name = "button_cx";
            this.button_cx.Size = new System.Drawing.Size(75, 23);
            this.button_cx.TabIndex = 7;
            this.button_cx.Text = "撤销修改";
            this.button_cx.UseVisualStyleBackColor = true;
            this.button_cx.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_hf
            // 
            this.button_hf.Location = new System.Drawing.Point(111, 23);
            this.button_hf.Name = "button_hf";
            this.button_hf.Size = new System.Drawing.Size(75, 23);
            this.button_hf.TabIndex = 8;
            this.button_hf.Text = "恢复修改";
            this.button_hf.UseVisualStyleBackColor = true;
            this.button_hf.Click += new System.EventHandler(this.button_hf_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "字母个数";
            // 
            // A_textBox
            // 
            this.A_textBox.BackColor = System.Drawing.Color.White;
            this.A_textBox.Location = new System.Drawing.Point(73, 29);
            this.A_textBox.Name = "A_textBox";
            this.A_textBox.ReadOnly = true;
            this.A_textBox.Size = new System.Drawing.Size(41, 21);
            this.A_textBox.TabIndex = 10;
            // 
            // N_textBox
            // 
            this.N_textBox.BackColor = System.Drawing.Color.White;
            this.N_textBox.Location = new System.Drawing.Point(185, 29);
            this.N_textBox.Name = "N_textBox";
            this.N_textBox.ReadOnly = true;
            this.N_textBox.Size = new System.Drawing.Size(41, 21);
            this.N_textBox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "数字个数";
            // 
            // S_textBox
            // 
            this.S_textBox.BackColor = System.Drawing.Color.White;
            this.S_textBox.Location = new System.Drawing.Point(73, 85);
            this.S_textBox.Name = "S_textBox";
            this.S_textBox.ReadOnly = true;
            this.S_textBox.Size = new System.Drawing.Size(41, 21);
            this.S_textBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "空格个数";
            // 
            // W_textBox
            // 
            this.W_textBox.BackColor = System.Drawing.Color.White;
            this.W_textBox.Location = new System.Drawing.Point(185, 85);
            this.W_textBox.Name = "W_textBox";
            this.W_textBox.ReadOnly = true;
            this.W_textBox.Size = new System.Drawing.Size(39, 21);
            this.W_textBox.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "单词个数";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "字符串个数为";
            // 
            // s_num
            // 
            this.s_num.BackColor = System.Drawing.Color.White;
            this.s_num.Location = new System.Drawing.Point(98, 98);
            this.s_num.Name = "s_num";
            this.s_num.ReadOnly = true;
            this.s_num.Size = new System.Drawing.Size(64, 21);
            this.s_num.TabIndex = 18;
            // 
            // O_textBox
            // 
            this.O_textBox.BackColor = System.Drawing.Color.White;
            this.O_textBox.Location = new System.Drawing.Point(89, 138);
            this.O_textBox.Name = "O_textBox";
            this.O_textBox.ReadOnly = true;
            this.O_textBox.Size = new System.Drawing.Size(41, 21);
            this.O_textBox.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 19;
            this.label8.Text = "其他字符个数";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(121, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 12);
            this.label9.TabIndex = 21;
            this.label9.Text = "（以空格数计算）";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.A_textBox);
            this.groupBox1.Controls.Add(this.O_textBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.N_textBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.S_textBox);
            this.groupBox1.Controls.Add(this.W_textBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(429, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 188);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "统计";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_cx);
            this.groupBox2.Controls.Add(this.button_hf);
            this.groupBox2.Location = new System.Drawing.Point(437, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(195, 66);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "编辑";
            // 
            // 清空ToolStripMenuItem
            // 
            this.清空ToolStripMenuItem.Name = "清空ToolStripMenuItem";
            this.清空ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.清空ToolStripMenuItem.Text = "清空统计";
            this.清空ToolStripMenuItem.Click += new System.EventHandler(this.清空ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 349);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.s_num);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.s_target);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "文本编辑器";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemun;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemre;
        private System.Windows.Forms.ToolStripMenuItem 打开文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 统计ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 文字字母ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数字ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 空格ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 单词ToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox s_target;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_cx;
        private System.Windows.Forms.Button button_hf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox A_textBox;
        private System.Windows.Forms.TextBox N_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox S_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox W_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox s_num;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 另存为ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全部ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 其他字符ToolStripMenuItem;
        private System.Windows.Forms.TextBox O_textBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem 清空ToolStripMenuItem;
    }
}

