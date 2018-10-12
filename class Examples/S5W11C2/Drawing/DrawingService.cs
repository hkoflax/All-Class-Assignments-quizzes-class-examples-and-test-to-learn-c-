using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeLib;

namespace Drawing
{
    class DrawingService
    {
        public void DrawArt(object[] shapes)
        {
            IDrawable[] temp = shapes as IDrawable [];
            foreach (var item in temp)
            {
                item.Draw();
            }
        }
    }
}
