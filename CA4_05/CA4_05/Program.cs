using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA4_05
{
    interface IBreathe
    {
        void Lung();

        void Gill();
    }

    interface ISport
    {
        void Run();

        void Swim();
    }

    interface IAnimal:IBreathe,ISport//冒号表示继承
    {
        void Fur();   
    }
    class Tiger:IAnimal,ISport
        //Tiger:IAnimal
    {
        public void Lung()
        {
            Console.WriteLine("老虎用肺呼吸");
        }

        public void Gill() 
        {
            Console.WriteLine("老虎不用鳃呼吸"); 
        }
        public void Run()
        {
            Console.WriteLine("老虎跑得很快");
        }

        public void Swim() 
        {
            Console.WriteLine("老虎擅长游泳");
        }
        public void Fur()
        {
            Console.WriteLine("老虎有皮毛");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Tiger tiger = new Tiger();
            tiger.Run();
            tiger.Lung();
            tiger.Swim();
            tiger.Gill();
        }
    }
}
