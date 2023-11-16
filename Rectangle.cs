using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2
{
    internal class Rectangle
    {
        int x1;
        int y1;
        int x2;
        int y2;

        public int X_1
        {
            get { return x1; }
            set { x1 = value; }
        }
        public int X_2
        {
            get { return x2; }
            set { x2 = value; }
        }
        public int Y_1
        {
            get { return y1; }
            set { y1 = value; }
        }
        public int Y_2
        {
            get { return y2; }
            set { y2 = value; }
        }
        public Rectangle(int min, int max)
        {
            x1 = new Random().Next(min, max);
            y1 = new Random().Next(min, max);
            x2 = x1 + new Random().Next(1, max - min);
            y2 = y1 + new Random().Next(1, max - min);
        }
        public Rectangle()
        {
            x1 = new Random().Next(-10, 10);
            y1 = new Random().Next(-10, 10);
            x2 = x1 + new Random().Next(1, 20);
            y2 = y1 + new Random().Next(1, 20);
        }
        public Rectangle(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }
        public int Width { get { return Math.Abs(x2 - x1); } }
        public int Height { get { return Math.Abs(y2 - y1); } }
        public void SetWidth(int width) { x2 = x1 + width; }
        public void SetHeight(int height) { y2 = y1 + height; }
    }
}
