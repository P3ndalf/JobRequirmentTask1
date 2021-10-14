using GeometricFiguresCalculatorLibrary.Abstractions;
using System;

namespace GeometricFiguresCalculatorLibrary.Entites
{
    public class Circle : IFigure
    {
        private double _radius;
        private const double _pi = 3.1415;
        private double _square;
        private double _perimeter;
        
        public Circle(double radius)
        {
            if (radius < 0) throw new ArgumentException(nameof(radius));
            _radius = radius;
            _perimeter = searchPerimeter();
            _square = searchSquare();
        }

        public double searchSquare()
        {
            double square = _radius * _radius * _pi;
            return square;
        }

        public double searchPerimeter()
        {
            double perimeter = 2 * _pi * _radius;
            return perimeter;
        }

        public double getSquare()
        {
            return _square;
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public double getPerimeter()
        {
            return _perimeter;
        }

        public void printInfo()
        {
            Console.WriteLine("Radius = {0:f2}",_radius);
            Console.WriteLine("Square = {0:f3}",_square);
            Console.WriteLine("Perimeter = {0:f3}",_perimeter);
        }

     
    }
}
