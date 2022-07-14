using FigureCalc.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FigureCalc.Implementation
{
    public class FigureCalculator
    {
        public static TT CalculateArea<T, TT>(CalculatedFigure<T, TT> obj)
        {
            return obj.CalculateArea();
        }

        public bool Has90Angle(BaseTriangle obj)
        {
            return obj.Has90Angle();
        }
    }
}
