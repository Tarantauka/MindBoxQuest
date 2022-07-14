using FigureCalc.Implementation;
using FigureCalc.Interfaces;
using System;

namespace MindBoxQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var test = FigureCalculator.CalculateArea(new BaseCircle() {Radius = 14 });
            var test2 = FigureCalculator.CalculateArea(new BaseTriangle() {SideA = 1, SideB = 2, SideC = 3 });
            var test3 = FigureCalculator.CalculateArea(new MyBuisnessLogicFigure() {Height = "12", Side = "10" });
            var test4 = FigureCalculator.Has90Angle(new BaseTriangle() { SideA = 1, SideB = 2, SideC = 3 });
            Console.WriteLine(test);
            Console.WriteLine(test2);
            Console.WriteLine(test3);
            Console.WriteLine(test4);
        }
    }
}
