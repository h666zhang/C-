using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_010
{
    interface Door
    {
        void Open(bool a);
        void Close(bool a);
    } 
     class AutoDoor:Door{
        public void Open(bool a) {
        if (a) {
                Console.WriteLine("有人来了，自动门开了");
            }        
        }
        public void Close(bool a)
        {
            if (!a)
            {
                Console.WriteLine("没有人，自动门关闭");
            }
        }
    }
    class PasswordDoor : Door {
        public void Open(bool a)
        {
            if (a)
            {
                Console.WriteLine("密码正确，密码门打开");
            }
        }
        public void Close(bool a)
        {
            if (!a)
            {
                Console.WriteLine("密码不正确，密码门不能打开");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            bool havePeople = false;
            bool passwordIstrue = false;
            AutoDoor a=new AutoDoor();
            a.Open(havePeople);
            a.Close(havePeople);
            PasswordDoor p=new PasswordDoor();
            p.Open(passwordIstrue);
            p.Close(passwordIstrue);
        }
    }
}
