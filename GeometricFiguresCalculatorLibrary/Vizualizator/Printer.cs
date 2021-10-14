using GeometricFiguresCalculatorLibrary.Abstractions;
using System;

namespace Vizualizator
{
    class Printer
    {
        private int _desicionsNumber;
        private string[] _desicions;
        private int _currentDesicionPosition;
        private readonly IGeometricFiguresCalculatorManager _libraryManager;

        public Printer(String[] desicions, IGeometricFiguresCalculatorManager libraryManager)
        {
            _desicionsNumber = desicions.Length;
            _desicions = desicions;
            _currentDesicionPosition = 0;
            _libraryManager = libraryManager;
        }

        public void Start()
        {
            if (_desicionsNumber != 0)
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Choose the figure you want to work with...or Press esc");

                    for (int i = 0; i < _desicionsNumber; i++)
                    {
                        Console.SetCursorPosition(0, i + 1);
                        if (i == _currentDesicionPosition)
                        {
                            Console.WriteLine("=> " + _desicions[i]);
                        }
                        else
                        {
                            Console.WriteLine("   " + _desicions[i]);
                        }
                                                  
                    }
                    ConsoleKey key = Console.ReadKey().Key;
                    if (key == ConsoleKey.Escape) return;
                    scrollDecisions(key);
                }
            }
        }

        private void scrollDecisions(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.S:
                case ConsoleKey.DownArrow:
                    {
                        if (_currentDesicionPosition < _desicionsNumber - 1) _currentDesicionPosition++;
                        else if(_currentDesicionPosition == _desicionsNumber - 1) _currentDesicionPosition = 0;
                        break;
                    }
                case ConsoleKey.W:
                case ConsoleKey.UpArrow:
                    {
                        if (_currentDesicionPosition > 0) _currentDesicionPosition--;
                        else if (_currentDesicionPosition == 0) _currentDesicionPosition = _desicionsNumber - 1;
                        break;
                    }
                case ConsoleKey.Enter:
                    {
                        Console.Clear();
                        chooseDesicion(_currentDesicionPosition);
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        private void chooseDesicion(int currentDesicionPosition)
        {
            switch (currentDesicionPosition)
            {
                case 0:
                    {
                        Console.Write("Enter radius of your circle -> ");
                        int circleRadius;
                        try
                        {
                            circleRadius = int.Parse(Console.ReadLine());
                        }
                        catch(NullReferenceException exc)
                        {
                            Console.WriteLine(exc.Message);
                            break;
                        }
                        
                        _libraryManager.initializeCircle(circleRadius);
                        Console.Write("Press any button...");
                        Console.ReadKey();
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("Enter side lengthes of your triangle like : a b c -> ");
                        String[] lengthesInString = Console.ReadLine().Split(" ");
                        int arraySize = lengthesInString.Length;
                        double[] triangleSideLengthes = new double[arraySize];
                        try
                        {
                            for (int i = 0; i < arraySize; i++)
                            {
                                triangleSideLengthes[i] = double.Parse(lengthesInString[i]);
                            }
                        }
                        catch (NullReferenceException exc)
                        {
                            Console.WriteLine(exc.Message);
                            break;
                        }
                        
                        
                        _libraryManager.initializeTriangle(triangleSideLengthes);
                        Console.Write("Press any button...");
                        Console.ReadKey();
                        break;
                    }
            }
        }
    }
}
