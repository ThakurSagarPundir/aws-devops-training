using DevOpsApi;

namespace DevOpsApi.Tests;

public class CalculatorTests
{
    [Fact]
    public void Add_TwoNumbers_ReturnsSum()
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        var result = calculator.Add(10, 20);

        // Assert
        Assert.Equal(30, result);
    }
}
