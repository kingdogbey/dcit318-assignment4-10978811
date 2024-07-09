﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrawingApp
{
    public partial class Form3 : Form
    {
        private bool isDrawing;
        private Point lastPoint;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            lastPoint = e.Location;
        }

        private void Form3_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                using (Graphics g = this.CreateGraphics())
                {
                    g.DrawLine(Pens.Black, lastPoint, e.Location);
                }
                lastPoint = e.Location;
            }
        }

        private void Form3_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }
    }
}
