using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLib
{
    public class Rectangle : Shape
    {
        public double SizeofSideA { get; set; }
        public double SizeofSideB { get; set; }

        public Rectangle(double sideA, double sideB) : base(2)
        {
            SizeofSideA = sideA;
            SizeofSideB = sideB;
        }
        public override double GetArea()
        {
            return (SizeofSideA * SizeofSideB);
        }
        public override void Draw()
        {
            Console.WriteLine("Draw Rectangle");
        }
    }
}
