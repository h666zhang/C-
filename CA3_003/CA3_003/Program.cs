using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA3_003
{

    class Person
    {
        public static string _name;
        public static string _gender;
        public static void Display()//静态方法所涉及的成员必须是静态的
        {
            Console.WriteLine($"name:{_name},gender:{_gender}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person._name = "zhangsan";
            Person._gender = "male";
            Person.Display();//静态方法用类名调问
        }
    }
}
