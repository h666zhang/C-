using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA4_03
{

    abstract class Animal //抽象类里不一定有抽象方法，反之必然
    {
        public void Fur()
        {
            Console.WriteLine();
        }

        public abstract void Shout();//只提供方法原型 不提供具体实现
    }
    class Dog:Animal
    {
        public override void Shout()
        {
            Console.WriteLine();
        }
    }
    class Babydog : Dog 
    {
        public override void Shout()
        { 
            base.Shout();// 通过base语句调用父类中重写的方法
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Animal animal = new Animal();//抽象类不能直接实例化
            Dog dog = new Dog();
            dog.Fur();
            dog.Shout();
            Animal animal = new Dog();//让父类的变量指向子类的对象
            //Animal animal = dog;
            animal.Shout();
        }
    }
}
