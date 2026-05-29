using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_006
{

    class People
    {
        public string _name;
        public string _blood;
        public People(string name, string blood)
        { 
            _name = name;
            _blood = blood;
        }
        public void PrintName()
        {
            Console.WriteLine($"Name:{_name}");
        }

        public void PrintBlood()
        {
            Console.WriteLine($"Blood:{_blood}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            People zhangsan = new People("zhangsan", "AB");
            zhangsan.PrintName();
            zhangsan.PrintBlood();
        }
    }
}
