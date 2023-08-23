namespace Kata.BD.DurationToText.Test
{
    public class UnitTestKata
    {
        [Theory]
        [InlineData(62, "1 minute and 2 seconds")]
        [InlineData(3662, "1 hour, 1 minute and 2 seconds")]
        [InlineData(0, "now")]
        [InlineData(15731080, "182 days, 1 hour, 44 minutes and 40 seconds")]
        [InlineData(45731080, "529 days, 7 hours, 4 minutes and 40 seconds")]
        public void Test1_ValidInputs_ReturnsCorrectResults(int duration, string expected)
        {
            Assert.Equal(expected, Kata.DurationToText(duration));
        }
    }
}