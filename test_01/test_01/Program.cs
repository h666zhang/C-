using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_01
{
    class Animal
    {
        public void Shout()
        {
            Console.WriteLine("111");
        }
        
    }
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("222");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Dog();
            a.Shout();
        }
    }
}
