using System;
using AreaCalculator.Data;
using AreaCalculator.Shapes;

namespace AreaCalculator.Commands
{
    public class TriangleCommand : Command
    {
        private readonly IDataHandler _dataHandler;

        public TriangleCommand(Func<IShape, string> consoleFormatter, Action errorConsoleOutputter, IDataHandler dataHandler) : base (consoleFormatter, errorConsoleOutputter)
        {
            _dataHandler = dataHandler;
        }

        public override void Execute()
        {
            Console.WriteLine();
            Console.WriteLine("Enter the width of the base: ");
            var baseResponse = Console.ReadLine();

            Console.WriteLine("Enter the height of the triangle: ");
            var heightResponse = Console.ReadLine();

            if (double.TryParse(baseResponse, out var width) && double.TryParse(heightResponse, out var height))
            {
                var triangle = new Triangle(width, height);
                Console.WriteLine(ConsoleFormatter(triangle));
                _dataHandler.SaveDataAsync(triangle);
            }
            else
            {
                ErrorConsoleOutputter();
            }
        }

    }
}
