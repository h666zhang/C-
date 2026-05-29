using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Homework_008
{
    class People
    {
        private string _name ="hey?";
        private string _sex = "male";

        public void Display1()
        {
            Console.WriteLine($"name:{_name},sex:{_sex}");
        }
    }
    class Student : People 
    {
        public void Display2()
        {
            Console.WriteLine("这是student类的显示函数");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stu1=new Student();
            People pe1=new People();
            Console.WriteLine();
            pe1.Display1();
            Console.WriteLine();
            Console.WriteLine();
            stu1.Display1();
            stu1.Display2();
        }
    }
}
