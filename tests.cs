using Xunit;

namespace QuadraticEquationTest
{
    public class QuadraticEquationTest
    {
        public void QuadraticEquation1()
        {
            //Arrange

            //Act
            var result1 = QuadraticEquation.Main(1, 4, 1);
            var result2 = QuadraticEquation.Main(1, 1, 1);
            var result3 = QuadraticEquation.Main(1, 2, 1);
            //Assert
            Assert.Equal((x1, x2), result1);
            Assert.Equal("no roots", result2);
            Assert.Equal(-1, result3);
        }
    }
}