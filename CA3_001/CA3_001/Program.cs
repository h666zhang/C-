using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CA3_001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person zhangsan = new Person();
            //zhangsan._age = 11;
            Person lisi;//引用 引用不能调用访问，也不能访问属性；引用是未赋值的变量
            Console.WriteLine("*******************");
            zhangsan._name = "张三";
            zhangsan._gender = "男";
            //zhangsan._age = 20;
            zhangsan._status = "累了";
            zhangsan.Display();
            zhangsan.Status();
            Console.WriteLine("*******************");
            lisi= new Person();
            lisi.Display();//对象访问成员变量后赋值只属于对象本身
        }
    }
    class Person//定义类 Rerson 类的位置：自命名空间以内，其他类++以外。 
    {
        public string _name;
        public string _gender;
        public int _age;
        public string _status;
        //定义共有型成员变量
        //变量分为 局部变量和成员变量 成员变量在实例化对象时 会初始化为该类型的默认值
        public void Display()
        {
            Console.WriteLine($"我的名字{_name},我的性别{_gender},我的年龄{_age}");
        }

        public void Status()
        {
            Console.WriteLine($"状态：{_status}");
        }

    }
}
