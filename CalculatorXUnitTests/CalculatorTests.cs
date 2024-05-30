using ClassModels;

namespace CalculatorXUnitTests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(3,5)]

        public void Add_TwoInts_ReturnSum(int x, int y)
        {
            
            var expected = x + y;

            // Act
            var result = Calculator.Add(x, y);

            // Assert

            Assert.Equal(expected, result);
        }
    }
}