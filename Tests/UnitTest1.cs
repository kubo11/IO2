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
    }
}