using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5W2C2E3_Carpet
{
    class Carpet
    {
        private int length;
        private int width;
        private int area;

        public int Length
        {
            set
            {
                length = value;
                calcArea();
            }

            get
            {
                return length;
            }
        }

        private void calcArea()
        {
            area = Length * Width;
        }

        public int Width
        {
            set
            {
                width = value;
                calcArea();
            }
             
            get
            {
                return width;
            }
        }

        public int Area
        {
            //set
            //{
            //    area = value;
            //}

            get
            {
                return area;
            }
        }

        public void TellAboutSelf()
        {
            Console.WriteLine("A carpet: \n Length = {0}; Width = {1}; Area = {2}",
                                Length,
                                Width,
                                Area);
        }
    }
}
