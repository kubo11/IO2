namespace Tests
{
    public class UnitTest1
    {
        private readonly StringCalculator calc = new StringCalculator();
        [Fact]
        public void WhenEmptyStringProided_ShouldReturnZero()
        {
            Assert.Equal(0, calc.Add(""));
        }
        [Theory]
        [InlineData("342", 342)]
        [InlineData("12", 12)]
        [InlineData("-2", -2)]
        [InlineData("0", 0)]
        public void WhenSingleNumberProvided_ShouldReturnThisNumber(string input, int output)
        {
            Assert.Equal(output, calc.Add(input));
        }
        [Theory]
        [InlineData("2,2", 4)]
        [InlineData("-2,2", 0)]
        [InlineData("0,0", 0)]
        [InlineData("123,-23", 100)]
        public void WhenTwoNumbersSeparatedBySemicolonProvided_ShouldReturnTheirSum(string input, int output)
        {
            Assert.Equal(output, calc.Add(input));
        }
        [Theory]
        [InlineData("2\n2", 4)]
        [InlineData("-2\n2", 0)]
        [InlineData("0\n0", 0)]
        [InlineData("123\n-23", 100)]
        public void WhenTwoNumbersSeparatedByNewlineProvided_ShouldReturnTheirSum(string input, int output)
        {
            Assert.Equal(output, calc.Add(input));
        }
    }
}