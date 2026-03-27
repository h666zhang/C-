using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal Panda = new Animal();
            Panda._name = "熊猫";
            Panda._country = "中国";
            Panda._diet = "竹子";
            Panda.Show();
            Animal Tiger;
        }
    }
    class Animal
    {
        public string _name;
        public string _country;
        public string _diet;
        public void Show()
        {
            Console.WriteLine($"姓名：{_name}，来自{_country}，爱吃{_diet}");
        }
    }
}
