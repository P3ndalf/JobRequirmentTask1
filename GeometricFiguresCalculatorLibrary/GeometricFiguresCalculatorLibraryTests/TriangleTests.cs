using GeometricFiguresCalculatorLibrary.Entites;
using System;
using Xunit;

namespace GeometricFiguresCalculatorLibraryTests
{
    public class TriangleTests
    {
        [Fact]
        public void ConstructorShouldFailIfSidesNumberIsIncorrect()
        {
            double[] sides = { 1.2 };

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var triangle = new Triangle(sides);
            });
        }
    }
}
