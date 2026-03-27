using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3,4]{{ 2, 5, 7, 4 }, { 12,7,89,-5 }, { 10,8,13,29 } };
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i / 4, i % 4] %2==0) {
                    arr[i / 4, i % 4] *= 2;
                }
                else //if (arr[i / 4, i % 4] %2!=0)
                {
                    arr[i / 4, i % 4] /= -2;
                }
            }
            int a = 0;
            foreach (int j in arr) {
                Console.Write( j +"\t");
                a++;
                if (a==4) {
                    Console.WriteLine();
                    a = 0;
                }
            }
        }
    }
}
