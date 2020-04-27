using System;
using System.Collections.Generic;

namespace Shapes
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Shape newshape = new Circle(2.5);
            Shape shapeTwo = new Rectangle(5, 5);

            List<Shape> shapes = new List<Shape>();
            shapes.Add(newshape);
            shapes.Add(shapeTwo);

            foreach (var item in shapes)
            {
                Console.WriteLine(item.CalculateArea());
            }
        }
    }
}
