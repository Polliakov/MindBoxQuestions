namespace Figures
{
    public class Triangle : IFigure
    {
        public Triangle(double a, double b, double c)
        {
            if (a <= 0)
                throw new ArgumentException("Argument must be greather than zero.", nameof(a));
            if (b <= 0)
                throw new ArgumentException("Argument must be greather than zero.", nameof(b));
            if (c <= 0)
                throw new ArgumentException("Argument must be greather than zero.", nameof(c));
            if (!(a + b > c && a + c > b && b + c > a))
                throw new ArgumentException($"Triangle with sides {a}, {b}, {c} can't exists");

            this.a = a;
            this.b = b;
            this.c = c;
        }

        private readonly double a;
        private readonly double b;
        private readonly double c;

        /// <summary>
        /// Calculates area by Geron formula.
        /// </summary>
        public double CalculateArea()
        {
            var p = a / 2 + b / 2 + c / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public bool IsRectangular() =>
            (a * a + b * b == c * c) || (a * a + c * c == b * b) || (b * b + c * c == a * a);
    }
}
