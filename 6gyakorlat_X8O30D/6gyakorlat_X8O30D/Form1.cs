using _6gyakorlat_X8O30D.Abstractions;
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
        List<Toy> _toys=new List<Toy>();

        private Toy _nextToy;

        private IToyFactory _factory;
        public IToyFactory Factory
        {
            get { return _factory; }
            set 
            { 
                _factory = value;
                DisplayNext();
            }
        }

        public Form1()
        {
            InitializeComponent();
            Factory = new BallFactory();
        }

        private void createTimer_Tick(object sender, EventArgs e)
        {
            var toy = Factory.CreateNew();
            mainpanel.Controls.Add(toy);
            toy.Left = -Width;
            toy.Top = 200;
            _toys.Add(toy);
        }

        private void conveyorTimer_Tick(object sender, EventArgs e)
        {
            var pozi = 0;
            foreach (var toy in _toys)
            {
                toy.MoveToy();
                if (toy.Left > pozi)
                {
                    pozi = toy.Left;
                }
            }
            if (pozi > 1000)
            {
                var torlendo = _toys[0];
                _toys.Remove(torlendo);
                mainpanel.Controls.Remove(torlendo);
            }
        }
                
        private void carbutton_Click(object sender, EventArgs e)
        {
            Factory = new CarFactory();
        }

        private void ballbutton_Click(object sender, EventArgs e)
        {
            Factory = new BallFactory()
            {
                BallColor = button1.BackColor
            };

        }

        private void presentbutton_Click(object sender, EventArgs e)
        {
            Factory = new PresentFactory()
            {
                RibbonColor = ribbonbutton.BackColor,
                BoxColor = boxbutton.BackColor
            };
        }

        void DisplayNext()
        {
            if (_nextToy != null)
                Controls.Remove(_nextToy);
            _nextToy = Factory.CreateNew();
            _nextToy.Top = label1.Top + label1.Height + 20;
            _nextToy.Left = label1.Left;
            Controls.Add(_nextToy);
            mainpanel.Controls.Add(_nextToy);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var colorPicker = new ColorDialog();
            colorPicker.Color = button1.BackColor;
            if (colorPicker.ShowDialog() !=DialogResult.OK)
            {
                return;
            }
            button.BackColor = colorPicker.Color;
        }

        
    }
}
