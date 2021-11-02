using Xunit;

namespace UnitTestDemoPartOne.UnitTests
{
    public class GreeterTests
    {
        [Fact]
        private void SayHello_WhenCalledWithAName_ReturnsAGreetingWithThatName()
        {
            // Arrange
            var greeter = new Greeter();

            // Act
            var result = greeter.SayHello("Tom");

            // Assert
            Assert.Equal("Hello, Tom", result);
        }
    }
}