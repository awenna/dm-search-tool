using DMCardDBGUI;
using Shouldly;
using Xunit;

namespace DMCArdDBGUITests
{
    public class SearchTests
    {
        private readonly string simpleCardText = "one two three four five";
        private readonly string shortCardText = "testing one two";

        [Fact]
        public void Empty_ReturnsNull()
        {
            SearchParser.Parse("").ShouldBe(null);
        }

        [Fact]
        public void NoCardText_DoesNotMatch()
        {
            SearchParser.Parse(simpleCardText).EvaluateOn(null).ShouldBe(false);
        }

        [Theory]
        [InlineData("three")]
        [InlineData("one")]
        [InlineData("two")]
        [InlineData("five")]
        [InlineData("FOUR")]
        public void SimpleInclude(string searchString, bool expectation = true)
        {
            SearchParser.Parse(searchString).EvaluateOn(simpleCardText).ShouldBe(expectation);
        }

        [Theory]
        [InlineData("one three")]
        [InlineData("one AND three")]
        [InlineData("one and three")]
        [InlineData("one And three")]
        [InlineData("one & three")]
        public void LogicalAnd(string searchString, bool expectation = true)
        {
            SearchParser.Parse(searchString).EvaluateOn(simpleCardText).ShouldBe(expectation);
        }

        [Theory]
        [InlineData("two or three")]
        [InlineData("two || three")]
        [InlineData("two | three")]
        [InlineData("two or six")]
        [InlineData("two || six")]
        [InlineData("two | six")]
        [InlineData("one or six")]
        [InlineData("one || six")]
        [InlineData("one | six")]
        public void LogicalOr(string searchString, bool expectation = true)
        {
            SearchParser.Parse(searchString).EvaluateOn(simpleCardText).ShouldBe(expectation);
        }

        [Theory]
        [InlineData("two not six")]
        [InlineData("one !six")]
        [InlineData("one ! six")]
        [InlineData("two NOT six")]
        [InlineData("two not three", false)]
        [InlineData("two !three", false)]
        [InlineData("two ! three", false)]
        [InlineData("two NOT three", false)]
        public void LogicalNot(string searchString, bool expectation = true)
        {
            SearchParser.Parse(searchString).EvaluateOn(simpleCardText).ShouldBe(expectation);
        }
    }
}
