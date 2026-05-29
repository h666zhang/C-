using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace CA3_04
{
    internal class Program
    {
        string _name;
        int _age;

        public Program(string name,int age) 
        { 
            _name = name;
            _age = age;
        }
        public Program()
        { 
            
        }
        public void Show()
        {
            Console.WriteLine($"Name:{_name},Age:{_age}");
        }
        
        public string Name
        {
            get { return _name; }
            set { Name = value; }
        }

        public int Age 
        {
            get { return _age; }
            set { Age = value; }
        }
        public int Add(int x, int y)
        {
            return x+y;
        }
        public int Add(int x,int y,int z)
        { 
            return x+y+z;   
        }

        static void Main(string[] args)
        {
            Program program = new Program("zhangsan",11);//隐式构造
            int x = 4; 
            int y = 1;
            int z = 3;
            Console.WriteLine(program.Add(x, y));
            Console.WriteLine(program.Add(x, y, z));
            program.Name = "zhangsan";
            Console.WriteLine(program.Name);
        }
    }
}