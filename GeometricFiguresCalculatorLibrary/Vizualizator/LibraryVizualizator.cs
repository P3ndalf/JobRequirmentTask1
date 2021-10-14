using GeometricFiguresCalculatorLibrary;
using GeometricFiguresCalculatorLibrary.Abstractions;
using System;

namespace Vizualizator
{
    class LibraryVizualizator
    {
        private static readonly IGeometricFiguresCalculatorManager _libraryManager = new GeometricFiguresCalculatorMaganer();
        static void Main(string[] args)
        {
            String[] desicions = new string[] { "Circle", "Triangle" };
            Printer printer = new Printer(desicions, _libraryManager);
            printer.Start();
        }
    }
}
