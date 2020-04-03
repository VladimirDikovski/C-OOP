using System;
using System.Collections.Generic;
using System.Text;

namespace PointinRectangle
{
   public class Rectangle
    {
        private Point topLeft;
        private Point bottonRight;

        public Rectangle(Point topLeft, Point bottomRight)
        {
            this.topLeft = topLeft;
            this.bottonRight = bottomRight;
        }
        public  bool Contains (Point point)
        {
           return this.topLeft.X <= point.X && this.bottonRight.X >= point.X && this.topLeft.Y <= point.Y && this.bottonRight.Y >= point.Y;
        }


    }
}
