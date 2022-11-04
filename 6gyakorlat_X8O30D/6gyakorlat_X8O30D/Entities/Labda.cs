using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6gyakorlat_X8O30D.Entities
{
    internal class Labda : Label
    {
        public Labda()
        {
            AutoSize = false;
            Height = 50;
            Width = 50;

            Paint += Labda_Paint;
        }

        private void Labda_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
        }

        protected void DrawImage(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.Blue), 0, 0, Width, Height);
        }

        public void MoveBall()
        {
            Left += 1;
        }
    }
}
