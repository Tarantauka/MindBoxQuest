using FigureCalc.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace MindBoxQuest
{
    public class MyBuisnessLogicFigure : CalculatedFigure<MyBuisnessLogicFigure, int>
    {
        public string Side { get; set; }
        public string Height { get; set; }
        public override int CalculateArea()
        {
            int.TryParse(Side, out var sideLength);
            int.TryParse(Height, out var heightLength);
            return (sideLength * heightLength);
        }
    }
}
