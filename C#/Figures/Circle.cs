namespace Figures
{
    public class Circle : IFigure
    {
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException(
                    $"The {nameof(radius)} argument must be greather than zero.");

            this.radius = radius;
        }

        private readonly double radius;

        public double CalculateArea() => radius * radius * Math.PI;
    }
}
