using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeLib;
using System.Drawing;

namespace S5W11C2
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes =
            {
                new Triangle(5,2),
                new ShapeLib.Rectangle(2,2),
                new Circle(4),
                new ShapeLib.Rectangle(6,7),
                new Triangle(4,5)
            };

            foreach(Shape aShape in shapes)
            {
                Console.WriteLine("The Area of {1} is : {0}",aShape.GetArea(), aShape.GetType());
            }
            shapes[4].Verticies = new[] { new Point(10, 10) };

            Console.WriteLine("*****************************************");
            Array.Sort(shapes);

            foreach (Shape aShape in shapes)
            {
                Console.WriteLine("The Area of {1} is : {0}", aShape.GetArea(), aShape.GetType());
            }

            foreach (Shape aShape in shapes)
            {
                aShape.Draw();
            }
        }
    }
}
