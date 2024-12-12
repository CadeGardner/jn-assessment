namespace BracketFinderTests;

public class BracketFinderTests
{
    [Fact]
    public void Matching_Brackets_Returns_True()
    {
        var input = "<>";
        var result = BracketFinder.HasMatchingBrackets(input);
        Assert.True(result);
    }

    [Fact]
    public void Double_Matching_Brackets_Returns_True()
    {
        var input = "<<>>";
        var result = BracketFinder.HasMatchingBrackets(input);
        Assert.True(result);
    }

    [Fact]
    public void No_Brackets_Returns_True()
    {
        var input = "";
        var result = BracketFinder.HasMatchingBrackets(input);
        Assert.True(result);
    }

    [Fact]
    public void Matching_Brackets_With_Content_Returns_True()
    {
        var input = "<abc...xyz>";
        var result = BracketFinder.HasMatchingBrackets(input);
        Assert.True(result);
    }

    [Fact]
    public void Inverse_Order_Brackets_Returns_False()
    {
        var input = "><";
        var result = BracketFinder.HasMatchingBrackets(input);
        Assert.False(result);
    }

    [Fact]
    public void Missing_Bracket_Returns_False()
    {
        var input = "<<>";
        var result = BracketFinder.HasMatchingBrackets(input);
        Assert.False(result);
    }
}
