using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLib
{
    public abstract class Shape : IComparable, IDrawable
    {
        protected Point[] verticies;
        public int NoOfSides { get; }
        public abstract void Draw();
        public virtual Point[] Verticies
        {
            get
            {
                return verticies;
            }

            set
            {
                if (value.Length ==1)
                {
                    verticies = value;
                }
                else
                {
                    throw new ArgumentException("Wrong number of verticies");
                }
            }
        }
        public Shape(int nberSides)
        {
            NoOfSides = nberSides;
        }

        public abstract double GetArea();

        public int CompareTo(object obj)
        {
            Shape temp = obj as Shape;
            if (temp == null) return 1;
            if (GetArea() < temp.GetArea()) return -1;
            else if (GetArea() > temp.GetArea()) return 1;
            else return 0;
        }
    }
}
