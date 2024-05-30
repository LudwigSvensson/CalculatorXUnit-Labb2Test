using ClassModels;

namespace CalculatorXUnitTests
{
    public class CalculatorTests
    {
        private readonly Calculator _calc;
        private readonly UserManager _userManager;
        private readonly Menu _menu;

        public CalculatorTests()
        {
            _calc = new Calculator();
            _userManager = new UserManager();
            _menu = new Menu();
        }

        [Theory]
        [InlineData(5,3)]
        [InlineData(10, 4)]
        [InlineData(2, 1)]
        [InlineData(4, 4)]

        public void Add_TwoInts_ReturnSum(int x, int y)
        {
            //Arrange
            var expected = x + y;

            // Act
            var result = _calc.Add(x, y);

            // Assert

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(5, 3)]
        [InlineData(10,4)]
        [InlineData(2, 1)]
        [InlineData(4, 4)]

        public void Subtract_TwoInts_ReturnSum(int x, int y)
        {
            //Arrange
            var expected = x - y;

            // Act
            var result = _calc.Subtract(x, y);

            // Assert

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(5, 3)]
        [InlineData(10, 4)]
        [InlineData(2, 1)]
        [InlineData(4, 4)]

        public void Multiply_TwoInts_ReturnSum(int x, int y)
        {
            //Arrange
            var expected = x * y;

            // Act
            var result = _calc.Multiply(x, y);

            // Assert
            
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(10, 4)]
        [InlineData(2, 1)]
        [InlineData(4, 4)]
        [InlineData(100, 10)]
        [InlineData(25, 1)]

        public void Divide_TwoInts_ReturnSum(int x, int y)
        {
            //Arrange
            var expected = x / y;

            // Act
            var result = _calc.Divide(x, y);

            // Assert

            Assert.Equal(expected, result);
        }

 

    }
}