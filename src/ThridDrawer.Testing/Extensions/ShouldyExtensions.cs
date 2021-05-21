namespace ThridDrawer.Testing.Extensions
{
    using Shouldly;

    public static class ShouldyExtensions
    {
        public static void ShouldNotBeDefault1<T>(this T value)
        {
            value.ShouldNotBe(default);
        }

        public static void ShoulBeDefault1<T>(this T value)
        {
            value.ShouldBe(default);
        }
    }
}