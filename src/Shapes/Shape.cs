namespace AreaCalculator.Shapes
{
    internal abstract class Shape : IShape
    {
        public string Name => GetType().Name;
        public abstract double Area { get; }
        public abstract string Dimensions { get; }
    }
}
