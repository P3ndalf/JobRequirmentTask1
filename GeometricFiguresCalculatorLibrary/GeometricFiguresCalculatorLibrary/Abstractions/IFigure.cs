using System;

namespace GeometricFiguresCalculatorLibrary.Abstractions
{
    public interface IFigure
    {
        public double searchSquare();

        public double searchPerimeter();

        public double getSqare();

        public double getPerimeter();

        public void printInfo();
    }
}
