using _6gyakorlat_X8O30D.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6gyakorlat_X8O30D
{
    public partial class Form1 : Form
    {
        List<Ball>_balls=new List<Ball>();

        private BallFactory _factory;
        public BallFactory Factory
        {
            get { return _factory; }
            set { _factory = value; }
        }

        public Form1()
        {
            InitializeComponent();
            Factory = new BallFactory();
        }
      

        private void createTimer_Tick(object sender, EventArgs e)
        {
            var ball = Factory.CreateNew();
            _balls.Add(ball);
            mainpanel.Controls.Add(ball);
            ball.Left = -Width;
        }

        private void conveyorTimer_Tick(object sender, EventArgs e)
        {
            var pozi = 0;
            foreach (var ball in _balls)
            {
                ball.MoveBall();
                if (ball.Left > pozi)
                {
                    pozi = ball.Left;
                }
            }
            if (pozi>1000)
            {
                var torlendo = _balls[0];
                _balls.Remove(torlendo);
                mainpanel.Controls.Remove(torlendo);
            }
        }
    }
}
