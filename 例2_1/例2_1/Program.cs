using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 例2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string strContent = "what ";
            strContent += "our name";
            Console.WriteLine("strContent的长度为："+strContent.Length);
            Console.WriteLine("第一个空格的位置"+strContent.IndexOf(' '));
            Console.WriteLine("最后一个空格的位置" + strContent.LastIndexOf(' '));
            string[] str1 = strContent.Split(' ');
            Console.WriteLine(str1[0]);
            Console.WriteLine(str1[1]);
            Console.WriteLine(str1[2]);
        }
    }
}
