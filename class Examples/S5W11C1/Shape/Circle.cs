using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLib
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle (double radius) : base (0)
        {
            Radius = radius;
        }
        public override double GetArea()
        {
            return (Math.PI*Radius * Radius);
        }
        public override Point[] Verticies
        {
            get
            {
                return base.Verticies;
            }

            set
            {
                if (value.Length == 0)
                {
                    verticies = value;
                }
                else
                {
                    throw new ArgumentException("Wrong number of verticies");
                }
            }
        }
        public override void Draw()
        {
            Console.WriteLine("Draw Circle");
        }
    }
}
