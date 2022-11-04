using _6gyakorlat_X8O30D.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6gyakorlat_X8O30D.Entities
{
    internal class Present : Toy
    {
        public SolidBrush RibbonColor { get; set; }
        public SolidBrush BoxColor { get; set; }
        public Present(Color ribbon, Color box)
        {
            RibbonColor = new SolidBrush(ribbon);
            BoxColor = new SolidBrush(box);
        }
        protected override void DrawImage(Graphics g)
        {
            g.FillRectangle(BoxColor, 0, 0, Width, Height);
            g.FillRectangle(RibbonColor, 0, 20, Width, (Height/5));
            g.FillRectangle(RibbonColor, 20, 0, (Width/5), Height);
        }
    }
}
