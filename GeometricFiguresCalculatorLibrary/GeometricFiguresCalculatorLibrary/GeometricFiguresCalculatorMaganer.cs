using GeometricFiguresCalculatorLibrary.Abstractions;
using GeometricFiguresCalculatorLibrary.Entites;

namespace GeometricFiguresCalculatorLibrary
{
    public class GeometricFiguresCalculatorMaganer : IGeometricFiguresCalculatorManager
    {
        private IFigure _figure;

        public GeometricFiguresCalculatorMaganer()
        {

        }

        public void initializeCircle(double radius)
        {
            _figure = new Circle(radius);
            _figure.printInfo();
        }

        public void initializeTriangle(double[] sides)
        {
            _figure = new Triangle(sides);
            _figure.printInfo();
        }
    }
}
