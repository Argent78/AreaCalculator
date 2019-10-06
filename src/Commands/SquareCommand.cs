using System;
using AreaCalculator.Data;
using AreaCalculator.Shapes;

namespace AreaCalculator.Commands
{
    public class SquareCommand : Command
    {
        private readonly IDataHandler _dataHandler;

        public SquareCommand(Func<IShape, string> consoleFormatter, Action errorConsoleOutputter, IDataHandler dataHandler) : base(consoleFormatter, errorConsoleOutputter)
        {
            _dataHandler = dataHandler;
        }

        public override void Execute()
        {
            Console.WriteLine();
            Console.WriteLine("Enter the width of one side: ");
            var response = Console.ReadLine();
            if (double.TryParse(response, out var width))
            {
                var square = new Square(width);
                Console.WriteLine(ConsoleFormatter(square));
                _dataHandler.SaveDataAsync(square);
            }
            else
            {
                ErrorConsoleOutputter();
            }
        }
    }
}
