using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字符串
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入字符串: ");
            string str = Console.ReadLine();
            Console.WriteLine($"你所在的学院{str}");
            while (str != "" )
            {   
                Console.WriteLine("请输入需要查找的字符串： （输入 'q' 可退出程序）");
                string strs = Console.ReadLine();
                if(strs == "q") 
                {
                    break;
                }
                if (str.IndexOf(strs) != -1)
                {
                    Console.WriteLine($"Indexof方法查找“{strs}”：" + str.IndexOf(strs));
                }
                else 
                {
                    Console.WriteLine($"字符串str中不存在字符串{strs}");
                }
            }
            Console.WriteLine("程序已退出");
        }
    }
}
