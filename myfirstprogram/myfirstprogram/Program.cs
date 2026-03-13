using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;//引用命名空间

namespace myfirstprogram//自命名空间
{
    internal class Program//internal 访问权限 
    {
        static void Main(string[] args)//Main方法
        {
            Console.Write("C#：");//输出不换行
            Console.WriteLine();//换行
            Console.WriteLine("Hello World");
            Console.WriteLine("第一个C#程序");//输出换行
            string strm = "this is a short string";
            string strn = "is";
            int index1 = strm.LastIndexOf(strn);
            Console.WriteLine(index1);
        }
    }
}
