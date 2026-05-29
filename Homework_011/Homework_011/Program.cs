using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Homework_011
{
    class People {
        private string _name;
        private int _age;
        public People(string name, int age)
        {
            _name = name;
            _age = age;
        }
        public void Print()
        {
            Console.WriteLine("姓名为{0}，年龄为{1}",_name,_age);
        }
        public virtual void Eat() {
            Console.WriteLine("我是人，要吃饭");
        }
    }
    class Child:People{
        public Child(string s,int a) : base(s, a) { }
        public override void Eat() { Console.WriteLine("我是小孩，用勺子吃饭"); }
    }
    class Elder : People
    {
        public Elder(string s, int a) : base(s, a) { }
        public override void Eat() { Console.WriteLine("我是大人，用筷子吃饭"); }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            People p = new Child("洋洋",5);
            p.Print();
            p.Eat();
            Console.WriteLine("**************");
            p = new Elder("张三", 30);
            p.Print();
            p.Eat();
        }
    }
}
