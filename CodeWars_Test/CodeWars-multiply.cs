using CodeWars;

namespace CodeWars_Test
{
    public class CodeWars_multiply
    {
        [Fact]
        public void ShouldDisplay15()
        {
            // Arrange
            var result = 15;
            CodeWarsGame codeWars = new();

            // Act
            var test = 3;
            var testedValue = codeWars.Multiply(test);

            // Assert
            Assert.Equal(testedValue, result);
        }

        [Fact]
        public void ShouldDisplay25000()
        {
            // Arrange
            var result = 25000;
            CodeWarsGame codeWars = new();

            // Act
            var test = 200;
            var testedValue = codeWars.Multiply(test);

            // Assert
            Assert.Equal(testedValue, result);
        }

        [Fact]
        public void ShouldDisplay0()
        {
            // Arrange
            var result = 0;
            CodeWarsGame codeWars = new();

            // Act
            var test = 0;
            var testedValue = codeWars.Multiply(test);

            // Assert
            Assert.Equal(testedValue, result);
        }

        [Fact]
        public void ShouldDisplayMinus15()
        {
            // Arrange
            var result = -15;
            CodeWarsGame codeWars = new();

            // Act
            var test = -3;
            var testedValue = codeWars.Multiply(test);

            // Assert
            Assert.Equal(testedValue, result);
        }

    }
}
