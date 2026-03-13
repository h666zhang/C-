using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, schoolNumber;
            Console.WriteLine("请输入姓名:");
            name = Console.ReadLine();
            while (name != "") {
                Console.WriteLine("请输入学号");
                schoolNumber = Console.ReadLine();
                Console.WriteLine("我的名字叫" + name + "，是某大学的学生。");
                Console.WriteLine("我的学号是:" + schoolNumber);
                Console.WriteLine("请输入姓名:");
                name=Console.ReadLine();
            }
        }
    }
}
