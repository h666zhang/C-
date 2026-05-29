using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA4_07
{
    class Animal
    {
        public string _name;
        public string _species;
        public Animal(string name, string species)
        {
            _name = name;
            _species = species;
        }
        public void Fur()
        {
            Console.WriteLine("\\/\\/\\/\\/");
        }
        public virtual void Breathe()
        {
            Console.WriteLine($"{_name}'s{_species},212312312");
        }
    }
    class Dog : Animal
    {
        public Dog(string name, string species) : base(name, species)
        {

        }
        public override void Breathe()
        {
             Console.WriteLine($"{_name}是{_species}");
        }
        //虚方法可以对他重写，也可以不重写
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("2313","33232");
            animal.Fur();
            animal.Breathe();
            Dog dog = new Dog("ZG9n", "5Y6f56We");
            dog.Fur();
            dog.Breathe();
        }
    }
}
