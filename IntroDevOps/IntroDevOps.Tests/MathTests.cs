using IntroDevOps.math;
using Xunit;

namespace IntroDevOps.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(5, 5)]
        [InlineData(2, 8)]
        [InlineData(3, 7)]
        [InlineData(10, 0)]
        public void TestSumar(int num1, int num2)
        {
            //Arranque
            var expected = 10;

            //Act
            var resultado = Calculadora.sumar(num1, num2);

            //Assert
            Assert.Equal(expected, resultado);
        }
    }
}