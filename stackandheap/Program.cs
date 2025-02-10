using System;
namespace valueandreference
{
    class Rect
    {
        public int width{set; get;}
        public int height{set; get;}
        public Rect(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rect r1 = new Rect(10, 20);
            Rect r2 = r1;
            r2.width = 30;
            Console.WriteLine(r1.width);
        }
    }
}