namespace Geometry.Tests;

public class CirclesUnitTests
{
    [Theory]
    [InlineData(3, 28.274334)]
    [InlineData(123, 47529.155256)]
    [InlineData(0, 0)]                                                                                                                                                                                                                                  
    [InlineData(1, Math.PI)]                                                                                                                                                                                                                                  
    public void GetSquares_ReturnCorrectResult(double radius, double expectedResult)
    {
        var circle = new Circle(radius);
        var actualResult = circle.GetSquare();
        Assert.Equal(expectedResult, actualResult, 6);
    }

    [Theory]
    [InlineData(-1)]
    public void Circle_IncorrectRadius_ThrowArgumentException(double radius)
    {
        Assert.Throws<ArgumentException>(() => { new Circle(radius); });
    }
}
