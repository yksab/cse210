using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> _shapes = new List<Shape>();
        
        Square s1 =new Square("green", 4);
        _shapes.Add(s1);

        Rectangle s2 = new Rectangle("green", 5, 4);
        _shapes.Add(s2);

        Circle s3 = new Circle("orange", 3);
        _shapes.Add(s3);

        foreach (Shape s in _shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.Writeline($"The {color} shape has an area of {area}.");
        }
    }
}