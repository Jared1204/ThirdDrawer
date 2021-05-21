namespace ThirdDrawer.Unit.Tests
{
    using Shouldly;
    using ThirdDrawer.Extensions.StringExtensionMethods;
    using Xunit;

    public class StringExtensionTests
    {
        [Theory]
        [InlineData(null, null)]
        [InlineData("", "")]
        [InlineData(" ", " ")]
        [InlineData("HELLO", "Hello")]
        [InlineData("HeLLo", "Hello")]
        [InlineData("hello", "Hello")]
        [InlineData("HELLO WORLD", "Hello world")]
        [InlineData("hello WORLD", "Hello world")]
        public void CapitaliseFirstCharOnly_ShouldCapitaliseCorrectly(string input, string expected)
        {
            var result = StringExtensions.CapitaliseFirstCharOnly(input);
            result.ShouldBe(expected);
        }

        [Theory]
        [InlineData("Test String", "Test S")]
        [InlineData("Test ", "Test ")]
        [InlineData(null, null)]
        [InlineData("", "")]
        public void TakeFirst_ShouldTruncateStringCorrectly(string input, string expected)
        {
            var result = StringExtensions.TakeFirst(input, 6);
            result.ShouldBe(expected);
        }

        [Fact]
        public void ToEncoded_ShouldEncodeStringCorrectly()
        {
            var result = StringExtensions.ToEncoded("http://localhost/test-encoding");
            result.ShouldBe("http%3a%2f%2flocalhost%2ftest-encoding");
        }
    }
}