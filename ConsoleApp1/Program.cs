// See https://aka.ms/new-console-template for more information
using CalculationFigureLibrary;
using CalculationFigureLibrary.FiguresTypes;

Console.WriteLine("Hello, World!");
AbstractFigure circle = new TriangleFigure(1,2,4);
TriangleFigure w = new(3, 5,  4);
Console.WriteLine(w.GetSquare());
CircleFigure q = new(11);
Console.WriteLine(   q.GetSquare());
