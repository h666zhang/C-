using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CA2_003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arr;
            //arr = new int[5]{1,2,3,4,5};
            //int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            //int[] arr = new int[] { 1, 2, 3, 4, 5 };
            //int[] arr = { 1, 2, 3, 4, 5 };//数据是引用数据类型
            //Console.WriteLine(arr[2]);
            //arr[2] += 100;
            //Console.WriteLine(arr[2]);
            //Console.WriteLine(arr.Length);
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] += 5;
            //    Console.WriteLine(arr[i]);
            //}

            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);//arr不是索引值，遍历过程中不能给i进行运算
            //}
            //for 可以正序访问 也可以倒叙访问 能赋值
            //foreach只能正序访问 不能赋值
            //二位数组

            //int[,] arr = new int [2,4]{{1,2,3,4},{5,6,7,8}};
            //Console.WriteLine(arr.GetLength(0));
            //Console.WriteLine(arr.Length);
            //for (int i = 0; i < arr.GetLength(0); i++) {
            //    for (int j = 0; j < arr.GetLength(1); j++) {

            //        Console.WriteLine(arr[i,j]);
            //    }
            //}

            int[,] arr = { { 0, 1, 2 }, { 3,-4,5 }, { 6,7,8 } };
            int b = 0;
            for (int a = 0; a < arr.Length; a++){
                    Console.Write(arr[a/3,a%3]+"\t");
                    b++;
                    if (b == 3) {
                        Console.WriteLine();
                        b = 0;
                    }
                } 
            }
        }
    }