using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            for (int i = 1; i < 11; i++)
            {

                for (int k = 0; k < a - i; k++) 
                {
                    Console.Write(" ");
                }
                for (int j = 1; j < 2*i; j++)
                {
                   Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
