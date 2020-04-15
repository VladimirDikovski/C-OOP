using System;

namespace Class_Box_Data
{
   public class StartUp
    {
       public static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double widht = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Box newBox = new Box(length, widht, height);

            SurfaceArea(newBox);
            Lateral(newBox);
            Volume(newBox);            
        }

        private static void Lateral(Box newBox)
        {         
            double lateral = 2 * newBox.Length * newBox.Height + 2 * newBox.Width * newBox.Height;
            Console.WriteLine($"Lateral Surface Area - {lateral:f2}");
        }

        private static void SurfaceArea(Box newBox)
        {          
            double surface = 2 * newBox.Length * newBox.Width + 2 * newBox.Length * newBox.Height + 2 * newBox.Width * newBox.Height;
            Console.WriteLine($"Surface Area - {surface:f2}");
        }

        private static void Volume(Box newBox)
        {
            double value = newBox.Length * newBox.Height * newBox.Width;
            Console.WriteLine($"Volume - {value:f2}");
        }
    }
}
