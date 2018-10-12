using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLib
{
    public class Triangle : Shape
    {
        public double SideSize { get; set; }
        public double Height { get; set; }

        public Triangle (double side, double height): base(3)
        {
            SideSize = side;
            Height = height;
        }

        public override double GetArea()
        {
            return (SideSize * Height) / 2;
        }
        public override void Draw()
        {
            Console.WriteLine("Draw Triangle");
        }

    }
}
