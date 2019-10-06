using Newtonsoft.Json;

namespace AreaCalculator.Shapes
{
    public interface IShape
    {
        string Name { get; }
        double Area { get; }

        [JsonIgnore]
        string Dimensions { get; }
    }
}
