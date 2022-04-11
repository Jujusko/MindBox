using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationFigureLibrary.Interfaces
{
    public interface ITriangle
    {
        public double Side { get; }
        public double SecondSide { get; }
        public double ThirdSide { get; }
    }
}
