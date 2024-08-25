using Reader;
namespace NumbersReaderTest
{
    public class NumbersReaderTest
    {
        [Theory]
        [InlineData(256, 183.4923444, -910.272485, "100        183,49     -910,27   ")]
        [InlineData(16, 10.1234, -20.5678, "10         10,12      -20,57    ")]
        [InlineData(4096, 3.1, -4.9, "1000       3,10       -4,90     ")]
        public void FormatingNumbers_WithInputNumbers_ShouldReturnCorrectNumbersInColumns(int firstNumber, double secondNumber, double thirdNumber, string expected)
        {
            string result = NumbersReader.FormatingNumbers(firstNumber, secondNumber, thirdNumber);
            Assert.Equal(expected, result);
        }
    }
}