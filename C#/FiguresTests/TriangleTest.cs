using Figures;

namespace FiguresTests
{
    public class TriangleTest
    {
        [Fact]
        public void TestCalculateArea()
        {
            var triangle = new Triangle(3, 4, 5);
            var expectedArea = 6.0;

            var actualArea = triangle.CalculateArea();

            Assert.Equal(expectedArea, actualArea, 0.0001);
        }

        [Fact]
        public void TestIsRectangular()
        {
            var triangle = new Triangle(3, 4, 5);

            Assert.True(triangle.IsRectangular());
        }

        [Fact]
        public void TestIsNotRectangular()
        {
            var triangle = new Triangle(3, 4, 6);

            Assert.False(triangle.IsRectangular());
        }
    }
}
