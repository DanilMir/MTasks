using System.Collections;

namespace Geometry;

public class Triangle : Figure
{
    public readonly double A;
    public readonly double B;
    public readonly double C;
    
    private const double Eps = 1e-9;
    
    public Triangle(double a, double b, double c)
    {
        if (a < 0) throw new ArgumentException("A side should not be negative");
        if (b < 0) throw new ArgumentException("B side should not be negative");
        if (c < 0) throw new ArgumentException("C side should not be negative");

        if (!IsTriangleExist(a, b, c))
        {
            throw new ArgumentException($"Triangle with slides {a}, {b}, {c} not exist");
        }
        
        A = a;
        B = b;
        C = c;
    }

    private bool IsTriangleExist(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a;
    }

    public override double GetSquare()
    {
        var semiPerimeter = (A + B + C) / 2;
        var square = Math.Sqrt(semiPerimeter * (semiPerimeter - A) * (semiPerimeter - B) * (semiPerimeter - C));
        return square;
    }

    public bool IsRightAngled()
    {
        var slides =  new double[] { A, B, C };
        Array.Sort(slides);

        return Math.Abs(slides[0] * slides[0] + slides[1] * slides[1] - slides[2] * slides[2]) < Eps;
    }
}