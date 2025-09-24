using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction basky = new Fraction(1,3);

        Console.WriteLine(basky.GetFractionString());
        Console.WriteLine(basky.GetDecimalValue());
    }
}