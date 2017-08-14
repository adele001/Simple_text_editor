using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public class KMP
    {
        public static string target = "";//输入的字符串
        public static bool sign;//标志： true 为寻找，false 为删除
        public static string text_t="";//原文本
        public static int number_s;//字符串个数
        public static int[] record_d = new int[210];//记录要删除字符串的位置
        
        //private static char[] temp_d=new char [220];//用来
        private static int[] arr_next = new int[210];//KMP的next数组 
        private static int len;//target字符串长度
        private static int len_t;//原文本长度

        public static void rukou()//入口函数
        {
            len = target.Length;
            len_t = text_t.Length;
            bulid_next();
            if (KMP.sign == true)
                find_s();
            else
                delete_s();
            
        }

        private static void bulid_next()//建立next数组  数组内元素代表原数组需要向后移动的位数
        {
            arr_next[0] = -1;//next数组第一位为-1 
            int i, j, k;
            int p = 0;
            for (i = 1; i < len; i++)
            {
                for (j = 0; j <= i - 2; j++)
                {
                    for (k = 0; k < i - 1 - j; k++)
                    {
                        if (target[k] != target[k + 1 + j])
                            break;
                    }
                    if (k == i - 1 - j)
                    {
                        p = j;
                        break;
                    }
                    else
                        p = i - 1;
                }
                arr_next[i] = p + 1;
            }
        }

        private static void find_s()
        {
            int count = 0;//记录字符串个数
            int m = KMP.len_t, n = KMP.len;//m为原文本长度 n为字符串长度
            int n_x = 0, t_x = 0;//n_x next数组指针,t_x原文本数组指针
            while (t_x <m)//开始寻找 不超出原文本数组范围
            {
                
                if (text_t[t_x] == target[n_x])//一个字符匹配成功
                {
                    n_x++;
                    t_x++;
                }
                else if (text_t[t_x] != target[n_x] && arr_next[n_x] == -1)//第一个字符匹配不成功
                {
                    t_x++;
                }
                else //使用KMP算法进行数组移动
                {
                    n_x = n_x - arr_next[n_x];
                }
                if (n_x == n)//找到目标字符串
                {
                    record_d[count] = t_x;//记录删除字符串后一位
                    count++;
                    n_x = 0;
                }
            }
            number_s = count;
        }
        private static void delete_s()//删除指定字符串
        {
            find_s();
            if (number_s == 0)
                return;
            for (int i = 0; i < number_s; i++)
            {
                //string s_temp=""; 
                text_t=text_t.Remove((record_d[i] - len*(i+1)), len);
                //text_t = s_temp;
            }
        }
    }
}
