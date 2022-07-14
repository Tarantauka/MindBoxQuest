using System;
using System.Collections.Generic;
using System.Text;

namespace FigureCalc.Implementation
{
    public class BaseTriangle : CalculatedFigure<BaseTriangle, double>
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public override double CalculateArea()
        {
            var p = SideA * SideB * SideC;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }
        internal bool Has90Angle()
        {
            if (SideA > SideB && SideA > SideC)
            {
                return Math.Pow(SideA, 2) == Math.Pow(SideB, 2) + Math.Pow(SideC, 2);
            }
            else if (SideB > SideA && SideB > SideC)
            {
                return Math.Pow(SideB, 2) == Math.Pow(SideA, 2) + Math.Pow(SideC, 2);
            }
            else if (SideC > SideA && SideC > SideB)
            {
                return Math.Pow(SideC, 2) == Math.Pow(SideA, 2) + Math.Pow(SideB, 2);
            }
            else
                return false;
        }
    }
}
