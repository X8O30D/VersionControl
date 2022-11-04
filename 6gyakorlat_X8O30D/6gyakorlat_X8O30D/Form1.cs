﻿using _6gyakorlat_X8O30D.Abstractions;
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

        private IToyFactory _factory;
        public IToyFactory Factory
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
            var toy = Factory.CreateNew();
            _toys.Add(toy);
            mainpanel.Controls.Add(toy);
            toy.Left = -Width;
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
            if (pozi>1000)
            {
                var torlendo = _toys[0];
                _toys.Remove(torlendo);
                mainpanel.Controls.Remove(torlendo);
            }
        }
    }
}
