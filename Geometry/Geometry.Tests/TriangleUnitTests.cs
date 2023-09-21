namespace Geometry.Tests;

public class TriangleUnitTests
{
    [Theory]
    [InlineData(3, 4, 5, 6)]
    public void GetSquares_ReturnCorrectResult(double a, double b, double c, double expectedResult)
    {
        var triangle = new Triangle(a, b, c);
        var actualResult = triangle.GetSquare();
        Assert.Equal(expectedResult, actualResult, 6);
    }
    
    [Theory]
    [InlineData(3, 4, 5)]
    public void IsRightAngled_ReturnTrue(double a, double b, double c)
    {
        var triangle = new Triangle(a, b, c);
        var actualResult = triangle.IsRightAngled();
        Assert.True(actualResult);
    }
    
    [Theory]
    [InlineData(3, 4, 4)]
    [InlineData(3, 4, 6)]
    public void IsRightAngled_ReturnFalse(double a, double b, double c)
    {
        var triangle = new Triangle(a, b, c);
        var actualResult = triangle.IsRightAngled();
        Assert.False(actualResult);
    }

    [Theory]
    [InlineData(-1, -1, -1)]
    [InlineData(3, -1, -1)]
    [InlineData(3, 4, -1)]
    [InlineData(3, 2, 5)]
    public void Triangle_IncorrectSides_ThrowArgumentException(double a, double b, double c)
    {
        Assert.Throws<ArgumentException>(() => { new Triangle(a, b, c); });
    }
}