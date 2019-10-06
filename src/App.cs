using System;
using AreaCalculator.Commands;

namespace AreaCalculator
{
    /**
     * The main application class
     * TODO: This class is too tightly-coupled to the UI-render. Consider refactoring console interaction to a seperate class
     */
    public class App
    {
        private readonly CircleCommand _circleCommand;
        private readonly TriangleCommand _triangleCommand;
        private readonly SquareCommand _squareCommand;
        private readonly NoneCommand _noneCommand;

        // The App class accepts its commands via constructor-injection
        public App(CircleCommand circleCommand, TriangleCommand triangleCommand, SquareCommand squareCommand, NoneCommand noneCommand)
        {
            _circleCommand = circleCommand;
            _triangleCommand = triangleCommand;
            _squareCommand = squareCommand;
            _noneCommand = noneCommand;
        }

        public void Run()
        {
            DisplayMenuOptions();
            var menuOption = GetUserSelection();

            ICommand shapeCommand = menuOption switch
            {
                MenuOptions.Circle => _circleCommand,
                MenuOptions.Triangle => _triangleCommand,
                MenuOptions.Square => _squareCommand,
                _ => _noneCommand,
            };

            shapeCommand.Execute();
        }

        private static MenuOptions GetUserSelection()
        {
            var selection = Console.ReadLine();
            Enum.TryParse<MenuOptions>($"{selection}", out var menuOption);
            return menuOption;
        }

        private static void DisplayMenuOptions()
        {
            Console.WriteLine(" -= Welcome to the shape area calculator =-");
            Console.WriteLine("\n");
            Console.WriteLine("Select from the following shapes:");
            Console.WriteLine("\t1: Circle");
            Console.WriteLine("\t2: Triangle");
            Console.WriteLine("\t3: Square");
            Console.Write("\n> ");
        }
    }
}
