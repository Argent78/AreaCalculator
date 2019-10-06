using System;

namespace AreaCalculator.Shapes
{
    internal class Circle : Shape
    {
        private readonly double _diameter;
        private readonly double _radius;

        public Circle(double diameter)
        {
            _diameter = Math.Abs(diameter);
            _radius = diameter / 2;
        }

        public override double Area => Math.Round(Math.PI * (_radius * _radius), 2, MidpointRounding.ToEven);
        public override string Dimensions => $"diameter of {_diameter}";
    }
}
