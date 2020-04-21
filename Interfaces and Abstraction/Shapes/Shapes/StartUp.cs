using System;
using System.Reflection.PortableExecutable;

namespace Shapes
{
   public class StartUp
    {
       public static void Main(string[] args)
        {
            var radius = int.Parse(Console.ReadLine());
            Idrawable newCircle = new Circle(radius);
            newCircle.Draw();

            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());

            Idrawable newRectangle = new Rectangle(width, height);
            newRectangle.Draw();
        }
    }
}
