using Figures;

namespace FiguresTests
{
    public class CircleTest
    {
        [Fact]
        public void TestCalculateArea()
        {
            var circle = new Circle(2);
            var expectedArea = 12.5663;

            var actualArea = circle.CalculateArea();

            Assert.Equal(expectedArea, actualArea, 0.0001);
        }
    }
}
