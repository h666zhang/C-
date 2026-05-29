using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CA4_01
{

    class Animal 
    {
        public string _name = "animal ";
        public string _furcolor = "white ";
        public Animal(string name ,string furcolor) //带参数的显示构造方法
        {
            _name = name;
            _furcolor=furcolor;
        }
        public void Shout() 
        {
            Console.WriteLine("???");
        }
        public void Display()
        {
            Console.WriteLine($"name:{_name} ,have_fur(?):{_furcolor} ");
        }
    }
    class Dog:Animal//若父类中存在带参数的显示构造方法 ，则子类中必须也带
    {
        public string _country = " Engilsh ";
        public Dog(string name,string furcolor, string country)
            :base(name,furcolor) 
        //参 数个数不能少于父类 通过base语句调用父类中的构造方法
        {
            _name = name;//?
            _country = country;
        }

        //如果子类没新的形参，{}里啥都不写


        public void Show()
        {
            Console.WriteLine($"name:{_name},have_fur(?):{_furcolor},form:{_country} ");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("dadada","Black");
            animal.Shout();
            animal.Display();
            Console.WriteLine("***********************");
            Dog dog = new Dog("asdas","White","ccb");
            dog.Shout();
            dog.Display();
            Console.WriteLine("***********************");
            dog._furcolor = "Black";
            dog.Show();
        }
    }
}
