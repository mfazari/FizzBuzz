using FizzBuzz;

namespace FizzBuzzTest;

public class FizzBuzzServiceTest
{
    [Fact]
    public void TestFizzOutput()
    {
        // Arrange
        var fizzBuzzService = new FizzBuzzService();

        // Act
        var result = fizzBuzzService.GetResult(3);

        // Assert
        Assert.Equal("Fizz", result);
    }

    [Fact]
    public void TestFizzBuzzOutput()
    {
        // Arrange
        var fizzBuzzService = new FizzBuzzService();

        // Act
        var result = fizzBuzzService.GetResult(15);

        // Assert
        Assert.Equal("FizzBuzz", result);
    }

    [Fact]
    public void TestBuzzOutput()
    {
        // Arrange
        var fizzBuzzService = new FizzBuzzService();

        // Act
        var result = fizzBuzzService.GetResult(5);

        // Assert
        Assert.Equal("Buzz", result);
    }

    [Fact]
    public void TestNumberOutput()
    {
        // Arrange
        var fizzBuzzService = new FizzBuzzService();

        // Act
        var result = fizzBuzzService.GetResult(2);

        // Assert
        Assert.Equal("2", result);
    }

}
