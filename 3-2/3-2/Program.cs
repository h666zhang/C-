using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2
{
    class Adder
    {
        private int _x;
        private int _y;
        private int _z;
        public Adder(int x, int y)
        {
            _x = x;
            _y = y;
        }
        public int Add()
        { 
            _z = _x + _y;
            return _z;
        }
    }

    

    internal class Program
    {
        static void Main(string[] args)
        {
            Adder adder = new Adder(14, 20);
            Console.WriteLine("和为："+adder.Add());
        }
    }
}
