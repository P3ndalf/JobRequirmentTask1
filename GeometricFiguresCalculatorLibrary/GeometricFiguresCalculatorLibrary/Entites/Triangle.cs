using GeometricFiguresCalculatorLibrary.Abstractions;
using System;

namespace GeometricFiguresCalculatorLibrary.Entites
{
    public class Triangle : IFigure
    {
        private double[] _sides;
        private double _square;
        private double _perimeter;

        public Triangle(double[] sides)
        {
            if (sides.Length != 3) throw new ArgumentOutOfRangeException(nameof(sides));
            _sides = sides;
            _perimeter = searchPerimeter();
            _square = searchSquare();
        }

        private bool checkIfTriangleRight()
        {
            // a^2 = b^2 + c^2
            double gipotenuza = _sides[getBiggestSideIndex()];
            double leftPifagor = gipotenuza * gipotenuza;
            double rightPifagor = 0;
            for (int i = 0; i < _sides.Length; i++)
            {
                if(i != getBiggestSideIndex())
                {
                    rightPifagor += _sides[i] * _sides[i];
                }
            }
            return (leftPifagor == rightPifagor) ? true : false;
        }
        
        private int getBiggestSideIndex()
        {
            double max = _sides[0];
            int index = 0;
            for(int i = 0; i < _sides.Length; i++)
            {
                if(_sides[i] > max)
                {
                    max = _sides[i];
                    index = i;
                }
            }
            return index;
        }

        public double searchSquare()
        {
            double halfPerimeter = _perimeter / 2;
            double square = halfPerimeter;
            foreach(double side in _sides)
            {
                square *= (halfPerimeter - side);
            }
            square = Math.Sqrt(square);
            return square;
        }

        public double searchPerimeter()
        {
            double perimeter = 0;
            foreach(double side in _sides)
            {
                perimeter += side;
            }
            return perimeter;
        }

        public double getSquare()
        {
            return _square;
        }

        public double getPerimeter()
        {
            return _perimeter;
        }

        public void printInfo()
        {
            Console.WriteLine("Sides = {0:f2} {1:f2} {2:f2}",_sides[0],_sides[1],_sides[2]);
            Console.WriteLine("Square = {0:f3}",_square);
            Console.WriteLine("Perimeter = {0:f3}",_perimeter);
            Console.WriteLine(checkIfTriangleRight() ? "Triangle is right" : "Triangle is not a right");
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        
    }
}
