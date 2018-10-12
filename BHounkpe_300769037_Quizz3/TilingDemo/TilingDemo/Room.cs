using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TilingDemo
{
    class Room
    {
        private int length;
        private int width;
        public Room(int lenght, int width)
        {
            Length = lenght;
            Width = width;
        }
        private double FloorArea
        {
            get
            {
                return Length * Width;
            }
        }
        
        public int numberOfBoxesOfTileNeeded
        {
            get
            {
                int extraBoxs;
                int nberBoxes = (int)(FloorArea / 12);
                if(FloorArea%12==0)
                {
                   extraBoxs = 0;
                }else
                {
                    extraBoxs = 1;
                }
                return (nberBoxes + extraBoxs + 1);
            }
        }

        public int Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }
        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }
    }
}
