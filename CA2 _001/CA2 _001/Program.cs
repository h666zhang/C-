using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CA2__001
{
    internal class Program
    {
        static void Main(string[] args)

        {
            //偶数
            //int Count = 0;
            //for (int i = 0; i <= 100; i++) 
            //{
            //    if (i % 2 == 0) 
            //    {

            //        Console.Write(i + "\t");
            //        Count++;
            //        if (Count == 10) 
            //        {

            //            Console.WriteLine();
            //            Count = 0;
            //        }
            //    }
            //}

            //素数查找
            //int A_Count = 0;
            //int B_Count = 0;
            //for (int i = 1; i <= 100; i++) {
            //    for (int j = 1; j <= i; j++) {
            //        if(i % j == 0){
            //            A_Count++;
            //        }
            //    }
            //    if (A_Count == 2) {
            //        Console.Write(i+"\t");
            //        B_Count++;
            //        if (B_Count == 5) { 
            //            Console.WriteLine();
            //            B_Count = 0;
            //        }
            //    }
            //    A_Count = 0;
            //}
            //99乘法表
            //for (int i = 1; i < 10; i++) {
            //    for (int j = 1; j <= i; j++) {
            //        Console.Write($"{i}*{j}={i*j}\t");
            //    }
            //    Console.WriteLine();
            //}
            //for(int i = 9; i > 0; i--) {
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write($"{i}*{j}={i * j}\t");
            //    }
            //    Console.WriteLine();
            //}
            string[] strings = {"I","love","my","program" };
            foreach (string a in strings) {
                Console.Write(a+' ');
            }
        }
    }
}
