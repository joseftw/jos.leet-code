using Shouldly;
using Xunit;

namespace JOS.LeetCode.Tests;

public class ZigzagConversionTests
{
    private readonly ZigzagConversion _sut;

    public ZigzagConversionTests()
    {
        _sut = new ZigzagConversion();
    }
    
    [Theory]
    [InlineData("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
    [InlineData("PAYPALISHIRING", 4, "PINALSIGYAHRPI")]
    [InlineData("A", 1, "A")]
    public void ShouldSolveExamples(string s, int numRows, string expected)
    {
        var result = _sut.Execute(s, numRows);
        
        result.ShouldBe(expected);
    }
}