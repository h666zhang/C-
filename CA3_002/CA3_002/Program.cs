using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA3_002
{

    class Person
    {
        public string _name;
        public string _gender;
        //private int _x;
        public void Dispaly()
        {
            Console.WriteLine($"name:{_name},gender:{_gender}");
        }
        //显式构造方法
        public Person(string name,string gender)
        {
            _name = name;
            _gender = gender;
            Console.WriteLine("Success");
        }

        //public int sadasd(int x)
        //{
        //    _x = x;
        //    return 0;
        //}
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person zhangsan = new Person("zhangsan","male");
            zhangsan.Dispaly();
        }
    }
}
