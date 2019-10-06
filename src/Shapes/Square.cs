using System;

namespace AreaCalculator.Shapes
{
    internal class Square : Shape
    {
        private readonly double _width;

        public Square(double width)
        {
            _width = Math.Abs(width);
        }

        public override double Area => _width * _width;
        public override string Dimensions => $"sides of {_width}";
    }
}