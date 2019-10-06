using AreaCalculator.Commands;
using AreaCalculator.Shapes;
using Microsoft.Extensions.DependencyInjection;
using System;
using AreaCalculator.Data;

namespace AreaCalculator
{
    /**
     * Entry point for the executable.
     *
     * Registers services with the DI container, resolves an instance of the app class and invokes the Run method
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<CircleCommand>()
                .AddTransient<SquareCommand>()
                .AddTransient<TriangleCommand>()
                .AddTransient<NoneCommand>()
                .AddTransient<Func<IShape, string>>(c => shape => $"Area of a {shape.Name} with {shape.Dimensions} is {shape.Area}")
                .AddTransient<Action>(c => () => Console.WriteLine("Input not a number. Better luck next time"))
                .AddSingleton<IDataHandler, DataHandler>()
                .AddSingleton<App>()
                .BuildServiceProvider();

            serviceProvider.GetService<App>().Run();
        }
    }
}
