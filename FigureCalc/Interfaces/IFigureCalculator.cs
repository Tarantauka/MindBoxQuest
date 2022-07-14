using System;
using System.Collections.Generic;
using System.Text;

namespace FigureCalc.Interfaces
{
    public interface IFigureCalculator<T>
    {
        decimal CalculateArea(T obj);
    }
}
