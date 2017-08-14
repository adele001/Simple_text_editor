using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class tongji
    {
        public static string wenben="";//原文本
        public static int letter,number,space,word,other;
        private static byte []wenben_a=new byte[100];
        private static int len_wen;
        public static void rukou()
        {
            len_wen=wenben.Length;//计算出长度
            wenben_a=Encoding.Default.GetBytes(wenben);//转换为ASCII码
            all();//调用计算函数
        }
        private static void all()
        {
            letter = 0;
            number = 0;
            space = 0;
            word = 0;
            other = 0;
            for (int i = 0; i < len_wen; i++)
            {
                if (wenben_a[i] == 32)
                    space++;
                else if (wenben_a[i] >= 48 && wenben_a[i] <= 57)
                    number++;
                else if ((wenben_a[i] >= 65 && wenben_a[i] <= 90) || (wenben_a[i] >= 97 && wenben_a[i] <= 122))
                    letter++;
                else
                    other++;
            }
            if (letter != 0)
                word = space + 1;
            else
                word = 0;
        }
    }
}
