﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using System.Windows.Shapes;

namespace WpfApp6 {
    public class Ball : ICanvasObject {
        public double X { get; set; }
        public double Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Canvas Canvas { get; set; }
        public double Angle { get; set; }
        public int DirectionX { get; set; }
        public int DirectionY { get; set; }
        public Ellipse Shape { get; set; }
        public double Speed { get; set; }

        public Ball(int width, int height, Canvas canvas) {
            Width = width;
            Height = height;
            Canvas = canvas;
            Shape = new Ellipse() {
                Width = width,
                Height = height,
                Fill = new SolidColorBrush(Colors.White),
            };
            Reset();
            Canvas.Children.Add(Shape);
        }

        public void Draw() {
            Canvas.SetLeft(Shape, X);
            Canvas.SetTop(Shape, Y);
        }

        public void Move() {
            X += Math.Cos(Angle) * Speed * DirectionX;
            Y += Math.Sin(Angle) * Speed * DirectionY;
            if (Y + Width >= Canvas.Height || Y - Height <= 0)
                DirectionY *= -1;
            Draw();
        }

        public void Reset() {
            X = Canvas.Width / 2 - Width / 2;
            Y = Canvas.Height / 2 - Height / 2;
            DirectionX = 1;
            DirectionY = 1;
            Random r = new();
            Angle = r.Next(30, 60) * Math.PI / 180;
            Speed = 3;
        }
    }
}
