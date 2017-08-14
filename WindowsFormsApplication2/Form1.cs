using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;//使用arraylist功能 添加命名空间

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //撤销删除功能初始化
            temp_record.Add("");//初始化撤销恢复功能的记录缓存区
            Arr_count = 0;
            op_sign = false;
        }
        
        

        //>>>>>>>>>>>>>>>>>>>>>撤销和恢复功能>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        public ArrayList temp_record = new ArrayList();//使用动态数组 作为记录更改的缓存区 
        public bool op_sign;//撤销恢复功能标志
        public int Arr_count;//记录array的当前记录数
        public string[] richbox_record = new string[300];//可记录300次改变 
        public int re_count;//richbox_record数组的指针
        public bool re_sign;//richbox_record是否建立的标志
        public bool cx_sign;//撤销标志

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //richbox改变触发记录缓存内容
            if (op_sign == true)//撤销删除导致的richbox内容变化 不需要记录
            {
                op_sign = false;
            }
            else
            {
                new_record();//调用new_record记录当前的内容
            }
        }
        private void new_record()
        {
            //清空richbox_record
            for (int i = 0; i < richbox_record.Length; i++)
            {
                richbox_record[i] = null;
            }
            re_sign = false;
            re_count = 0;
            cx_sign = false;//

            temp_record.Add(richTextBox1.Text);//添加当前内容进入动态数组
            Arr_count = temp_record.Count;
        }
        private void setup_rich()//建立字符串缓存
        {
            if (re_sign == false)
            {
                foreach (string i in temp_record)//从动态数组中取出当前的缓存内容
                {
                    richbox_record[re_count] = i;
                    re_count++;
                }
                re_sign = true;
            }
            else
                return;
        }

        private void chexiao()
        {
            cx_sign = true;//撤销功能标志
            op_sign = true;
            setup_rich();//获取缓存
            if (re_count > 1)
            {
                re_count--;
                richTextBox1.Text = richbox_record[re_count - 1];//实现撤销
                temp_record.Clear();//执行撤消恢复后 清空动态数组的缓存 记录当前的内容 撤销的特性
                temp_record.Add(richTextBox1.Text);
                op_sign = false;
            }
            else
            {
                op_sign = false;
                return;//没有撤销内容
            }
        }

        private void huifu()
        {
            op_sign = true;
            /* if (re_count == Arr_count)
             {
                 richTextBox1.Text = richbox_record[re_count - 1];
             }*/
            if (cx_sign == true && re_count < Arr_count)//先撤销才能恢复 且有恢复内容
            {
                re_count++;
                richTextBox1.Text = richbox_record[re_count - 1];
                temp_record.Clear();//执行撤消恢复后 清空动态数组的缓存 记录当前的内容 撤销的特性
                temp_record.Add(richTextBox1.Text);
                op_sign = false;
            }
            else
            {
                op_sign = false;
                return;//没有恢复内容
            }
        }

        //>>>>>>>>>>>>>>>>>>>>>>>>>>保存功能>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        SaveFileDialog Save_file = new SaveFileDialog();//保存文件对话框
        OpenFileDialog Open_file = new OpenFileDialog();//打开文件对话框

        string File_name = "";//文件名
        //private static string richbox_temp = "";//richbox缓存

        private void 保存ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Save_file.Filter = "txt files (*.txt)|*.txt";//保存过滤器 设置为txt文件
            //Save_file.FilterIndex = 2;
            //Save_file.RestoreDirectory = true;
            if (File_name == "")
            {
                if (Save_file.ShowDialog() == DialogResult.OK)//保存操作 保存为txt文件
                {
                    richTextBox1.SaveFile(Save_file.FileName, RichTextBoxStreamType.PlainText);
                }
                File_name = Save_file.FileName;//保存文件名
            }
            else
            {
                richTextBox1.SaveFile(File_name, RichTextBoxStreamType.PlainText);
            }
        }

        private void 另存为ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save_file.Filter = "txt files (*.txt)|*.txt";//保存文件过滤器 设置为txt文件
            if (Save_file.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(Save_file.FileName, RichTextBoxStreamType.PlainText);
            }
            File_name = Save_file.FileName;//保存文件名
        }

        private void 打开文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open_file.Filter = "txt files (*.txt)|*.txt";//打开文件过滤器 设置为txt文件
            Open_file.ShowDialog();
            File_name = Open_file.FileName;
            if (File_name != "")
            {
                richTextBox1.LoadFile(File_name, RichTextBoxStreamType.PlainText);
            }
        }

        private void toolStripMenuItemun_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void toolStripMenuItemre_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }


        private void button1_Click(object sender, EventArgs e)//统计目标字符串个数
        {
            int num = 0;//记录字符串个数
            if(s_target.Text.Trim()==string.Empty)//判断输入是否为空
            {
                MessageBox.Show("请输入字符串");
                return;
            }

            KMP.target = s_target.Text;//传入目标字符串
            KMP.text_t = richTextBox1.Text;//传入目标文本
            //richTextBox1.Text = KMP.target;//
            //KMP.len = KMP.target.Length;
            // KMP.len_t = KMP.text_t.Length;
            KMP.sign = true;//寻找标志置为true，rukou函数将调用函数
            KMP.rukou();//进入寻找字符串个数类函数入口 
            //s_num.Text = KMP.len.ToString();
            /*for (int i = 0; i < KMP.target.Length; i++)
            {
                richTextBox1.AppendText(KMP.arr_next[i].ToString());
            }*/
            num = KMP.number_s;
            s_num.Text = num.ToString();//显示字符个数


        }

        private void 文字字母ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tongji.wenben = richTextBox1.Text;//传入原文本
            tongji.rukou();//调用计数函数
            A_textBox.Text = tongji.letter.ToString();
            //richTextBox1.AppendText(tongji.wenben);
            /*for (int i = 0; i < 10; i++)
            {
                
                richTextBox1.AppendText(tongji.wenben_a[i].ToString());
            }
            richTextBox1.AppendText(tongji.len_wen.ToString());
             */
        }

        private void 全部ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tongji.wenben = richTextBox1.Text;//传入原文本
            tongji.rukou();//调用计数函数
            A_textBox.Text = tongji.letter.ToString();
            N_textBox.Text = tongji.number.ToString();
            S_textBox.Text = tongji.space.ToString();
            W_textBox.Text = tongji.word.ToString();
            O_textBox.Text = tongji.other.ToString();
        }

        private void 数字ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tongji.wenben = richTextBox1.Text;//传入原文本
            tongji.rukou();//调用计数函数
            N_textBox.Text = tongji.number.ToString();
        }

        private void 空格ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tongji.wenben = richTextBox1.Text;//传入原文本
            tongji.rukou();//调用计数函数
            S_textBox.Text = tongji.space.ToString();
        }

        private void 单词ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tongji.wenben = richTextBox1.Text;//传入原文本
            tongji.rukou();//调用计数函数
            W_textBox.Text = tongji.word.ToString();
        }

        private void 其他字符ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tongji.wenben = richTextBox1.Text;//传入原文本
            tongji.rukou();//调用计数函数
            O_textBox.Text = tongji.other.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (s_target.Text.Trim() == string.Empty)//判断输入是否为空
            {
                MessageBox.Show("请输入字符串");
                return;
            }
            KMP.target = s_target.Text;//传入目标字符串
            KMP.text_t = richTextBox1.Text;//传入目标文本
            KMP.sign = false;//删除标志置为false，rukou函数将调用函数delete_s
            KMP.rukou();//进入寻找字符串个数类函数入口
            if (KMP.number_s == 0)
                MessageBox.Show("该字符串不存在");
            richTextBox1.Text = KMP.text_t;
            /*for (int i = 0; i < KMP.number_s; i++)
            {
                richTextBox1.AppendText(" ");
                richTextBox1.AppendText(KMP.record_d[i].ToString());
                
            }
            richTextBox1.AppendText(KMP.len.ToString());*/
        }

        

        private void button3_Click(object sender, EventArgs e)//撤销按钮
        {
            chexiao();
        }

        private void button_hf_Click(object sender, EventArgs e)
        {
            if (cx_sign == true)//先撤销才能恢复
                huifu();
            else
                return;
        }

        private void 清空ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            s_num.Text = "";
            A_textBox.Text = "";
            N_textBox.Text = "";
            S_textBox.Text = "";
            O_textBox.Text = "";
            W_textBox.Text = "";
        }



    }
}
