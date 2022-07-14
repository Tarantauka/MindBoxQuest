using System;
using System.Collections.Generic;
using System.Text;

namespace FigureCalc.Interfaces
{
    internal interface ICalculatedFigure<T, TT>
    {
        TT CalculateArea();
    }
}
