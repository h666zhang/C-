using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_009
{

    public abstract class VideoShow
    {
        public abstract string playVideo();
    }
    public class VCD : VideoShow
    {
        public override string playVideo()
        {
            return "正在播放VCD";
        }
    }
    public class DVD : VideoShow
    {
        public override string playVideo()
        {
            return "正在播放DVD";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            VideoShow vs;
            vs= new DVD();
            Console.WriteLine(vs.playVideo());
            vs = new VCD();
            Console.WriteLine(vs.playVideo());
        }
    }
}
