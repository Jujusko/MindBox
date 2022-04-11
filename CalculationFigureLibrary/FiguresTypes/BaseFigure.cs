using CalculationFigureLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationFigureLibrary.FiguresTypes
{
    public class BaseFigure : AbstractFigure
    {
        //Как фигуру без типа выбрал просто квадрат. 
        private double FirstSide { get; set; }
        private double SecondSide { get; set; }
        private double Square { get; set; }

        public BaseFigure (double a, double b)
        {
            FirstSide = a;
            SecondSide = b;
            if (!IsValid())
                throw new ArgumentException("Bad Args");
        }
        public override double GetSquare()
        {
            Square = FirstSide * SecondSide;
            return Square;
        }

        protected override bool IsValid()
        {
            if (FirstSide <= 0 || SecondSide <= 0)
                return false;
            return true;
        }

    }
}
