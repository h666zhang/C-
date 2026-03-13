using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 圆的面积
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const float Pi = 3.141592653f;
            float XueHao = 18;
            float MianJi, ZhouChang;
            MianJi = Pi * XueHao * XueHao;
            ZhouChang = 2 * Pi * XueHao;
            Console.WriteLine(MianJi);
            Console.WriteLine(ZhouChang);
        }
    }
}
