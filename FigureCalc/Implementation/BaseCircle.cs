using System;
using System.Collections.Generic;
using System.Text;

namespace FigureCalc.Implementation
{
    public class BaseCircle : CalculatedFigure<BaseCircle, double>
    {
        public double Radius { get; set; }

        public override double CalculateArea()
        {
            return Radius * Math.PI;
        }
    }
}
