using DaeNe.AspNetCore.Conventions.Transformers;

namespace DaeNe.AspNetCore.Conventions.Tests;

public class KebabCaseParameterTransformerTests
{
    [Theory]
    [InlineData("SuperTest", "super-test")]
    [InlineData("SuperTest123", "super-test123")]
    [InlineData("SuperTest123Test", "super-test123-test")]
    [InlineData("Word", "word")]
    [InlineData("MoreThanTwoWords", "more-than-two-words")]
    public void TransformOutbound_ShouldCorrectlyTransformPascalCaseToKebabCase(string input, string expected)
    {
        var transformer = new KebabCaseParameterTransformer();
        var actual = transformer.TransformOutbound(input);
        Assert.Equal(expected, actual);
    }
    
    [Theory]
    [InlineData("super-test")]
    [InlineData("super-test123")]
    [InlineData("word")]
    public void TransformOutbound_ShouldNotTransformKebabCase(string input)
    {
        var transformer = new KebabCaseParameterTransformer();
        var actual = transformer.TransformOutbound(input);
        Assert.Equal(input, actual);
    }
    
    [Theory]
    [InlineData("")]
    [InlineData(null!)]
    public void TransformOutbound_ShouldReturnEmptyStringForNullOrWhiteSpace(string input)
    {
        var transformer = new KebabCaseParameterTransformer();
        var actual = transformer.TransformOutbound(input);
        Assert.Equal(string.Empty, actual);
    }
}
