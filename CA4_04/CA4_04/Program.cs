using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CA4_04
{
    //接口的位置：自命名空间以内，其他类或者接口以外
    interface IAnimal
    {
        void Performance();
        void Country();
        //只提供方法原型，不提供方法，不需要指明访问权限，默认是public
        int Age { get; set; }
        //定义属性，数据类型，属性名称，权限，不需要指明访问权限，默认是public
    }

    class AmurTriger : IAnimal //用类 实现 接口
    {
        int _Age;
        public void Performance() 
        {
            Console.WriteLine("1145141919180");
        }
        public void Country()
        {
            Console.WriteLine("????");
        }
        public int Age { get { return _Age; } set { _Age = value; } }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //接口无法直接实例化
            AmurTriger tiger = new AmurTriger();
            tiger.Performance();
            tiger.Age = 32;
            Console.WriteLine($"Age:{tiger.Age}");
        }
    }
}
