using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculationFigureLibrary.Interfaces;

namespace CalculationFigureLibrary.FiguresTypes
{
    public class TriangleFigure : AbstractFigure, ITriangle
    {
        public double Side { get; }
        public double SecondSide { get; }
        public double ThirdSide { get; }
        public double Square { get; private set; }

        public TriangleFigure(double side, double secondSide, double thirdSide)
        {
            Side = side;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
            if (!IsValid())
                throw new ArgumentException("Bad params");
        }

        public override double GetSquare()
        {
            if (!isRectangular())
                Square = BaseSquare();
            else
                Square = RecatngleSquare();

            if (Square == double.NaN || Square == 0/* case 1,2,3*/)
                throw new Exception("Bad values");
            Square = Math.Round(Square, 2);
            return Square;
        }

        private double BaseSquare()
        {
            double p = (Side + SecondSide + ThirdSide) / 2;
            
            var a = Math.Sqrt(p * (p - Side) * (p - SecondSide) * (p - ThirdSide));
            return Math.Sqrt(p * (p - Side) * (p - SecondSide) * (p - ThirdSide));
        }
        private double RecatngleSquare()
        {
            List<double> sides = new List<double> { Side, SecondSide, ThirdSide };
            var maxLen = sides.Max();
            sides.Remove(maxLen);
            return sides[0] * sides[1] / 2;
        }
        public bool isRectangular()
        {
            List<double> sides = new List<double> { Side, SecondSide, ThirdSide};
            var maxLen = sides.Max();
            sides.Remove(maxLen);
            if (maxLen * maxLen == sides[0] * sides[0] + sides[1] * sides[1])
                return true;
            return false;
        }

        protected override bool IsValid()
        {
            if (Side <= 0  || SecondSide <= 0 || ThirdSide <= 0)
                return false;
            return true;
        }
    }
}
