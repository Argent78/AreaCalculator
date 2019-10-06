using System;
using AreaCalculator.Shapes;

namespace AreaCalculator.Commands
{
    /**
     * Common functionality across all commands
     */
    public abstract class Command : ICommand
    {
        protected readonly Func<IShape, string> ConsoleFormatter;
        protected readonly Action ErrorConsoleOutputter;

        protected Command(Func<IShape, string> consoleFormatter, Action errorConsoleOutputter)
        {
            ConsoleFormatter = consoleFormatter;
            ErrorConsoleOutputter = errorConsoleOutputter;
        }

        public abstract void Execute();
    }
}
