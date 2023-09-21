namespace Geometry;

public class Circle : Figure
{
    public readonly double Radius;
    
    public Circle(double radius)
    {
        if (radius < 0)
        {
            throw new ArgumentException("Radius should not be negative");
        }
        Radius = radius;
    }
    
    public override double GetSquare()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}
