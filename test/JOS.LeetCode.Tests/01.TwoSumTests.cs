using Shouldly;
using Xunit;

namespace JOS.LeetCode.Tests;

public class TwoSumTests
{
    private readonly TwoSum _sut;

    public TwoSumTests()
    {
        _sut = new TwoSum();
    }

    [Theory]
    [InlineData(new[]{2,7,11,15}, 9, new[]{0,1})]
    [InlineData(new[]{3,2,4}, 6, new[]{1,2})]
    [InlineData(new[]{3,3}, 6, new[]{0,1})]
    [InlineData(new[]{3,2,3}, 6, new[]{0,2})]
    [InlineData(new[]{0,4,3,0}, 0, new[]{0,3})]
    [InlineData(new[]{-3,4,3,90}, 0, new[]{0,2})]
    [InlineData(new[]{-1,-2,-3,-4,-5}, -8, new[]{2,4})]
    public void ShouldSolveExamples(int[] nums, int target, int[] expected)
    {
        var result = _sut.Execute(nums, target);
        
        result.ShouldBe(expected);
    }
}