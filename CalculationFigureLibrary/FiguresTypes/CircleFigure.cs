using CalculationFigureLibrary.Interfaces;
using static System.Math;

namespace CalculationFigureLibrary.FiguresTypes
{
    public class CircleFigure : AbstractFigure, ICircle
    {
        public double Radius { get; }

        public CircleFigure(int radius)
        {
            this.Radius = radius;
            if (!IsValid())
                throw new ArgumentException("BadArgs");
        }
        public override double GetSquare()
        {
            return Round(PI * Pow(Radius, 2), 2);
        }

        protected override bool IsValid()
        {
            if (Radius <= 0)
                return false;
            return true;
        }
    }
}
