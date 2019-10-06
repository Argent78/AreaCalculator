using System;
using AreaCalculator.Data;
using AreaCalculator.Shapes;

namespace AreaCalculator.Commands
{
    public class CircleCommand : Command
    {
        private readonly IDataHandler _dataHandler;

        public CircleCommand(Func<IShape, string> consoleFormatter, Action errorConsoleOutputter, IDataHandler dataHandler) : base(consoleFormatter, errorConsoleOutputter)
        {
            _dataHandler = dataHandler;
        }

        public override void Execute()
        {
            Console.WriteLine();
            Console.WriteLine("Enter the diameter of the circle: ");
            var response = Console.ReadLine();
            if (double.TryParse(response, out var diameter))
            {
                var circle = new Circle(diameter);
                Console.WriteLine(ConsoleFormatter(circle));
                _dataHandler.SaveDataAsync(circle);// no need to await this call, as there is no further control flow to return to
            }
            else
            {
                ErrorConsoleOutputter();
            }
        }
    }
}
