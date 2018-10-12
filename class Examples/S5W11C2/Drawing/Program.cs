using ShapeLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing
{
    class Program
    {
        static void Main(string[] args)
        {
            IDrawable[] art ={
                new Triangle(5,2),
                new ShapeLib.Rectangle(2,2),
                new Circle(4),
                new ShapeLib.Rectangle(6,7),
                new Triangle(4,5)};
            DrawingService ds = new DrawingService();
            ds.DrawArt(art);
        }
    }
}
