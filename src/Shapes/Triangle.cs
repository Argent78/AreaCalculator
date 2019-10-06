using System;

namespace AreaCalculator.Shapes
{
    internal class Triangle : Shape
    {
        private readonly double _width;
        private readonly double _height;

        public Triangle(double width, double height)
        {
            _width = Math.Abs(width);
            _height = Math.Abs(height);
        }

        public override double Area => (_width / 2) * _height;

        public override string Dimensions => $"base of {_width} and height of {_height}";
    }
}