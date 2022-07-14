using FigureCalc.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FigureCalc.Implementation
{
    public class CalculatedFigure<T, TT> : ICalculatedFigure<T, TT>
    {
        public virtual TT CalculateArea()
        {
            return default;
        }
    }
}
