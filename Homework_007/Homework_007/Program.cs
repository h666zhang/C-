using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("请输入一个年份：");
            //int nianfen = Convert.ToInt32(Console.ReadLine());
            //if (nianfen % 4 == 0)
            //{
            //    if (nianfen % 100 != 0)
            //    {
            //        Console.WriteLine("这是闰年");
            //    }
            //    else
            //    {
            //        if (nianfen % 400 == 0)
            //        {
            //            Console.WriteLine("这是闰年");
            //        }
            //        else 
            //        {
            //            Console.WriteLine("这不是闰年");
            //        }
            //    } 
            //}
            //else 
            //{
            //    Console.WriteLine("这不是闰年");
            //}


            //Console.WriteLine("请输入一个年份：");
            //int nianfen = Convert.ToInt32(Console.ReadLine());
            //if ((nianfen % 4 == 0 && nianfen % 100 != 0) || nianfen % 400 == 0)
            //{
            //    Console.WriteLine("这是闰年");
            //}
            //else
            //{
            //    Console.WriteLine("这不是闰年");
            //}


            Console.WriteLine("请输入一个年份：");

            if (int.TryParse(Console.ReadLine(), out int nianfen))
            {
                if (DateTime.IsLeapYear(nianfen))
                {
                    Console.WriteLine("这是闰年");
                }
                else
                {
                    Console.WriteLine("这不是闰年");
                }
            }
        }
    }
}
