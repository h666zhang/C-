using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA4_06
{
    interface ITiger
    {
        void Move();
    }
    interface IFish
    {
        void Move();
    }

    class Animal : ITiger, IFish
    {
        void ITiger.Move()
        {
            Console.WriteLine();
        }
        void IFish.Move()
        {
            Console.WriteLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal=new Animal();
            //((接口名称)对象名称).方法名称
            ((ITiger)animal).Move();//显示实现
        }
    }
}
