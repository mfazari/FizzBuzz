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

}
