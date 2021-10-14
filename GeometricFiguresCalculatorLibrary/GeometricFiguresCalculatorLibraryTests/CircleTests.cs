using GeometricFiguresCalculatorLibrary.Entites;
using Moq;
using System;
using Xunit;

namespace GeometricFiguresCalculatorLibraryTests
{
    public class CircleTests
    {
        [Fact]
        public void ConstructorShouldFailIfIncorrectInput()
        {
            double radius = -5;

            Assert.Throws<ArgumentException>(() =>
            {
                var circle = new Circle(radius);
            });
        }

        [Fact]
        public void SquareShouldReturnPIIfSideIsEqualsOne()
        {
            double radius = 1;
            var expectedSquare = 3.1415;

            var circle = new Circle(radius);

            Assert.Equal(expectedSquare, circle.getSquare());
        }
    }
}
