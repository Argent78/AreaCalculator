using System;

namespace AreaCalculator.Commands
{
    public class NoneCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine();
            Console.WriteLine("Invalid selection.");
        }
    }
}
