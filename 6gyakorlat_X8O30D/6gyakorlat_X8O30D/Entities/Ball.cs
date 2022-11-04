using _6gyakorlat_X8O30D.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6gyakorlat_X8O30D.Entities
{
    public class Ball : Toy
    {
        public Ball(Color color)
        {
            BallColor = new SolidBrush(color);
        }
        public SolidBrush BallColor { get; private set; }
        protected override void DrawImage(Graphics g)
        {
            g.FillEllipse(BallColor, 0, 0, Width, Height);
        }
    }
}
